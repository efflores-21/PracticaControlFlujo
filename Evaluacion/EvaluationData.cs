using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    using System.Text.RegularExpressions;

    public class EvaluacionData
    {
        // Datos basicos como nombre, edad, y email 
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        // esto es para verificar que el usuario sea major de edad 
        public bool ValidarEdad()
        {
            return Edad >= 18;
        }
        // esto es para segun su edad el formulario le diga al usuario si es major de edad, adulto, etc.
        public string CalcularRangoEdad()
        {
            if (Edad < 18)
            {
                return "Menor de edad";
            }
            else if (Edad <= 65)
            {
                return "Adulto";
            }
            else
            {
                return "Tercera edad";
            }
        }
        // esto es para el email y que cuando el usuario lo ponga no tenga problemas con el email
        public bool ValidarEmail()
        {
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(Email);
        }
    }
}


