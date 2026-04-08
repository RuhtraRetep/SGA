using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Forms
{
    public partial class F_Atualizar : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["SGA"].ConnectionString;
        int matricula;
        public F_Atualizar()
        {
            InitializeComponent();
        }

        private void VerificarMatricula()
        {
            try
            {
                string query = "Select matricula From Alunos WHERE matricula = @matricula;";
                matricula = Convert.ToInt32(txtMatricula.Text);

				using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        panel3.Visible = false;
                        panel1.Visible = true;
                    }

                    else
                    {
                        MessageBox.Show("Matricula digitada não existe");
                    }
                    return;
                }
            }

            catch (Exception ex) { MessageBox.Show("Erro no try" + ex.Message); }
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            VerificarMatricula();
        }
        private void EscolherCampos()
        {
            if (clbEscolherAlteracao.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um campo para alterar");
                return;
            }

            if (clbEscolherAlteracao.GetItemChecked(0))
            { txtAlterarNome.Visible = true; label3.Visible = true; }
            else { txtAlterarNome.Visible = false; label3.Visible = false; }

            if (clbEscolherAlteracao.GetItemChecked(1))
            { mkdAlterarDataNascimento.Visible = true; label6.Visible = true; }
            else { mkdAlterarDataNascimento.Visible = false; label6.Visible = false; }

            if (clbEscolherAlteracao.GetItemChecked(2))
            { mkdAlterarCpf.Visible = true; label5.Visible = true; }
            else { mkdAlterarCpf.Visible = false; label5.Visible = false; }

            if (clbEscolherAlteracao.GetItemChecked(3))
            { txtAlterarEndereco.Visible = true; label7.Visible = true; }
            else { txtAlterarEndereco.Visible = false; label7.Visible = false; }

            if (clbEscolherAlteracao.GetItemChecked(4))
            { mkdAlterarTelefone.Visible = true; label4.Visible = true; }
            else { mkdAlterarTelefone.Visible = false; label4.Visible = false; }

            if (clbEscolherAlteracao.GetItemChecked(5))
            { txtAlterarEmail.Visible = true; label8.Visible = true; }
            else { txtAlterarEmail.Visible = false; label8.Visible = false; }

            panel1.Visible = false;
            panel2.Visible = true;
            return;

        }
        private void btnEscolherCampos_Click(object sender, EventArgs e)
        {
            EscolherCampos();
        }
        private void Alterar()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    int linhasAfetadas = 0;
                    if (txtAlterarEmail.Text == string.Empty && txtAlterarEndereco.Text == string.Empty
                        && txtAlterarNome.Text == string.Empty && mkdAlterarCpf.MaskFull == false
                        && mkdAlterarDataNascimento.MaskFull == false && mkdAlterarTelefone.MaskFull == false)
                    {
                        MessageBox.Show("Preencha os valores corretamente");
                    }

                    if (txtAlterarNome.Text != string.Empty)
                    {
                        string query = "Update Alunos SET nome = @nome WHERE matricula = @matricula ";
						MySqlCommand cmd = new MySqlCommand(query, conn);
						cmd.Parameters.AddWithValue("@nome", txtAlterarNome.Text);
						cmd.Parameters.AddWithValue("@matricula", matricula);
						linhasAfetadas = cmd.ExecuteNonQuery();         
					}

					if (txtAlterarEmail.Text != string.Empty)
					{
						string query = "Update Alunos SET email = @email WHERE matricula = @matricula ";
						MySqlCommand cmd = new MySqlCommand(query, conn);
						cmd.Parameters.AddWithValue("@email", txtAlterarEmail.Text);
						cmd.Parameters.AddWithValue("@matricula", matricula);
						linhasAfetadas = cmd.ExecuteNonQuery();
					}

					if (txtAlterarEndereco.Text != string.Empty)
					{
						string query = "Update Alunos SET endereco = @endereco WHERE matricula = @matricula ";
						MySqlCommand cmd = new MySqlCommand(query, conn);
						cmd.Parameters.AddWithValue("@endereco", txtAlterarEndereco.Text);
						cmd.Parameters.AddWithValue("@matricula", matricula);
						linhasAfetadas = cmd.ExecuteNonQuery();
					}

					if (mkdAlterarCpf.MaskFull != false)
					{
						string query = "Update Alunos SET cpf = @CPF WHERE matricula = @matricula ";
						MySqlCommand cmd = new MySqlCommand(query, conn);
						cmd.Parameters.AddWithValue("@CPF", mkdAlterarCpf.Text);
						cmd.Parameters.AddWithValue("@matricula", matricula);
						linhasAfetadas = cmd.ExecuteNonQuery();
					}

					if (mkdAlterarDataNascimento.MaskFull != false)
					{
						string query = "Update Alunos SET nascimento = @dataNascimento WHERE matricula = @matricula ";
						MySqlCommand cmd = new MySqlCommand(query, conn);
						cmd.Parameters.AddWithValue("@dataNascimento", mkdAlterarDataNascimento.Text);
						cmd.Parameters.AddWithValue("@matricula", matricula);
						linhasAfetadas = cmd.ExecuteNonQuery();
					}

                    if (mkdAlterarTelefone.MaskFull != false)
                    {
                        string query = "Update Alunos SET telefone = @telefone WHERE matricula = @matricula ";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@telefone", mkdAlterarTelefone.Text);
                        cmd.Parameters.AddWithValue("@matricula", matricula);
						linhasAfetadas = cmd.ExecuteNonQuery();

                    }


                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Alterações feitas com sucesso");
                    }
                    else
                    {
						MessageBox.Show("Algo deu errado :(");
					}
                    panel2.Visible = false;

				}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
    }
}
