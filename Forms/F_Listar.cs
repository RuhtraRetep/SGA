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
        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarAlunos();
        }
    }
}
