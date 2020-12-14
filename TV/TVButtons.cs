using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVBut
{
	class TVButtons
	{
		private bool OnOff = false;
        private string[] channels = new string[9] { "http://serv30.vintera.tv:8081/detskiy/ryzhiy_08/playlist.m3u8", "http://62.32.67.187:1935/WEB_Smilik/Smilik.stream/playlist.m3u8", "http://songtvru.ru:8060/hd/playlist.m3u8", "http://163.172.179.78:8081/tv/eurosport-2/playlist.m3u8", "http://serv30.vintera.tv:8081/detskiy/multimania20/playlist.m3u8", "http://185.57.68.33:8091/232/tracks-v1a1/index.m3u8", "https://hls-myudm.cdnvideo.ru/myudm-live/myudm.sdp/playlist.m3u8", "http://185.22.183.150:8085/media/hls_183_150/telekafe/index.m3u8", "https://bozztv.com/36bay2/gin/giniko_arjlover_2000kb_36bay2/index.m3u8" };
		private int channel = 0;

        public string TurnOnOff()
        {
            if (OnOff == false)
                OnOff = true;
            else
                OnOff = false;

            if (OnOff == true)
                return channels[channel];
            else
                return "1";
        }

        public int volume_change()
        {
            if (OnOff == true)
            {
                return 2;
            }
            return 0;
        }

        public bool volume_mute()
        {
            if (OnOff == true)
            {
                return true;
            }
            return false;
        }

        public string forward()
        {
            if (OnOff == true)
            {
                channel++;
                if (channel > 8)
                    channel = 0;
                return channels[channel];
            }
            return "1";
        }

        public string back()
        {
            if (OnOff == true)
            {
                channel--;
                if (channel < 0)
                    channel = 8;
                return channels[channel];
            }
            return "1";
        }

        public string one()
        {
            if (OnOff == true)
            {
                channel = 0;
                return channels[channel];
            }
            return "1";
        }

        public string two()
        {
            if (OnOff == true)
            {
                channel = 1;
                return channels[channel];
            }
            return "1";
        }

        public string three()
        {
            if (OnOff == true)
            {
                channel = 2;
                return channels[channel];
            }
            return "1";
        }

        public string four()
        {
            if (OnOff == true)
            {
                channel = 3;
                return channels[channel];
            }
            return "1";
        }

        public string five()
        {
            if (OnOff == true)
            {
                channel = 4;
                return channels[channel];
            }
            return "1";
        }

        public string six()
        {
            if (OnOff == true)
            {
                channel = 5;
                return channels[channel];
            }
            return "1";
        }

        public string seven()
        {
            if (OnOff == true)
            {
                channel = 6;
                return channels[channel];
            }
            return "1";
        }

        public string eight()
        {
            if (OnOff == true)
            {
                channel = 7;
                return channels[channel];
            }
            return "1";
        }

        public string nine()
        {
            if (OnOff == true)
            {
                channel = 8;
                return channels[channel];
            }
            return "1";
        }
    }
}
