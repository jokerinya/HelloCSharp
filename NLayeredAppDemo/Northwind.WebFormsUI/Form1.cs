using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        // Added all Nuget packages to this startup project too.
        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxAddProductCategoryName.DataSource = _categoryService.GetAll();
            cbxAddProductCategoryName.DisplayMember = "CategoryName";
            cbxAddProductCategoryName.ValueMember = "CategoryId";

            cbxUpdateProductCategoryName.DataSource = _categoryService.GetAll();
            cbxUpdateProductCategoryName.DisplayMember = "CategoryName";
            cbxUpdateProductCategoryName.ValueMember = "CategoryId";
        }

        private void ListProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // for first fetch it makes an error will be deal it later
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByName(tbxProductName.Text);
            }
            else
            {
                ListProducts();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                {
                    ProductName = tbxAddProductName.Text,
                    CategoryId = Convert.ToInt32(cbxAddProductCategoryName.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxAddProductUnitInPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxAddProductUnitInPrice.Text),
                    QuantityPerUnit = tbxAddProductQuantityPerUnit.Text,
                });
                MessageBox.Show("Product Added");
                ListProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // The important part here is to add the primary key, even if this is a new object
                // according to primary it will update it
                _productService.Update(new Product()
                {
                    // Means selected == dgw.CurrentRow
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxUpdateProductCategoryName.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxUpdateProductUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUpdateProductUnitsInStock.Text),
                    QuantityPerUnit = tbxUpdateProductQuantityPerUnit.Text,
                });
                MessageBox.Show("Product Updated");
                ListProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateProductCategoryName.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
            tbxUpdateProductUnitPrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateProductUnitsInStock.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateProductQuantityPerUnit.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    // ProductId will be enough.
                    _productService.Delete(new Product()
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    });
                    MessageBox.Show("Product Deleted");
                    ListProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
