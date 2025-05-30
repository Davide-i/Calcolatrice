namespace Calcolatrice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSette = new Button();
            buttonOtto = new Button();
            buttonNove = new Button();
            buttonPer = new Button();
            buttonDiviso = new Button();
            buttonSei = new Button();
            buttonCinque = new Button();
            buttonQuattro = new Button();
            buttonMeno = new Button();
            buttonTre = new Button();
            buttonDue = new Button();
            buttonUno = new Button();
            buttonPiu = new Button();
            buttonUguale = new Button();
            buttonVirgola = new Button();
            buttonZero = new Button();
            buttonPercentuale = new Button();
            buttonCancella = new Button();
            buttonClear = new Button();
            richTextBoxDisplay = new RichTextBox();
            labelOperazioni = new Label();
            listBoxOperazioni = new ListBox();
            buttonCronologia = new Button();
            buttonChangeSign = new Button();
            SuspendLayout();
            // 
            // buttonSette
            // 
            buttonSette.Location = new Point(12, 125);
            buttonSette.Name = "buttonSette";
            buttonSette.Size = new Size(60, 60);
            buttonSette.TabIndex = 1;
            buttonSette.Text = "7";
            buttonSette.UseVisualStyleBackColor = true;
            buttonSette.Click += buttonSette_Click;
            // 
            // buttonOtto
            // 
            buttonOtto.Location = new Point(78, 125);
            buttonOtto.Name = "buttonOtto";
            buttonOtto.Size = new Size(60, 60);
            buttonOtto.TabIndex = 2;
            buttonOtto.Text = "8";
            buttonOtto.UseVisualStyleBackColor = true;
            buttonOtto.Click += buttonOtto_Click;
            // 
            // buttonNove
            // 
            buttonNove.Location = new Point(144, 125);
            buttonNove.Name = "buttonNove";
            buttonNove.Size = new Size(60, 60);
            buttonNove.TabIndex = 3;
            buttonNove.Text = "9";
            buttonNove.UseVisualStyleBackColor = true;
            buttonNove.Click += buttonNove_Click;
            // 
            // buttonPer
            // 
            buttonPer.Location = new Point(210, 125);
            buttonPer.Name = "buttonPer";
            buttonPer.Size = new Size(60, 60);
            buttonPer.TabIndex = 4;
            buttonPer.Text = "X";
            buttonPer.UseVisualStyleBackColor = true;
            buttonPer.Click += buttonPer_Click;
            // 
            // buttonDiviso
            // 
            buttonDiviso.Location = new Point(210, 191);
            buttonDiviso.Name = "buttonDiviso";
            buttonDiviso.Size = new Size(60, 60);
            buttonDiviso.TabIndex = 8;
            buttonDiviso.Text = "/";
            buttonDiviso.UseVisualStyleBackColor = true;
            buttonDiviso.Click += buttonDiviso_Click;
            // 
            // buttonSei
            // 
            buttonSei.Location = new Point(144, 191);
            buttonSei.Name = "buttonSei";
            buttonSei.Size = new Size(60, 60);
            buttonSei.TabIndex = 7;
            buttonSei.Text = "6";
            buttonSei.UseVisualStyleBackColor = true;
            buttonSei.Click += buttonSei_Click;
            // 
            // buttonCinque
            // 
            buttonCinque.Location = new Point(78, 191);
            buttonCinque.Name = "buttonCinque";
            buttonCinque.Size = new Size(60, 60);
            buttonCinque.TabIndex = 6;
            buttonCinque.Text = "5";
            buttonCinque.UseVisualStyleBackColor = true;
            buttonCinque.Click += buttonCinque_Click;
            // 
            // buttonQuattro
            // 
            buttonQuattro.Location = new Point(12, 191);
            buttonQuattro.Name = "buttonQuattro";
            buttonQuattro.Size = new Size(60, 60);
            buttonQuattro.TabIndex = 5;
            buttonQuattro.Text = "4";
            buttonQuattro.UseVisualStyleBackColor = true;
            buttonQuattro.Click += buttonQuattro_Click;
            // 
            // buttonMeno
            // 
            buttonMeno.Location = new Point(210, 257);
            buttonMeno.Name = "buttonMeno";
            buttonMeno.Size = new Size(60, 60);
            buttonMeno.TabIndex = 12;
            buttonMeno.Text = "-";
            buttonMeno.UseVisualStyleBackColor = true;
            buttonMeno.Click += buttonMeno_Click;
            // 
            // buttonTre
            // 
            buttonTre.Location = new Point(144, 257);
            buttonTre.Name = "buttonTre";
            buttonTre.Size = new Size(60, 60);
            buttonTre.TabIndex = 11;
            buttonTre.Text = "3";
            buttonTre.UseVisualStyleBackColor = true;
            buttonTre.Click += buttonTre_Click;
            // 
            // buttonDue
            // 
            buttonDue.Location = new Point(78, 257);
            buttonDue.Name = "buttonDue";
            buttonDue.Size = new Size(60, 60);
            buttonDue.TabIndex = 10;
            buttonDue.Text = "2";
            buttonDue.UseVisualStyleBackColor = true;
            buttonDue.Click += buttonDue_Click;
            // 
            // buttonUno
            // 
            buttonUno.Location = new Point(12, 257);
            buttonUno.Name = "buttonUno";
            buttonUno.Size = new Size(60, 60);
            buttonUno.TabIndex = 9;
            buttonUno.Text = "1";
            buttonUno.UseVisualStyleBackColor = true;
            buttonUno.Click += buttonUno_Click;
            // 
            // buttonPiu
            // 
            buttonPiu.Location = new Point(210, 323);
            buttonPiu.Name = "buttonPiu";
            buttonPiu.Size = new Size(60, 60);
            buttonPiu.TabIndex = 16;
            buttonPiu.Text = "+";
            buttonPiu.UseVisualStyleBackColor = true;
            buttonPiu.Click += buttonPiu_Click;
            // 
            // buttonUguale
            // 
            buttonUguale.Location = new Point(144, 323);
            buttonUguale.Name = "buttonUguale";
            buttonUguale.Size = new Size(60, 60);
            buttonUguale.TabIndex = 15;
            buttonUguale.Text = "=";
            buttonUguale.UseVisualStyleBackColor = true;
            buttonUguale.Click += buttonUguale_Click;
            // 
            // buttonVirgola
            // 
            buttonVirgola.Location = new Point(78, 323);
            buttonVirgola.Name = "buttonVirgola";
            buttonVirgola.Size = new Size(60, 60);
            buttonVirgola.TabIndex = 14;
            buttonVirgola.Text = ",";
            buttonVirgola.UseVisualStyleBackColor = true;
            buttonVirgola.Click += buttonVirgola_Click;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(12, 323);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(60, 60);
            buttonZero.TabIndex = 13;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonPercentuale
            // 
            buttonPercentuale.Location = new Point(210, 59);
            buttonPercentuale.Name = "buttonPercentuale";
            buttonPercentuale.Size = new Size(60, 60);
            buttonPercentuale.TabIndex = 19;
            buttonPercentuale.Text = "%";
            buttonPercentuale.UseVisualStyleBackColor = true;
            buttonPercentuale.Click += buttonPercentuale_Click;
            // 
            // buttonCancella
            // 
            buttonCancella.Location = new Point(78, 59);
            buttonCancella.Name = "buttonCancella";
            buttonCancella.Size = new Size(60, 60);
            buttonCancella.TabIndex = 18;
            buttonCancella.Text = "Cancella";
            buttonCancella.UseVisualStyleBackColor = true;
            buttonCancella.Click += buttonCancella_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(12, 59);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(60, 60);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Pulisci";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // richTextBoxDisplay
            // 
            richTextBoxDisplay.Font = new Font("Segoe UI", 20F);
            richTextBoxDisplay.Location = new Point(12, 12);
            richTextBoxDisplay.Multiline = false;
            richTextBoxDisplay.Name = "richTextBoxDisplay";
            richTextBoxDisplay.ReadOnly = true;
            richTextBoxDisplay.Size = new Size(258, 41);
            richTextBoxDisplay.TabIndex = 21;
            richTextBoxDisplay.Text = "0";
            // 
            // labelOperazioni
            // 
            labelOperazioni.AutoSize = true;
            labelOperazioni.Location = new Point(320, 38);
            labelOperazioni.Name = "labelOperazioni";
            labelOperazioni.Size = new Size(126, 15);
            labelOperazioni.TabIndex = 22;
            labelOperazioni.Text = "Operazioni precedenti:";
            // 
            // listBoxOperazioni
            // 
            listBoxOperazioni.FormattingEnabled = true;
            listBoxOperazioni.ItemHeight = 15;
            listBoxOperazioni.Location = new Point(276, 59);
            listBoxOperazioni.Name = "listBoxOperazioni";
            listBoxOperazioni.Size = new Size(217, 259);
            listBoxOperazioni.TabIndex = 23;
            // 
            // buttonCronologia
            // 
            buttonCronologia.Location = new Point(276, 324);
            buttonCronologia.Name = "buttonCronologia";
            buttonCronologia.Size = new Size(217, 59);
            buttonCronologia.TabIndex = 24;
            buttonCronologia.Text = "Cancella cronologia operazioni";
            buttonCronologia.UseVisualStyleBackColor = true;
            buttonCronologia.Click += buttonCronologia_Click;
            // 
            // buttonChangeSign
            // 
            buttonChangeSign.Font = new Font("Segoe UI", 12F);
            buttonChangeSign.Location = new Point(144, 59);
            buttonChangeSign.Name = "buttonChangeSign";
            buttonChangeSign.Size = new Size(60, 60);
            buttonChangeSign.TabIndex = 25;
            buttonChangeSign.Text = "-/+";
            buttonChangeSign.UseVisualStyleBackColor = true;
            buttonChangeSign.Click += buttonChangeSign_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 391);
            Controls.Add(buttonChangeSign);
            Controls.Add(buttonCronologia);
            Controls.Add(listBoxOperazioni);
            Controls.Add(labelOperazioni);
            Controls.Add(richTextBoxDisplay);
            Controls.Add(buttonPercentuale);
            Controls.Add(buttonCancella);
            Controls.Add(buttonClear);
            Controls.Add(buttonPiu);
            Controls.Add(buttonUguale);
            Controls.Add(buttonVirgola);
            Controls.Add(buttonZero);
            Controls.Add(buttonMeno);
            Controls.Add(buttonTre);
            Controls.Add(buttonDue);
            Controls.Add(buttonUno);
            Controls.Add(buttonDiviso);
            Controls.Add(buttonSei);
            Controls.Add(buttonCinque);
            Controls.Add(buttonQuattro);
            Controls.Add(buttonPer);
            Controls.Add(buttonNove);
            Controls.Add(buttonOtto);
            Controls.Add(buttonSette);
            Name = "Form1";
            Text = "Calcolatrice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSette;
        private Button buttonOtto;
        private Button buttonNove;
        private Button buttonPer;
        private Button buttonDiviso;
        private Button buttonSei;
        private Button buttonCinque;
        private Button buttonQuattro;
        private Button buttonMeno;
        private Button buttonTre;
        private Button buttonDue;
        private Button buttonUno;
        private Button buttonPiu;
        private Button buttonUguale;
        private Button buttonVirgola;
        private Button buttonZero;
        private Button buttonPercentuale;
        private Button buttonCancella;
        private Button buttonClear;
        private RichTextBox richTextBoxDisplay;
        private Label labelOperazioni;
        private ListBox listBoxOperazioni;
        private Button buttonCronologia;
        private Button buttonChangeSign;
    }
}
