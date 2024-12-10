using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal(new CampContext()));
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
    }
}
