using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormOrders : Form
    {
        static readonly IBI bl = Factory.Get();
        Order order = new Order();
        BO.Product p;
        List<BO.Product> l;
        double totalPrice = 0;
        public FormOrders()
        {
            InitializeComponent();

            l = bl.Product.ReadAll().ToList();

            if (l.Count == 0)
            {
                MessageBox.Show("אין מוצרים במערכת.");
                return;
            }

            dataGridViewAllProduct.AutoGenerateColumns = true;
            dataGridViewAllProduct.DataSource = l;
        }

        private void buttonAddProductToOrder_Click(object sender, EventArgs e)
        {
            //if (dataGridViewAllProduct.CurrentRow == null)
            //{
            //    MessageBox.Show("לא נבחר מוצר");
            //    return;
            //}

            //// המרת השורה לאובייקט המוצר
            //var product = (BO.Product)dataGridViewAllProduct.CurrentRow.DataBoundItem;

            //try
            //{
            //    // ברירת מחדל כמות = 1 (או אפשר לקחת ממקום אחר – למשל NumericUpDown)
            //    int amount = 1;

            //    bl.Order.AddProductToOrder(order, product.Product_Id, amount);
            //    RefreshOrderView();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
}
