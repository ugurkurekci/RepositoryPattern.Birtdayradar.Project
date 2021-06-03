using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.BirthDayDbContext;
using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsUI.Forms.RehberDeleteUpdate;

namespace WinFormsUI.Forms.Rehber
{
    public partial class RehberForm : Form
    {
        BirthDayManager birthDayManager = new BirthDayManager(new EfBirthDayDal());
        public RehberForm()
        {
            InitializeComponent();
        }



        private void RehberForm_Load(object sender, EventArgs e)
        {

            getall();
        }

        private void secilibtn_Click(object sender, EventArgs e)
        {
            RehberDeleteUpdateForm rehberDeleteUpdateForm = new RehberDeleteUpdateForm();
            rehberDeleteUpdateForm.Notxb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            rehberDeleteUpdateForm.Nametxb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            rehberDeleteUpdateForm.Surnametxb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            rehberDeleteUpdateForm.jobtxb.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            rehberDeleteUpdateForm.telephonetxb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rehberDeleteUpdateForm.datetxb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rehberDeleteUpdateForm.newagetxb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            rehberDeleteUpdateForm.notertxb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            rehberDeleteUpdateForm.Show();

            
        }


        public void getall()
        {
            dataGridView1.DataSource = birthDayManager.GetAll().Data;
            countlbl.Text = dataGridView1.Rows.Count.ToString();
        }

        private void yenilepctrbx_Click(object sender, EventArgs e)
        {
            yenilepctrbx.BackColor = Color.Green;
            getall();
            MessageBox.Show(Messages.f5);
        }
    }
}
