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
            labelTotal = new Label();
            NumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).BeginInit();
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
            buttonAddProductToOrder.Location = new Point(131, 394);
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
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(596, 401);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(50, 20);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "label1";
            // 
            // NumericUpDown
            // 
            NumericUpDown.Location = new Point(321, 396);
            NumericUpDown.Name = "NumericUpDown";
            NumericUpDown.Size = new Size(150, 27);
            NumericUpDown.TabIndex = 4;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumericUpDown);
            Controls.Add(labelTotal);
            Controls.Add(dataGridViewOrders);
            Controls.Add(buttonAddProductToOrder);
            Controls.Add(dataGridViewAllProduct);
            Name = "FormOrders";
            Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAllProduct;
        private Button buttonAddProductToOrder;
        private DataGridView dataGridViewOrders;
        private Label labelTotal;
        private NumericUpDown NumericUpDown;
    }
}