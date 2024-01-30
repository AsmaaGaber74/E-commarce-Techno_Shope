﻿namespace Presentation.User_Role
{
    partial class CartItemPanel
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
            label1 = new Label();
            CartItemDGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            OrderAll = new Button();
            label2 = new Label();
            OrderTotalprice = new Label();
            ((System.ComponentModel.ISupportInitialize)CartItemDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(487, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 31);
            label1.TabIndex = 0;
            label1.Text = "product In cart item";
            // 
            // CartItemDGV
            // 
            CartItemDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CartItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartItemDGV.Location = new Point(35, 54);
            CartItemDGV.Name = "CartItemDGV";
            CartItemDGV.RowHeadersWidth = 51;
            CartItemDGV.Size = new Size(1127, 480);
            CartItemDGV.TabIndex = 1;
            CartItemDGV.CellContentClick += CartItemDGV_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(721, 555);
            button1.Name = "button1";
            button1.Size = new Size(112, 53);
            button1.TabIndex = 2;
            button1.Text = "NextBtn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(351, 555);
            button2.Name = "button2";
            button2.Size = new Size(115, 53);
            button2.TabIndex = 3;
            button2.Text = "previousBtn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrderAll
            // 
            OrderAll.Location = new Point(35, 649);
            OrderAll.Name = "OrderAll";
            OrderAll.Size = new Size(112, 53);
            OrderAll.TabIndex = 4;
            OrderAll.Text = "Order now";
            OrderAll.UseVisualStyleBackColor = true;
            OrderAll.Click += OrderAll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(169, 656);
            label2.Name = "label2";
            label2.Size = new Size(217, 31);
            label2.TabIndex = 5;
            label2.Text = "Order Total price :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderTotalprice
            // 
            OrderTotalprice.AutoSize = true;
            OrderTotalprice.Location = new Point(392, 665);
            OrderTotalprice.Name = "OrderTotalprice";
            OrderTotalprice.Size = new Size(0, 20);
            OrderTotalprice.TabIndex = 6;
            // 
            // CartItemPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 736);
            Controls.Add(OrderTotalprice);
            Controls.Add(label2);
            Controls.Add(OrderAll);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CartItemDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CartItemPanel";
            Text = "CartItemPanel";
            Load += CartItemPanel_Load;
            ((System.ComponentModel.ISupportInitialize)CartItemDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView CartItemDGV;
        private Button button1;
        private Button button2;
        private Button OrderAll;
        private Label label2;
        private Label OrderTotalprice;
    }
}