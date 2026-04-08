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
    public partial class F_Listar : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["SGA"].ConnectionString;
        public F_Listar()
        {
            InitializeComponent();
        }

        public void ListarAlunos()
        {
            dgvExibirAlunos.DataSource = null;
            try
            {
                string query = "SELECT * FROM alunos";

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvExibirAlunos.DataSource = dt;
                }
            }

            catch (Exception ex) { MessageBox.Show("Erro no Try" + ex.Message); }


        }
        private void BuscarAlunos()
        {
            dgvExibirAlunos.DataSource = null;

            if (txtMatricula.Text != string.Empty && txtNome.Text != string.Empty)
            {
                MessageBox.Show("Preencha UM dos campos");
                return;
            }

            if (txtNome.Text != string.Empty )
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string query = "SELECT * FROM alunos WHERE nome = @nome";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvExibirAlunos.DataSource = dt;
                    }

                    catch (Exception ex) { MessageBox.Show("Erro no Try" + ex.Message); }
                }
                return;
            }

            if (txtMatricula.Text != string.Empty)
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string query = "SELECT * FROM alunos WHERE matricula = @matricula";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@matricula", Convert.ToInt32(txtMatricula.Text));

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvExibirAlunos.DataSource = dt;
                    }

                    catch (Exception ex) { MessageBox.Show("Erro no Try" + ex.Message); }
                }
                return;
            }

            MessageBox.Show("Preencha UM dos campos");
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarAlunos();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAlunos();
        }
    }
}
