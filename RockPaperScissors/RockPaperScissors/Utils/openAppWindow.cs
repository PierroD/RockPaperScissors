using RockPaperScissors.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


class openAppWindow
{

    public static void OpenWindow(Control parentForm, Form openForm)
    {
        Form formBackground = new Form();

        formBackground.StartPosition = FormStartPosition.Manual;
        formBackground.FormBorderStyle = FormBorderStyle.None;
        formBackground.Opacity = 0.70d;
        formBackground.BackColor = Color.Black;
        formBackground.WindowState = FormWindowState.Normal;
        formBackground.Size = parentForm.Size;
        //formBackground.TopMost = true;
        formBackground.Location = parentForm.Location;
        formBackground.ShowInTaskbar = false;
        formBackground.Show();


        openForm.Owner = formBackground;
        openForm.StartPosition = FormStartPosition.Manual;
        openForm.TopMost = true;
        openForm.Location = new Point(parentForm.Location.X + (parentForm.Width - openForm.Width) / 2, parentForm.Location.Y + (parentForm.Height - openForm.Height) / 2);

        openForm.ShowDialog();
        formBackground.Dispose();

    }
}
