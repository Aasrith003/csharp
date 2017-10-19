using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO.Ports;
using System.Threading;

namespace arduinoweb
{
    public class ArduinoMain
    {
        SerialPort arduino = new SerialPort("COM3", 9600);
        //defining main variables and properties
        public string error;
        public bool state;
        public string LedStatus {get;set;}
        public string BuzzerStatus { get; set; }
       
       
        //connection and diconnection
        public bool connect()
        {
            try
            {
                arduino.Open();
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            if(arduino.IsOpen == true)
            {
                state = true;
            }
            else
            {
                state = false;

            }
            return state;
        }
        public string close()
        {
            try
            {
                arduino.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }

        //led controls
        public string ledon()
        {
            try
            {
                arduino.Write("1");
            }
            catch(Exception et)
            {
                error = et.Message;
            }
            LedStatus = "led is on";
            return LedStatus;
        }
        public string ledoff()
        {
            try
            {
                arduino.Write("0");
            }
            catch (Exception et)
            {
                error = error + et.Message;
            }
            LedStatus = "led is off";
            return LedStatus;
        }
        public string ledBlink()
        {
            try
            {
                arduino.Write("5");
            }
            catch (Exception ex)
            {
                error = error + ex.Message;
            }
            LedStatus = "LED IS BLINKING";
            return LedStatus;
        }

        //buzzer controls
        public string buzzerOn()
        {
            try
            {
                arduino.Write("2");

            }
            catch(Exception ex)
            {
                if(error != null)
                {
                    error = error + ex.Message;
                }
                else
                {
                    error = ex.Message;
                }
            }
            BuzzerStatus = "buzzer is on";
            return BuzzerStatus;
        }
        public string buzzerOff()
        {
            try
            {
                arduino.Write("3");

            }
            catch (Exception ex)
            {
                if (error != null)
                {
                    error = error + ex.Message;
                }
                else
                {
                    error = ex.Message;
                }
            }
            BuzzerStatus = "buzzer is off";
            return BuzzerStatus;
        }
        public string buzzerBeep()
        {
            try
            {
                arduino.Write("4");
            }
            catch(Exception ex)
            {
                error = error + ex.Message;
            }
            BuzzerStatus = "Buzzer is beeping";
            return BuzzerStatus;
        }
        
        
     /*  public bool aarduino_status()
        {
            SerialPort read = new SerialPort("COM3", 9600);
            read.Open();
            string status = read.ReadLine();
            if(status == "1")
            {
                state = true;
            }
            else
            {
                state = false;
            }
            read.Close();
            return state;
        }*/

        
        } 
}