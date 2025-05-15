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
        public FrmPrincipal(FrmManutencaoAlunos frmManutencaoAlunos)
        {
            InitializeComponent();
            _frmManutencaoAlunos = frmManutencaoAlunos;
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmManutencaoAlunos.ShowDialog();
        }
    }
}
