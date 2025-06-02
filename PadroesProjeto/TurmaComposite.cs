using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public class TurmaComposite : IElementoRelatorio
    {
        private readonly Turma _turma;
        private readonly List<IElementoRelatorio> _filhos = new List<IElementoRelatorio>();

        public TurmaComposite(Turma turma)
        {
            _turma = turma;
            foreach (var aluno in _turma.Alunos)
            {
                _filhos.Add(new AlunoLeaf(aluno));
            }
        }

        public void Escrever(Document doc, int nivel = 0)
        {
            doc.Add(new Paragraph($"{Indent(nivel)}Turma: {_turma.Nome}"));
            foreach (var filho in _filhos)
            {
                filho.Escrever(doc, nivel + 1);
            }
        }

        private string Indent(int nivel) => new string(' ', nivel * 4);
    }

}
