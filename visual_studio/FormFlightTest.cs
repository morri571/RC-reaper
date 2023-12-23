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
using System.Threading;

namespace Reaper_flight_software
{
    public partial class FormFlightTest : System.Windows.Forms.Form
    {
        private string[] portNames;
        private bool configured = false; //is the port configured with properties?
        private bool throttleOnOff = false; //is the throttle on or off?
        private bool readyToSend = true; //is the arduino ready to receive data from the app?
        private int PWM = 0;
        private SerialPort arduinoPort = new SerialPort();
        private string arduinoThrottle = null;

        private string throttleBuffer = null;
        const string DELIMITER = "_";

        public FormFlightTest()
        {
            InitializeComponent();
            arduinoPort.DataReceived += ArduinoPort_DataReceived;
        }

        #region events

        private void Form_Load(object sender, EventArgs e)
        {
            portNames = SerialPort.GetPortNames(); //get all available port names
            foreach (string port in portNames)
            {
                comboBoxPortNames.Items.Add(port); //create list of found ports
            }

            comboBoxBaudRate.SelectedIndex = 0; //select default configuration
            comboBoxPortNames.SelectedIndex = 0;
            comboBoxParityBits.SelectedIndex = 0;
            comboBoxDataBits.SelectedIndex = 3;
            comboBoxStopBits.SelectedIndex = 1;
        }

        private void buttonConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                arduinoPort.PortName = comboBoxPortNames.Text; //try to open and configure ports from values selected from dropdown
                arduinoPort.BaudRate = Int32.Parse(comboBoxBaudRate.Text);
                arduinoPort.Parity = (Parity)comboBoxParityBits.SelectedIndex;
                arduinoPort.DataBits = Int32.Parse(comboBoxDataBits.Text);
                arduinoPort.StopBits = (StopBits)comboBoxStopBits.SelectedIndex;

                arduinoPort.Open();

                configured = true; //port is open and ready to transmit
            }

            catch 
            {
                MessageBox.Show("Configuration Invalid or Port Not Open");

                configured = false; //port is closed and not ready to transmit
            }
        }

        private void throttleTrackBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(throttleOnOff == true) //if the throttle is enabled
            {
                if (e.KeyChar == 'w' && throttleTrackBar.Value < throttleTrackBar.Maximum) //'w' is keyup for throttle
                {
                    throttleTrackBar.Value += 1;
                }
                else if (e.KeyChar == 's' && throttleTrackBar.Value > throttleTrackBar.Minimum) //'s' is keydown for throttle
                {
                    throttleTrackBar.Value -= 1;
                }
            }
        }

        private void throttleTrackBar_ValueChanged(object sender, EventArgs e)
        {

            if (configured == true && readyToSend == true)
            {
                readyToSend = false; //ready to send only true after confirmation from arduino, default to true for first message sent

                calcPWM(throttleTrackBar.Value);

                throttleBuffer = "-1" + DELIMITER // -1_x_256 is the buffer, where -1 denotes start and 256 denotes end
                + PWM.ToString() + DELIMITER
                + "256" + "\n";

                write(throttleBuffer); //send buffer to arduino
                textBoxMessageSent.Text = throttleBuffer; //show message sent
            }
        }

        private void checkBoxPower_CheckedChanged(object sender, EventArgs e)
        {
            throttleOnOff = checkBoxPower.Checked ? true : false; //turn throttle on or off
            checkBoxPower.BackColor = checkBoxPower.Checked ? Color.Lime : Color.Red; //change color based on on or off

            throttleControl(throttleOnOff);
        }

        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            if (arduinoPort.IsOpen == true) //if the port is not open, don't do anything
            {
                write("-1_1000_256\n"); //TURN OFF THROTTLE BEFORE DOING ANYTHING ELSE
                checkBoxPower.Checked = false; //disable throttle
                arduinoPort.Close(); //close port
                configured = false; //unconfigured
            }
        }

        private void ArduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            arduinoThrottle = arduinoPort.ReadExisting(); //get message from arduino
            //textBoxMessageReceived.Text = arduinoThrottle; //display received message CROSSTHREADING NEEDS DEBUGGING
            readyToSend = true; //confirmation from arduino
        }

        #endregion events

        private void write(string data)
        {
            if(configured == true) //makes sure port is open
            {
                arduinoPort.Write(data); //send data to arduino
            }
        }

        private void read(string data)
        {

        }

        private void throttleControl(bool throttleOnOff)
        {
            if (throttleOnOff == false) //if throttle is off
            {
                write("-1_1000_256\n"); //send signal to arduino to turn off
                throttleTrackBar.Enabled = false; //do not allow further input
            }
            else
            {
                throttleTrackBar.Enabled = true; //allow input
            }
        }

        private void calcPWM(int RPM)
        {
            PWM = (int)Math.Round(Math.Pow(RPM,4) * 2.61 * Math.Pow(10,-12) 
            - Math.Pow(RPM,3) * 6.2211 * Math.Pow(10,-8) 
            + Math.Pow(RPM,2) * 5.3929 * Math.Pow(10,-4) 
            - RPM * 1.972 + 3.6644 * Math.Pow(10,3));
        }
    }
}
