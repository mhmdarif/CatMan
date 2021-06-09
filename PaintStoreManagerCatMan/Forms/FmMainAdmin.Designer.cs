
namespace PaintStoreManagerCatMan.Forms
{
    partial class FmMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMainAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Products = new System.Windows.Forms.Button();
            this.Btn_Categories = new System.Windows.Forms.Button();
            this.Btn_Cashiers = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Cart = new System.Windows.Forms.Button();
            this.Btn_History = new System.Windows.Forms.Button();
            this.Btn_Logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.Btn_Logout);
            this.panel1.Controls.Add(this.Btn_History);
            this.panel1.Controls.Add(this.Btn_Cart);
            this.panel1.Controls.Add(this.Btn_Cashiers);
            this.panel1.Controls.Add(this.Btn_Categories);
            this.panel1.Controls.Add(this.Btn_Products);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.Lbl_Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 100);
            this.panel2.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(984, 561);
            this.panelDesktop.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // Btn_Products
            // 
            this.Btn_Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Products.FlatAppearance.BorderSize = 0;
            this.Btn_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Products.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Products.ForeColor = System.Drawing.Color.White;
            this.Btn_Products.Location = new System.Drawing.Point(0, 100);
            this.Btn_Products.Name = "Btn_Products";
            this.Btn_Products.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Products.Size = new System.Drawing.Size(200, 71);
            this.Btn_Products.TabIndex = 1;
            this.Btn_Products.Text = "Products";
            this.Btn_Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Products.UseVisualStyleBackColor = true;
            this.Btn_Products.Click += new System.EventHandler(this.Btn_Products_Click);
            // 
            // Btn_Categories
            // 
            this.Btn_Categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Categories.FlatAppearance.BorderSize = 0;
            this.Btn_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Categories.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Categories.ForeColor = System.Drawing.Color.White;
            this.Btn_Categories.Location = new System.Drawing.Point(0, 171);
            this.Btn_Categories.Name = "Btn_Categories";
            this.Btn_Categories.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Categories.Size = new System.Drawing.Size(200, 71);
            this.Btn_Categories.TabIndex = 2;
            this.Btn_Categories.Text = "Categories";
            this.Btn_Categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Categories.UseVisualStyleBackColor = true;
            this.Btn_Categories.Click += new System.EventHandler(this.Btn_Categories_Click);
            // 
            // Btn_Cashiers
            // 
            this.Btn_Cashiers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Cashiers.FlatAppearance.BorderSize = 0;
            this.Btn_Cashiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cashiers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cashiers.ForeColor = System.Drawing.Color.White;
            this.Btn_Cashiers.Location = new System.Drawing.Point(0, 242);
            this.Btn_Cashiers.Name = "Btn_Cashiers";
            this.Btn_Cashiers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Cashiers.Size = new System.Drawing.Size(200, 71);
            this.Btn_Cashiers.TabIndex = 3;
            this.Btn_Cashiers.Text = "Cashiers";
            this.Btn_Cashiers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cashiers.UseVisualStyleBackColor = true;
            this.Btn_Cashiers.Click += new System.EventHandler(this.Btn_Cashiers_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(435, 38);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(143, 23);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Admin Control";
            // 
            // Btn_Cart
            // 
            this.Btn_Cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Cart.FlatAppearance.BorderSize = 0;
            this.Btn_Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cart.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cart.ForeColor = System.Drawing.Color.White;
            this.Btn_Cart.Location = new System.Drawing.Point(0, 313);
            this.Btn_Cart.Name = "Btn_Cart";
            this.Btn_Cart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Cart.Size = new System.Drawing.Size(200, 71);
            this.Btn_Cart.TabIndex = 4;
            this.Btn_Cart.Text = "Cart";
            this.Btn_Cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cart.UseVisualStyleBackColor = true;
            this.Btn_Cart.Click += new System.EventHandler(this.Btn_Cart_Click);
            // 
            // Btn_History
            // 
            this.Btn_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_History.FlatAppearance.BorderSize = 0;
            this.Btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_History.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_History.ForeColor = System.Drawing.Color.White;
            this.Btn_History.Location = new System.Drawing.Point(0, 384);
            this.Btn_History.Name = "Btn_History";
            this.Btn_History.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_History.Size = new System.Drawing.Size(200, 71);
            this.Btn_History.TabIndex = 5;
            this.Btn_History.Text = "History";
            this.Btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_History.UseVisualStyleBackColor = true;
            this.Btn_History.Click += new System.EventHandler(this.Btn_History_Click);
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.ActiveBorderThickness = 1;
            this.Btn_Logout.ActiveCornerRadius = 20;
            this.Btn_Logout.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.Btn_Logout.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Logout.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.Btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.Btn_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Logout.BackgroundImage")));
            this.Btn_Logout.ButtonText = "Logout";
            this.Btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Logout.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Logout.IdleBorderThickness = 1;
            this.Btn_Logout.IdleCornerRadius = 20;
            this.Btn_Logout.IdleFillColor = System.Drawing.Color.Red;
            this.Btn_Logout.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Logout.IdleLineColor = System.Drawing.Color.Red;
            this.Btn_Logout.Location = new System.Drawing.Point(11, 602);
            this.Btn_Logout.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(181, 45);
            this.Btn_Logout.TabIndex = 6;
            this.Btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // FmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FmMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmMainAdmin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button Btn_Products;
        private System.Windows.Forms.Button Btn_Categories;
        private System.Windows.Forms.Button Btn_Cashiers;
        private System.Windows.Forms.Label Lbl_Title;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Logout;
        private System.Windows.Forms.Button Btn_History;
        private System.Windows.Forms.Button Btn_Cart;
    }
}