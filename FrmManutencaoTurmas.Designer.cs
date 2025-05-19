namespace TrabalhoFinalPOO
{
    partial class FrmManutencaoTurmas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.numericQuantidadeAlunos = new System.Windows.Forms.NumericUpDown();
            this.comboCurso = new System.Windows.Forms.ComboBox();
            this.comboProfessor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.comboAluno = new System.Windows.Forms.ComboBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.comboTurma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemoverAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidadeAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de Alunos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Professor";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(130, 66);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 5;
            // 
            // comboSemestre
            // 
            this.comboSemestre.FormattingEnabled = true;
            this.comboSemestre.Location = new System.Drawing.Point(342, 65);
            this.comboSemestre.Name = "comboSemestre";
            this.comboSemestre.Size = new System.Drawing.Size(121, 21);
            this.comboSemestre.TabIndex = 6;
            // 
            // numericQuantidadeAlunos
            // 
            this.numericQuantidadeAlunos.Location = new System.Drawing.Point(130, 101);
            this.numericQuantidadeAlunos.Name = "numericQuantidadeAlunos";
            this.numericQuantidadeAlunos.Size = new System.Drawing.Size(120, 20);
            this.numericQuantidadeAlunos.TabIndex = 7;
            // 
            // comboCurso
            // 
            this.comboCurso.FormattingEnabled = true;
            this.comboCurso.Location = new System.Drawing.Point(130, 135);
            this.comboCurso.Name = "comboCurso";
            this.comboCurso.Size = new System.Drawing.Size(333, 21);
            this.comboCurso.TabIndex = 8;
            // 
            // comboProfessor
            // 
            this.comboProfessor.FormattingEnabled = true;
            this.comboProfessor.Location = new System.Drawing.Point(130, 171);
            this.comboProfessor.Name = "comboProfessor";
            this.comboProfessor.Size = new System.Drawing.Size(333, 21);
            this.comboProfessor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aluno";
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(129, 214);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(253, 20);
            this.txtAluno.TabIndex = 11;
            // 
            // comboAluno
            // 
            this.comboAluno.FormattingEnabled = true;
            this.comboAluno.Location = new System.Drawing.Point(129, 241);
            this.comboAluno.Name = "comboAluno";
            this.comboAluno.Size = new System.Drawing.Size(253, 21);
            this.comboAluno.TabIndex = 12;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(129, 278);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(362, 150);
            this.dgvAlunos.TabIndex = 13;
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.Location = new System.Drawing.Point(388, 214);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAluno.TabIndex = 14;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.Location = new System.Drawing.Point(388, 241);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarAluno.TabIndex = 15;
            this.btnAdicionarAluno.Text = "Adicionar";
            this.btnAdicionarAluno.UseVisualStyleBackColor = true;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionarAluno_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(130, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(252, 20);
            this.txtNome.TabIndex = 17;
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.Location = new System.Drawing.Point(388, 6);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNome.TabIndex = 18;
            this.btnBuscarNome.Text = "Buscar";
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            // 
            // comboTurma
            // 
            this.comboTurma.FormattingEnabled = true;
            this.comboTurma.Location = new System.Drawing.Point(130, 35);
            this.comboTurma.Name = "comboTurma";
            this.comboTurma.Size = new System.Drawing.Size(333, 21);
            this.comboTurma.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Turma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Alunos na Turma";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(193, 434);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemoverAluno
            // 
            this.btnRemoverAluno.Location = new System.Drawing.Point(39, 384);
            this.btnRemoverAluno.Name = "btnRemoverAluno";
            this.btnRemoverAluno.Size = new System.Drawing.Size(75, 44);
            this.btnRemoverAluno.TabIndex = 23;
            this.btnRemoverAluno.Text = "Remover";
            this.btnRemoverAluno.UseVisualStyleBackColor = true;
            this.btnRemoverAluno.Click += new System.EventHandler(this.btnRemoverAluno_Click);
            // 
            // FrmManutencaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 464);
            this.Controls.Add(this.btnRemoverAluno);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboTurma);
            this.Controls.Add(this.btnBuscarNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.comboAluno);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboProfessor);
            this.Controls.Add(this.comboCurso);
            this.Controls.Add(this.numericQuantidadeAlunos);
            this.Controls.Add(this.comboSemestre);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmManutencaoTurmas";
            this.Text = "Manutenção de Turmas";
            this.Load += new System.EventHandler(this.FrmManutencaoTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidadeAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.NumericUpDown numericQuantidadeAlunos;
        private System.Windows.Forms.ComboBox comboCurso;
        private System.Windows.Forms.ComboBox comboProfessor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.ComboBox comboAluno;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.ComboBox comboTurma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemoverAluno;
    }
}