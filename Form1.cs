using MySql.Data.MySqlClient;
using System.Data;

namespace ExemploBDInsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //string v-nome = txt_Nome.Text;
            //string v-email = txt_Email.Text;

            string conexao = "Server=localhost;Database=db_usuarios;Uid=root;Pwd=root;";
            string query = "insert into tb_usuarios (nome, email, nacionalidade, telefone) values (@nome , @email, @nacionalidade)";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@nacionalidade", txt_nacionalidade.Text);
                    cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                //conn.Close();
            }

        }

        private void btn_MostrarDados_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=db_usuarios;Uid=root;Pwd=root;";
            string query = "SELECT id, nome, email, nm_nacionalidade, nr_telefone FROM tb_usuarios";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                //conn.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_Nome.Visible = true;
            lbl_Email.Visible = true;
            txt_Nome.Visible = true;
            txt_Email.Visible = true;
          nacionalidade.Visible = true;
            txt_nacionalidade.Visible = true;
            telefone.Visible = true;
            txt_telefone.Visible = true;
            btn_ConfirmarCadastro.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
