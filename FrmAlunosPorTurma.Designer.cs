namespace TrabalhoFinalPOO
{
    partial class FrmAlunosPorTurma
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
            this.comboTurma = new System.Windows.Forms.ComboBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTurma
            // 
            this.comboTurma.FormattingEnabled = true;
            this.comboTurma.Location = new System.Drawing.Point(12, 12);
            this.comboTurma.Name = "comboTurma";
            this.comboTurma.Size = new System.Drawing.Size(121, 21);
            this.comboTurma.TabIndex = 0;
            this.comboTurma.SelectedIndexChanged += new System.EventHandler(this.comboTurma_SelectedIndexChanged);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(12, 39);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(247, 284);
            this.dgvAlunos.TabIndex = 1;
            // 
            // FrmAlunosPorTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 335);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.comboTurma);
            this.Name = "FrmAlunosPorTurma";
            this.Text = "FrmAlunosPorTurma";
            this.Load += new System.EventHandler(this.FrmAlunosPorTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTurma;
        private System.Windows.Forms.DataGridView dgvAlunos;
    }
}