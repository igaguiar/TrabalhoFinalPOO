using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Controllers;
using TrabalhoFinalPOO.Models;

namespace TrabalhoFinalPOO
{
    public partial class FrmPrincipal : Form
    {
        FrmManutencaoAlunos _frmManutencaoAlunos;
        AlunoController _alunoController;
        public FrmPrincipal(FrmManutencaoAlunos frmManutencaoAlunos, AlunoController alunoController)
        {
            InitializeComponent();
            _frmManutencaoAlunos = frmManutencaoAlunos;
            _alunoController = alunoController;
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _alunoController.MenuCriarAluno();
            _frmManutencaoAlunos.ShowDialog();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _alunoController.MenuExcluirAluno();
            _frmManutencaoAlunos.ShowDialog();
        }
    }
}
