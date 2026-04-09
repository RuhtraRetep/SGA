using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;




namespace Forms
{
    public partial class F_TelaPrincipal : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["SGA"].ConnectionString;
        public F_TelaPrincipal()
        {
            InitializeComponent();
        }

        private void OrganizarCascata()
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void OrganizarVertical()
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void OrganizarHorizontal()
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void FecharTodasJanelas()
        {
            foreach (Form filho in this.MdiChildren)
            {
                filho.Close();
            }
        }
        private void ExportarTelaPDF()
        {
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

                PdfDocument doc = new PdfDocument();
                PdfPage page = doc.AddPage();

                page.Width = XUnit.FromPoint(this.Width);
                page.Height = XUnit.FromPoint(this.Height);


                using (XGraphics gfx = XGraphics.FromPdfPage(page))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        XImage imagem = XImage.FromStream(ms);

                        gfx.DrawImage(imagem, 0, 0, page.Width, page.Height);
                    }
                }

                SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", Title = "Exportar Tela" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(sfd.FileName);
                    MessageBox.Show("Exportação concluí­da!", "Exportar");
                }
            }
        }
        private void ExportarFormPDF()
        {
            Form formularioAtivo = this.ActiveMdiChild;

            if (formularioAtivo == null)
            {
                MessageBox.Show("Não há janela aberta para exportar!", "Aviso");
                return;
            }

            using (Bitmap bitmap = new Bitmap(formularioAtivo.Width, formularioAtivo.Height))
            {
                formularioAtivo.DrawToBitmap(bitmap, new Rectangle(0, 0, formularioAtivo.Width, formularioAtivo.Height));

                PdfDocument doc = new PdfDocument();
                PdfPage page = doc.AddPage();

                page.Width = XUnit.FromPoint(formularioAtivo.Width);
                page.Height = XUnit.FromPoint(formularioAtivo.Height);

                using (XGraphics gfx = XGraphics.FromPdfPage(page))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        XImage imagem = XImage.FromStream(ms);
                        gfx.DrawImage(imagem, 0, 0, page.Width, page.Height);
                    }
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF|*.pdf",
                    Title = "Exportar",
                    FileName = formularioAtivo.Text
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(sfd.FileName);
                    MessageBox.Show($"O formulário '{formularioAtivo.Text}' foi exportado!");
                }
            }
        }
        private void BuscarAlunos()
        {
            dgvExibirAlunos.Visible = true;
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
        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizarCascata();
        }
        private void ladoALadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OrganizarVertical();
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizarHorizontal();
        }
        private void fecharTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodasJanelas();
        }
        private void telaCheiaParaPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarTelaPDF();
        }
        private void formulárioPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarFormPDF();
        }
        private void dgvExibirAlunos_DoubleClick(object sender, EventArgs e)
        {
            dgvExibirAlunos.Visible = false;
            txtBuscar.Text = string.Empty;
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarAlunos();
            }
        }
    }
}
