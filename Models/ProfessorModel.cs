using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.Models
{
    public class ProfessorModel
    {
        private List<Professor> professores = new List<Professor>();

        public List<Professor> Professores
        {
            get { return professores; }
        }
        public void Adicionar(Professor professor)
        {
            professores.Add(professor);
        }
        public void Remover(Professor professor)
        {
            professores.Remove(professor);
        }
        public Professor BuscaProfessorPorId(int id)
        {
            return professores.FirstOrDefault(p => p.Id == id);
        }
        public Professor BuscaProfessorPorCpf(string cpf)
        {
            return professores.FirstOrDefault(p => p.CPF == cpf);
        }
        public int BuscarProximoId()
        {
            if (professores.Count == 0)
            {
                return 0;
            }
            return professores.Max(p => p.Id) + 1;
        }
    }
}
