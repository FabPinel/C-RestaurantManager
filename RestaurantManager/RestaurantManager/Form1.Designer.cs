namespace RestaurantManager
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonSalle = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelMenu.Controls.Add(this.buttonStock);
            this.panelMenu.Controls.Add(this.buttonMenu);
            this.panelMenu.Controls.Add(this.buttonReservation);
            this.panelMenu.Controls.Add(this.buttonSalle);
            this.panelMenu.Controls.Add(this.buttonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 614);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonStock
            // 
            this.buttonStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStock.FlatAppearance.BorderSize = 0;
            this.buttonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStock.ForeColor = System.Drawing.Color.White;
            this.buttonStock.Image = global::RestaurantManager.Properties.Resources.shopping_cart__1_;
            this.buttonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStock.Location = new System.Drawing.Point(0, 320);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonStock.Size = new System.Drawing.Size(220, 60);
            this.buttonStock.TabIndex = 5;
            this.buttonStock.Text = "  Stock";
            this.buttonStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStock.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Image = global::RestaurantManager.Properties.Resources.shopping_cart__1_;
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(0, 260);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonMenu.Size = new System.Drawing.Size(220, 60);
            this.buttonMenu.TabIndex = 4;
            this.buttonMenu.Text = "  Menu";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenu.UseVisualStyleBackColor = true;
            // 
            // buttonReservation
            // 
            this.buttonReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Image = global::RestaurantManager.Properties.Resources.shopping_list;
            this.buttonReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.Location = new System.Drawing.Point(0, 200);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonReservation.Size = new System.Drawing.Size(220, 60);
            this.buttonReservation.TabIndex = 3;
            this.buttonReservation.Text = "  Réservation";
            this.buttonReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReservation.UseVisualStyleBackColor = true;
            // 
            // buttonSalle
            // 
            this.buttonSalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalle.FlatAppearance.BorderSize = 0;
            this.buttonSalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalle.ForeColor = System.Drawing.Color.White;
            this.buttonSalle.Image = global::RestaurantManager.Properties.Resources.shopping_cart__1_;
            this.buttonSalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalle.Location = new System.Drawing.Point(0, 140);
            this.buttonSalle.Name = "buttonSalle";
            this.buttonSalle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSalle.Size = new System.Drawing.Size(220, 60);
            this.buttonSalle.TabIndex = 2;
            this.buttonSalle.Text = "  Salle";
            this.buttonSalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalle.UseVisualStyleBackColor = true;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = global::RestaurantManager.Properties.Resources.shopping_cart__1_;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 80);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(220, 60);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "  Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 614);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonSalle;
    }
}

