using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.Models
{
    public class AlunoModel
    {
        private List<Aluno> alunos = new List<Aluno>();

        public void Adicionar(Aluno aluno)
        {
            alunos.Add(aluno);
        }
        public Aluno BuscaAlunoPorId(int id)
        {
            return alunos.FirstOrDefault(a => a.Id == id);
        }
        public Aluno BuscaAlunoPorCpf(string cpf)
        {
            return alunos.FirstOrDefault(a => a.CPF == cpf);
        }
        public int BuscarProximoId()
        {
            if (alunos.Count == 0)
            {
                return 0;
            }

            return alunos.Max(a => a.Id) + 1;
        }
    }
}
