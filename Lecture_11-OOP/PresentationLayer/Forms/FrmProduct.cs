using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal(new CampContext()));
            _categoryService = new CategoryManager(new EfCategoryDal(new CampContext()));
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var products = _productService.TGetListAll();
            dgvProduct.DataSource = products;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var products = _productService.TGetProductsByCategory();
            dgvProduct.DataSource = products;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = _productService.TGetById(Convert.ToInt32(txtID.Text));
            _productService.TDelete(value);
            MessageBox.Show("Ürün Silindi!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                CategoryId = Convert.ToInt32(cmbCategory.SelectedValue)
            };

            _productService.TAdd(product);
            MessageBox.Show("Ürün Eklendi!");
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            var product = _productService.TGetById(Convert.ToInt32(txtID.Text));
            txtName.Text = product.Name;
            txtDescription.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
            txtStock.Text = product.Stock.ToString();
            cmbCategory.SelectedValue = product.CategoryId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Product product = _productService.TGetById(id);
            product.Name = txtName.Text;
            product.Description = txtDescription.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            _productService.TUpdate(product);
            MessageBox.Show("Ürün Güncellendi!");
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var categories = _categoryService.TGetListAll();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }
    }
}
