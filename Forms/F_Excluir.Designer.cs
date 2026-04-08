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
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 10F);
            txtMatricula.Location = new Point(342, 108);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(120, 25);
            txtMatricula.TabIndex = 0;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(363, 173);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 23);
            label1.Name = "label1";
            label1.Size = new Size(221, 42);
            label1.TabIndex = 2;
            label1.Text = "Digite a matrícula do Aluno\r\n p/ excluir o aluno";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // F_Excluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDeletar);
            Controls.Add(txtMatricula);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_Excluir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Excluir Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private Button btnDeletar;
        private Label label1;
    }
}