using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace Forms
{
    public partial class F_Login : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["SGA"].ConnectionString;
        public F_Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            if (String.IsNullOrEmpty(txtLogin.Text) || String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Preencha os campos");
                return;
            }
            string login = txtLogin.Text;
            string senha = txtSenha.Text;


            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string query = "Select senha, nome From Usuarios Where login = @login;";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string senhaHash = reader["senha"].ToString();

                            bool ehValido = BCrypt.Net.BCrypt.Verify(senha, senhaHash);

                            if (ehValido)
                            {
                                F_TelaPrincipal f = new F_TelaPrincipal();
                                this.Hide();
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Login ou senha incorretos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado");
                        }

                    }
				}

                catch (Exception ex) { MessageBox.Show("Erro no Try" + ex.Message); }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            F_Cadastro f = new F_Cadastro();
            this.Hide();
            f.Show();
        }
    }
}
