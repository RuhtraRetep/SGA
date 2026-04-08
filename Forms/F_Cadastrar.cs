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

    public partial class F_Cadastrar : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["SGA"].ConnectionString;
        public F_Cadastrar()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CadastrarAluno();
        }

        private void CadastrarAluno()
        {
            if (txtNome.Text == string.Empty || txtEmail.Text == string.Empty || txtEndereco.Text == string.Empty ||
                mkdCpf.MaskFull == false || mkdDataNascimento.MaskFull == false || mkdTelefone.MaskFull == false)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }


            string query = "INSERT INTO alunos (nome, cpf, nascimento, endereco, telefone, email) VALUES (@nome, @cpf, @data_nascimento, @endereco, @telefone, @email)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", mkdCpf.Text);
                    cmd.Parameters.AddWithValue("@data_nascimento", mkdDataNascimento.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@telefone", mkdTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            catch (Exception ex) { MessageBox.Show("Deu ruim no Try", ex.Message); return; }

            MessageBox.Show("Aluno Cadastrado");
        }

        
    
    }
}
