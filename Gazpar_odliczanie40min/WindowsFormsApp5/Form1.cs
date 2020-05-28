using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EasyModbus;
using System.IO.Ports;
using System.Threading;
using WiringPi;


namespace WindowsFormsApp5
{


    public partial class Form1 : Form
    {
        const int przekaznik = 15;


        struct wozki
        {
            public string numer;
            public DateTime data_start;
            public DateTime data_koniec;
            public string czas;
            public bool flaga;
        }
        wozki[] arr = new wozki[10000];



        // this will prevent cross-threading between the serial port
        // received data thread & the display of that data on the central thread
        private delegate void preventCrossThreading(string x);
        private preventCrossThreading accessControlFromCentralThread;

        public Form1()
        {
            InitializeComponent();
            inicjalizacja();
           // tworzeniepliku();
            odczytywanko();
            textBox2.Select();
            textBox2.KeyDown += textBox2_KeyDown;
             textBox2.PreviewKeyDown += textBox2_PreviewKeyDown;
            Application.ApplicationExit += new EventHandler(OnApplicationExit);


            textBox2.AcceptsTab = true;

          //  for (int i = 0; i < 20; i++)
          //  {
          //      arr[i].data_koniec = DateTime.Now;
           //     arr[i].data_start = DateTime.MaxValue;
           //     arr[i].czas = "0";
          //     arr[i].flaga = false;
          //  }


        }

        public static void OnApplicationExit(object sender, EventArgs e)
        {

            GPIO.pinMode(przekaznik, (int)GPIO.GPIOpinmode.Output);
            GPIO.digitalWrite(przekaznik, (int)GPIO.GPIOpinvalue.Low);


        }

        static void inicjalizacja()
        {

            //Place the LED on GPIO 5 (Physical Pin 29)



            // Tell the user that we are attempting to start the GPIO
            Console.WriteLine("Initializing GPIO Interface");

            // The WiringPiSetup method is static and returns either true or false
            // Any value less than 0 represents a failure

            if (Init.WiringPiSetupPhys() >= 0)


            //ensures that it initializes the GPIO interface and reports ready to work. We will use Physical Pin Numbers
            if(true)
            {
                // Tell the Pi that we will send data out the GPIO
                GPIO.pinMode(przekaznik, (int)GPIO.GPIOpinmode.Output);

                //Ensure that the LED is OFF
                //Remember the supply is 3.3V(high) therefore: High-High=0 --> LED is OFF
                GPIO.digitalWrite(przekaznik, (int)GPIO.GPIOpinvalue.Low);

                // Tell the user that GPIO Initialization Completed successfully
                Console.WriteLine("GPIO Initialization Complete");
            }
            else
            {
                //Tell the user that GPIO Interface did not initialize
                Console.WriteLine("GPIO Initialization Failed!");
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            //    int errorcode = 0;
            //    port.Close();
            //Application.Restart();
            textBox2.Clear();
            minutki.Clear();

            //label1.Text = "Zeskanuj barcode";

            //     Environment.Exit(errorcode);
            textBox2.ReadOnly = false;
            textBox2.Select();


            for (int i = 0; i < 20; i++)
            {
                arr[i].data_koniec = DateTime.Now;
                arr[i].data_start = DateTime.MaxValue;
                arr[i].czas = "0";
                arr[i].flaga = false;

            }
            //GPIO.digitalWrite(przekaznik, (int)GPIO.GPIOpinvalue.Low);
            //Application.Exit();
            System.Environment.Exit(0);
            // GPIO.digitalWrite(przekaznik, (int)GPIO.GPIOpinvalue.Low);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 2)
                textBox2.Clear();


        }


        private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Determine whether the key entered is the F1 key. If it is, display Help.
            if (e.KeyCode == Keys.Enter)
            {
                int licznik;
                string kupa;
                kupa = textBox2.Text;
                tworzeniepliku();
                //numerwozka.Text = kupa;
                textBox2.Clear();

                if (int.TryParse(kupa, out licznik))
                {
                    if (arr[licznik].flaga == false)
                    {
                        arr[licznik].flaga = true;
                        wejscie(licznik);

                    }
                }
                // Display a pop-up Help topic to assist the user.
                //  Help.ShowPopup(textBox2, "Enter your name.", new Point(textBox2.Bottom, textBox2.Right));
            }
            if (e.KeyCode == Keys.Tab)
            {

                string pomocnicza;
                //MessageBox.Show("Tab");
                pomocnicza = textBox2.Text;
                numerwozka.Text = pomocnicza;
                textBox2.Clear();
                odliczanko(pomocnicza);

                // odliczanko(textBox2.Text);
                // textBox2.Clear();
                // Display a pop-up Help topic to provide additional assistance to the user.
                // Help.ShowPopup(textBox2, "Enter your first name followed by your last name. Middle name is optional.",
                //    new Point(textBox2.Top, this.textBox2.Left));
            }
        }
           private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
           {
              if (e.KeyData == Keys.Tab)
              {



                   e.IsInputKey = true;
               }
               if (e.KeyData == (Keys.Tab | Keys.Shift))
               {
                    //MessageBox.Show("Shift + Tab");
                   e.IsInputKey = true;
               }
           }

        private void wejscie(int licznik)
        {
            // int licznik;
            // if (int.TryParse(sn, out licznik))
            //  {
            // arr[licznik].numer = licznik;
            arr[licznik].data_start = DateTime.Now;
            arr[licznik].flaga = true;
            tworzeniepliku();

            //MessageBox.Show("data startu dla:{0}", arr[licznik].numer);

            //  }
            //   else;//nie wiem co
        }

        private void odliczanko(string sn)
        {

            int licznik, minutki;
            float minutkif;

            if (int.TryParse(sn, out licznik))
            {
                // GPIO.digitalWrite(przekaznik, (int)GPIO.GPIOpinvalue.High);
                do
                {
                    //MessageBox.Show("zaczynam");
                    arr[licznik].data_koniec = DateTime.Now;
                    TimeSpan result = arr[licznik].data_koniec - arr[licznik].data_start;



                    string Minutystring = result.TotalMinutes.ToString();

                    string godiznkiwysietlanie = result.Hours.ToString();
                    string minutkiwysietlanie = result.Minutes.ToString();
                    string sekundystring = result.Seconds.ToString();
                    float.TryParse(Minutystring, out minutkif);
                    minutki = (int)minutkif;

                    if (minutki < 0)
                        arr[licznik].data_start = DateTime.Now;
                    //  MessageBox.Show("bufor to:", minutkif);
                    // MessageBox.Show("bufor to:", Minutystring);
                    //  MessageBox.Show("inutki");
                    //RCVbox.Clear();
                    // Application.DoEvents(); //służy do obsługi zdarzeń poza pętlą (zmienia wartość label1 i obsługa przycisków)
                    //Thread.Sleep(500);
                    // odliczanko(sn);
                    this.godzina.Text = godiznkiwysietlanie;
                    this.minutki.Text = minutkiwysietlanie;
                    this.sekundy.Text = sekundystring;
                    numerwozka.Text = sn;

                    //Thread.Sleep(250);

                    //RCVbox.Clear();
                    if (minutki < 40)
                    {
                        Application.DoEvents();
                        this.BackColor = Color.Red;
                        GPIO.digitalWrite(przekaznik, (int)GPIO.GPIOpinvalue.High);
                    }
                    else
                        this.BackColor = Color.Green;
                } while (minutki < 40);


                if (minutki >= 40)
                {
                    // port.Write("OK\r");
                    GPIO.digitalWrite(przekaznik, (int)GPIO.GPIOpinvalue.Low);


                    // arr[licznik].data_koniec = arr[licznik].data_start = DateTime.MinValue;
                }
                else
                {
                    GPIO.digitalWrite(przekaznik, (int)GPIO.GPIOpinvalue.High);

                }
                arr[licznik].flaga = false;
                tworzeniepliku();

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void tworzeniepliku()
        {
            string sciezka = ("/home/pi/Myapp");      //definiowanieścieżki do której zapisywane logi

           if (Directory.Exists(sciezka))       //sprawdzanie czy  istnieje
           {
               ;
            }
            else
                System.IO.Directory.CreateDirectory(sciezka); //jeśli nie to ją tworzy

            using (StreamWriter sw = new StreamWriter("/home/pi/Myapp/" + "zapis.txt"))
            {
                for (int i = 0; i < 20; i++)
                {

                    //sw.WriteLine("licznik:{0},start:{1},flaga:{2}",i,arr[i].data_start, arr[i].flaga);
                    sw.WriteLine(arr[i].data_start);
                    sw.WriteLine(arr[i].flaga);



                }
                sw.Close();
            }
            
        }


        private void odczytywanko()
        {
            string sciezka = ("/home/pi/Myapp/" + "zapis.txt");

            using (StreamReader sr = new StreamReader(sciezka))
            {
                int i = 0;
                while (sr.Peek() >= 0)
                {
                    
                    arr[i].data_start = Convert.ToDateTime(sr.ReadLine());
                    arr[i].flaga = bool.Parse(sr.ReadLine());

                    i++;
                    //sw.WriteLine(arr[i].flaga);




                }
                sr.Close();
            }
        }



    }
}
