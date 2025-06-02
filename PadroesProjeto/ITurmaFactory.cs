using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public interface ITurmaFactory
    {
        Turma CriarTurma(int id, string nome, int ano, int semestre, int quantidadeAlunos, Curso curso, Professor professor, List<Aluno> alunos);
    }
}
