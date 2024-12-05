using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal(new CampContext()));
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _categoryService.TGetListAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _categoryService.TAdd(new Category
            {
                Name = txtName.Text,
                Status = true
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var category = _categoryService.TGetById(id);
            _categoryService.TDelete(category);
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var category = _categoryService.TGetById(id);
            dataGridView1.DataSource = new List<Category> { category };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isActive = rbActive.Checked;
            Category category = _categoryService.TGetById(int.Parse(txtID.Text));
            category.Name = txtName.Text;
            category.Status = isActive;
            _categoryService.TUpdate(category);
        }
    }
}
