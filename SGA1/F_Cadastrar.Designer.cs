namespace SGA1
{
    partial class F_Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Cadastrar));
            txtNome = new TextBox();
            mkdDataNascimento = new MaskedTextBox();
            mkdCpf = new MaskedTextBox();
            txtEndereco = new TextBox();
            mkdTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            btnEnviar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(45, 19);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // mkdDataNascimento
            // 
            mkdDataNascimento.Location = new Point(45, 81);
            mkdDataNascimento.Mask = "00/00/0000";
            mkdDataNascimento.Name = "mkdDataNascimento";
            mkdDataNascimento.Size = new Size(100, 23);
            mkdDataNascimento.TabIndex = 6;
            mkdDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // mkdCpf
            // 
            mkdCpf.Location = new Point(45, 125);
            mkdCpf.Mask = "000,000,000-00";
            mkdCpf.Name = "mkdCpf";
            mkdCpf.Size = new Size(100, 23);
            mkdCpf.TabIndex = 7;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(45, 177);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(100, 23);
            txtEndereco.TabIndex = 8;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(45, 230);
            mkdTelefone.Mask = "(00)00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(47, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(60, 338);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 11;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(mkdDataNascimento);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(mkdCpf);
            panel1.Controls.Add(mkdTelefone);
            panel1.Controls.Add(txtEndereco);
            panel1.Location = new Point(296, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 396);
            panel1.TabIndex = 12;
            // 
            // F_Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Aluno";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private MaskedTextBox mkdDataNascimento;
        private MaskedTextBox mkdCpf;
        private TextBox txtEndereco;
        private MaskedTextBox mkdTelefone;
        private TextBox txtEmail;
        private Button btnEnviar;
        private Panel panel1;
    }
}