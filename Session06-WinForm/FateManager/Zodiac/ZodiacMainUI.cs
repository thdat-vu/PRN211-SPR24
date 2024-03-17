using Services;

namespace Zodiac
{
	public partial class ZodiacMainUI : Form
	{
		public ZodiacMainUI()
		{
			InitializeComponent();
		}

		private void btnShowImage_Click(object sender, EventArgs e)
		{
			//load ảnh
			//Image image = Image.FromFile("signs\\hotgirl.jpg");
			Image image = Image.FromFile(@"signs\hotgirl.jpg");
			picImageSign.Image = image;
		}

		private void btnCheckZodiac_Click(object sender, EventArgs e)
		{
			//lấy ra đc day và month
			int day = int.Parse(txtDay.Text);
			int month = int.Parse(txtMonth.Text);

			//validation

			string zodiacSignEN = ZodiacCalculator.GetZodiacEnglish(month, day);
			string zodiacSignVI = ZodiacCalculator.GetZodiacVietnamese(zodiacSignEN);
			//hiển thị ra ảnh và nhấn
			lblZodiacSign.Text += " " + zodiacSignEN + " | " + zodiacSignVI;
			Image image = Image.FromFile("signs\\" + zodiacSignEN + ".jpg");
			picImageSign.Image = image;
		}

		private void lblZodiacSign_Click(object sender, EventArgs e)
		{

		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			//Click to quit
			//create message box to confirm quit

			//cho 1 kết quả của popup để xác nhận quit
			DialogResult answer =
			//Content						//Title		//button				//Icon for message box
			MessageBox.Show("Do you really want to quit?", "Quit app?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			//hộp hỏi đáp, cửa sổ popup hỏi đáp với user và nó có trả về nút đã đc nhấn, thuộc CLASS DIAGLOG RESULT - DIAGLOG: HỘP HỘI THOẠI, HỎI ĐÁP
			//NHẤN NÚT  LÀ CHỌN LỜI ĐÁP


			if (answer == DialogResult.Yes)
			{
				Application.Exit();

			}

		}
	}
}
