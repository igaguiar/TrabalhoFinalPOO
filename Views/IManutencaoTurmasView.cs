using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinalPOO.Controllers;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.Views
{
    public interface IManutencaoTurmasView
    {
        void SetController(TurmaController controller);
        string Nome { get; set; }
        string Turma { get; set; }
        int Ano { get; set; }
        int Semestre { get; set; }
        int QuantidadeAlunos { get; set; }
        Curso Curso { get; }
        Professor Professor { get; }
        string NomeAluno { get; set; }
        Aluno Aluno { get; }
        ComboBox ComboSemestre { get; set; }
        ComboBox ComboCurso { get; set; }
        ComboBox ComboProfessor { get; set; }
        ComboBox ComboAluno { get; set; }
        DataGridView DataGridViewAlunos { get; set; }
        Button BuscarNome { get; set; }
        Button BuscarAluno { get; set; }
        Button AdicionarAluno { get; set; }
        Button RemoverAluno { get; set; }
        Button CadastrarTurma { get; set; }
    }
}
