using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class ContadorDeVisitas
    {
        private int Visitas;

        public void RegistrarVisita()
        {
            Visitas++;
        }
        public int ObterTotal()
        {
            return Visitas;
        }
    }
}
