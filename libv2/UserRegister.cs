using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libv2.Model;

namespace libv2
{
    public partial class UserRegister : Form
    {

        libraryEntities db = new libraryEntities();
        public UserRegister()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtSurname.Text == "")
            {
                MessageBox.Show("Bütün xanaları doldurmalısınız!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                if (IsValidEmail(txtEmail.Text))
                {
                    User u = new User();
                    var i = db.Users.FirstOrDefault(x => x.Phone == txtPhone.Text);
                    if (i == null)
                    {
                        u.Name = txtName.Text;
                        u.Surname = txtSurname.Text;
                        u.Phone = txtPhone.Text;
                        u.E_mail = txtEmail.Text;
                        db.Users.Add(u);
                        db.SaveChanges();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Belə bir istifadəçi bazada mövcuddur", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else {

                    MessageBox.Show("Email duzgun formatda daxil edilmeyib", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                



            }

            //if () {
            //    u.Name = txtName.Text;
            //    u.Surname = txtSurname.Text;
            //    u.Phone = txtPhone.Text;
            //    u.E_mail = txtEmail.Text;
            //    db.Users.Add(u);
            //    db.SaveChanges();
            //    this.Close();
            //} else
            //{
            //    MessageBox.Show("Belə bir istifadəçi bazada mövcuddur", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}



        }
    }
}
