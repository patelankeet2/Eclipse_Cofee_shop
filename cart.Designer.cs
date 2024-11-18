namespace Eclipse_Cofee_shop
{
    partial class cart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.viewCard = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.tableReservation = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.card = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.edit,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(234, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(732, 404);
            this.dataGridView1.TabIndex = 25;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.edit.HeaderText = "EDIT";
            this.edit.Name = "edit";
            this.edit.Text = "EDIT";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.HeaderText = "DELETE";
            this.delete.Name = "delete";
            this.delete.Text = "DELETE";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(707, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 51);
            this.button2.TabIndex = 24;
            this.button2.Text = "Add To Payment ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(237, 504);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 51);
            this.progressBar1.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.viewCard);
            this.panel4.Controls.Add(this.panel17);
            this.panel4.Controls.Add(this.dashboard);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 68);
            this.panel4.TabIndex = 22;
            // 
            // viewCard
            // 
            this.viewCard.BackColor = System.Drawing.Color.Lime;
            this.viewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCard.Location = new System.Drawing.Point(211, 9);
            this.viewCard.Name = "viewCard";
            this.viewCard.Size = new System.Drawing.Size(259, 51);
            this.viewCard.TabIndex = 15;
            this.viewCard.Text = "View Cart";
            this.viewCard.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.pictureBox4);
            this.panel17.Location = new System.Drawing.Point(222, 51);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(709, 461);
            this.panel17.TabIndex = 8;
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Location = new System.Drawing.Point(28, 19);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(140, 29);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Controls.Add(this.pictureBox5);
            this.panel19.Controls.Add(this.logOut);
            this.panel19.Controls.Add(this.pictureBox6);
            this.panel19.Controls.Add(this.tableReservation);
            this.panel19.Controls.Add(this.pictureBox7);
            this.panel19.Controls.Add(this.order);
            this.panel19.Controls.Add(this.pictureBox14);
            this.panel19.Controls.Add(this.pictureBox15);
            this.panel19.Controls.Add(this.button1);
            this.panel19.Controls.Add(this.card);
            this.panel19.Controls.Add(this.profile);
            this.panel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel19.Location = new System.Drawing.Point(12, 12);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(213, 543);
            this.panel19.TabIndex = 21;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Yellow;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(23, 492);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(155, 36);
            this.logOut.TabIndex = 5;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            // 
            // tableReservation
            // 
            this.tableReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableReservation.ForeColor = System.Drawing.Color.Blue;
            this.tableReservation.Location = new System.Drawing.Point(0, 255);
            this.tableReservation.Name = "tableReservation";
            this.tableReservation.Size = new System.Drawing.Size(213, 32);
            this.tableReservation.TabIndex = 5;
            this.tableReservation.Text = "      Table Reservation";
            this.tableReservation.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tableReservation.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.Blue;
            this.order.Location = new System.Drawing.Point(0, 216);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(213, 33);
            this.order.TabIndex = 4;
            this.order.Text = "      Order";
            this.order.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.order.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(0, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "      Menu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // card
            // 
            this.card.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card.ForeColor = System.Drawing.Color.Blue;
            this.card.Location = new System.Drawing.Point(0, 177);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(213, 33);
            this.card.TabIndex = 3;
            this.card.Text = "      Cart";
            this.card.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.card.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            this.profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.ForeColor = System.Drawing.Color.Blue;
            this.profile.Location = new System.Drawing.Point(0, 100);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(213, 34);
            this.profile.TabIndex = 0;
            this.profile.Text = "      Profile";
            this.profile.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.profile.UseVisualStyleBackColor = true;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(-378, -32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(349, 548);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Eclipse_Cofee_shop.Properties.Resources.table_logo;
            this.pictureBox5.Location = new System.Drawing.Point(0, 255);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Eclipse_Cofee_shop.Properties.Resources.order_logo;
            this.pictureBox6.Location = new System.Drawing.Point(0, 216);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Eclipse_Cofee_shop.Properties.Resources.card_logo;
            this.pictureBox7.Location = new System.Drawing.Point(0, 177);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Eclipse_Cofee_shop.Properties.Resources.menu_logo;
            this.pictureBox14.Location = new System.Drawing.Point(0, 138);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(28, 33);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 6;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Eclipse_Cofee_shop.Properties.Resources.profile_logo;
            this.pictureBox15.Location = new System.Drawing.Point(0, 100);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(28, 34);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 1;
            this.pictureBox15.TabStop = false;
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button viewCard;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label dashboard;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button tableReservation;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button card;
        private System.Windows.Forms.Button profile;
    }
}