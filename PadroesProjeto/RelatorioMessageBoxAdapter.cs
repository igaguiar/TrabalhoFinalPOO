using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.PadroesProjeto
{
    public class RelatorioMessageBoxAdapter : IRelatorioAdapter
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

            StringBuilder relatorio = new StringBuilder();
            relatorio.AppendLine("Relatório: Quantidade de Alunos por Curso");
            relatorio.AppendLine("==========================================");

            foreach (var item in alunosPorCurso)
            {
                relatorio.AppendLine($"Curso: {item.Curso} - Alunos: {item.TotalAlunos}");
            }

            MessageBox.Show(relatorio.ToString(), "Relatório");
        }
    }
}
