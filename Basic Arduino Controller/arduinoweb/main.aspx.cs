using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace arduinoweb
{
    public partial class main : System.Web.UI.Page
    {
        ArduinoMain Main = new ArduinoMain();
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }    
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Main.connect();
            Main.ledon();
            LedState.Text = Main.LedStatus;
            Main.close();
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Main.connect();
            Main.ledoff();
            LedState.Text = Main.LedStatus;
            Main.close();
            
        }

        protected void BuzzerOn_Click(object sender, EventArgs e)
        {
            Main.connect();
            Main.buzzerOn();
            buzzerState.Text = Main.BuzzerStatus;
            Main.close();
        }

        protected void BuzzerOff_Click(object sender, EventArgs e)
        {
            Main.connect();
            Main.buzzerOff();
            buzzerState.Text = Main.BuzzerStatus;
            Main.close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Main.connect();
            Main.buzzerBeep();
            buzzerState.Text = Main.BuzzerStatus;
            Main.close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Main.connect();
            Main.ledBlink();
            LedState.Text = Main.LedStatus;
            Main.close();
        }
    }
}