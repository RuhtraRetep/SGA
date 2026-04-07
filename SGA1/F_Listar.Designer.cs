namespace SGA1
{
    partial class F_Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Listar));
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            btnBuscar = new Button();
            btnListar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(205, 86);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(373, 86);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Id";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(219, 210);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(636, 112);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(85, 39);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar todos os alunos";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // F_Listar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListar);
            Controls.Add(btnBuscar);
            Controls.Add(txtMatricula);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_Listar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMatricula;
        private Button btnBuscar;
        private Button btnListar;
    }
}