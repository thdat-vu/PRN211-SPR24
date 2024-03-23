using Repository.Entities;
using Services;
using System.Threading.Tasks.Dataflow;

namespace BookManagement_VuThanhDat
{
    public partial class BookManager : Form
    {
        //BackField
        private Book _selected = null;
        public BookManager()
        {
            InitializeComponent();
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            //Để load được đống sách lên thì lấy ở đâu đây?
            //bước 1: Trong book Service có 1 hàm lấy các sách ra. Khởi tạo bookService như là hành xử vs DAO

            BookService service = new BookService();
            //
            dgvBookList.DataSource = service.GetAllBooks();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi hàm màn hình Detail lên. màn hình này bản chất là class BookDetailForm.
            //khác mỗi trò có render bề mặt
            //Nó là 1 class mà, nên nó có _field, prop, method như thường thôi
            //Làm sao để gọi khi nhân nút Create ở trang main UI mà nó hiện Form Detail lên đây?
            //bước 1: khơi tạo form detail như khởi tạo 1 object.
            BookDetailForm form = new BookDetailForm();
            //bước 2: bảo form này show .Dialog() <Hiện và không thể nhấn vào form Main UI đc nữa cho đến khi form Detail mất> hoặc .Show() <hiện như pop up và có thể chạm vào form MainUI>
            form.ShowDialog();
            RefreshDataGridView();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //hàm này đc gọi khi ai đó /user select 1 hay nhiều dòng. ta lấy dòng đầu tiên và có đc info của cuốn sách đã gửi vào table

            //dgvBookList.DataSource = BookService.GetAllBooks()
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //Hỏi xem có chọn dòng hay ko hay chỉ chọn header
                //MessageBox.Show("Anh đã chọn dòng");
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                //Có thể user sẽ chọn nhiều dòng cùng lúc. ta lấy ra dòng đầu tiên [0]. Và dòng này ứng với data ngầm phía sau là book nào
                //if (selectedBook != null)
                //{
                //    // MessageBox.Show(selectedBook.ToString());
                //    //đẩy selectedBook sang form bên kia
                //    BookDetailForm frm = new BookDetailForm();
                //    frm.EditedBook = selectedBook;
                //    frm.ShowDialog();
                //}
            }
        }
        public void RefreshDataGridView()
        {
            BookService service = new BookService();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = service.GetAllBooks().ToList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //đẩy sang FormDetail 
            //khai biến, new , gán prop, show dialog
            //thằng form detail : mở lên, check selected khác null ko.
            //khác null thì vào edit mode và show data mà nó đẩy sang

            if (_selected != null)
            {
                BookDetailForm frm = new BookDetailForm();
                //đưa sách sang
                frm.EditedBook = _selected;
                frm.ShowDialog();
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Please a certain book to edit", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ta sẽ lấy ra 2 chuỗi mà nằm trong txtBookName và txtDescription
            var books = new BookService().GetAllBooks();
            //phải làm thao tác xóa dũ liệu cũ trong dgv trước
            dgvBookList.DataSource = null;
            //rồi mới insert kq query lấy sách bỏ vào dgv
            // dgvBookList.DataSource = books.Where(x => true).ToList();
            //nhớ là datagrid view nó chỉ đọc đc kiểu list thôi ha chứ nó ko đọc đc IEnumberable
            if(!string.IsNullOrWhiteSpace(txtBookName.Text) && (string.IsNullOrWhiteSpace(txtBookDescription.Text)))
            {
                dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower())).ToList();
            }
            if(string.IsNullOrWhiteSpace(txtBookName.Text) && (!string.IsNullOrWhiteSpace(txtBookDescription.Text)))
            {
                dgvBookList.DataSource = books.Where(x => x.Description.ToLower().Contains(txtBookDescription.Text.ToLower())).ToList();
            }
            if(!string.IsNullOrWhiteSpace(txtBookName.Text) && (!string.IsNullOrWhiteSpace(txtBookDescription.Text)))
            {
                dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtBookDescription.Text.ToLower())).ToList();
            }
            

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            
            //Application.Exit(); đừng có thoát app luôn
            //trả về trang login đi

            LoginForm form = new();
            this.Close();
            form.ShowDialog();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_selected!= null)
            {
                BookService service = new BookService();
                service.DeleteBook(_selected);
                RefreshDataGridView();
            }
        }
    }
}
