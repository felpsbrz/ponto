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
    public partial class usuarios : Form
    {
        string connectionString = "server=193.203.175.33;port=3306;database=u174511361_pontodehoras;uid=u174511361_pontodehoras;pwd=@P0nto123;";
        public usuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            ExibirUsuarios(); // Carrega os dados iniciais
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        // --- MÉTODOS PRINCIPAIS ---
        public void ExibirUsuarios()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nome, email, cpf, senha, cargo FROM usuarios";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
                }
            }
        }

        public void InserirUsuario()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO usuarios (nome, email, cpf, senha, cargo) VALUES (@nome, @email, @codigo, @senha, @cargo)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", Nome.Text);
                    cmd.Parameters.AddWithValue("@email", Email.Text);
                    cmd.Parameters.AddWithValue("@codigo", Codigo.Text);
                    cmd.Parameters.AddWithValue("@senha", Senha.Text);
                    cmd.Parameters.AddWithValue("@cargo", cargo.Text);

                    cmd.ExecuteNonQuery();
                    LimparCampos();
                    ExibirUsuarios(); // Atualiza o DataGridView
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir usuário: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida (não no cabeçalho)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Nome.Text = row.Cells["nome"].Value.ToString();
                Email.Text = row.Cells["email"].Value.ToString();
                Codigo.Text = row.Cells["cpf"].Value.ToString();
                Senha.Text = row.Cells["senha"].Value.ToString();
                cargo.Text = row.Cells["cargo"].Value.ToString();
            }
        }
        public void AtualizarUsuario()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para atualizar!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE usuarios SET nome = @nome, email = @email, cpf = @codigo, senha = @senha, cargo = @cargo WHERE cpf = @codigoAntigo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", Nome.Text);
                    cmd.Parameters.AddWithValue("@email", Email.Text);
                    cmd.Parameters.AddWithValue("@codigo", Codigo.Text);
                    cmd.Parameters.AddWithValue("@senha", Senha.Text);
                    cmd.Parameters.AddWithValue("@cargo", cargo.Text);
                    cmd.Parameters.AddWithValue("@codigoAntigo", dataGridView1.CurrentRow.Cells["codigo"].Value.ToString());

                    cmd.ExecuteNonQuery();
                    ExibirUsuarios(); // Atualiza o DataGridView
                    MessageBox.Show("Usuário atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar usuário: " + ex.Message);
                }
            }
        }

        private void ExcluirUsuario()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para excluir!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM usuarios WHERE cpf = @codigo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo", dataGridView1.CurrentRow.Cells["codigo"].Value.ToString());

                    cmd.ExecuteNonQuery();
                    ExibirUsuarios(); // Atualiza o DataGridView
                    MessageBox.Show("Usuário excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
                }
            }
        }
        // --- MÉTODOS AUXILIARES ---
        private void PreencherCamposSelecionados()
        {
            if (dataGridView1.CurrentRow != null)
            {
                Nome.Text = dataGridView1.CurrentRow.Cells["nome"].Value.ToString();
                Email.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                Codigo.Text = dataGridView1.CurrentRow.Cells["cpf"].Value.ToString();
                Senha.Text = dataGridView1.CurrentRow.Cells["senha"].Value.ToString();
                cargo.Text = dataGridView1.CurrentRow.Cells["cargo"].Value.ToString();
            }
        }

        private void LimparCampos()
        {
            Nome.Text = Email.Text = Codigo.Text = Senha.Text = cargo.Text = "";
        }
    }
}
