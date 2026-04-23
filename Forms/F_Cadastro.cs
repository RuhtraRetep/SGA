using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace Forms
{
    public partial class F_Cadastro : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["SGA"].ConnectionString;
        public F_Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastrar()
        {
            if (String.IsNullOrEmpty(txtLogin.Text) || String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Preencha os campos");
                return;
            }
            string senha = BCrypt.Net.BCrypt.HashPassword(txtSenha.Text);
            string login = txtLogin.Text;
            string nome = txtNome.Text;

            string query = "INSERT INTO Usuarios (login, senha, nome) Values (@login ,@senha, @nome);";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    var rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deu certo");
                        F_Login f = new F_Login();
                        this.Hide();
                        f.Show();
                    }

                    else
                    {
                        MessageBox.Show("Deu errado");
                        txtNome.Text = "";
						txtSenha.Text = "";
						txtLogin.Text = "";
					}
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            F_Login f = new F_Login();
            this.Hide();
            f.Show();
        }
    }
}
