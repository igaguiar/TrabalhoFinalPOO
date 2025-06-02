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
        // Instância única (singleton)
        private static CursoModel _instance;

        // Lock para thread safety (opcional para apps desktop, mas boa prática)
        private static readonly object _lock = new object();

        // Lista interna de cursos
        private List<Curso> cursos = new List<Curso>();

        // Construtor privado
        private CursoModel() { }

        // Propriedade de acesso à instância única
        public static CursoModel Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CursoModel();
                    }
                    return _instance;
                }
            }
        }

        public List<Curso> Cursos => cursos;

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
                return 0;

            return cursos.Max(a => a.Id) + 1;
        }
    }
}
