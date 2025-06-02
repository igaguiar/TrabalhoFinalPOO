using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public abstract class TurmaCreator
    {
        public abstract Turma CriarTurma(int ano, int semestre, int quantidadeAlunos, Curso curso, Professor professor, List<Aluno> alunos);
    }
}
