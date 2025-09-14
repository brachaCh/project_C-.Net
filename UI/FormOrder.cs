//using BlApi;
//using BO;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using BlApi;
//using BO;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using DO;

//namespace UI
//{
//    public partial class FormOrder : Form
//    {
//        static readonly IBI bl = Factory.Get();
//        Order order = new Order();
//        BO.Product p;
//        List<BO.Product> l;
//        double totalPrice = 0;

//        public FormOrder()
//        {
//            InitializeComponent();
//            l = bl.Product.ReadAll();

//            dataSourceAllProduct.DataSource = bl.Product.ReadAll();
//            l = bl.Product.ReadAll();
//            comboBoxProducts.DataSource = l;
//            //comboBoxProducts.DisplayMember = "Product_Name";
//            //comboBoxProducts.ValueMember = "Product_Id";
//            //dataSourceAllSales.DataSource = bl.Sale.ReadAll();
//            //dataSourceAllProduct.Visible = false;
//            //dataSourceAllSales.Visible = false;
//            //dataSourceAllOrder.Visible = false;
//            //IdProductAddToOrder.Visible = false;
//            //CountProductAddToOrder.Visible = false;
//            //buttonAddToOrder.Visible = false;
//            //numericUpDownFinalPrice.Visible = false;
//            //label1.Visible = false;
//            //label5.Visible = false;
//            //label4.Visible = false;
//            //label6.Visible = false;
//            //label3.Visible = false;
//            //comboBoxProducts.Visible = false;
//            dataSourceAllProduct.Visible = true;
//            dataSourceAllSales.Visible = true;
//            dataSourceAllOrder.Visible = true;
//            IdProductAddToOrder.Visible = true;
//            CountProductAddToOrder.Visible = true;
//            buttonAddToOrder.Visible = true;
//            numericUpDownFinalPrice.Visible = true;
//            comboBoxProducts.Visible = true;
//            label1.Visible = true;
//            label5.Visible = true;
//            label4.Visible = true;
//            label6.Visible = true;
//            label3.Visible = true;
//        }

//        private void label4_Click(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//            //  try
//            //  {
//            //      Customer customer = bl.Customer.Read(int.Parse(textBoxIdCustomer.Text));
//            ////      order = new Order(customer.IsClub, order.ProductList, int.Parse(numericUpDownFinalPrice.Text));
//            //      bl.Order.AddProductToOrder(order, int.Parse(IdProductAddToOrder.Text), int.Parse(CountProductAddToOrder.Text));

//            //     p= bl.Product.Read(  int.Parse(IdProductAddToOrder.Text));
//            //      ProductInOrder productInOrder=new ProductInOrder(int.Parse(IdProductAddToOrder.Text),p.Product_Name
//            //          ,p.Price,int.Parse(CountProductAddToOrder.Text),p.category);


//            //      //bl.Order.DoOrder(order);

//            //     l = new List<Product>();
//            //      l.Add(p);

//            ////  }
//            //try
//            //{
//            //p = bl.Product.Read(int.Parse(IdProductAddToOrder.Text));
//            //bl.Order.AddProductToOrder(order, int.Parse(IdProductAddToOrder.Text), int.Parse(CountProductAddToOrder.Text));
//            //dataSourceAllOrder.DataSource = order.ProductList;
//            //numericUpDownFinalPrice.Value = (decimal)order.FinalPrice;
//            //numericUpDownFinalPrice.Value =(decimal)(numericUpDownFinalPrice.Value)+ p.Price * (int.Parse(CountProductAddToOrder.Text));
//            //dataSourceAllSales.DataSource = order.SearchSaleForProduct();

//            //    if (comboBoxProducts.SelectedItem is BO.Product product)
//            //    {
//            //        try
//            //        {
//            //            bl.Order.AddProductToOrder(order, productId, amount);
//            //            productId = product.Product_Id;
//            //            addToCart(productId, amount);
//            //        }
//            //        catch (Exception ex)
//            //        {
//            //            MessageBox.Show(ex.Message);
//            //        }
//            //    }
//            //}
//            //catch (Exception ex)
//            //{
//            //    MessageBox.Show(ex.Message);
//            //}



//            //int productId = (int)numericUpDown_add.Value;
//            //int amount = (int)numericUpDown_amount.Value;

//            int productId = int.Parse(IdProductAddToOrder.Text);
//            int amount = int.Parse(CountProductAddToOrder.Text);
//            try
//            {
//                p = bl.Product.Read(productId);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//            if (amount == 0)
//            {
//                MessageBox.Show("Please add quantity");
//            }
//            if (p == null)
//            {
//                MessageBox.Show("Code does not exist");
//            }
//            if (p != null && amount > 0 && productId > 999)
//            {
//                bl.Order.AddProductToOrder(order, productId, amount);
//                listBox1.Items.Clear();

//                foreach (var item in order.ProductList)
//                {
//                    string line = $"name: {item.Product_Name}         amount: {item.Count}         price: {item.Price}         total price: {item.TotalPrice}";
//                    if (item.TotalPrice != item.Price * item.Count)
//                        line += $"     sale: - {item.Price * item.Count - item.TotalPrice}";
//                    listBox1.Items.Add(line);
//                    totalPrice += item.TotalPrice;
//                }
//                label_total.Text = "";
//                label_total.Text += totalPrice + " ₪";
//                totalPrice = 0;
//                //numericUpDown_add.Value = 0;
//                //numericUpDown_amount.Value = 0;

//            }
//            else
//            {
//                //if (comboBoxProducts.SelectedItem is BO.Product product)
//                //{
//                //    try
//                //    {

//                //        s_bl.order.AddProductToOrder(order, product.Id, amount);
//                //        productId = product.Id;
//                //    }
//                //    catch
//                //    {

//                //        MessageBox.Show("Code does not exist");
//                //    }
//                //}
//            }


//        }



//        //private void addToCart(int p, int a)
//        //{
//        //    bl.Order.AddProductToOrder(order, p, a);
//        //    comboBoxProducts.Items.Clear();
//        //    comboBoxProducts.Items.Remove(p);
//        //    foreach (var item in order.ProductList)
//        //    {
//        //        string line = $"name: {item.Product_Name}         amount: {a}         price: {item.Price}         total price: {item.TotalPrice}";
//        //        if (item.TotalPrice != item.Price * item.Count)
//        //            line += $"     sale: - {item.Price * a - item.TotalPrice}";
//        //        comboBoxProducts.Items.Add(line);
//        //        totalPrice += item.TotalPrice;
//        //    }
//        //    label_total.Text = "";
//        //    label_total.Text += totalPrice + " ₪";
//        //    totalPrice = 0;
//        //    //IdProductAddToOrder.Text = 0;
//        //    //numericUpDown_amount.Value = 0;
//        //}

//        //private void buttonSubmitName_Click(object sender, EventArgs e)
//        //{
//        //    dataSourceAllProduct.Visible = true;
//        //    dataSourceAllSales.Visible = true;
//        //    dataSourceAllOrder.Visible = true;
//        //    IdProductAddToOrder.Visible = true;
//        //    CountProductAddToOrder.Visible = true;
//        //    buttonAddToOrder.Visible = true;
//        //    numericUpDownFinalPrice.Visible = true;
//        //    comboBoxProducts.Visible = true;
//        //    label1.Visible = true;
//        //    label5.Visible = true;
//        //    label4.Visible = true;
//        //    label6.Visible = true;
//        //    label3.Visible = true;
//        //}

//        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}


using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormOrder : Form
    {
        static readonly IBI bl = Factory.Get();
        Order order = new Order();
        BO.Product p;
        List<BO.Product> l;
        double totalPrice = 0;

        public FormOrder()
        {
            InitializeComponent();

            // קריאת כל המוצרים
            l = bl.Product.ReadAll().ToList();

            // אם אין מוצרים – הודעה
            if (l.Count == 0)
            {
                MessageBox.Show("אין מוצרים במערכת.");
                return;
            }

            // הצגת רשימה בטבלה (DataGridView)
            dataSourceAllProduct.AutoGenerateColumns = true;
            dataSourceAllProduct.DataSource = l;

            // הצגת רשימה ב-ComboBox
            comboBoxProducts.DataSource = l;
            comboBoxProducts.DisplayMember = "Product_Name";
            comboBoxProducts.ValueMember = "Product_Id";

            // החשיפה של הפקדים מהתחלה
            dataSourceAllProduct.Visible = true;
            dataSourceAllSales.Visible = true;
            dataSourceAllOrder.Visible = true;
            IdProductAddToOrder.Visible = true;
            CountProductAddToOrder.Visible = true;
            buttonAddToOrder.Visible = true;
            numericUpDownFinalPrice.Visible = true;
            comboBoxProducts.Visible = true;
            label1.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label3.Visible = true;
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            //int productId = 0;
            //int amount = 0;

            //try
            //{
            //    // לפי קוד מוצר או לפי בחירה
            //    if (!string.IsNullOrWhiteSpace(IdProductAddToOrder.Text))
            //    {
            //        productId = int.Parse(IdProductAddToOrder.Text);
            //    }
            //    else if (comboBoxProducts.SelectedItem is BO.Product product)
            //    {
            //        productId = product.Product_Id;
            //    }

            //    amount = int.Parse(CountProductAddToOrder.Text);
            //    p = bl.Product.Read(productId);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}

            //if (amount <= 0)
            //{
            //    MessageBox.Show("אנא הזן כמות גדולה מ-0");
            //    return;
            //}
            //if (p == null)
            //{
            //    MessageBox.Show("קוד מוצר לא קיים");
            //    return;
            //}

            //try
            //{
            //    bl.Order.AddProductToOrder(order, productId, amount);
            //    RefreshOrderView();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void RefreshOrderView()
        {
            listBox1.Items.Clear();
            totalPrice = 0;

            foreach (var item in order.ProductList)
            {
                string line = $"name: {item.Product_Name}   amount: {item.Count}   price: {item.Price}   total: {item.TotalPrice}";
                if (item.TotalPrice != item.Price * item.Count)
                    line += $"   sale: - {item.Price * item.Count - item.TotalPrice}";
                listBox1.Items.Add(line);
                totalPrice += item.TotalPrice;
            }

            label_total.Text = totalPrice + " ₪";
            numericUpDownFinalPrice.Value = (decimal)totalPrice;
        }

        private void buttonDoOrder_Click(object sender, EventArgs e)
        {
            try
            {
                bl.Order.DoOrder(order);
                MessageBox.Show("הזמנה בוצעה בהצלחה!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

