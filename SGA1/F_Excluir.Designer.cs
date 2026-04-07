namespace SGA1
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
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(359, 99);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 0;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(374, 234);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 1;
            btnDeletar.Text = "Excluir";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // F_Excluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}