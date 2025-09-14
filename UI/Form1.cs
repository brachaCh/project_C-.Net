namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            this.Hide();
            managerForm.FormClosed += ManagerForm_FormClosed;
            managerForm.Show();
        }

        private void ManagerForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            this.Hide();
            formOrder.FormClosed += FormOrder_FormClosed;
            formOrder.Show();
        }
        private void FormOrder_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //FormOrder formOrder = new FormOrder();
            //this.Hide();
            //formOrder.FormClosed += FormOrder_FormClosed1;
            //formOrder.Show();
            FormOrders formOrders = new FormOrders();
            this.Hide();
            formOrders.FormClosed += FormOrders_FormClosed;
            formOrders.Show();
        }

        private void FormOrders_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //private void FormOrder_FormClosed1(object? sender, FormClosedEventArgs e)
        //{
        //    this.Show();
        //}
    }
}
