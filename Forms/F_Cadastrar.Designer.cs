namespace Forms
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
            btnEnviar = new Button();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            mkdDataNascimento = new MaskedTextBox();
            txtEmail = new TextBox();
            mkdCpf = new MaskedTextBox();
            mkdTelefone = new MaskedTextBox();
            txtEndereco = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Top;
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(190, 369);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(107, 37);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnEnviar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(mkdDataNascimento);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(mkdCpf);
            panel2.Controls.Add(mkdTelefone);
            panel2.Controls.Add(txtEndereco);
            panel2.Location = new Point(90, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 459);
            panel2.TabIndex = 14;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(59, 274);
            label8.Name = "label8";
            label8.Size = new Size(116, 17);
            label8.TabIndex = 17;
            label8.Text = "E-mail p/ contato";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(59, 99);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 16;
            label7.Text = "Endereço";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(374, 165);
            label6.Name = "label6";
            label6.Size = new Size(133, 34);
            label6.TabIndex = 15;
            label6.Text = "Data de Nascimento\r\ndo Aluno";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(59, 182);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 14;
            label5.Text = "CPF do Aluno";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(199, 182);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 13;
            label4.Text = "Telefone p/ contato";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(59, 28);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 12;
            label3.Text = "Nome do Aluno";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top;
            txtNome.Location = new Point(59, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(331, 23);
            txtNome.TabIndex = 0;
            // 
            // mkdDataNascimento
            // 
            mkdDataNascimento.Anchor = AnchorStyles.Top;
            mkdDataNascimento.Location = new Point(374, 214);
            mkdDataNascimento.Mask = "00/00/0000";
            mkdDataNascimento.Name = "mkdDataNascimento";
            mkdDataNascimento.Size = new Size(65, 23);
            mkdDataNascimento.TabIndex = 3;
            mkdDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Location = new Point(59, 306);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 23);
            txtEmail.TabIndex = 18;
            // 
            // mkdCpf
            // 
            mkdCpf.Anchor = AnchorStyles.Top;
            mkdCpf.Location = new Point(59, 214);
            mkdCpf.Mask = "000,000,000-00";
            mkdCpf.Name = "mkdCpf";
            mkdCpf.Size = new Size(83, 23);
            mkdCpf.TabIndex = 4;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Anchor = AnchorStyles.Top;
            mkdTelefone.Location = new Point(199, 214);
            mkdTelefone.Mask = "(00)00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(84, 23);
            mkdTelefone.TabIndex = 5;
            // 
            // txtEndereco
            // 
            txtEndereco.Anchor = AnchorStyles.Top;
            txtEndereco.Location = new Point(59, 130);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(407, 23);
            txtEndereco.TabIndex = 19;
            // 
            // F_Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 541);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Aluno";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEnviar;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNome;
        private MaskedTextBox mkdDataNascimento;
        private TextBox txtEmail;
        private MaskedTextBox mkdCpf;
        private MaskedTextBox mkdTelefone;
        private TextBox txtEndereco;
    }
}