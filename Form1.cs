using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Ponto
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void view_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 5)
            {
                string connectionString = "server=193.203.175.33;port=3306;database=u174511361_pontodehoras;uid=u174511361_pontodehoras;pwd=@P0nto123;";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string cpf = textBox1.Text.Trim();

                        // 1. Verifica se o CPF existe
                        string buscaUsuario = "SELECT id, nome FROM usuarios WHERE cpf = @cpf";
                        MySqlCommand cmdUsuario = new MySqlCommand(buscaUsuario, conn);
                        cmdUsuario.Parameters.AddWithValue("@cpf", cpf);

                        object result = cmdUsuario.ExecuteScalar();

                        if (result != null)
                        {
                            // CPF encontrado
                            int usuarioId = Convert.ToInt32(result);


                            senha senha = new senha();
                            senha.Show();
                            senha.form = this;
                            
                            senha.codigo = textBox1.Text;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("CPF não encontrado.");
                        }

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        public void limparText()
        {
            textBox1.Text = "";
        }

        private void textBox1_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
