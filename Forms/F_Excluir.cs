using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms

{
    public partial class F_Excluir : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["SGA"].ConnectionString;
        public F_Excluir()
        {
            InitializeComponent();
        }

        private void DeletarAluno()
        {
            try
            {
                string query = "DELETE FROM Alunos WHERE matricula = @matricula";

                if (txtMatricula.Text != string.Empty)
                {
                    using (MySqlConnection conn = new MySqlConnection(conexao))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@matricula", Convert.ToInt32(txtMatricula.Text));
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Aluno deletado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum Aluno encontrado com o ID fornecido.");
                        }
                    }
                }

                else { MessageBox.Show("Digite o Id do Aluno que deseja deletar"); }


            }

            catch (Exception ex) { MessageBox.Show("Deu erro no Try" + ex.Message); }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarAluno();
        }

    }
}
