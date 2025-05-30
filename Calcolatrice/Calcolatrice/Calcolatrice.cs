using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    class Calcolatrice
    {
        public decimal Num1 { get; private set; }
        public decimal Num2 { get; private set; }

        private string LastOp;

        public static List<Operazione> Operazioni = new List<Operazione>();
        private FileManager fileManager = new FileManager();
        public Calcolatrice()
        {
            fileManager.LoadFromCSV(Operazioni);
            Num1 = 0;
            LastOp = string.Empty;
        }
        public string Calcola(string op, string testo)
        {
            Num2 = decimal.Parse(testo);
            Operazione operazione;
            decimal ris = 0;
            if (LastOp == "=" || LastOp == string.Empty)
            {
                Num1 = Num2;
                LastOp = op;
                return testo;
            }
            switch (LastOp)
            {
                case "+":
                    
                    ris = Num1 + Num2;
                    break;
                case "-":
                    ris = Num1 - Num2;
                    break;
                case "*":
                    ris = Num1 * Num2;
                    break;
                case "/":
                    if (Num2 == 0)
                    {
                        break;
                    }
                    ris = Num1/Num2;
                    break;
            }
            if (!(op == "="))
            {
                operazione = new Operazione(Num1, Num2, ris, LastOp);
                Operazioni.Add(operazione);
                fileManager.AddToCSV(operazione);
            }
            LastOp = op;
            Num1 = ris;
            return Convert.ToString(ris);
        }
        public string Uguale(string testo)
        {
            string res = Calcola(LastOp, testo);
            LastOp = "=";
            return res;
        }
        public string Percentuale(string testo)
        {
            Num2 = decimal.Parse(testo);
            Num2 = Num1 / 100 * Num2;
            return Convert.ToString(Num2);
        }
        public void Clear()
        {
            Num1 = 0;
            LastOp = string.Empty;
        }

        public bool CancellaCronologia()
        {
            Operazioni.Clear();
            return fileManager.ClearCSV();
        }
    }
}
