namespace Forms
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
            btnListar = new Button();
            dgvExibirAlunos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExibirAlunos).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(385, 173);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(81, 31);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvExibirAlunos
            // 
            dgvExibirAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExibirAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExibirAlunos.Dock = DockStyle.Bottom;
            dgvExibirAlunos.Location = new Point(0, 263);
            dgvExibirAlunos.Name = "dgvExibirAlunos";
            dgvExibirAlunos.Size = new Size(872, 187);
            dgvExibirAlunos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(321, 21);
            label1.Name = "label1";
            label1.Size = new Size(228, 46);
            label1.TabIndex = 5;
            label1.Text = "Listar Alunos";
            // 
            // F_Listar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(label1);
            Controls.Add(dgvExibirAlunos);
            Controls.Add(btnListar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Listar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Alunos";
            ((System.ComponentModel.ISupportInitialize)dgvExibirAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnListar;
        private DataGridView dgvExibirAlunos;
        private Label label1;
    }
}