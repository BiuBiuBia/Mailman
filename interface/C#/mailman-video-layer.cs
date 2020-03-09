using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailman_video_layer
{
    public partial class Form1 : Form
    {
        static public void decompose()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = @"http://localhost:9123/video/decompose?workplace=C:/Workplace&imagePrefix=tmp&videoName=output.mp4";
            p.Start();
        }
        static public void compose()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = @"http://localhost:9123/video/compose?fps=10&numOfPictures=100&workplace=C:/Workplace&imagePrefix=tmp&deleteImages=false";
            p.Start();
        }
        public Form1()
        {
            decompose();
            compose();
            InitializeComponent();
        }

    }
}
