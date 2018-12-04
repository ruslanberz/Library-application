using System;
using libv2.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace libv2
{
    public partial class Form1 : Form
    {
        libraryEntities db = new libraryEntities();
        List<int> potentialBook = new List<int>();

        public Form1()
        {
            InitializeComponent();
            FillBookNames();
            FillUserCombo();
            FillCreditUser();
        }

        private void FillBookNames() {

            //foreach (Book item in db.Books.ToList())
            //{
            //    ChkL.Items.Add(item.BookName +" Mərtəbə:"+item.Shelf.Floor.FloorName+" Rəf: "+item.Shelf.ShelfName+" Polka:" +item.Row +" Qiymət:"+item.Price.ToString("0.##.##"));
            //}
        }

#region Fill

        private void txtBookNameSearch_TextChanged(object sender, EventArgs e)
        {
            DgvSearch.Rows.Clear();
            string search = txtBookNameSearch.Text;
            foreach (Book item in db.Books.ToList())
            {
                if (item.BookName.ToLower().Contains(search.ToLower())&&!potentialBook.Contains(item.BookId)) {

                    DgvSearch.Rows.Add(item.BookId,
                                       item.BookName,
                                       item.Shelf.Floor.FloorName,
                                       item.Shelf.ShelfName,
                                       item.Row,
                                       item.Price.ToString("0.##.##"),
                                       item.IsAvailable == false ? "Kitab əldədir" : "Var"
                                       );

                }
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
           
                int id = DgvSearch.CurrentCell.RowIndex;
                int bookId = Convert.ToInt32(DgvSearch.Rows[id].Cells[0].Value.ToString());
                potentialBook.Add(bookId);
                Book add = new Book();
                add = db.Books.FirstOrDefault(x => x.BookId == bookId);
                if (add.IsAvailable == false)
                {
                    MessageBox.Show("Bu kitab artiq eldedir", "Fatal of FATAL Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ChkL.Items.Add(add.BookId + ". " + add.BookName + " Mərtəbə:" + add.Shelf.Floor.FloorName + " Rəf: " + add.Shelf.ShelfName + " Polka:" + add.Row + " Qiymət:" + add.Price.ToString("0.##.##"));
                    DgvSearch.Rows.RemoveAt(id);
                }



            
        }

        public void FillUserCombo() {

            foreach (User item in db.Users.ToList())
            {
                cmbUserList.Items.Add(item.Name + " " + item.Surname + " " + item.Phone);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserRegister f = new UserRegister();
            f.Show();
        }

        private void cmbUserList_Click(object sender, EventArgs e)
        {
            cmbUserList.Items.Clear();
            FillUserCombo();
        }

        private void btnBookConfirm_Click(object sender, EventArgs e)
        {
            if (ChkL.Items.Count > 0)
            {
                int CheckedCount = 0;
                if (cmbUserList.Text == "")
                {
                    MessageBox.Show("Istifadecini mutleq secmelisiniz", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Order o = new Order();
                string cmbString = cmbUserList.Text;
                string PhoneNumber = cmbString.Split(' ')[2];
                int userId = db.Users.FirstOrDefault(x => x.Phone == PhoneNumber).UserId;


                for (int i = 0; i < ChkL.Items.Count; i++)
                {

                    if (ChkL.GetItemChecked(i))
                    {
                        CheckedCount++;


                    }


                }

                if (CheckedCount > 0)
                {
                    o.UserID = userId;
                    o.BookDate = DateTime.Now;
                    o.isReturned = false;
                    db.Orders.Add(o);
                    db.SaveChanges();

                    for (int i = 0; i < ChkL.Items.Count; i++)
                    {

                        if (ChkL.GetItemChecked(i))
                        {
                            OrderItem oi = new OrderItem();
                            oi.OrderID = o.OrderId;
                            int bookId = Convert.ToInt32(ChkL.Items[i].ToString().Split('.')[0]);
                            oi.BookID = bookId;
                            oi.Price = db.Books.FirstOrDefault(x => x.BookId == bookId).Price;
                            Book fixBoook = new Book();
                            fixBoook = db.Books.FirstOrDefault(b => b.BookId == bookId);
                            fixBoook.IsAvailable = false;
                            db.OrderItems.Add(oi);
                            db.SaveChanges();


                        }


                    }

                }

                MessageBox.Show("Təsdiq uğurla olundu", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvSearch.Rows.Clear();
                FillBookNames();
                ChkL.Items.Clear();
                cmbUserList.Text = "";
                potentialBook.Clear();
                cmbCreditUsers.Text = "";
                cmbCreditUsers.Items.Clear();
                FillCreditUser();
            }
            else
            {
                MessageBox.Show("Heç bir kitab seçməmisiniz!", "The most fatal error ever!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion


        #region Search
        private void FillCreditUser()

        {
            foreach (Order item in db.Orders.ToList())
            {
                if (item.isReturned == false) {

                    cmbCreditUsers.Items.Add(item.User.Name+" "+item.User.Surname+" "+item.User.Phone);
                }
            }

        }
        #endregion

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            DgvCredit.Rows.Clear();
            if (cmbCreditUsers.Text == "")
            {
                MessageBox.Show("İstifadəçi mütləq seçilməlidir", "FATALITY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string cmbString = cmbCreditUsers.Text;
                string PhoneNumber = cmbString.Split(' ')[2];
                int userId = db.Users.FirstOrDefault(x => x.Phone == PhoneNumber).UserId;



                foreach (OrderItem item in db.OrderItems.ToList())
                {
                    if (item.Order.UserID == userId&&item.Order.isReturned==false)
                    {
                        DateTime date = new DateTime();
                        date = item.Order.BookDate;
                        date = date.AddDays(30);
                        DgvCredit.Rows.Add(item.Order.UserID,
                                           item.Order.User.Name,
                                           item.Order.User.Surname,
                                           item.Order.User.Phone,
                                           item.Book.BookName,
                                           date.ToString("dd-MM-yyyy"),
                                           item.Price);


                    }


                }


            }

        }

        private void btnSeachDate_Click(object sender, EventArgs e)
        {
            DgvCredit.Rows.Clear();
       
            DateTime searchTime = new DateTime();
            searchTime = DtpCredit.Value;
            double incrementDays = Convert.ToDouble( txtIncrement.Text);
            searchTime = searchTime.AddDays(incrementDays);
            foreach (OrderItem item in db.OrderItems.ToList())
            {    
                 DateTime date = new DateTime();
                    date = item.Order.BookDate;
                    date = date.AddDays(30);
                if (date.Date==searchTime.Date&&item.Order.isReturned==false)
                {
                   
                    DgvCredit.Rows.Add(item.Order.UserID,
                                       item.Order.User.Name,
                                       item.Order.User.Surname,
                                       item.Order.User.Phone,
                                       item.Book.BookName,
                                       date.ToString("dd-MM-yyyy"),
                                       item.Price
                                       );


                }


            }
            txtIncrement.Text = "0";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvCredit.SelectedRows.Count; i++)
            {
                int userId = Convert.ToInt32( DgvCredit.SelectedRows[i].Cells[0].Value.ToString());
                var OrderTime = DgvCredit.SelectedRows[i].Cells[5].Value.ToString();
                //MessageBox.Show(OrderTime.ToString());
                foreach (OrderItem item in db.OrderItems.ToList())

                {
                    //MessageBox.Show(item.Order.BookDate.Date.ToString("dd-MM-yyyy"));
                    if (userId == item.Order.UserID && OrderTime == item.Order.BookDate.Date.AddDays(30).ToString("dd-MM-yyyy"))
                    {
                        



                        foreach (OrderItem item2 in db.OrderItems.ToList())
                        {
                            if (item2.Order.OrderId == item.Order.OrderId)
                            {
                                item2.Book.IsAvailable = true;
                                db.SaveChanges();
                            }
                        }
                        item.Order.isReturned = true;
                        db.SaveChanges();

                    }
                    
                }
            }
            MessageBox.Show("Kitablar qaytarıldı","Ok",MessageBoxButtons.OK,MessageBoxIcon.Information);
            DgvCredit.Rows.Clear();
            cmbCreditUsers.Text = "";
            cmbCreditUsers.Items.Clear();
            FillCreditUser();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
