using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public class AlertaQuantidadeAlunosObserver : IObserverTurma
    {
        public void NotificarExcedenteAlunos(Turma turma)
        {
            MessageBox.Show($"A turma excedeu a quantidade máxima de alunos permitida (Quantidade Limite: {turma.QuantidadeAlunos}).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
