// -Must have compatible Arduino/Genuino; tested with Genuino UNO R3
// -Computer must be connected to arduino while in operation
// -Requires 5V relay and light (with + and - leads or jumpers)
// -Requires accompanying Arduino program

// CAUTION - Wall power is 120V or 240V. This is enough to kill you. 
// Do not touch the + and - wires together; it could start a fire or cause death.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Lightswitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            port.Open();
        }

        private void On_button_Click(object sender, EventArgs e)
        {
            port.Write("ON");
            statusIndicator.Text = "ON";
            statusIndicator.ForeColor = System.Drawing.Color.Red;
        }

        private void Off_button_Click(object sender, EventArgs e)
        {
            port.Write("OFF");
            statusIndicator.Text = "OFF";
            statusIndicator.ForeColor = System.Drawing.Color.Black;
        }
    }
}
