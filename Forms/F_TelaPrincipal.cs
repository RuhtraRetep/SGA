using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Forms
{
    public partial class F_TelaPrincipal : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["SGA"].ConnectionString;
        public F_TelaPrincipal()
        {
            InitializeComponent();
        }
        private void BuscarAlunos()
        {
            dgvExibirAlunos.DataSource = null;

            if (txtBuscar.Text != string.Empty)
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string query = "SELECT * FROM alunos WHERE nome = @nome";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nome", txtBuscar.Text);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvExibirAlunos.DataSource = dt;
                    }

                    catch (Exception ex) { MessageBox.Show("Erro no Try" + ex.Message); }
                }
                return;
            }
        }
        private void CadastrarAluno()
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is F_Cadastrar)
                {
                    item.Focus();
                    return;
                }

            }
            F_Cadastrar fCad = new F_Cadastrar();
            fCad.MdiParent = this;
            fCad.Show();
        }
        private void AtualizarAluno()
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is F_Atualizar)
                {
                    item.Focus();
                    return;
                }
            }
            F_Atualizar fPes = new F_Atualizar();
            fPes.MdiParent = this;
            fPes.Show();
        }
        private void ListarAluno()
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is F_Listar)
                {
                    item.Focus();
                    return;
                }
            }
            F_Listar fLis = new F_Listar();
            fLis.MdiParent = this;
            fLis.Show();
        }
        private void ExcluirAluno()
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is F_Excluir)
                {
                    item.Focus();
                    return;
                }
            }
            F_Excluir fExc = new F_Excluir();
            fExc.MdiParent = this;
            fExc.Show();
        }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAluno();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            CadastrarAluno();
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            ExcluirAluno();
        }
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirAluno();
        }
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            ListarAluno();
        }
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAluno();
        }
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            AtualizarAluno();
        }
        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarAluno();
        }
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            BuscarAlunos();
        }
    }
}
