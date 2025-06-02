using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public class CursoComposite : IElementoRelatorio
    {
        private readonly string _nomeCurso;
        private readonly List<IElementoRelatorio> _turmas = new List<IElementoRelatorio>();


        public CursoComposite(string nomeCurso)
        {
            _nomeCurso = nomeCurso;
        }

        public void AdicionarTurma(Turma turma)
        {
            _turmas.Add(new TurmaComposite(turma));
        }

        public void Escrever(Document doc, int nivel = 0)
        {
            doc.Add(new Paragraph($"{Indent(nivel)}Curso: {_nomeCurso}"));
            foreach (var turma in _turmas)
            {
                turma.Escrever(doc, nivel + 1);
            }
        }

        private string Indent(int nivel) => new string(' ', nivel * 4);
    }

}
