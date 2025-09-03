using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;
namespace UI
{
    public partial class FormSale : Form
    {
        static readonly IBI sale_bi = BlApi.Factory.Get();
        Sale sale;
        public FormSale()
        {
            InitializeComponent();
            panel4.Visible = false;
            AddPanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
            ReadOnePanel.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            panel4.Visible = false;
            ReadOnePanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            panel4.Visible = true;
            AddPanel.Visible = false;
            ReadOnePanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            AddPanel.Visible = false;
            ReadOnePanel.Visible = false;
            dataGridView1.Visible = false;
        }

        private void ReadAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = sale_bi.Sale.ReadAll();
       
                ReadOneCustomer.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                AddPanel.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ReadOneCustomer_Click(object sender, EventArgs e)
        {
            ReadOneCustomer.Visible = true;
            ReadOnePanel.Visible = true;
            panel5.Visible = false;
            panel4.Visible = false;
            AddPanel.Visible = false;
        }

        private void sumbitReadOne_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;
                List<BO.Sale> list = new List<BO.Sale>();
                sale = sale_bi.Sale.Read(int.Parse(textBoxReadOne.Text));
                list.Add(sale);
                dataGridView1.DataSource = list;
                ReadOnePanel.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                AddPanel.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void deleteSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                sale_bi.Sale.Delete(int.Parse(textBox1.Text));
                panel5.Visible = false;
                dataGridView1.DataSource = sale_bi.Sale.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sale = new Sale(0, int.Parse(textBoxUpdateId.Text), int.Parse(numericUpDownPrice.Text), checkBox1.Checked, DateTime.Parse(dateTimePicker1.Text), int.Parse(numericUpDown2.Text), DateTime.Parse(dateTimePicker2.Text)); ;
                sale_bi.Sale.Update(sale);
                panel4.Visible = false;
                dataGridView1.DataSource = sale_bi.Sale.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sale = new Sale(0, int.Parse(textBox2.Text), int.Parse(numericUpDown3.Text), checkBox2.Checked, DateTime.Parse(dateTimePicker2.Text), int.Parse(numericUpDown1.Text), DateTime.Parse(dateTimePicker3.Text));
                sale_bi.Sale.Create(sale);
                AddPanel.Visible = false;
                dataGridView1.DataSource = sale_bi.Sale.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
