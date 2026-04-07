namespace SGA1
{
    partial class F_Pesquisar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Pesquisar));
            txtMatricula = new TextBox();
            btnVerificar = new Button();
            panel1 = new Panel();
            btnEscolherCampos = new Button();
            label1 = new Label();
            clbEscolherAlteracao = new CheckedListBox();
            panel2 = new Panel();
            txtAlterarNome = new TextBox();
            btnAlterar = new Button();
            mkdAlterarDataNascimento = new MaskedTextBox();
            txtAlterarEmail = new TextBox();
            mkdAlterarCpf = new MaskedTextBox();
            mkdAlterarTelefone = new MaskedTextBox();
            txtAlterarEndereco = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(27, 15);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(39, 65);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnEscolherCampos);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(clbEscolherAlteracao);
            panel1.Location = new Point(35, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 257);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // btnEscolherCampos
            // 
            btnEscolherCampos.Location = new Point(119, 219);
            btnEscolherCampos.Name = "btnEscolherCampos";
            btnEscolherCampos.Size = new Size(75, 23);
            btnEscolherCampos.TabIndex = 2;
            btnEscolherCampos.Text = "Escolher";
            btnEscolherCampos.UseVisualStyleBackColor = true;
            btnEscolherCampos.Click += btnEscolherCampos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(88, 14);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 1;
            label1.Text = "Campos para alterar";
            // 
            // clbEscolherAlteracao
            // 
            clbEscolherAlteracao.Font = new Font("Segoe UI", 11F);
            clbEscolherAlteracao.FormattingEnabled = true;
            clbEscolherAlteracao.Items.AddRange(new object[] { "Nome", "Data de Nascimento", "CPF", "Endereço", "Telefone", "E-mail" });
            clbEscolherAlteracao.Location = new Point(60, 53);
            clbEscolherAlteracao.Name = "clbEscolherAlteracao";
            clbEscolherAlteracao.Size = new Size(179, 136);
            clbEscolherAlteracao.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(txtAlterarNome);
            panel2.Controls.Add(btnAlterar);
            panel2.Controls.Add(mkdAlterarDataNascimento);
            panel2.Controls.Add(txtAlterarEmail);
            panel2.Controls.Add(mkdAlterarCpf);
            panel2.Controls.Add(mkdAlterarTelefone);
            panel2.Controls.Add(txtAlterarEndereco);
            panel2.Location = new Point(519, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 396);
            panel2.TabIndex = 13;
            panel2.Visible = false;
            // 
            // txtAlterarNome
            // 
            txtAlterarNome.Location = new Point(45, 19);
            txtAlterarNome.Name = "txtAlterarNome";
            txtAlterarNome.Size = new Size(100, 23);
            txtAlterarNome.TabIndex = 0;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(60, 338);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // mkdAlterarDataNascimento
            // 
            mkdAlterarDataNascimento.Location = new Point(45, 81);
            mkdAlterarDataNascimento.Mask = "00/00/0000";
            mkdAlterarDataNascimento.Name = "mkdAlterarDataNascimento";
            mkdAlterarDataNascimento.Size = new Size(100, 23);
            mkdAlterarDataNascimento.TabIndex = 6;
            mkdAlterarDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtAlterarEmail
            // 
            txtAlterarEmail.Location = new Point(47, 284);
            txtAlterarEmail.Name = "txtAlterarEmail";
            txtAlterarEmail.Size = new Size(100, 23);
            txtAlterarEmail.TabIndex = 10;
            // 
            // mkdAlterarCpf
            // 
            mkdAlterarCpf.Location = new Point(45, 125);
            mkdAlterarCpf.Mask = "000,000,000-00";
            mkdAlterarCpf.Name = "mkdAlterarCpf";
            mkdAlterarCpf.Size = new Size(100, 23);
            mkdAlterarCpf.TabIndex = 7;
            // 
            // mkdAlterarTelefone
            // 
            mkdAlterarTelefone.Location = new Point(45, 230);
            mkdAlterarTelefone.Mask = "(00)00000-0000";
            mkdAlterarTelefone.Name = "mkdAlterarTelefone";
            mkdAlterarTelefone.Size = new Size(100, 23);
            mkdAlterarTelefone.TabIndex = 9;
            // 
            // txtAlterarEndereco
            // 
            txtAlterarEndereco.Location = new Point(45, 177);
            txtAlterarEndereco.Name = "txtAlterarEndereco";
            txtAlterarEndereco.Size = new Size(100, 23);
            txtAlterarEndereco.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtMatricula);
            panel3.Controls.Add(btnVerificar);
            panel3.Location = new Point(147, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 100);
            panel3.TabIndex = 14;
            // 
            // F_Pesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_Pesquisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Aluno";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMatricula;
        private Button btnVerificar;
        private Panel panel1;
        private Button btnEscolherCampos;
        private Label label1;
        private CheckedListBox clbEscolherAlteracao;
        private Panel panel2;
        private TextBox txtAlterarNome;
        private Button btnAlterar;
        private MaskedTextBox mkdAlterarDataNascimento;
        private TextBox txtAlterarEmail;
        private MaskedTextBox mkdAlterarCpf;
        private MaskedTextBox mkdAlterarTelefone;
        private TextBox txtAlterarEndereco;
        private Panel panel3;
    }
}