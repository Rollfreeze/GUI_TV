using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVBut;


namespace TV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TVButtons buttons = new TVButtons();

        private void button1_Click(object sender, EventArgs e)
        {
            string check = buttons.TurnOnOff();
            if (check == "1")
                Media.close();
            else
                Media.URL = check;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string check = buttons.TurnOnOff();
            if (check == "1")
                Media.close();
            else
                Media.URL = check;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private int x = 0; private int y = 0;
      
        // Движение мышки
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }

        private void MouseDown1(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        string volume; 
        //громче
        private async void button_volumePlus(object sender, EventArgs e)
        {
            int checking = buttons.volume_change();
            if (checking == 2)
            {
                Media.settings.volume += checking;
                volume = Media.settings.volume.ToString();

                label5.Visible = true;
                label5.Text ="VOL: " + volume;
                await Task.Delay(TimeSpan.FromSeconds(3));
                label5.Visible = false;
            }
        }

        //тише
        private async void button_volumeMinus(object sender, EventArgs e)
        {
            int checking = buttons.volume_change();
            if (checking == 2)
            {
                Media.settings.volume -= checking;
                volume = Media.settings.volume.ToString();

                label5.Visible = true;
                label5.Text = "VOL: " + volume;
                await Task.Delay(TimeSpan.FromSeconds(3));
                label5.Visible = false;
            }
        }

        //mute
        private async void button11_Click(object sender, EventArgs e)
        {
            if (buttons.volume_mute() == true)
            {
                if (Media.settings.mute == false)
                {
                    Media.settings.mute = true;
                }
                else
                {
                    Media.settings.mute = false;
                }

                label5.Visible = true;

                if (Media.settings.mute == true)
                {
                    label5.Text = "mute on";
                }
                else
                {
                    label5.Text = "mute off";
                }

                await Task.Delay(TimeSpan.FromSeconds(3));

                label5.Visible = false;
            }
        }
        
        //громче
        private async void button5_Click(object sender, EventArgs e)
        {
            int checking = buttons.volume_change();
            if (checking == 2)
            {
                Media.settings.volume += checking;
                volume = Media.settings.volume.ToString();

                label5.Visible = true;
                label5.Text = "VOL: " + volume;
                await Task.Delay(TimeSpan.FromSeconds(3));
                label5.Visible = false;
            }
        }

        //тише
        private async void button6_Click(object sender, EventArgs e)
        {
            int checking = buttons.volume_change();
            if (checking == 2)
            {
                Media.settings.volume -= checking;
                volume = Media.settings.volume.ToString();

                label5.Visible = true;
                label5.Text = "VOL: " + volume;
                await Task.Delay(TimeSpan.FromSeconds(3));
                label5.Visible = false;
            }
        }

        //forward channel
        private void button9_Click(object sender, EventArgs e)
        {
            string checking = buttons.forward();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }
        
        //back channel
        private void button10_Click(object sender, EventArgs e)
        {
            string checking = buttons.back();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        //forward channel
        private void button8_Click(object sender, EventArgs e)
        {
            string checking = buttons.forward();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        //back channel
        private void button7_Click(object sender, EventArgs e)
        {
            string checking = buttons.back();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string checking = buttons.one();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string checking = buttons.two();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string checking = buttons.three();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string checking = buttons.four();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string checking = buttons.five();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string checking = buttons.six();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string checking = buttons.seven();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string checking = buttons.eight();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string checking = buttons.nine();
            if (checking == "1")
            {
                //nothing
            }
            else
            {
                Media.URL = checking;
            }
        }
    }
}

