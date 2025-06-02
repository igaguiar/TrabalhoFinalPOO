using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public class TurmaFactoryPadrao : ITurmaFactory
    {
        public Turma CriarTurma(int id, string nome, int ano, int semestre, int quantidadeAlunos, Curso curso, Professor professor, List<Aluno> alunos)
        {
            return new Turma
            {
                Id = id,
                Nome = nome,
                Ano = ano,
                Semestre = semestre,
                QuantidadeAlunos = quantidadeAlunos,
                Curso = curso,
                Professor = professor,
                Alunos = alunos
            };
        }
    }
}
