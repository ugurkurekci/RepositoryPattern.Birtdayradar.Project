using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI.Forms.RehberAdd.AddErrorIcon
{
    public partial class AddErrorIcon : Form
    {
        public AddErrorIcon()
        {
            InitializeComponent();
        }

        private void pictureboxadderror_Click(object sender, EventArgs e)
        {
            AddErrorIcon.ActiveForm.Close();
        }
    }
}
