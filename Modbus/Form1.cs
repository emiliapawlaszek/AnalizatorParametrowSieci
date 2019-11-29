using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus
{
    public partial class Form1 : Form
    {
        bool odswiezaj = true;
        TcpClient polaczenie = new TcpClient();
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
      
        }
       
        public void odswiezanie() { 
            while (odswiezaj)
            {
        
                byte[] request = { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x10, 0x02, 0x00, 0x02 };
                stream.Write(request, 0, request.Length);
                byte[] answer = new byte[100];
                stream.Read(answer, 0, answer.Length);
                byte[] cutAnswer = new byte[4];
                Array.ConstrainedCopy(answer, 9, cutAnswer, 0, 4);
                Array.Reverse(cutAnswer);
                int voltageL1 = BitConverter.ToInt32(cutAnswer, 0);
                napiecieBox.Text = (voltageL1 / 1000.0F).ToString();

                //natezenie
                byte[] request2 = { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x10, 0x10, 0x00, 0x02 };
                stream.Write(request2, 0, request.Length);
                answer = new byte[100];
                stream.Read(answer, 0, answer.Length);
                cutAnswer = new byte[4];
                Array.ConstrainedCopy(answer, 9, cutAnswer, 0, 4);
                Array.Reverse(cutAnswer);
                int currentL1 = BitConverter.ToInt32(cutAnswer, 0);
                natezenieBox.Text = (currentL1 / 1000.0F).ToString();

                Refresh();
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                
                System.Diagnostics.Debug.WriteLine("Łącze się...");
                    polaczenie.Connect(adresIP.Text,Int32.Parse(portBox.Text));
                    stream = polaczenie.GetStream();
                    polaczonoLabel.Text = "POŁĄCZONO";
                    polaczonoLabel.ForeColor = Color.Green;
                    button1.Visible = false;
                    panel2.Visible = true;
                    adresIP.Enabled = false;
                portBox.Enabled = false;
                tresbledu.Visible = false;
                    odswiezanie();
            
                }
                catch (SocketException)
                {
             
                    string komunikat = "Brak polaczenia. Sprawdź IP lub port!";
                    Console.WriteLine(komunikat);

                    tresbledu.Text = komunikat;
                    tresbledu.ForeColor = Color.Red;
                    tresbledu.Visible = true;
                    adresIP.Text = "";
                    portBox.Text = "";
              
                }
            catch (FormatException)
            {

                string komunikat = "Brak polaczenia. Sprawdź IP lub port!";
                Console.WriteLine(komunikat);

                tresbledu.Text = komunikat;
                tresbledu.ForeColor = Color.Red;
                tresbledu.Visible = true;
                adresIP.Text = "";
                portBox.Text = "";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tresbledu_Click(object sender, EventArgs e)
        {

        }
    }
}
