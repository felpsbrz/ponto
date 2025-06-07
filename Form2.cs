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

namespace Ponto
{
    public partial class PainelAdm : Form
    {
        public PainelAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                string connectionString = "server=193.203.175.33;port=3306;database=u174511361_pontodehoras;uid=u174511361_pontodehoras;pwd=@P0nto123;";


                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string cpf = textBox1.Text.Trim();
                    string senhaDigitada = textBox2.Text.Trim();

                    // 1. Verifica se o CPF e senha coincidem
                    string buscaUsuario = "SELECT id, nome FROM usuarios WHERE nome = @cpf AND senha = @senha";
                    MySqlCommand cmdUsuario = new MySqlCommand(buscaUsuario, conn);
                    cmdUsuario.Parameters.AddWithValue("@cpf", cpf);
                    cmdUsuario.Parameters.AddWithValue("@senha", senhaDigitada);

                    object result = cmdUsuario.ExecuteScalar();

                    if (result != null)
                    {
                        // CPF e senha corretos

                        painel_adm rc = new painel_adm();

                        rc.Show();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha inválidos.");



                    }

                    conn.Close();
                }

            }

        }
    }
}
