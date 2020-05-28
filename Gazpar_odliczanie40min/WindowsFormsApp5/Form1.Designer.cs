namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minutki = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sekundy = new System.Windows.Forms.TextBox();
            this.numerwozka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.godzina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Location = new System.Drawing.Point(23, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zeskanuj Barcode";
            // 
            // minutki
            // 
            this.minutki.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutki.Location = new System.Drawing.Point(350, 159);
            this.minutki.MaxLength = 7;
            this.minutki.Name = "minutki";
            this.minutki.ReadOnly = true;
            this.minutki.Size = new System.Drawing.Size(114, 102);
            this.minutki.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(389, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 91);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zamykanie aplikacji";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sekundy
            // 
            this.sekundy.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sekundy.Location = new System.Drawing.Point(470, 159);
            this.sekundy.MaxLength = 7;
            this.sekundy.Name = "sekundy";
            this.sekundy.ReadOnly = true;
            this.sekundy.Size = new System.Drawing.Size(114, 102);
            this.sekundy.TabIndex = 8;
            // 
            // numerwozka
            // 
            this.numerwozka.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numerwozka.Location = new System.Drawing.Point(23, 159);
            this.numerwozka.MaxLength = 7;
            this.numerwozka.Name = "numerwozka";
            this.numerwozka.ReadOnly = true;
            this.numerwozka.Size = new System.Drawing.Size(196, 102);
            this.numerwozka.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numer wózka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(238, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "godziny";
            // 
            // godzina
            // 
            this.godzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.godzina.Location = new System.Drawing.Point(232, 159);
            this.godzina.MaxLength = 7;
            this.godzina.Name = "godzina";
            this.godzina.ReadOnly = true;
            this.godzina.Size = new System.Drawing.Size(114, 102);
            this.godzina.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(364, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "minuty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(474, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "sekundy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(627, 332);
            this.ControlBox = false;
            this.Controls.Add(this.numerwozka);
            this.Controls.Add(this.sekundy);
            this.Controls.Add(this.godzina);
            this.Controls.Add(this.minutki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Odliczanie";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox minutki;
        private System.Windows.Forms.TextBox sekundy;
        private System.Windows.Forms.TextBox numerwozka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox godzina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

