namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        private bool virgola = false;
        private bool overwrite = false;
        Calcolatrice calc;
        public Form1()
        {
            InitializeComponent();
        }
        private void AddText(string text)
        {
            if (richTextBoxDisplay.Text == "0" || overwrite) richTextBoxDisplay.Text = text;
            else richTextBoxDisplay.Text += text;
            overwrite = false;
        }
        private void buttonUno_Click(object sender, EventArgs e)
        {
            AddText("1");
        }

        private void buttonDue_Click(object sender, EventArgs e)
        {
            AddText("2");
        }

        private void buttonTre_Click(object sender, EventArgs e)
        {
            AddText("3");
        }

        private void buttonQuattro_Click(object sender, EventArgs e)
        {
            AddText("4");
        }

        private void buttonCinque_Click(object sender, EventArgs e)
        {
            AddText("5");
        }

        private void buttonSei_Click(object sender, EventArgs e)
        {
            AddText("6");
        }

        private void buttonSette_Click(object sender, EventArgs e)
        {
            AddText("7");
        }

        private void buttonOtto_Click(object sender, EventArgs e)
        {
            AddText("8");
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            AddText("9");
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            AddText("0");
        }

        private void buttonVirgola_Click(object sender, EventArgs e)
        {
            if (!virgola && overwrite)
            {
                richTextBoxDisplay.Text = "0,";
                virgola = true;
                overwrite = false;
            }
            else if (!virgola)
            {
                richTextBoxDisplay.Text += ",";
                virgola = true;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxDisplay.Text = "0";
            virgola = false;
            calc.Clear();
        }

        private void buttonCancella_Click(object sender, EventArgs e)
        {
            if (richTextBoxDisplay.Text == "0") return;
            if (richTextBoxDisplay.Text.Length == 1)
            {
                richTextBoxDisplay.Text = "0";
                return;
            }

            int i = richTextBoxDisplay.Text.Length - 1;
            if (richTextBoxDisplay.Text[i] == ',')
            {
                virgola = false;
            }

            richTextBoxDisplay.Text = richTextBoxDisplay.Text.Substring(0, i);
        }

        private void buttonPiu_Click(object sender, EventArgs e)
        {
            string text = richTextBoxDisplay.Text;
            richTextBoxDisplay.Text = calc.Calcola("+", text);
            overwrite = true;
            virgola = false;
            ReloadCronologia();
        }

        private void buttonUguale_Click(object sender, EventArgs e)
        {
            string text = richTextBoxDisplay.Text;
            richTextBoxDisplay.Text = calc.Uguale(text);
            overwrite = true;
            virgola = false;
            ReloadCronologia();
        }

        private void buttonMeno_Click(object sender, EventArgs e)
        {
            string text = richTextBoxDisplay.Text;
            richTextBoxDisplay.Text = calc.Calcola("-", text);
            overwrite = true;
            virgola = false;
            ReloadCronologia();
        }

        private void buttonDiviso_Click(object sender, EventArgs e)
        {
            string text = richTextBoxDisplay.Text;
            richTextBoxDisplay.Text = calc.Calcola("/", text);
            overwrite = true;
            virgola = false;
            ReloadCronologia();
        }

        private void buttonPer_Click(object sender, EventArgs e)
        {
            string text = richTextBoxDisplay.Text;
            richTextBoxDisplay.Text = calc.Calcola("*", text);
            overwrite = true;
            virgola = false;
            ReloadCronologia();
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            string text = richTextBoxDisplay.Text;
            if (text[0] == '-')
            {
                richTextBoxDisplay.Text = text.Substring(1, text.Length - 1);
            }
            else
            {
                richTextBoxDisplay.Text = "-" + text;
            }
        }

        private void buttonPercentuale_Click(object sender, EventArgs e)
        {
            string text = richTextBoxDisplay.Text;
            richTextBoxDisplay.Text = calc.Percentuale(text);
            overwrite = true;
            virgola = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calc = new Calcolatrice();
            listBoxOperazioni.DataSource = Calcolatrice.Operazioni;
        }

        private void buttonCronologia_Click(object sender, EventArgs e)
        {
            calc.CancellaCronologia();
            ReloadCronologia();
        }

        private void ReloadCronologia()
        {
            listBoxOperazioni.DataSource = null;
            listBoxOperazioni.DataSource = Calcolatrice.Operazioni;
        }
    }
}
