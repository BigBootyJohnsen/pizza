using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Pizza_Clicker_WhoaGeilEy
{
    public partial class Form1 : Form
    {
        public long pizza_count = 0; // Gibt an wie viele Pizzen wir haben.
        public long pizza_click = 1; // Gibt an wie viele Pizzen ein Click auf den Button gibt.
        public long pizza_cpt = 1; // Gibt an wie viele Clicks man pro Sekunde bekommt. (Autoclicks) (clicks per time)    


        public long pizza_up1_cost = 15;
        public long pizza_up2_cost = 100;
        public long pizza_up3_cost = 1100;
        public long pizza_up4_cost = 12000;
        public long pizza_up5_cost = 130000;
        public long pizza_up6_cost = 1400000;
        public long pizza_up7_cost = 20000000;
        public long pizza_up8_cost = 330000000;
        public long pizza_up9_cost = 510000000;
        public long pizza_up10_cost = 75000000000;
        public long pizza_up11_cost = 1000000000000;
        public long pizza_up12_cost = 14000000000000;
        public long pizza_up13_cost = 170000000000000;
        public long pizza_up14_cost = 2100000000000000;


        // Timer value
        public TimeSpan timeLeft;


        public Form1()
        {
            InitializeComponent();
            timer_test.Start(); // startet den timer(den Zähler)
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            pizza_count += pizza_click; // = pizza_count = pizza_count + pizza_click;
            lblPizza_count.Text = "Pizzen: " + pizza_count;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_test_Tick(object sender, EventArgs e)
        {
            pizza_count += pizza_cpt; // cpt wird hinzugegeben 
            lblPizza_count.Text = "Pizzen: " + pizza_count;
        }


        private void shop_up2_Click_1(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_up2_cost)
            {
                pizza_cpt += 1;
                pizza_count -= pizza_up2_cost;
                pizza_up2_cost = Convert.ToInt64(Convert.ToDouble(pizza_up2_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;
            }
        }

        private void shop_up3_Click_1(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_up3_cost)
            {
                pizza_cpt += 8;
                pizza_count -= pizza_up3_cost;
                pizza_up3_cost = Convert.ToInt64(Convert.ToDouble(pizza_up3_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;
            }
        }
    }
}
//jayden hat ein geilen lsdefgiouv8s9doynhizgtfisgsghjsrgusicogzbshzfubsizfgtszfuilsfbgsufhjsikiongding dog
