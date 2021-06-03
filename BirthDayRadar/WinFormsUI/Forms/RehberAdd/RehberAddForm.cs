using Business.Concrete;
using DataAccess.Concrete.BirthDayDbContext;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI.Forms.RehberAdd
{
    public partial class RehberAddForm : Form
    {
        public RehberAddForm()
        {
            InitializeComponent();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nametxb_TextChanged(object sender, EventArgs e)
        {

            if (Nametxb.Text.Length > 0)
            {
                panelcizgi1.BackColor = Color.Green;
                Namelbl.ForeColor = Color.Green;

            }
            else
            {
                panelcizgi1.BackColor = Color.Red;
                Namelbl.ForeColor = Color.Black;
                MessageBox.Show("Boş geçilemez.");
            }
        }

        private void Nametxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void oldagecbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datepicker.Text.Length > 0)
            {
                panelcizgi5.BackColor = Color.Green;
                oldagelbl.ForeColor = Color.Green;

            }
            else
            {
                panelcizgi5.BackColor = Color.Red;
                oldagelbl.ForeColor = Color.Black;
                MessageBox.Show("Boş geçilemez.");
            }
        }

        private void RehberAddForm_Load(object sender, EventArgs e)
        {


            for (int number = 1; number < 101; number++)
            {

                newagecbbx.Items.Add(number);

            }
        }

        private void Surnametxb_TextChanged(object sender, EventArgs e)
        {
            if (Surnametxb.Text.Length > 0)
            {
                panelcizgi2.BackColor = Color.Green;
                Surnamelbl.ForeColor = Color.Green;

            }
            else
            {
                panelcizgi2.BackColor = Color.Red;
                Surnamelbl.ForeColor = Color.Black;
                MessageBox.Show("Boş geçilemez.");
            }
        }

        private void jobtxb_TextChanged(object sender, EventArgs e)
        {
            if (jobtxb.Text.Length > 0)
            {
                panelcizgi3.BackColor = Color.Green;
                Joblbl.ForeColor = Color.Green;

            }
            else
            {
                panelcizgi3.BackColor = Color.Red;
                Joblbl.ForeColor = Color.Black;
                MessageBox.Show("Boş geçilemez.");
            }
        }

        private void telephonetxb_TextChanged(object sender, EventArgs e)
        {
            if (telephonetxb.Text.Length > 0)
            {
                panelcizgi4.BackColor = Color.Green;
                telephonelbl.ForeColor = Color.Green;

            }
            else
            {
                panelcizgi4.BackColor = Color.Red;
                telephonelbl.ForeColor = Color.Black;
                MessageBox.Show("Boş geçilemez.");
            }
        }

        private void newagecbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newagecbbx.Text.Length > 0)
            {
                panelcizgi6.BackColor = Color.Green;
                newagelbl.ForeColor = Color.Green;

            }
            else
            {
                panelcizgi6.BackColor = Color.Red;
                newagelbl.ForeColor = Color.Black;
                MessageBox.Show("Boş geçilemez.");
            }
        }

        private void notertxb_TextChanged(object sender, EventArgs e)
        {
            if (notertxb.Text.Length > 0)
            {
                panelcizgi7.BackColor = Color.Green;
                Notelbl.ForeColor = Color.Green;

            }
            else
            {
                panelcizgi7.BackColor = Color.Red;
                Notelbl.ForeColor = Color.Black;
                MessageBox.Show("Boş geçilemez.");
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            BirthDayManager birthDayManager = new BirthDayManager(new EfBirthDayDal());
            var result = birthDayManager.Add(new BirthDayRadar
            {
                Name = Nametxb.Text,
                Surname = Surnametxb.Text,
                Job = jobtxb.Text,
                Telephone = telephonetxb.Text,
                Note = notertxb.Text,
                Date = datepicker.Value.Date,
                NewAge = Convert.ToInt32(newagecbbx.Text),
            });
            if (result.Success)
            {
                duyurulbl.Text = "Başarılı Şekilde Kaydedildi";
                duyurulbl.ForeColor = Color.Green;

                AddIcon.AddIconForm addIconForm = new AddIcon.AddIconForm();
                addIconForm.Show();

            }
            else
            {
                duyurulbl.Text = "Hata oldu, kontrol edin veya yetkili çağırın.";
                duyurulbl.ForeColor = Color.Red;
                AddErrorIcon.AddErrorIcon addErrorIcon = new AddErrorIcon.AddErrorIcon();
                addErrorIcon.Show();
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }

            }
        }
    }
}
