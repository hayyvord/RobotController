using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using RobotController;

namespace WindowsFormsApplication1
{
    public partial class Robot : Form
    {

        #region Varibles
        
        private string RobotPort = "";

        private int MotionDelay = 0;

        private int Speed = 0;
        
        ComPort myRobot = new ComPort("COM3");
       
        #endregion
  
        #region Constructor
       
        public Robot()
        {
            InitializeComponent();
            SearchForPorts();
        }
        
        #endregion
  
        #region SearchForPorts
   
        private void SearchForPorts()
        {
            cbPorts.Items.Clear();

            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();

            if (portNames.Length == 0)
            {
                cbPorts.Text = "No Ports";
                return;
            }

            foreach (string item in portNames)
            {

                cbPorts.Items.Add(item);
            }


            cbPorts.Text = cbPorts.Items[0].ToString();
        }
        
        #endregion
     
        #region Conections Buttons
     
        private void Connect_Click(object sender, EventArgs e)
        {
            this.RobotPort = cbPorts.Text;
  
            myRobot = new ComPort(this.RobotPort);
            
            myRobot.Connect();

            Connect.Enabled = false;
            Disconnect.Enabled = true;
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            myRobot.Disconnect();
            Connect.Enabled = true;
            Disconnect.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            myRobot.Reset();
        }
        
        #endregion

        #region Set Speed

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            tbSpeed.Minimum = 0;
            tbSpeed.Maximum = 255;

            if (tbSpeed.Value < 256 && tbSpeed.Value > -1)
            {
                Speed = tbSpeed.Value;
                Console.WriteLine(string.Format("Speed:{0}", Speed));
                tbStatus.AppendText(string.Format("myRobot.Set speed: {0:D3}", Speed));
                tbStatus.AppendText(Environment.NewLine);
            }
                       
            //Speed = tbSpeed.Value;
        }
       
        #endregion

        #region Motion Buttons
        
        private void Up_Click(object sender, EventArgs e)
        {
            myRobot.Up(Speed);
            Thread.Sleep(MotionDelay);
            myRobot.Stop();
            
            tbStatus.AppendText(string.Format("myRobot.Up with speed:{0:D3}", Speed));
            tbStatus.AppendText(Environment.NewLine);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            myRobot.Down(Speed);
            Thread.Sleep(MotionDelay);
            myRobot.Stop();

            tbStatus.AppendText(string.Format("myRobot.Down with speed:{0:D3}", Speed));
            tbStatus.AppendText(Environment.NewLine);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            myRobot.Left(Speed);
            Thread.Sleep(MotionDelay);
            myRobot.Stop();
          
            tbStatus.AppendText(string.Format("myRobot.Left with speed:{0:D3}", Speed));
            tbStatus.AppendText(Environment.NewLine);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            myRobot.Right(Speed);
            Thread.Sleep(MotionDelay);
            myRobot.Stop();

            tbStatus.AppendText(string.Format("myRobot.Right with speed:{0:D3}", Speed));
            tbStatus.AppendText(Environment.NewLine);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            myRobot.Stop();
            tbStatus.AppendText("myRobot.Stop");
            tbStatus.AppendText(Environment.NewLine);
        }
       
        #endregion

        #region Motion Delay 

        private void MtDelay_TextChanged(object sender, EventArgs e)
        {
            MotionDelay = Convert.ToInt32(MtDelay);
        }
       
        #endregion


    }
}
