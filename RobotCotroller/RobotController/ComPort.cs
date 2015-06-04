using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;



namespace WindowsFormsApplication1
{
    class ComPort
    {
        #region Varibles
        
        public SerialPort RobotPort;
       
        private bool isConnected = false;

        private string PortName = String.Empty;

        #endregion

        #region ComPort Name

        public ComPort(string ComPortName)
        {
            this.PortName = ComPortName;
        }
        
        #endregion

        #region ComPort Connect

        public void Connect()
        {
              try
              {
                    if (!isConnected)
                    {
                        RobotPort = new SerialPort();
                        RobotPort.PortName = PortName;
                        RobotPort.BaudRate = 9600;
                        RobotPort.DataBits = 8;
                        RobotPort.StopBits = StopBits.One;
                        RobotPort.Parity = Parity.None;
                        RobotPort.Open();

                        isConnected = true;
                    }
                }
                catch 
                {
                    isConnected = false;
                    Thread.Sleep(3000);
                    Connect();
                }
        }
     
        #endregion
        
        #region ComPort Disconnect
        
        public void Disconnect()
        {
            if (isConnected)
            {
                RobotPort.Close();
            }
            
            isConnected = false;
        }
     
        #endregion

        #region Robot Reset
        
        public void Reset()
        {
            if (isConnected)
            {
                RobotPort.DtrEnable = true;
                Thread.Sleep(200);
                RobotPort.DtrEnable = false;
            }
        }
       
        #endregion

        #region Make Move

        public void Up(int Speed)
        {
            string direction = "";

            direction = MotionCommnads.Up;
            string command = String.Format("?{0}{1:D3}", direction, Speed);
            SendCommands(command);
        }

        public void Down(int Speed)
        {
            string direction = "";

            direction = MotionCommnads.Down;
            string command = String.Format("?{0}{1:D3}", direction, Speed);
            SendCommands(command);
        }

        public void Left(int Speed)
        {
            string direction = "";

            direction = MotionCommnads.Left;
            string command = String.Format("?{0}{1:D3}", direction, Speed);
            SendCommands(command);
        }

        public void Right(int Speed)
        {
            string direction = "";

            direction = MotionCommnads.Right;
            string command = String.Format("?{0}{1:D3}", direction, Speed);
            SendCommands(command);
        }

        public void Stop()
        {
            string direction = "";
            int Speed = 0;

            direction = MotionCommnads.Stop;
            string command = String.Format("?{0}{1:D3}", direction, Speed);
            SendCommands(command);
        }

        #endregion

        #region SendCommands

        public void SendCommands(string Command)
        {
            try
            {
               if (isConnected)
               {
                Console.WriteLine(string.Format("Command:{0}", Command));
                RobotPort.WriteLine(Command);
               }
            }
            catch
            {
                isConnected = false;
                Thread.Sleep(3000);
                Connect();
            }
        }

        #endregion

    }
}
