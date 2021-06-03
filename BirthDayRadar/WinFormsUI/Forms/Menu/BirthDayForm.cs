using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsUI.Forms.Rehber;
using WinFormsUI.Forms.RehberAdd;
using WinFormsUI.Forms.RehberDeleteUpdate;

namespace WinFormsUI
{
    public partial class BirthDayForm : Form
    {
        public BirthDayForm()
        {
            InitializeComponent();
        }
        private void havadurumupnl_Paint(object sender, PaintEventArgs e)
        {


        }

        private void rehberBtn_Click(object sender, EventArgs e)
        {
            RehberForm rehberForm = new RehberForm();
            rehberForm.Show();


        }

        private void panelcontext_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelfooterr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelfooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rehberAddbtn_Click(object sender, EventArgs e)
        {
            RehberAddForm rehberAddForm = new RehberAddForm();
            rehberAddForm.Show();
        }

        private void BirthDayForm_Load(object sender, EventArgs e)
        {
            timetimer.Start();

        }

        private void timetimer_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongDateString();
            timelbl.Text = DateTime.Now.ToLongTimeString();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            RehberDeleteUpdateForm rehberDeleteUpdateForm = new RehberDeleteUpdateForm();
            rehberDeleteUpdateForm.Show();
        }
    }
}
