﻿using Repository.Entities;
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

namespace BookManagement_VuThanhDat
{
    public partial class BookDetailForm : Form
    {
        //Prop này dâm lắm này. Dùng để truyền 1 book đã có trong dtb nếu nhấn Update 1 cuốn sách
        public Book EditedBook { get; set; } = null;
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void BookDetailForm_Load(object sender, EventArgs e)
        //{

        //}

        public void BookDetailForm_Load(object sender, EventArgs e)
        {

            BookCategoryService categoryService = new BookCategoryService();

            cboBookCategoryId.DataSource = categoryService.GetAllCategories();

            //Chọn cột mà hiển thị
            cboBookCategoryId.DisplayMember = "BookGenreType";

            //chọn cột để lấy value dùng cho khóa ngoại bên Book Table
            //select 1 đằng - user view, cần value nẻo khác
            //Id            | Genre             | Desc
            //Lấy value     hiển thị user chọn    Ẩn info

            cboBookCategoryId.ValueMember = "BookCategoryId";

            //jump đến cái value mình thích - chọn đúng type cho cuốn sách
            cboBookCategoryId.SelectedValue = 5;
            //self help type
            //cuốn sách đang edit.BookCategoryId;

            //dòng này cơ bản là: để giúp khi chọn 1 cuốn sách trong dataGridView ở main UI. 

            //=> nhấn nút Create, đương nhiên Prop Edited book phải null rồi

            //nhưng nếu nhấn 1 dòng trong datagrid view thì sao?
            //chúng ta sổ 1 Form Detail có các field đã có sẵn để vào thôi.
            //cứ từ từ mà debug.
            if (EditedBook != null)
            {
                txtBookId.Text = EditedBook.BookId.ToString();
                txtBookName.Text = EditedBook.BookName.ToString();
                txtDescription.Text = EditedBook.Description;
                cboBookCategoryId.SelectedValue = EditedBook.BookCategoryId;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //chỗ này ko đc Application.Exit nha
            //đóng form nhỏ của 1 app bự th

            this.Close();
        }
    }
}
