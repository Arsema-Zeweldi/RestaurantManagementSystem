namespace RestaurantReservationAndOrderingSystem
{
    partial class Bar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.BarMenuView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Complete = new System.Windows.Forms.Button();
            this.BarOrderView = new System.Windows.Forms.DataGridView();
            this.Signout1 = new System.Windows.Forms.Button();
            this.signout2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarMenuView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarOrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1216, 662);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Signout1);
            this.tabPage1.Controls.Add(this.Delete);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Controls.Add(this.BarMenuView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1208, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(677, 538);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(191, 48);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(384, 538);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(232, 48);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // BarMenuView
            // 
            this.BarMenuView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BarMenuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BarMenuView.Location = new System.Drawing.Point(4, 4);
            this.BarMenuView.Name = "BarMenuView";
            this.BarMenuView.Size = new System.Drawing.Size(1179, 504);
            this.BarMenuView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.signout2);
            this.tabPage2.Controls.Add(this.Complete);
            this.tabPage2.Controls.Add(this.BarOrderView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1208, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Complete
            // 
            this.Complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complete.Location = new System.Drawing.Point(533, 537);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(165, 49);
            this.Complete.TabIndex = 1;
            this.Complete.Text = "Complete";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // BarOrderView
            // 
            this.BarOrderView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BarOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BarOrderView.Location = new System.Drawing.Point(7, 4);
            this.BarOrderView.Name = "BarOrderView";
            this.BarOrderView.Size = new System.Drawing.Size(1176, 517);
            this.BarOrderView.TabIndex = 0;
            // 
            // Signout1
            // 
            this.Signout1.Location = new System.Drawing.Point(1099, 548);
            this.Signout1.Name = "Signout1";
            this.Signout1.Size = new System.Drawing.Size(75, 23);
            this.Signout1.TabIndex = 5;
            this.Signout1.Text = "Sign out";
            this.Signout1.UseVisualStyleBackColor = true;
            this.Signout1.Click += new System.EventHandler(this.Signout1_Click);
            // 
            // signout2
            // 
            this.signout2.Location = new System.Drawing.Point(1103, 552);
            this.signout2.Name = "signout2";
            this.signout2.Size = new System.Drawing.Size(75, 23);
            this.signout2.TabIndex = 2;
            this.signout2.Text = "Sign out";
            this.signout2.UseVisualStyleBackColor = true;
            this.signout2.Click += new System.EventHandler(this.signout2_Click);
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bar";
            this.Text = "Bar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarMenuView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarOrderView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView BarOrderView;
        private System.Windows.Forms.DataGridView BarMenuView;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.Button Signout1;
        private System.Windows.Forms.Button signout2;
    }
}