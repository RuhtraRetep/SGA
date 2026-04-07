namespace SGA1
{
    public partial class F_TelaPrincipal : Form
    {
        public F_TelaPrincipal()
        {
            InitializeComponent();
        }

        private void CadastrarAluno()
        {
            F_Cadastrar fCad = new F_Cadastrar();
            fCad.MdiParent = this;
            fCad.Show();
        }

        private void AtualizarAluno()
        {
            
            F_Pesquisar fPes = new F_Pesquisar();
            fPes.MdiParent = this;
            fPes.Show();
        }

        private void ListarAluno()
        {
            F_Listar fLis = new F_Listar();
            fLis.MdiParent = this;
            fLis.Show();
        }

        private void ExcluirAluno()
        {
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
    }
}
