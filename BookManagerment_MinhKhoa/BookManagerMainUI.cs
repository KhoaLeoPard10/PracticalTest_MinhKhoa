using Microsoft.VisualBasic;
using Repositories.Entities;
using Services;

namespace BookManagerment_MinhKhoa
{
    public partial class BookManagerMainUI : Form
    {
        //backing field _
        //gọi Services để cung cấp data vào cái grid/table
        private BookServices _services = new BookServices();
        private Book _selected = null; //chờ ai đó nhấn 1 dòng trong grid/table                        
                                       //thì nó được gán = cuốn sách đang chọn
                                       //đẩy được cuốn sách được chọn sang màn hình update

        private object services;

        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        //hàm dùng nội bộ gọi là Helper
        private void FillDateGridView()
        {
            dgvBookList.DataSource = null; //xóa trắng grid
            dgvBookList.DataSource = _services.GetAllBook(); //nhờ Service xuống DB 
        }
        public void BookManagerMainUI_Load(object sender, EventArgs e)
        {

            FillDateGridView();

            //dgvBookList.DataSource = null; //xóa trắng grid
            //dgvBookList.DataSource = _services.GetAllBook();
            //                                hàm I trả về all books
        }   //Bad Smells - Robert C. Martin - Clean code, SOLID, Agile Manifesto
            //HÀM FILL DATA VÀO GRID ĐƯỢC GỌI NHIỀU LẦN Ở NÚT CREATE, UPDATE, DELETE, LOAD FORM

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản chất là class BookDetailFrom, khác truyền thống là nó có phần render bề mặt!!!
            //Nó là 1 class nên nó sẽ có _field, prop, methods như bt
            //khai báo biến, new như bình thường
            //chỉ khác là có thêm phần render
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog(); //render đi em
            //f.Show(); //nguy hiểm nhen, vì cứ new là có object, cửa sổ mới!!!
            //F5 lưới here
            FillDateGridView();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 dòng hay nhiều dòng - chìm chuột, cho nên ta sẽ lấy dòng đầu tiên được chọn nếu người ta chọn nhiều dòng
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên được chọn là bốc nó ra, đẩy sang màn hình detail
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem; //lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu .DataSource = List<Book> của hàm GetAllBooks
            }
            //TODO: nếu user chọn Cell thay vì chọn nguyên dòng, reset biến _selected về NULL
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //đẩy sang Form Detail
            //khai biến, new, gán prop, show dialog
            //thằng form detail: mở lên, check selected khác null hem? khác null mode EDIT, SHOW DATA ĐƯỢC GỬI SANG
            if (_selected != null) //người dùng phải chọn 1 dòng trong grid
            {
                BookDetailForm f = new BookDetailForm();

                //đưa sách sang
                f.Selectedbook = _selected;
                f.ShowDialog();
                //F5 grid
                FillDateGridView();
            }
            else
                MessageBox.Show("Please slect certain book to edit!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             //ta sẽ lấy ra 2 chuỗi đang nằm trong txtBookName & txtDescription
            //va ta where trên cái danh sách books đang có

            var books = new BookServices().GetAllBook();
            dgvBookList.DataSource = null;
            //dgvBookList.DataSource = books.Where(x => false).ToList(); //không trả về cuốn nào
            //dgvBookList.DataSource = books.Where(x => true).ToList(); //đưa cuốn nào cũng đồng ý hết

            //dgvBookList.DataSource = books.Where(
            //    delegate (Book x)
            //    {
            //        return x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower());
            //    }).ToList();


            dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null) //người dùng phải chọn 1 dòng trong grid
            {
                MessageBox.Show("Please slect certain book to delete!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //thoát hàm
            }
            //không thoát hàm tức là đã chọn dòng
            //nhờ Service xóa giùm

            //TRƯỚC KHI XÓA HỎI CÂU CONFORM

            DialogResult answer = MessageBox.Show("Do you really want to delete?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;

            //sure Yes thì xóa
            _services.DeleteBookFromUI(_selected); //thay vì đẩy cuốn sách Book sang Detail form nay ta đẩy xuống hàm xóa
            //F5 grid
            FillDateGridView();

            //VIP???
            _selected = null;
        }
    }
}
