using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors.Views
{
    public partial class Form_Win : Form
    {
        public Form_Win()
        {
            InitializeComponent();
        }

        private async void Form_Win_Shown(object sender, EventArgs e)
        {
            await Task.Delay(TimeSpan.FromSeconds(6), default(CancellationToken));
            this.Close();
        }


    }
}
