namespace products
{
    partial class Form2
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
            this.Creams = new System.Windows.Forms.Button();
            this.MakeUp = new System.Windows.Forms.Button();
            this.Perfumes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Creams
            // 
            this.Creams.Location = new System.Drawing.Point(25, 39);
            this.Creams.Name = "Creams";
            this.Creams.Size = new System.Drawing.Size(92, 34);
            this.Creams.TabIndex = 0;
            this.Creams.Text = "Creams";
            this.Creams.UseVisualStyleBackColor = true;
            this.Creams.Click += new System.EventHandler(this.Creams_Click);
            // 
            // MakeUp
            // 
            this.MakeUp.Location = new System.Drawing.Point(25, 130);
            this.MakeUp.Name = "MakeUp";
            this.MakeUp.Size = new System.Drawing.Size(92, 31);
            this.MakeUp.TabIndex = 1;
            this.MakeUp.Text = "MakeUp";
            this.MakeUp.UseVisualStyleBackColor = true;
            this.MakeUp.Click += new System.EventHandler(this.MakeUp_Click);
            // 
            // Perfumes
            // 
            this.Perfumes.Location = new System.Drawing.Point(25, 214);
            this.Perfumes.Name = "Perfumes";
            this.Perfumes.Size = new System.Drawing.Size(92, 33);
            this.Perfumes.TabIndex = 2;
            this.Perfumes.Text = "Perfumes";
            this.Perfumes.UseVisualStyleBackColor = true;
            this.Perfumes.Click += new System.EventHandler(this.Perfumes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 208);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(575, 288);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(111, 38);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(246, 288);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(121, 38);
            this.Order.TabIndex = 7;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 356);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Perfumes);
            this.Controls.Add(this.MakeUp);
            this.Controls.Add(this.Creams);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Creams;
        private System.Windows.Forms.Button MakeUp;
        private System.Windows.Forms.Button Perfumes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Order;
    }
}