namespace Forms
{
    partial class F_Excluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Excluir));
            txtMatricula = new TextBox();
            btnDeletar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 10F);
            txtMatricula.Location = new Point(110, 82);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(66, 25);
            txtMatricula.TabIndex = 0;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(104, 150);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(79, 32);
            btnDeletar.TabIndex = 1;
            btnDeletar.Text = "Excluir";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(47, 25);
            label1.Name = "label1";
            label1.Size = new Size(193, 38);
            label1.TabIndex = 2;
            label1.Text = "Digite a matrícula do Aluno\r\n p/ excluir o aluno";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMatricula);
            panel1.Controls.Add(btnDeletar);
            panel1.Location = new Point(256, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 225);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 30);
            label2.Name = "label2";
            label2.Size = new Size(223, 45);
            label2.TabIndex = 4;
            label2.Text = "Excluir Aluno";
            // 
            // F_Excluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Excluir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Excluir Aluno";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private Button btnDeletar;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}