namespace Forms
{
    partial class F_Atualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Atualizar));
            txtMatricula = new TextBox();
            btnVerificar = new Button();
            panel1 = new Panel();
            btnEscolherCampos = new Button();
            label1 = new Label();
            clbEscolherAlteracao = new CheckedListBox();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            btnEnviar = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtAlterarNome = new TextBox();
            mkdAlterarDataNascimento = new MaskedTextBox();
            txtAlterarEmail = new TextBox();
            mkdAlterarCpf = new MaskedTextBox();
            mkdAlterarTelefone = new MaskedTextBox();
            txtAlterarEndereco = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.Top;
            txtMatricula.Location = new Point(40, 62);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(108, 23);
            txtMatricula.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Anchor = AnchorStyles.Top;
            btnVerificar.Location = new Point(62, 99);
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
            panel1.Location = new Point(227, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 284);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // btnEscolherCampos
            // 
            btnEscolherCampos.Anchor = AnchorStyles.Top;
            btnEscolherCampos.Location = new Point(163, 217);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 14);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 1;
            label1.Text = "Campos para alterar";
            // 
            // clbEscolherAlteracao
            // 
            clbEscolherAlteracao.Anchor = AnchorStyles.Top;
            clbEscolherAlteracao.BackColor = SystemColors.ControlDark;
            clbEscolherAlteracao.BorderStyle = BorderStyle.None;
            clbEscolherAlteracao.Font = new Font("Segoe UI", 11F);
            clbEscolherAlteracao.FormattingEnabled = true;
            clbEscolherAlteracao.Items.AddRange(new object[] { "Nome", "Data de Nascimento", "CPF", "Endereço", "Telefone", "E-mail" });
            clbEscolherAlteracao.Location = new Point(104, 51);
            clbEscolherAlteracao.Margin = new Padding(0);
            clbEscolherAlteracao.Name = "clbEscolherAlteracao";
            clbEscolherAlteracao.Size = new Size(179, 132);
            clbEscolherAlteracao.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtMatricula);
            panel3.Controls.Add(btnVerificar);
            panel3.Location = new Point(315, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 163);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 11);
            label2.Name = "label2";
            label2.Size = new Size(119, 34);
            label2.TabIndex = 2;
            label2.Text = "Digite a Matrícula\r\ndo Aluno";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(btnEnviar);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(txtAlterarNome);
            panel4.Controls.Add(mkdAlterarDataNascimento);
            panel4.Controls.Add(txtAlterarEmail);
            panel4.Controls.Add(mkdAlterarCpf);
            panel4.Controls.Add(mkdAlterarTelefone);
            panel4.Controls.Add(txtAlterarEndereco);
            panel4.Location = new Point(122, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(585, 379);
            panel4.TabIndex = 15;
            panel4.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(37, 148);
            label9.Name = "label9";
            label9.Size = new Size(116, 17);
            label9.TabIndex = 17;
            label9.Text = "E-mail p/ contato";
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Top;
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(366, 332);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(107, 37);
            btnEnviar.TabIndex = 11;
            btnEnviar.Text = "Alterar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.Location = new Point(37, 86);
            label10.Name = "label10";
            label10.Size = new Size(64, 17);
            label10.TabIndex = 16;
            label10.Text = "Endereço";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(37, 212);
            label11.Name = "label11";
            label11.Size = new Size(133, 34);
            label11.TabIndex = 15;
            label11.Text = "Data de Nascimento\r\ndo Aluno";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.Location = new Point(205, 229);
            label12.Name = "label12";
            label12.Size = new Size(92, 17);
            label12.TabIndex = 14;
            label12.Text = "CPF do Aluno";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label13.Location = new Point(373, 229);
            label13.Name = "label13";
            label13.Size = new Size(130, 17);
            label13.TabIndex = 13;
            label13.Text = "Telefone p/ contato";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.Location = new Point(37, 27);
            label14.Name = "label14";
            label14.Size = new Size(115, 19);
            label14.TabIndex = 12;
            label14.Text = "Nome do Aluno";
            // 
            // txtAlterarNome
            // 
            txtAlterarNome.Anchor = AnchorStyles.Top;
            txtAlterarNome.Location = new Point(38, 49);
            txtAlterarNome.Name = "txtAlterarNome";
            txtAlterarNome.PlaceholderText = "Digite o Nome Completo";
            txtAlterarNome.Size = new Size(427, 23);
            txtAlterarNome.TabIndex = 0;
            // 
            // mkdAlterarDataNascimento
            // 
            mkdAlterarDataNascimento.Anchor = AnchorStyles.Top;
            mkdAlterarDataNascimento.Location = new Point(37, 249);
            mkdAlterarDataNascimento.Mask = "00/00/0000";
            mkdAlterarDataNascimento.Name = "mkdAlterarDataNascimento";
            mkdAlterarDataNascimento.Size = new Size(100, 23);
            mkdAlterarDataNascimento.TabIndex = 3;
            mkdAlterarDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtAlterarEmail
            // 
            txtAlterarEmail.Anchor = AnchorStyles.Top;
            txtAlterarEmail.Location = new Point(38, 166);
            txtAlterarEmail.Name = "txtAlterarEmail";
            txtAlterarEmail.PlaceholderText = "example@gmail.com";
            txtAlterarEmail.Size = new Size(427, 23);
            txtAlterarEmail.TabIndex = 2;
            // 
            // mkdAlterarCpf
            // 
            mkdAlterarCpf.Anchor = AnchorStyles.Top;
            mkdAlterarCpf.Location = new Point(206, 249);
            mkdAlterarCpf.Mask = "000,000,000-00";
            mkdAlterarCpf.Name = "mkdAlterarCpf";
            mkdAlterarCpf.Size = new Size(100, 23);
            mkdAlterarCpf.TabIndex = 4;
            // 
            // mkdAlterarTelefone
            // 
            mkdAlterarTelefone.Anchor = AnchorStyles.Top;
            mkdAlterarTelefone.Location = new Point(373, 249);
            mkdAlterarTelefone.Mask = "(00)00000-0000";
            mkdAlterarTelefone.Name = "mkdAlterarTelefone";
            mkdAlterarTelefone.Size = new Size(100, 23);
            mkdAlterarTelefone.TabIndex = 5;
            // 
            // txtAlterarEndereco
            // 
            txtAlterarEndereco.Anchor = AnchorStyles.Top;
            txtAlterarEndereco.Location = new Point(38, 104);
            txtAlterarEndereco.Name = "txtAlterarEndereco";
            txtAlterarEndereco.PlaceholderText = "Logradouro, Número - Complemento, Bairro, Cidade - UF";
            txtAlterarEndereco.Size = new Size(505, 23);
            txtAlterarEndereco.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 20);
            label3.Name = "label3";
            label3.Size = new Size(264, 45);
            label3.TabIndex = 16;
            label3.Text = "Atualizar Dados";
            // 
            // F_Atualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Atualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Aluno";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private Button btnVerificar;
        private Panel panel1;
        private Button btnEscolherCampos;
        private Label label1;
        private CheckedListBox clbEscolherAlteracao;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label9;
        private Button btnEnviar;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtAlterarNome;
        private MaskedTextBox mkdAlterarDataNascimento;
        private TextBox txtAlterarEmail;
        private MaskedTextBox mkdAlterarCpf;
        private MaskedTextBox mkdAlterarTelefone;
        private TextBox txtAlterarEndereco;
        private Label label3;
    }
}