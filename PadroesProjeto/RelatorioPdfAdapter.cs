using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public class RelatorioPdfAdapter : IRelatorioAdapter
    {
        public void GerarRelatorio(List<Turma> turmas)
        {
            if (turmas == null || turmas.Count == 0)
            {
                MessageBox.Show("Nenhuma turma cadastrada.");
                return;
            }

            string pasta = @"C:\temp";
            string caminho = Path.Combine(pasta, "relatorio_alunos_por_curso.pdf");

            try
            {
                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                // Agrupa turmas por curso usando Composite
                var cursosAgrupados = turmas
                    .Where(t => t.Curso != null)
                    .GroupBy(t => t.Curso.Nome)
                    .Select(grupo =>
                    {
                        var cursoComposite = new CursoComposite(grupo.Key);
                        foreach (var turma in grupo)
                            cursoComposite.AdicionarTurma(turma);
                        return cursoComposite;
                    })
                    .ToList();

                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph("Relatório: Alunos por Curso e Turma"));
                doc.Add(new Paragraph("======================================"));
                doc.Add(new Paragraph(" "));

                foreach (var curso in cursosAgrupados)
                {
                    curso.Escrever(doc);
                    doc.Add(new Paragraph(" "));
                }

                doc.Close();
                MessageBox.Show($"Relatório PDF salvo com sucesso em: {caminho}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
            }
        }
    }
}
