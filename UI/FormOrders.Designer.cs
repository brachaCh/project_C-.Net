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
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
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
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddProductToOrder);
            Controls.Add(dataGridViewAllProduct);
            Name = "FormOrders";
            Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAllProduct;
        private Button buttonAddProductToOrder;
    }
}