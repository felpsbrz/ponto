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
    public partial class RegistroSucesso : Form
    {
        public Form form;
        public RegistroSucesso()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistroSucesso_Load(object sender, EventArgs e)
        {
            string connectionString = "server=193.203.175.33;port=3306;database=u174511361_pontodehoras;uid=u174511361_pontodehoras;pwd=@P0nto123;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
            SELECT 
                u.nome AS Nome,
                r.data_registro AS Data,
                r.hora_entrada AS Entrada,
                r.hora_saida AS Saida,
                r.totalHoras AS Total_Horas,
                r.observacao AS Observacao
            FROM registros_ponto r
            INNER JOIN usuarios u ON r.usuario_id = u.id
            WHERE r.data_registro = CURDATE()
            ORDER BY r.hora_entrada DESC
        ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Exibe os dados em um DataGridView chamado dataGridView1
                    dataGridView1.DataSource = dataTable;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }

            System.Windows.Forms.Timer fecharTimer = new System.Windows.Forms.Timer();
            fecharTimer.Interval = 10000; // 10 segundos (em milissegundos)
            fecharTimer.Tick += (s, args) =>
            {
                fecharTimer.Stop();
                form.Show();
                this.Close();
            };
            fecharTimer.Start();

        }
    }
}
