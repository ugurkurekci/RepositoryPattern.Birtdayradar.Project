﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI.Forms.RehberAdd.AddIcon
{
    public partial class AddIconForm : Form
    {
        public AddIconForm()
        {
            InitializeComponent();
        }

        private void pictureboxadd_Click(object sender, EventArgs e)
        {
            AddIconForm.ActiveForm.Close();
        }
    }
}
