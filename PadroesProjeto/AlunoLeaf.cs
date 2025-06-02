using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public class AlunoLeaf : IElementoRelatorio
    {
        private readonly Aluno _aluno;

        public AlunoLeaf(Aluno aluno)
        {
            _aluno = aluno;
        }

        public void Escrever(Document doc, int nivel = 0)
        {
            doc.Add(new Paragraph($"{Indent(nivel)}- Aluno: {_aluno.Nome}"));
        }

        private string Indent(int nivel) => new string(' ', nivel * 4);
    }

}
