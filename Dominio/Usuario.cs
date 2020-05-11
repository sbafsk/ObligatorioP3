using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Cedula { get; set; }

        public string Contraseña { get; set; }

        public string Rol { get; set; }

        public override string ToString()
        {
            return Cedula;
        }

        public static bool ValidarCedula(string ci)
        {
            const int MIN_LENGTH = 7;
            const int MAX_LENGTH = 8;

            if (ci == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = ci.Length >= MIN_LENGTH && ci.Length <= MAX_LENGTH;            
            bool hasStringDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in ci)
                {                    
                    if (char.IsLetter(c)) hasStringDigit = true;                    
                }
            }

            return meetsLengthRequirements && !hasStringDigit;
            

        }
        public static bool ValidarContraseña(string pass)
        {
            const int MIN_LENGTH = 6;
            const int MAX_LENGTH = 15;

            if (pass == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = pass.Length >= MIN_LENGTH && pass.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in pass)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            return meetsLengthRequirements
                    && hasUpperCaseLetter
                    && hasLowerCaseLetter
                    && hasDecimalDigit;

            

        }
    }
}
