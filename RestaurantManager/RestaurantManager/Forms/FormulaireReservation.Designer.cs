namespace RestaurantManager.Forms
{
    partial class FormulaireReservation
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
            this.lblTextFormReservation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveReservation = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.lblNumTable = new System.Windows.Forms.Label();
            this.txtPersonnes = new System.Windows.Forms.TextBox();
            this.lblNbrPersonnes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.lblTextFormReservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 102);
            this.panel1.TabIndex = 2;
            // 
            // lblTextFormReservation
            // 
            this.lblTextFormReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextFormReservation.AutoSize = true;
            this.lblTextFormReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFormReservation.ForeColor = System.Drawing.Color.White;
            this.lblTextFormReservation.Location = new System.Drawing.Point(154, 38);
            this.lblTextFormReservation.Name = "lblTextFormReservation";
            this.lblTextFormReservation.Size = new System.Drawing.Size(196, 22);
            this.lblTextFormReservation.TabIndex = 0;
            this.lblTextFormReservation.Text = "Ajouter une réservation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSaveReservation);
            this.panel2.Controls.Add(this.txtClient);
            this.panel2.Controls.Add(this.lblClient);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.txtTable);
            this.panel2.Controls.Add(this.lblNumTable);
            this.panel2.Controls.Add(this.txtPersonnes);
            this.panel2.Controls.Add(this.lblNbrPersonnes);
            this.panel2.Location = new System.Drawing.Point(37, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 501);
            this.panel2.TabIndex = 3;
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnSaveReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveReservation.FlatAppearance.BorderSize = 0;
            this.btnSaveReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReservation.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReservation.ForeColor = System.Drawing.Color.White;
            this.btnSaveReservation.Location = new System.Drawing.Point(59, 369);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(101, 36);
            this.btnSaveReservation.TabIndex = 0;
            this.btnSaveReservation.Text = "Ajouter";
            this.btnSaveReservation.UseVisualStyleBackColor = false;
            this.btnSaveReservation.Click += new System.EventHandler(this.btnSaveReservation_Click_1);
            // 
            // txtClient
            // 
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(57, 321);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(321, 21);
            this.txtClient.TabIndex = 7;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(55, 291);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(38, 15);
            this.lblClient.TabIndex = 6;
            this.lblClient.Text = "Client";
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(58, 255);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(320, 21);
            this.txtDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(56, 225);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 15);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date et heure";
            // 
            // txtTable
            // 
            this.txtTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTable.Location = new System.Drawing.Point(57, 189);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(321, 21);
            this.txtTable.TabIndex = 3;
            // 
            // lblNumTable
            // 
            this.lblNumTable.AutoSize = true;
            this.lblNumTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTable.Location = new System.Drawing.Point(55, 159);
            this.lblNumTable.Name = "lblNumTable";
            this.lblNumTable.Size = new System.Drawing.Size(55, 15);
            this.lblNumTable.TabIndex = 2;
            this.lblNumTable.Text = "N° Table";
            // 
            // txtPersonnes
            // 
            this.txtPersonnes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonnes.Location = new System.Drawing.Point(57, 123);
            this.txtPersonnes.Name = "txtPersonnes";
            this.txtPersonnes.Size = new System.Drawing.Size(321, 21);
            this.txtPersonnes.TabIndex = 1;
            // 
            // lblNbrPersonnes
            // 
            this.lblNbrPersonnes.AutoSize = true;
            this.lblNbrPersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrPersonnes.Location = new System.Drawing.Point(55, 93);
            this.lblNbrPersonnes.Name = "lblNbrPersonnes";
            this.lblNbrPersonnes.Size = new System.Drawing.Size(130, 15);
            this.lblNbrPersonnes.TabIndex = 0;
            this.lblNbrPersonnes.Text = "Nombre de personnes";
            // 
            // FormulaireReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormulaireReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireReservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTextFormReservation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveReservation;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label lblNumTable;
        private System.Windows.Forms.TextBox txtPersonnes;
        private System.Windows.Forms.Label lblNbrPersonnes;
    }
}