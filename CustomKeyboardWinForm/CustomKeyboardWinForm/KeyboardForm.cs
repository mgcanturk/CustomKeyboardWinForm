using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomKeyboardWinForm
{
    public partial class KeyboardForm : Form
    {
        private bool vCaps = true;
        private bool vShift = false;
        private TextBox txt;
        public Point mouseLocation;
        public KeyboardForm(ref TextBox TextBox)
        {
            InitializeComponent();
            txt = TextBox;
        }
        private void CapsLButton_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    if (vCaps)
                    {
                        if (ctrl.Text != "BackS" && ctrl.Text != "Shift" && ctrl.Text != "Space" && ctrl.Text != "Caps" && ctrl.Text != "Clear")
                            ctrl.Text = ctrl.Text.ToUpper();
                    }
                    else
                    {
                        if (ctrl.Text != "BackS" && ctrl.Text != "Shift" && ctrl.Text != "Space" && ctrl.Text != "Caps" && ctrl.Text != "Clear")
                            ctrl.Text = ctrl.Text.ToLower();
                    }
                }
            }
            if (vCaps)
                vCaps = false;
            else
                vCaps = true;
        }
        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length <= 1)
                txt.Clear();
            else
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            vShift = true;
            ShiftButton.BackColor = Color.Green;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (vShift)
            {
                txt.Text += ((Button)sender).Text.ToUpper();
                vShift = false;
                ShiftButton.BackColor = SystemColors.Control;
            }
            else
                txt.Text += ((Button)sender).Text;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.SuppressFinalize(this);
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void CleanTextButton_Click(object sender, EventArgs e)
        {
            txt.Clear();
        }
    }
}
