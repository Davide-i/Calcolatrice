using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    class Operazione
    {
        public decimal Num1 { get; private set; }
        public decimal Num2 { get; private set; }
        public decimal Risultato { get; private set; }
        public string Op { get; private set; }

        public Operazione(decimal num1, decimal num2, decimal risultato, string op)
        {
            Num1 = num1;
            Num2 = num2;
            Risultato = risultato;
            Op = op;
        }

        public override string ToString()
        {
            return $"{Num1} {Op} {Num2} = {Risultato}";
        }

        public string Save()
        {
            return $"{Num1.ToString().Replace(',', '.')},{Op},{Num2.ToString().Replace(',', '.')},{Risultato.ToString().Replace(',', '.')}";
        }
    }
}
