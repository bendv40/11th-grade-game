using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pbl_game_ben_adar
{
    public partial class Form5 : Form
    {
       
        public Form5()
        {
            InitializeComponent();
           
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            maneger.f.Close();
        }
    }
}
