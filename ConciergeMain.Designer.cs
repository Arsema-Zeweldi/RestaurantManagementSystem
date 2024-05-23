namespace RestaurantReservationAndOrderingSystem
{
    partial class ConciergeMain
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
            this.AddNewButton = new System.Windows.Forms.Button();
            this.ViewExistingButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewButton
            // 
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.Location = new System.Drawing.Point(65, 196);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(258, 44);
            this.AddNewButton.TabIndex = 0;
            this.AddNewButton.Text = "Add New Reservation";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewExistingButton
            // 
            this.ViewExistingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewExistingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewExistingButton.Location = new System.Drawing.Point(430, 196);
            this.ViewExistingButton.Name = "ViewExistingButton";
            this.ViewExistingButton.Size = new System.Drawing.Size(258, 44);
            this.ViewExistingButton.TabIndex = 1;
            this.ViewExistingButton.Text = "View Existing Reservations";
            this.ViewExistingButton.UseVisualStyleBackColor = true;
            this.ViewExistingButton.Click += new System.EventHandler(this.ViewExistingButton_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.Location = new System.Drawing.Point(700, 415);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(75, 23);
            this.SignOutButton.TabIndex = 4;
            this.SignOutButton.Text = "Sign out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // ConciergeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.ViewExistingButton);
            this.Controls.Add(this.AddNewButton);
            this.Name = "ConciergeMain";
            this.Text = "ConciergeMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button ViewExistingButton;
        private System.Windows.Forms.Button SignOutButton;
    }
}