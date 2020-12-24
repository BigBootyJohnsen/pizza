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
        public double pizza_count = 0; // Gibt an wie viele Pizzen wir haben.
        public double pizza_click = 1; // Gibt an wie viele Pizzen ein Click auf den Button gibt.
        public double pizza_cpt = 0; // Gibt an wie viele Clicks man pro Sekunde bekommt. (Autoclicks) (clicks per time)    

        //cpt costs
        public double pizza_cpt1_cost = 15;
        public double pizza_cpt2_cost = 100;
        public double pizza_cpt3_cost = 1100;
        public double pizza_cpt4_cost = 12000;
        public double pizza_cpt5_cost = 130000;
        public double pizza_cpt6_cost = 1400000;
        public double pizza_cpt7_cost = 20000000;
        public double pizza_cpt8_cost = 330000000;
        public double pizza_cpt9_cost = 510000000;
        public double pizza_cpt10_cost = 75000000000;
        public double pizza_cpt11_cost = 1000000000000;
        public double pizza_cpt12_cost = 14000000000000;
        public double pizza_cpt13_cost = 170000000000000;
        public double pizza_cpt14_cost = 2100000000000000;

        //cpt anzahl
        public double pizza_cpt1_number = 0;
        public double pizza_cpt2_number = 0;
        public double pizza_cpt3_number = 0;
        public double pizza_cpt4_number = 0;
        public double pizza_cpt5_number = 0;
        public double pizza_cpt6_number = 0;
        public double pizza_cpt7_number = 0;
        public double pizza_cpt8_number = 0;
        public double pizza_cpt9_number = 0;
        public double pizza_cpt10_number = 0;
        public double pizza_cpt11_number = 0;
        public double pizza_cpt12_number = 0;
        public double pizza_cpt13_number = 0;
        public double pizza_cpt14_number = 0;

        //cpt multiplyer
        //was man bekommt
        public double pizza_cpt1_pizzen = 1;
        public double pizza_cpt2_pizzen = 1;
        public double pizza_cpt3_pizzen = 8;
        public double pizza_cpt4_pizzen = 47;
        public double pizza_cpt5_pizzen = 260;
        public double pizza_cpt6_pizzen = 1400;
        public double pizza_cpt7_pizzen = 7800;
        public double pizza_cpt8_pizzen = 44000;
        public double pizza_cpt9_pizzen = 260000;
        public double pizza_cpt10_pizzen = 1600000;
        public double pizza_cpt11_pizzen = 10000000;
        public double pizza_cpt12_pizzen = 65000000;
        public double pizza_cpt13_pizzen = 430000000;
        public double pizza_cpt14_pizzen = 29000000000;



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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//Schliest das fenster
        }

        private void timer_test_Tick(object sender, EventArgs e)
        {
            pizza_count += pizza_cpt / 20; // cpt wird hinzugegeben 
            lblPizza_count.Text = "Pizzen: " + Convert.ToInt64(pizza_count);

            lbl_cpt_ps.Text = "Pizzen/s: " + Convert.ToString(pizza_cpt);//wie viele pizzen pro sekunde produziert werden
        }


        private void shop_cpt2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt2_cost)
            {
                pizza_cpt += pizza_cpt2_pizzen; //dem gesamtem cpt wird der cpt des gekauften hinzugefügt 
                pizza_count -= pizza_cpt2_cost;
                pizza_cpt2_number++;
                pizza_cpt2_cost = Convert.ToInt64(pizza_cpt2_cost * 1.15);

                //gibt die infos über das cpt weiter an die lbl
                lbl_cpt2_number.Text = Convert.ToString(pizza_cpt2_number);
                lbl_cpt2_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                lbl_cpt2_cost.Text = Convert.ToString(pizza_cpt2_cost);

            }
        }

        private void shop_cpt3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt3_cost)
            {
                pizza_cpt += pizza_cpt3_pizzen; //dem gesamtem cpt wird der cpt des gekauften hinzugefügt 
                pizza_cpt3_number++;
                pizza_count -= pizza_cpt3_cost;
                pizza_cpt3_cost = Convert.ToInt64(Convert.ToDouble(pizza_cpt3_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;

                //gibt die infos über das cpt weiter an die lbl
                lbl_cpt3_number.Text = Convert.ToString(pizza_cpt3_number);
                lbl_cpt3_pizzen.Text = Convert.ToString(pizza_cpt3_pizzen);
                lbl_cpt3_cost.Text = Convert.ToString(pizza_cpt3_cost);
            }
        }

        private void shop_cpt4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt4_cost)
            {
                pizza_cpt += pizza_cpt4_pizzen; //dem gesamtem cpt wird der cpt des gekauften hinzugefügt 
                pizza_cpt4_number++;
                pizza_count -= pizza_cpt4_cost;
                pizza_cpt4_cost = Convert.ToInt64(Convert.ToDouble(pizza_cpt4_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;

                //gibt die infos über das cpt weiter an die lbl
                lbl_cpt4_number.Text = Convert.ToString(pizza_cpt4_number);
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt4_pizzen);
                lbl_cpt4_cost.Text = Convert.ToString(pizza_cpt4_cost);
            }
        }



        private void btn_click_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000)
            {
                pizza_click = pizza_click + (pizza_click * 1.01);
                btn_click_up1.Visible = false;
            }
        }

        private void btn_click_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 5000000)
            {
                pizza_click = pizza_click + (pizza_click * 1.01);
                btn_click_up1.Visible = false;

            }
        }

        private void btn_click_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 500000000)
            {
                pizza_click = pizza_click + (pizza_click * 1.01);
                btn_click_up1.Visible = false;

            }
        }

        private void btn_click_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000000000)
            {
                pizza_click = pizza_click + (pizza_click * 1.01);
                btn_click_up1.Visible = false;

            }
        }
    }
}
//jayden hat ein geilen lsdefgiouv8s9doynhizgtfisgsghjsrgusicogzbshzfubsizfgtszfuilsfbgsufhjsikiongding dog
