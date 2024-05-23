namespace RestaurantReservationAndOrderingSystem
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Reservations = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Customers = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Staff = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Reports = new System.Windows.Forms.TabPage();
            this.chartCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMoneyEarned = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartReservations = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Settings = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.AddStaffButton = new System.Windows.Forms.Button();
            this.DeleteStaffButton = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.Reservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyEarned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReservations)).BeginInit();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Dashboard);
            this.Tabs.Controls.Add(this.Reservations);
            this.Tabs.Controls.Add(this.Orders);
            this.Tabs.Controls.Add(this.Customers);
            this.Tabs.Controls.Add(this.Menu);
            this.Tabs.Controls.Add(this.Staff);
            this.Tabs.Controls.Add(this.Reports);
            this.Tabs.Controls.Add(this.Settings);
            this.Tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(4, 4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(775, 455);
            this.Tabs.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.progressBar1);
            this.Dashboard.Controls.Add(this.monthCalendar1);
            this.Dashboard.Location = new System.Drawing.Point(4, 25);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(767, 358);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(297, 76);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 80);
            this.progressBar1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Reservations
            // 
            this.Reservations.Controls.Add(this.dataGridView1);
            this.Reservations.Location = new System.Drawing.Point(4, 25);
            this.Reservations.Name = "Reservations";
            this.Reservations.Padding = new System.Windows.Forms.Padding(3);
            this.Reservations.Size = new System.Drawing.Size(767, 358);
            this.Reservations.TabIndex = 1;
            this.Reservations.Text = "Reservations";
            this.Reservations.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.dataGridView2);
            this.Orders.Location = new System.Drawing.Point(4, 25);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(767, 358);
            this.Orders.TabIndex = 2;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(754, 345);
            this.dataGridView2.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.dataGridView3);
            this.Customers.Location = new System.Drawing.Point(4, 25);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(767, 358);
            this.Customers.TabIndex = 3;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(755, 346);
            this.dataGridView3.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.dataGridView4);
            this.Menu.Location = new System.Drawing.Point(4, 25);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3);
            this.Menu.Size = new System.Drawing.Size(767, 358);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(7, 7);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(754, 348);
            this.dataGridView4.TabIndex = 0;
            // 
            // Staff
            // 
            this.Staff.Controls.Add(this.DeleteStaffButton);
            this.Staff.Controls.Add(this.AddStaffButton);
            this.Staff.Controls.Add(this.dataGridView5);
            this.Staff.Location = new System.Drawing.Point(4, 25);
            this.Staff.Name = "Staff";
            this.Staff.Padding = new System.Windows.Forms.Padding(3);
            this.Staff.Size = new System.Drawing.Size(767, 426);
            this.Staff.TabIndex = 5;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(7, 7);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(754, 345);
            this.dataGridView5.TabIndex = 0;
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.chartCustomers);
            this.Reports.Controls.Add(this.chartMoneyEarned);
            this.Reports.Controls.Add(this.chartReservations);
            this.Reports.Location = new System.Drawing.Point(4, 25);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(767, 358);
            this.Reports.TabIndex = 6;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // chartCustomers
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCustomers.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCustomers.Legends.Add(legend4);
            this.chartCustomers.Location = new System.Drawing.Point(616, 7);
            this.chartCustomers.Name = "chartCustomers";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCustomers.Series.Add(series4);
            this.chartCustomers.Size = new System.Drawing.Size(300, 300);
            this.chartCustomers.TabIndex = 2;
            this.chartCustomers.Text = "chart3";
            // 
            // chartMoneyEarned
            // 
            chartArea5.Name = "ChartArea1";
            this.chartMoneyEarned.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartMoneyEarned.Legends.Add(legend5);
            this.chartMoneyEarned.Location = new System.Drawing.Point(309, 6);
            this.chartMoneyEarned.Name = "chartMoneyEarned";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartMoneyEarned.Series.Add(series5);
            this.chartMoneyEarned.Size = new System.Drawing.Size(300, 300);
            this.chartMoneyEarned.TabIndex = 1;
            this.chartMoneyEarned.Text = "chart2";
            // 
            // chartReservations
            // 
            chartArea6.Name = "ChartArea1";
            this.chartReservations.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartReservations.Legends.Add(legend6);
            this.chartReservations.Location = new System.Drawing.Point(3, 6);
            this.chartReservations.Name = "chartReservations";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartReservations.Series.Add(series6);
            this.chartReservations.Size = new System.Drawing.Size(300, 300);
            this.chartReservations.TabIndex = 0;
            this.chartReservations.Text = "chart1";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.button1);
            this.Settings.Controls.Add(this.button3);
            this.Settings.Controls.Add(this.button2);
            this.Settings.Controls.Add(this.Reset);
            this.Settings.Location = new System.Drawing.Point(4, 25);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(767, 358);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(39, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add New Staff";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(39, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add new Tables";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Location = new System.Drawing.Point(39, 292);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(239, 37);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Finish Daily transactions";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Location = new System.Drawing.Point(226, 373);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(127, 47);
            this.AddStaffButton.TabIndex = 1;
            this.AddStaffButton.Text = "Add New Staff";
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // DeleteStaffButton
            // 
            this.DeleteStaffButton.Location = new System.Drawing.Point(507, 373);
            this.DeleteStaffButton.Name = "DeleteStaffButton";
            this.DeleteStaffButton.Size = new System.Drawing.Size(118, 47);
            this.DeleteStaffButton.TabIndex = 2;
            this.DeleteStaffButton.Text = "Delete Staff";
            this.DeleteStaffButton.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.Tabs);
            this.Name = "Admin";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Tabs.ResumeLayout(false);
            this.Dashboard.ResumeLayout(false);
            this.Reservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Staff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.Reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyEarned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReservations)).EndInit();
            this.Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.TabPage Reservations;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage Staff;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReservations;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoneyEarned;
        private System.Windows.Forms.Button DeleteStaffButton;
        private System.Windows.Forms.Button AddStaffButton;
    }
}