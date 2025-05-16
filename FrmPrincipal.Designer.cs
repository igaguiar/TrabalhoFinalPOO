namespace TrabalhoFinalPOO
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarTurmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosPorTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarMatrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrículasPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.matrículasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.excluirAlunoToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // excluirAlunoToolStripMenuItem
            // 
            this.excluirAlunoToolStripMenuItem.Name = "excluirAlunoToolStripMenuItem";
            this.excluirAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirAlunoToolStripMenuItem.Text = "Excluir Aluno";
            this.excluirAlunoToolStripMenuItem.Click += new System.EventHandler(this.excluirAlunoToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProfessorToolStripMenuItem,
            this.excluirProfessorToolStripMenuItem});
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            // 
            // cadastrarProfessorToolStripMenuItem
            // 
            this.cadastrarProfessorToolStripMenuItem.Name = "cadastrarProfessorToolStripMenuItem";
            this.cadastrarProfessorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarProfessorToolStripMenuItem.Text = "Cadastrar Professor";
            this.cadastrarProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProfessorToolStripMenuItem_Click);
            // 
            // excluirProfessorToolStripMenuItem
            // 
            this.excluirProfessorToolStripMenuItem.Name = "excluirProfessorToolStripMenuItem";
            this.excluirProfessorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirProfessorToolStripMenuItem.Text = "Excluir Professor";
            this.excluirProfessorToolStripMenuItem.Click += new System.EventHandler(this.excluirProfessorToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarCursoToolStripMenuItem,
            this.excluirCursoToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // cadastrarCursoToolStripMenuItem
            // 
            this.cadastrarCursoToolStripMenuItem.Name = "cadastrarCursoToolStripMenuItem";
            this.cadastrarCursoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cadastrarCursoToolStripMenuItem.Text = "Cadastrar Curso";
            // 
            // excluirCursoToolStripMenuItem
            // 
            this.excluirCursoToolStripMenuItem.Name = "excluirCursoToolStripMenuItem";
            this.excluirCursoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.excluirCursoToolStripMenuItem.Text = "Excluir Curso";
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarTurmaToolStripMenuItem1,
            this.excluirTurmaToolStripMenuItem});
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // criarTurmaToolStripMenuItem1
            // 
            this.criarTurmaToolStripMenuItem1.Name = "criarTurmaToolStripMenuItem1";
            this.criarTurmaToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.criarTurmaToolStripMenuItem1.Text = "Criar Turma";
            // 
            // excluirTurmaToolStripMenuItem
            // 
            this.excluirTurmaToolStripMenuItem.Name = "excluirTurmaToolStripMenuItem";
            this.excluirTurmaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.excluirTurmaToolStripMenuItem.Text = "Excluir Turma";
            // 
            // matrículasToolStripMenuItem
            // 
            this.matrículasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.realizarMatrículaToolStripMenuItem});
            this.matrículasToolStripMenuItem.Name = "matrículasToolStripMenuItem";
            this.matrículasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.matrículasToolStripMenuItem.Text = "Matrículas";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turmasPorCursoToolStripMenuItem,
            this.alunosPorTurmaToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // turmasPorCursoToolStripMenuItem
            // 
            this.turmasPorCursoToolStripMenuItem.Name = "turmasPorCursoToolStripMenuItem";
            this.turmasPorCursoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.turmasPorCursoToolStripMenuItem.Text = "Turmas por Curso";
            // 
            // alunosPorTurmaToolStripMenuItem
            // 
            this.alunosPorTurmaToolStripMenuItem.Name = "alunosPorTurmaToolStripMenuItem";
            this.alunosPorTurmaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.alunosPorTurmaToolStripMenuItem.Text = "Alunos por Turma";
            // 
            // realizarMatrículaToolStripMenuItem
            // 
            this.realizarMatrículaToolStripMenuItem.Name = "realizarMatrículaToolStripMenuItem";
            this.realizarMatrículaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarMatrículaToolStripMenuItem.Text = "Realizar Matrícula";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrículasPorCursoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // matrículasPorCursoToolStripMenuItem
            // 
            this.matrículasPorCursoToolStripMenuItem.Name = "matrículasPorCursoToolStripMenuItem";
            this.matrículasPorCursoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.matrículasPorCursoToolStripMenuItem.Text = "Matrículas por Curso";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Gestão Academica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrículasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarTurmaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosPorTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarMatrículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrículasPorCursoToolStripMenuItem;
    }
}

