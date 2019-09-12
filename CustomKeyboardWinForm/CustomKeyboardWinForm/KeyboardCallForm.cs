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
    public partial class KeyboardCallForm : Form
    {
        public KeyboardCallForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            KeyboardForm keyboardForm = new KeyboardForm(ref textBox);
            keyboardForm.ShowDialog();
        }
    }
}
