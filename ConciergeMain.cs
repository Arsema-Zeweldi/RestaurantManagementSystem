using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantReservationAndOrderingSystem
{
    public partial class ConciergeMain : Form
    {
        public ConciergeMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concierge c = new Concierge();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void ViewExistingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConciergeView cv = new ConciergeView();
            cv.Show();
        }
    }
}
