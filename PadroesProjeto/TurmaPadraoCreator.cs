using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public class TurmaPadraoCreator : TurmaCreator
    {
        private int _id;

        public TurmaPadraoCreator(int proximoId)
        {
            _id = proximoId;
        }

        public override Turma CriarTurma(int ano, int semestre, int quantidadeAlunos, Curso curso, Professor professor, List<Aluno> alunos)
        {
            string nome = $"{curso.Nome} {ano}/{semestre}";

            return new Turma
            {
                Id = _id,
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
