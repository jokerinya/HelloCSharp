using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }

        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxKategori.DataSource = context.Categories.ToList();
                cbxKategori.DisplayMember = "CategoryName";
                cbxKategori.ValueMember = "CategoryId";
            }
        }

        private void cbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxKategori.SelectedValue.ToString()));
            }
            catch (Exception)
            {
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(key);
            }
        }
    }
}
