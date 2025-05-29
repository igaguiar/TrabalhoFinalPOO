namespace TrabalhoFinalPOO
{
    partial class FrmTurmasPorCurso
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
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.comboCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Location = new System.Drawing.Point(12, 39);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.Size = new System.Drawing.Size(544, 216);
            this.dgvTurmas.TabIndex = 0;
            // 
            // comboCurso
            // 
            this.comboCurso.FormattingEnabled = true;
            this.comboCurso.Location = new System.Drawing.Point(12, 12);
            this.comboCurso.Name = "comboCurso";
            this.comboCurso.Size = new System.Drawing.Size(121, 21);
            this.comboCurso.TabIndex = 1;
            this.comboCurso.SelectedIndexChanged += new System.EventHandler(this.comboCurso_SelectedIndexChanged);
            // 
            // FrmTurmasPorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 283);
            this.Controls.Add(this.comboCurso);
            this.Controls.Add(this.dgvTurmas);
            this.Name = "FrmTurmasPorCurso";
            this.Text = "FrmTurmasPorCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.ComboBox comboCurso;
    }
}