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

            var alunosPorCurso = turmas
                .Where(t => t.Curso != null)
                .GroupBy(t => t.Curso.Nome)
                .Select(g => new
                {
                    Curso = g.Key,
                    TotalAlunos = g.Sum(t => t.Alunos?.Count ?? 0)
                })
                .ToList();

            string pasta = @"C:\temp";
            string caminho = Path.Combine(pasta, "relatorio_alunos_por_curso.pdf");

            try
            {
                // Garante que a pasta C:\temp existe
                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph("Relatório: Quantidade de Alunos por Curso"));
                doc.Add(new Paragraph("=========================================="));
                doc.Add(new Paragraph(" "));

                foreach (var item in alunosPorCurso)
                {
                    doc.Add(new Paragraph($"Curso: {item.Curso} - Alunos: {item.TotalAlunos}"));
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
