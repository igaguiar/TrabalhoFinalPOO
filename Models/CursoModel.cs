using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalPOO.Datas;

namespace TrabalhoFinalPOO.Models
{
    public class CursoModel
    {
        private List<Curso> cursos = new List<Curso>();

        public List<Curso> Cursos
        {
            get { return cursos; }
        }
        public void Adicionar(Curso curso)
        {
            cursos.Add(curso);
        }
        public void Remover(Curso curso)
        {
            cursos.Remove(curso);
        }
        public Curso BuscaCursoPorId(int id)
        {
            return cursos.FirstOrDefault(a => a.Id == id);
        }
        public int BuscarProximoId()
        {
            if (cursos.Count == 0)
            {
                return 0;
            }
            return cursos.Max(a => a.Id) + 1;
        }
    }
}
