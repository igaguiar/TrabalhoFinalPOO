using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.Models
{
    public class TurmaModel
    {
        private List<Turma> turmas = new List<Turma>();

        public void Adicionar(Turma turma)
        {
            turmas.Add(turma);
        }
        public void Remover(Turma turma)
        {
            turmas.Remove(turma);
        }
        public Turma BuscaTurmaPorNome(string nome)
        {
            return turmas.FirstOrDefault(t => t.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
        public int BuscarProximoId()
        {
            if (turmas.Count == 0)
            {
                return 0;
            }
            return turmas.Max(t => t.Id) + 1;
        }
        public List<Turma> ObterTurmas()
        {
            return turmas;
        }
    }
}
