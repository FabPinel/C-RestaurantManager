namespace RestaurantManager.Forms
{
    partial class FormulaireStock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextFormStock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveStock = new System.Windows.Forms.Button();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdStock = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.lblTextFormStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 102);
            this.panel1.TabIndex = 1;
            // 
            // lblTextFormStock
            // 
            this.lblTextFormStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextFormStock.AutoSize = true;
            this.lblTextFormStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFormStock.ForeColor = System.Drawing.Color.White;
            this.lblTextFormStock.Location = new System.Drawing.Point(154, 38);
            this.lblTextFormStock.Name = "lblTextFormStock";
            this.lblTextFormStock.Size = new System.Drawing.Size(176, 22);
            this.lblTextFormStock.TabIndex = 0;
            this.lblTextFormStock.Text = "Ajouter un ingredient";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIdStock);
            this.panel2.Controls.Add(this.btnSaveStock);
            this.panel2.Controls.Add(this.txtCategorie);
            this.panel2.Controls.Add(this.lblCategorie);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.txtIngredient);
            this.panel2.Controls.Add(this.lblIngredient);
            this.panel2.Location = new System.Drawing.Point(37, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 426);
            this.panel2.TabIndex = 2;
            // 
            // btnSaveStock
            // 
            this.btnSaveStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnSaveStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStock.FlatAppearance.BorderSize = 0;
            this.btnSaveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStock.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStock.ForeColor = System.Drawing.Color.White;
            this.btnSaveStock.Location = new System.Drawing.Point(59, 303);
            this.btnSaveStock.Name = "btnSaveStock";
            this.btnSaveStock.Size = new System.Drawing.Size(101, 36);
            this.btnSaveStock.TabIndex = 0;
            this.btnSaveStock.Text = "Ajouter";
            this.btnSaveStock.UseVisualStyleBackColor = false;
            this.btnSaveStock.Click += new System.EventHandler(this.btnSaveStock_Click);
            // 
            // txtCategorie
            // 
            this.txtCategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorie.Location = new System.Drawing.Point(58, 255);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(320, 21);
            this.txtCategorie.TabIndex = 5;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(56, 225);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(60, 15);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Catégorie";
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(57, 189);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(321, 21);
            this.txtStock.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(55, 159);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(53, 15);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Quantité";
            // 
            // txtIngredient
            // 
            this.txtIngredient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredient.Location = new System.Drawing.Point(57, 123);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(321, 21);
            this.txtIngredient.TabIndex = 1;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.Location = new System.Drawing.Point(55, 93);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(34, 15);
            this.lblIngredient.TabIndex = 0;
            this.lblIngredient.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // txtIdStock
            // 
            this.txtIdStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStock.Location = new System.Drawing.Point(57, 52);
            this.txtIdStock.Name = "txtIdStock";
            this.txtIdStock.Size = new System.Drawing.Size(321, 21);
            this.txtIdStock.TabIndex = 6;
            // 
            // FormulaireStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormulaireStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTextFormStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveStock;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdStock;
    }
}