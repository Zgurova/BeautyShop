using System;

namespace products
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Creams = new System.Windows.Forms.Button();
            this.MakeUp = new System.Windows.Forms.Button();
            this.Perfumes = new System.Windows.Forms.Button();
            this.Cart = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(255, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(412, 218);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // Creams
            // 
            this.Creams.Location = new System.Drawing.Point(33, 32);
            this.Creams.Name = "Creams";
            this.Creams.Size = new System.Drawing.Size(124, 42);
            this.Creams.TabIndex = 2;
            this.Creams.Text = "Creams";
            this.Creams.UseVisualStyleBackColor = true;
            this.Creams.Click += new System.EventHandler(this.Creams_Click);
            // 
            // MakeUp
            // 
            this.MakeUp.Location = new System.Drawing.Point(33, 104);
            this.MakeUp.Name = "MakeUp";
            this.MakeUp.Size = new System.Drawing.Size(124, 40);
            this.MakeUp.TabIndex = 3;
            this.MakeUp.Text = "MakeUp";
            this.MakeUp.UseVisualStyleBackColor = true;
            this.MakeUp.Click += new System.EventHandler(this.MakeUp_Click);
            // 
            // Perfumes
            // 
            this.Perfumes.Location = new System.Drawing.Point(33, 178);
            this.Perfumes.Name = "Perfumes";
            this.Perfumes.Size = new System.Drawing.Size(124, 40);
            this.Perfumes.TabIndex = 4;
            this.Perfumes.Text = "Perfumes";
            this.Perfumes.UseVisualStyleBackColor = true;
            this.Perfumes.Click += new System.EventHandler(this.Perfumes_Click);
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(33, 282);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(124, 39);
            this.Cart.TabIndex = 5;
            this.Cart.Text = "Cart";
            this.Cart.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(566, 283);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 38);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(552, 284);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(115, 39);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(255, 284);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(112, 38);
            this.Order.TabIndex = 8;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(702, 362);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.Perfumes);
            this.Controls.Add(this.MakeUp);
            this.Controls.Add(this.Creams);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion      
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Creams;
        private System.Windows.Forms.Button MakeUp;
        private System.Windows.Forms.Button Perfumes;
        private System.Windows.Forms.Button Cart;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Order;

        public EventHandler Remove_Click { get; private set; }
        public EventHandler Add_Click { get; private set; }
    }
}

