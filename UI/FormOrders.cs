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
            dataGridViewOrders.ColumnCount = 5;
            dataGridViewOrders.Columns[0].Name = "ID";
            dataGridViewOrders.Columns[1].Name = "שם מוצר";
            dataGridViewOrders.Columns[2].Name = "מחיר ליחידה";
            dataGridViewOrders.Columns[3].Name = "כמות";
            dataGridViewOrders.Columns[3].Name = "סך הכל";

        }

        //private void buttonAddProductToOrder_Click(object sender, EventArgs e)
        //{

        //    //if (dataGridViewAllProduct.CurrentRow != null)
        //    //{
        //    //    // לקחת את המוצר מהשורה שנבחרה
        //    //    var selectedRow = dataGridViewAllProduct.CurrentRow;

        //    //    string id = selectedRow.Cells["product_Id"].Value.ToString();
        //    //    string name = selectedRow.Cells["product_Name"].Value.ToString();
        //    //    decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

        //    //    // להוסיף ל-DataGridView של ההזמנה עם כמות 1 כברירת מחדל
        //    //    dataGridViewOrders.Rows.Add(id, name, price, 1);
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("בחר שורה לפני ההוספה");
        //    //}
        //    string inputId = textBoxProductCode.Text.Trim();

        //    if (string.IsNullOrEmpty(inputId))
        //    {
        //        MessageBox.Show("הקלד קוד מוצר לחיפוש.");
        //        return;
        //    }

        //    if (dataGridViewAllProduct.CurrentRow == null)
        //    {
        //        MessageBox.Show("בחר מוצר לפני ההוספה.");
        //        return;
        //    }

        //    var selectedRow = dataGridViewAllProduct.CurrentRow;
        //    Product product = l.FirstOrDefault(p => p.Product_Id.ToString() == inputId);
        //    if (product == null)
        //    {
        //        MessageBox.Show("לא נמצא מוצר עם הקוד הזה.");
        //        return;
        //    }

        //    foreach (DataGridViewRow row in dataGridViewAllProduct.Rows)
        //    {
        //        if (row.Cells[0].Value.ToString() == inputId)
        //        {
        //            row.Selected = true;
        //            dataGridViewAllProduct.FirstDisplayedScrollingRowIndex = row.Index;
        //            break;
        //        }
        //    }

        //    string id = selectedRow.Cells[0].Value.ToString();
        //    string name = selectedRow.Cells[1].Value.ToString();
        //    decimal price = Convert.ToDecimal(selectedRow.Cells[2].Value);

        //    // --- פופאפ להזנת כמות ---
        //    NumericUpDown nud = new NumericUpDown();
        //    nud.Minimum = 1;
        //    nud.Maximum = 1000;
        //    nud.Value = 1;

        //    Form prompt = new Form()
        //    {
        //        Width = 250,
        //        Height = 150,
        //        Text = "בחר כמות",
        //        FormBorderStyle = FormBorderStyle.FixedDialog,
        //        StartPosition = FormStartPosition.CenterParent,
        //        MinimizeBox = false,
        //        MaximizeBox = false
        //    };

        //    Label textLabel = new Label() { Left = 20, Top = 20, Text = "כמה יחידות להוסיף?" };
        //    Button confirmation = new Button() { Text = "OK", Left = 80, Width = 80, Top = 60, DialogResult = DialogResult.OK };

        //    prompt.Controls.Add(nud);
        //    nud.Left = 20;
        //    nud.Top = 50;
        //    prompt.Controls.Add(confirmation);
        //    prompt.Controls.Add(textLabel);
        //    prompt.AcceptButton = confirmation;

        //    if (prompt.ShowDialog() != DialogResult.OK) return;

        //    int quantityToAdd = (int)nud.Value;

        //    // --- בדיקה אם המוצר כבר קיים ב-DataGridViewOrder ---
        //    bool found = false;
        //    foreach (DataGridViewRow row in dataGridViewOrders.Rows)
        //    {
        //        if (row.Cells[0].Value.ToString() == id) // אם ID זהה
        //        {
        //            int currentQty = Convert.ToInt32(row.Cells[3].Value);
        //            row.Cells[3].Value = currentQty + quantityToAdd; // עדכון כמות
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (!found)
        //    {
        //        dataGridViewOrders.Rows.Add(id, name, price, quantityToAdd);
        //    }
        //}

        private void buttonAddProductToOrder_Click(object sender, EventArgs e)
        {
            string inputId = textBoxProductCode.Text.Trim();

            if (string.IsNullOrEmpty(inputId))
            {
                MessageBox.Show("הקלד קוד מוצר לחיפוש.");
                return;
            }

            // חיפוש המוצר לפי הקוד
            Product product = l.FirstOrDefault(p => p.Product_Id.ToString() == inputId);
            if (product == null)
            {
                MessageBox.Show("לא נמצא מוצר עם הקוד הזה.");
                return;
            }

            // סימון שורה מתאימה בטבלת המוצרים
            foreach (DataGridViewRow row in dataGridViewAllProduct.Rows)
            {
                if (row.Cells[0].Value.ToString() == inputId)
                {
                    row.Selected = true;
                    dataGridViewAllProduct.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

            // --- פופאפ להזנת כמות ---
            NumericUpDown nud = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 1000,
                Value = 1,
                Left = 20,
                Top = 50
            };

            Form prompt = new Form
            {
                Width = 250,
                Height = 150,
                Text = "בחר כמות",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            Label textLabel = new Label { Left = 20, Top = 20, Text = "כמה יחידות להוסיף?" };
            Button confirmation = new Button { Text = "OK", Left = 80, Width = 80, Top = 60, DialogResult = DialogResult.OK };

            prompt.Controls.Add(nud);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() != DialogResult.OK) return;

            int quantityToAdd = (int)nud.Value;

            // --- בדיקה אם המוצר כבר קיים בטבלת ההזמנה ---
            bool found = false;
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == product.Product_Id.ToString())
                {
                    int currentQty = Convert.ToInt32(row.Cells[3].Value);
                    row.Cells[3].Value = currentQty + quantityToAdd; // עדכון כמות
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                dataGridViewOrders.Rows.Add(product.Product_Id, product.Product_Name, product.Price, quantityToAdd, product.Price * quantityToAdd);
            }

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                double price = Convert.ToDouble(row.Cells[2].Value);
                int qty = Convert.ToInt32(row.Cells[3].Value);
                total += price * qty;
            }

            totalPrice = total;
            labelTotal.Text = $"סה\"כ לתשלום: {totalPrice:N2} ₪";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

