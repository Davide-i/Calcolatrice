using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    class FileManager
    {
        private string FilePath = "Operazioni.csv";
        StreamReader sr;
        StreamWriter sw;

        public bool LoadFromCSV(List<Operazione> operazioni)
        {
            bool res = false;
            try
            {
                sr = new StreamReader(FilePath);
                string[] data;
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    operazioni.Add(new Operazione(decimal.Parse(data[0].Replace('.', ',')), decimal.Parse(data[2].Replace('.', ',')), decimal.Parse(data[3].Replace('.', ',')), data[1]));
                }
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento da file: {ex.Message}", "Errore");
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            return res;
        }

        public bool AddToCSV(Operazione op)
        {
            bool res = false;
            try
            {
                sw = new StreamWriter(FilePath, true);
                sw.WriteLine(op.Save());
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel salvatagio su file: {ex.Message}", "Errore");
            }
            finally
            {
                if (sw != null) sw.Close();
            }
            return res;
        }

        public bool ClearCSV()
        {
            bool res = false;
            FileStream fs = null;
            try
            {
                fs = new FileStream(FilePath, FileMode.Truncate);
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nella cancellazione della cronologia delle operazioni: {ex.Message}");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            return res;
        }
    }
}
