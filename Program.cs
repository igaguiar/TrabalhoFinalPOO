using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Controllers;
using TrabalhoFinalPOO.Models;

namespace TrabalhoFinalPOO
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FrmManutencaoAlunos frmManutencaoAlunos = new FrmManutencaoAlunos();
            frmManutencaoAlunos.Visible = false;

            AlunoModel alunoModel = new AlunoModel();
            AlunoController alunoController = new AlunoController(frmManutencaoAlunos, alunoModel);

            FrmPrincipal frmPrincipal = new FrmPrincipal(frmManutencaoAlunos, alunoController);
            frmPrincipal.ShowDialog();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmPrincipal());
        }
    }
}
