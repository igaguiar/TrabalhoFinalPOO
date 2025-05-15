using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrabalhoFinalPOO.Utilidades
{
    public static class Utilidade
    {
        public static bool ValidarNome(string nome)
        {
            return !string.IsNullOrWhiteSpace(nome) && nome.Length >= 3;
        }
        public static bool ValidarCpf(string cpf)
        {
            return !string.IsNullOrWhiteSpace(cpf) && cpf.Length == 11;
        }
        public static bool ValidarEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$");
        }
    }
}
