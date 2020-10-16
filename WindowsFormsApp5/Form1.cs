using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string position_to_be; string x,y,z; 
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
         
        }
        delegate void SetTextCallback(string text);
        private void SetText1(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Distance.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText1);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Distance.Text = text;
            }
        }

    

        private void SetText2(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Acceleration.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Acceleration.Text = text;
            }
        }

        private void SetText3(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Velocity.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText3);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Velocity.Text = text;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            
           
                x = serialPort1.ReadLine();
                y = serialPort1.ReadLine();
            z = serialPort1.ReadLine();
            if (!String.IsNullOrEmpty(x))
                   SetText1(x.ToString());
            if (!String.IsNullOrEmpty(y))
                SetText2(y.ToString());
            if (!String.IsNullOrEmpty(z))
                SetText3(z.ToString());





        }

       
        private void button1_Click(object sender, EventArgs e)
        {
          
            position_to_be = DistToBe.Text;
            serialPort1.WriteLine(position_to_be);
            
          


        }
        


    }
}

