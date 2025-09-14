namespace UI
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataSourceAllProduct = new DataGridView();
            dataSourceAllSales = new DataGridView();
            IdProductAddToOrder = new TextBox();
            label1 = new Label();
            buttonAddToOrder = new Button();
            label2 = new Label();
            label3 = new Label();
            dataSourceAllOrder = new DataGridView();
            label4 = new Label();
            CountProductAddToOrder = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxIdCustomer = new TextBox();
            label7 = new Label();
            buttonSubmitName = new Button();
            numericUpDownFinalPrice = new NumericUpDown();
            comboBoxProducts = new ComboBox();
            label8 = new Label();
            label_total = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataSourceAllProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSourceAllSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSourceAllOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinalPrice).BeginInit();
            SuspendLayout();
            // 
            // dataSourceAllProduct
            // 
            dataSourceAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSourceAllProduct.Location = new Point(42, 28);
            dataSourceAllProduct.Margin = new Padding(3, 4, 3, 4);
            dataSourceAllProduct.Name = "dataSourceAllProduct";
            dataSourceAllProduct.RowHeadersWidth = 51;
            dataSourceAllProduct.Size = new Size(271, 263);
            dataSourceAllProduct.TabIndex = 0;
            // 
            // dataSourceAllSales
            // 
            dataSourceAllSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSourceAllSales.Location = new Point(42, 321);
            dataSourceAllSales.Margin = new Padding(3, 4, 3, 4);
            dataSourceAllSales.Name = "dataSourceAllSales";
            dataSourceAllSales.RowHeadersWidth = 51;
            dataSourceAllSales.Size = new Size(271, 263);
            dataSourceAllSales.TabIndex = 1;
            // 
            // IdProductAddToOrder
            // 
            IdProductAddToOrder.Location = new Point(617, 45);
            IdProductAddToOrder.Margin = new Padding(3, 4, 3, 4);
            IdProductAddToOrder.Name = "IdProductAddToOrder";
            IdProductAddToOrder.Size = new Size(114, 27);
            IdProductAddToOrder.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(750, 49);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 3;
            label1.Text = ":קוד מוצר";
            // 
            // buttonAddToOrder
            // 
            buttonAddToOrder.Location = new Point(679, 193);
            buttonAddToOrder.Margin = new Padding(3, 4, 3, 4);
            buttonAddToOrder.Name = "buttonAddToOrder";
            buttonAddToOrder.Size = new Size(86, 31);
            buttonAddToOrder.TabIndex = 4;
            buttonAddToOrder.Text = "להוספה";
            buttonAddToOrder.UseVisualStyleBackColor = true;
            //buttonAddToOrder.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 4);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 5;
            label2.Text = ":רשימת מוצרים";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 297);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 6;
            label3.Text = ":רשימת מבצעים";
            // 
            // dataSourceAllOrder
            // 
            dataSourceAllOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSourceAllOrder.Location = new Point(591, 279);
            dataSourceAllOrder.Margin = new Padding(3, 4, 3, 4);
            dataSourceAllOrder.Name = "dataSourceAllOrder";
            dataSourceAllOrder.RowHeadersWidth = 51;
            dataSourceAllOrder.Size = new Size(275, 277);
            dataSourceAllOrder.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(690, 243);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 8;
            label4.Text = ":רשימת ההזמנה";
            //label4.Click += label4_Click;
            // 
            // CountProductAddToOrder
            // 
            CountProductAddToOrder.Location = new Point(617, 84);
            CountProductAddToOrder.Margin = new Padding(3, 4, 3, 4);
            CountProductAddToOrder.Name = "CountProductAddToOrder";
            CountProductAddToOrder.Size = new Size(114, 27);
            CountProductAddToOrder.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 95);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 10;
            label5.Text = ":כמות מוצר";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(721, 568);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 12;
            label6.Text = ":מחיר סופי";
            // 
            // textBoxIdCustomer
            // 
            textBoxIdCustomer.Location = new Point(401, 164);
            textBoxIdCustomer.Margin = new Padding(3, 4, 3, 4);
            textBoxIdCustomer.Name = "textBoxIdCustomer";
            textBoxIdCustomer.Size = new Size(114, 27);
            textBoxIdCustomer.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 127);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 14;
            label7.Text = ":מזהה לקוח";
            // 
            // buttonSubmitName
            // 
            buttonSubmitName.Location = new Point(410, 216);
            buttonSubmitName.Margin = new Padding(3, 4, 3, 4);
            buttonSubmitName.Name = "buttonSubmitName";
            buttonSubmitName.Size = new Size(86, 31);
            buttonSubmitName.TabIndex = 15;
            buttonSubmitName.Text = "אישור";
            buttonSubmitName.UseVisualStyleBackColor = true;
            //buttonSubmitName.Click += buttonSubmitName_Click;
            // 
            // numericUpDownFinalPrice
            // 
            numericUpDownFinalPrice.Location = new Point(432, 500);
            numericUpDownFinalPrice.Margin = new Padding(3, 4, 3, 4);
            numericUpDownFinalPrice.Name = "numericUpDownFinalPrice";
            numericUpDownFinalPrice.Size = new Size(104, 27);
            numericUpDownFinalPrice.TabIndex = 16;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(617, 123);
            comboBoxProducts.Margin = new Padding(3, 4, 3, 4);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(114, 28);
            comboBoxProducts.TabIndex = 17;
            //comboBoxProducts.SelectedIndexChanged += comboBoxProducts_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(750, 133);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 18;
            label8.Text = ":בחר מוצר";
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Location = new Point(714, 564);
            label_total.Name = "label_total";
            label_total.Size = new Size(0, 20);
            label_total.TabIndex = 19;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(319, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(292, 144);
            listBox1.TabIndex = 20;
            //listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listBox1);
            Controls.Add(label_total);
            Controls.Add(label8);
            Controls.Add(comboBoxProducts);
            Controls.Add(numericUpDownFinalPrice);
            Controls.Add(buttonSubmitName);
            Controls.Add(label7);
            Controls.Add(textBoxIdCustomer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CountProductAddToOrder);
            Controls.Add(label4);
            Controls.Add(dataSourceAllOrder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonAddToOrder);
            Controls.Add(label1);
            Controls.Add(IdProductAddToOrder);
            Controls.Add(dataSourceAllSales);
            Controls.Add(dataSourceAllProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormOrder";
            Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)dataSourceAllProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSourceAllSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSourceAllOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinalPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataSourceAllProduct;
        private DataGridView dataSourceAllSales;
        private TextBox IdProductAddToOrder;
        private Label label1;
        private Button buttonAddToOrder;
        private Label label2;
        private Label label3;
        private DataGridView dataSourceAllOrder;
        private Label label4;
        private TextBox CountProductAddToOrder;
        private Label label5;
        private Label label6;
        private TextBox textBoxIdCustomer;
        private Label label7;
        private Button buttonSubmitName;
        private NumericUpDown numericUpDownFinalPrice;
        private ComboBox comboBoxProducts;
        private Label label8;
        private Label label_total;
        private ListBox listBox1;
    }
}