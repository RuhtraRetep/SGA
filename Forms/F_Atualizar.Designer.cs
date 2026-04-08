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
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtAlterarNome = new TextBox();
            btnAlterar = new Button();
            mkdAlterarDataNascimento = new MaskedTextBox();
            txtAlterarEmail = new TextBox();
            mkdAlterarCpf = new MaskedTextBox();
            mkdAlterarTelefone = new MaskedTextBox();
            txtAlterarEndereco = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(45, 62);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(108, 23);
            txtMatricula.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(67, 99);
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
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 14);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtAlterarNome);
            panel2.Controls.Add(btnAlterar);
            panel2.Controls.Add(mkdAlterarDataNascimento);
            panel2.Controls.Add(txtAlterarEmail);
            panel2.Controls.Add(mkdAlterarCpf);
            panel2.Controls.Add(mkdAlterarTelefone);
            panel2.Controls.Add(txtAlterarEndereco);
            panel2.Location = new Point(249, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 367);
            panel2.TabIndex = 13;
            panel2.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(18, 167);
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
            label7.Location = new Point(18, 92);
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
            label6.Location = new Point(212, 7);
            label6.Name = "label6";
            label6.Size = new Size(133, 34);
            label6.TabIndex = 15;
            label6.Text = "Data de Nascimento\r\ndo Aluno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(208, 92);
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
            label4.Location = new Point(212, 167);
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
            label3.Location = new Point(18, 22);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 12;
            label3.Text = "Nome do Aluno";
            // 
            // txtAlterarNome
            // 
            txtAlterarNome.Anchor = AnchorStyles.Top;
            txtAlterarNome.Location = new Point(19, 40);
            txtAlterarNome.Name = "txtAlterarNome";
            txtAlterarNome.PlaceholderText = "Digite o Nome";
            txtAlterarNome.Size = new Size(122, 23);
            txtAlterarNome.TabIndex = 0;
            txtAlterarNome.Visible = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Top;
            btnAlterar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAlterar.Location = new Point(146, 283);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(87, 38);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // mkdAlterarDataNascimento
            // 
            mkdAlterarDataNascimento.Anchor = AnchorStyles.Top;
            mkdAlterarDataNascimento.Location = new Point(213, 40);
            mkdAlterarDataNascimento.Mask = "00/00/0000";
            mkdAlterarDataNascimento.Name = "mkdAlterarDataNascimento";
            mkdAlterarDataNascimento.Size = new Size(100, 23);
            mkdAlterarDataNascimento.TabIndex = 6;
            mkdAlterarDataNascimento.ValidatingType = typeof(DateTime);
            mkdAlterarDataNascimento.Visible = false;
            // 
            // txtAlterarEmail
            // 
            txtAlterarEmail.Anchor = AnchorStyles.Top;
            txtAlterarEmail.Location = new Point(19, 185);
            txtAlterarEmail.Name = "txtAlterarEmail";
            txtAlterarEmail.PlaceholderText = "example@gmail.com";
            txtAlterarEmail.Size = new Size(122, 23);
            txtAlterarEmail.TabIndex = 10;
            txtAlterarEmail.Visible = false;
            // 
            // mkdAlterarCpf
            // 
            mkdAlterarCpf.Anchor = AnchorStyles.Top;
            mkdAlterarCpf.Location = new Point(213, 110);
            mkdAlterarCpf.Mask = "000,000,000-00";
            mkdAlterarCpf.Name = "mkdAlterarCpf";
            mkdAlterarCpf.Size = new Size(100, 23);
            mkdAlterarCpf.TabIndex = 7;
            mkdAlterarCpf.Visible = false;
            // 
            // mkdAlterarTelefone
            // 
            mkdAlterarTelefone.Anchor = AnchorStyles.Top;
            mkdAlterarTelefone.Location = new Point(213, 185);
            mkdAlterarTelefone.Mask = "(00)00000-0000";
            mkdAlterarTelefone.Name = "mkdAlterarTelefone";
            mkdAlterarTelefone.Size = new Size(100, 23);
            mkdAlterarTelefone.TabIndex = 9;
            mkdAlterarTelefone.Visible = false;
            // 
            // txtAlterarEndereco
            // 
            txtAlterarEndereco.Anchor = AnchorStyles.Top;
            txtAlterarEndereco.Location = new Point(19, 110);
            txtAlterarEndereco.Name = "txtAlterarEndereco";
            txtAlterarEndereco.PlaceholderText = "Cidade";
            txtAlterarEndereco.Size = new Size(122, 23);
            txtAlterarEndereco.TabIndex = 8;
            txtAlterarEndereco.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtMatricula);
            panel3.Controls.Add(btnVerificar);
            panel3.Location = new Point(313, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 148);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 11);
            label2.Name = "label2";
            label2.Size = new Size(119, 34);
            label2.TabIndex = 2;
            label2.Text = "Digite a Matrícula\r\ndo Aluno";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // F_Atualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_Atualizar";
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
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}