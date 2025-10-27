namespace UI
{
    partial class FormOrders
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
            dataGridViewAllProduct = new DataGridView();
            buttonAddProductToOrder = new Button();
            dataGridViewOrders = new DataGridView();
            textBoxProductCode = new TextBox();
            labelTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAllProduct
            // 
            dataGridViewAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllProduct.Location = new Point(45, 34);
            dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            dataGridViewAllProduct.RowHeadersWidth = 51;
            dataGridViewAllProduct.RowTemplate.Height = 29;
            dataGridViewAllProduct.Size = new Size(406, 336);
            dataGridViewAllProduct.TabIndex = 0;
            // 
            // buttonAddProductToOrder
            // 
            buttonAddProductToOrder.Location = new Point(45, 392);
            buttonAddProductToOrder.Name = "buttonAddProductToOrder";
            buttonAddProductToOrder.Size = new Size(168, 29);
            buttonAddProductToOrder.TabIndex = 1;
            buttonAddProductToOrder.Text = "הוספת מוצר להזמנה";
            buttonAddProductToOrder.UseVisualStyleBackColor = true;
            buttonAddProductToOrder.Click += buttonAddProductToOrder_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(473, 34);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.RowTemplate.Height = 29;
            dataGridViewOrders.Size = new Size(315, 336);
            dataGridViewOrders.TabIndex = 2;
            // 
            // textBoxProductCode
            // 
            textBoxProductCode.Location = new Point(296, 396);
            textBoxProductCode.Name = "textBoxProductCode";
            textBoxProductCode.Size = new Size(125, 27);
            textBoxProductCode.TabIndex = 3;
            textBoxProductCode.TextChanged += textBox1_TextChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(586, 392);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(103, 20);
            labelTotal.TabIndex = 4;
            labelTotal.Text = ":סה\"כ לתשלום";
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTotal);
            Controls.Add(textBoxProductCode);
            Controls.Add(dataGridViewOrders);
            Controls.Add(buttonAddProductToOrder);
            Controls.Add(dataGridViewAllProduct);
            Name = "FormOrders";
            Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAllProduct;
        private Button buttonAddProductToOrder;
        private DataGridView dataGridViewOrders;
        private TextBox textBoxProductCode;
        private Label labelTotal;
    }
}