using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerment_MinhKhoa
{
    public partial class BookDetailForm : Form
    {
        //vì DetailForm cũng là 1 class, nên nó có prop như bt. Hơn bt là nó là class có thể render (Bố/Cha class form của SDK lo phần render - mối quan hệ kế thừa)

        //public int      Yob { get; set; } = 2003;
        //                .Yob = ???
        public Book Selectedbook { get; set; } = null;
        //mặc định form này mở lên, không có book nào cả
        //nếu muốn có book thì phải .SelectedBook = cuốn muốn gán vào!!!


        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //MỞ MÀN HÌNH DETAIL THÌ TA SẼ:
            //1. FILL ĐẦY CATEGORY DROPDOWN - LẤY DATA TỪ TABLE CATEGORY
            //2. NẾU LÀ EDIT 1 CUỐN SÁCH THÌ FILL DATA CỦA CUỐN SÁCH MUỐN
            //   EDIT VÀO CÁC Ô TƯƠNG ỨNG
            //3. NẾU LÀ TẠO MỚI CUỐN SÁCH, THÌ CỨ ĐỂ MÀN HÌNH TRỐNG CHỜ USER NHẬP INFO - KHÔNG CẦN LÀM GÌ THÊM

            BookCategoryServices cat = new BookCategoryServices();

            //đổ full data vào cbo
            cboBookCategoryId.DataSource = cat.GetAllCategories(); //hàm số II

            //chọn cột để hiển thị trên cbo
            cboBookCategoryId.DisplayMember = "BookGenreType";

            //chọn cột để value thực sự cần dùng - what you see is not what you get
            //Chọn Self Help dễ cho user -> code map sang value 5 của cột BookCategoryId, dùng làm FK đẩy vào table BOOK

            cboBookCategoryId.ValueMember = "BookCategoryId";

            //vi diệu
            //nhảy đến giá trị bất kì nào mình thích trong cbo
            //mặc định là đầu danh sách xổ 1
            //cboBookCategoryId.SelectedValue = 5; //default với mình là sách Self help

            //CHECK HÀNG, CÓ PHẢI LÀ EDIT HAY KHÔNG
            //CHECK BIẾN SELECTEDBOOK COI CÓ ĐƯỢC SET KHÁC NULL KHÔNG
            //NẾU CÓ SÁCH THÌ FILL VÀO CÁC Ô
            if (Selectedbook != null)
            {
                lblHeader.Text = "Update selected book...";
                txtBookId.Text = Selectedbook.BookId.ToString();
                txtBookId.Enabled = false; //KHÔNG CHO EDIT CỘT BOOKID TRONG MODE EDIT
                txtBookName.Text = Selectedbook.BookName;
                txtDescription.Text = Selectedbook.Description;
                //dtpPublicationDate.Text = Selectedbook.PublicationDate.ToString();
                dtpPublicationDate.Value = Selectedbook.PublicationDate;
                //DateTime data type
                txtQuantity.Text = Selectedbook.Quantity.ToString();
                txtPrice.Text = Selectedbook.Price.ToString();
                txtAuthor.Text = Selectedbook.Author.ToString();

                cboBookCategoryId.SelectedValue = Selectedbook.BookCategoryId; //1 2 3 4 5
                //tùy sách có cate gì thì jump đến số đó!!!
            }
            else
                lblHeader.Text = "Create a new book....";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to cancel?", "Cancle", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (answer == DialogResult.OK)
            {
                Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ta phải new 1 cuốn sách với các info lấy từ ô text
            //gõ vào ô text để update hoặc tạo mới, thì rõ ràng là phải đưa ô text vào 1 cuốn sách
            //không care sách mới hay cũ, phải new trong RAM cái đã
            //nếu là sách cũ EDIT mode, thì cuốn sách new đã có ID của Book Selected, VÀ UPDATE XUỐNG DB
            //nếu là sách mới ADD MODE, thì cuốn sách này có cái ID mới và mong nó không trùng id đám sách đang có -> INSERT XUỐNG DB

            Book book = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboBookCategoryId.SelectedValue.ToString())
            };
            //object initialization
            //gửi xuống DB qua BookServices
            BookServices services = new BookServices();
            //check mode EDIT HAY NEW
            if (Selectedbook != null) //flag variable
                services.UpdateBookFromUI(book);
            else
                services.AddBookFromUI(book);

            //cho dù new/edit thì xong phải tắt cái màn hình Detail
            Close(); //hàm của class Cha Form
            //Đóng màn hình Detail thì phải F5 cái grid
            //Bên Main form phải refresh lưới ở ngay sau chỗ gọi Detail
        }
    }
}
