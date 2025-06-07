using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ponto
{
    public partial class senha : Form
    {
        public string codigo;
        public Form1 form;
        public senha()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >= 5) { 
            string connectionString = "server=193.203.175.33;port=3306;database=u174511361_pontodehoras;uid=u174511361_pontodehoras;pwd=@P0nto123;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string cpf = codigo.Trim();
                    string senhaDigitada = textBox1.Text.Trim();

                    // 1. Verifica se o CPF e senha coincidem
                    string buscaUsuario = "SELECT id, nome FROM usuarios WHERE cpf = @cpf AND senha = @senha";
                    MySqlCommand cmdUsuario = new MySqlCommand(buscaUsuario, conn);
                    cmdUsuario.Parameters.AddWithValue("@cpf", cpf);
                    cmdUsuario.Parameters.AddWithValue("@senha", senhaDigitada);

                    object result = cmdUsuario.ExecuteScalar();

                    if (result != null)
                    {
                        // CPF e senha corretos
                        int usuarioId = Convert.ToInt32(result);

                        // 2. Verifica se já existe entrada hoje sem saída
                        string verificaEntrada = @"
                        SELECT id, hora_entrada
                        FROM registros_ponto
                        WHERE usuario_id = @usuarioId AND data_registro = CURDATE() AND hora_saida IS NULL
                        LIMIT 1";

                        MySqlCommand cmdVerifica = new MySqlCommand(verificaEntrada, conn);
                        cmdVerifica.Parameters.AddWithValue("@usuarioId", usuarioId);

                        using (MySqlDataReader reader = cmdVerifica.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Já existe entrada, registrar saída
                                int registroId = reader.GetInt32("id");
                                TimeSpan horaEntrada = reader.GetTimeSpan("hora_entrada");
                                reader.Close();

                                TimeSpan horaAtual = DateTime.Now.TimeOfDay;
                                TimeSpan totalHoras = horaAtual - horaEntrada;

                                string atualizaSaida = @"
                                UPDATE registros_ponto
                                SET hora_saida = @horaSaida, totalHoras = @totalHoras
                                WHERE id = @registroId";

                                MySqlCommand cmdUpdate = new MySqlCommand(atualizaSaida, conn);
                                cmdUpdate.Parameters.AddWithValue("@horaSaida", horaAtual);
                                cmdUpdate.Parameters.AddWithValue("@totalHoras", totalHoras);
                                cmdUpdate.Parameters.AddWithValue("@registroId", registroId);

                                cmdUpdate.ExecuteNonQuery();
                                    RegistroSucesso rc = new RegistroSucesso();
                                    rc.form = form;
                                    rc.Show();
                                    this.Close();
                            }
                            else
                            {
                                // Nenhuma entrada hoje, registrar nova entrada
                                reader.Close();

                                string registraEntrada = @"
                                INSERT INTO registros_ponto (usuario_id, data_registro, hora_entrada, observacao)
                                VALUES (@usuarioId, CURDATE(), CURTIME(), 'Entrada registrada via sistema')";

                                MySqlCommand cmdInsert = new MySqlCommand(registraEntrada, conn);
                                cmdInsert.Parameters.AddWithValue("@usuarioId", usuarioId);
                                cmdInsert.ExecuteNonQuery();

                                RegistroSucesso rc = new RegistroSucesso();
                                    rc.form = form;
                                rc.Show();
                                    this.Close();
                                }
                        }
                    }
                    else
                    {
                            MessageBox.Show("CPF ou senha inválidos.");

                            form.Show();
                            form.limparText();
                            this.Close();

                        }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                    System.Windows.Forms.Timer fecharTimer = new System.Windows.Forms.Timer();
                    fecharTimer.Interval = 30000; // 10 segundos (em milissegundos)
                    fecharTimer.Tick += (s, args) =>
                    {
                        fecharTimer.Stop();
                        this.Close();
                    };
                    fecharTimer.Start();
                    MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
    }
}
