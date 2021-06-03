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
using WinFormsUI.Forms.Rehber;
using WinFormsUI.Forms.RehberAdd.AddErrorIcon;
using WinFormsUI.Forms.RehberAdd.AddIcon;

namespace WinFormsUI.Forms.RehberDeleteUpdate
{
    public partial class RehberDeleteUpdateForm : Form
    {
        public RehberDeleteUpdateForm()
        {
            InitializeComponent();
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            BirthDayManager birthDayManager = new BirthDayManager(new EfBirthDayDal());
            var result = birthDayManager.Delete(new BirthDayRadar
            {
                Id = Convert.ToInt32(Notxb.Text)

            });


            if (result.Success)
            {

                duyurulbl.Text = "Başarılı Şekilde Kaydedildi";
                duyurulbl.ForeColor = Color.Green;

                AddIconForm addIconForm = new AddIconForm();
                addIconForm.Show();


            }
            else
            {
                duyurulbl.Text = "Hata oldu, kontrol edin veya yetkili çağırın.";
                duyurulbl.ForeColor = Color.Red;
                AddErrorIcon addErrorIcon = new AddErrorIcon();
                addErrorIcon.Show();
            }
           
        }

    }
}
