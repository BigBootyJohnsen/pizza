﻿using System;
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
        public long pizza_cpt = 0; // Gibt an wie viele Clicks man pro Sekunde bekommt. (Autoclicks) (clicks per time)    

        //cpt costs
        public long pizza_cpt1_cost = 15;
        public long pizza_cpt2_cost = 100;
        public long pizza_cpt3_cost = 1100;
        public long pizza_cpt4_cost = 12000;
        public long pizza_cpt5_cost = 130000;
        public long pizza_cpt6_cost = 1400000;
        public long pizza_cpt7_cost = 20000000;
        public long pizza_cpt8_cost = 330000000;
        public long pizza_cpt9_cost = 510000000;
        public long pizza_cpt10_cost = 75000000000;
        public long pizza_cpt11_cost = 1000000000000;
        public long pizza_cpt12_cost = 14000000000000;
        public long pizza_cpt13_cost = 170000000000000;
        public long pizza_cpt14_cost = 2100000000000000;

        //cpt anzahl
        public int pizza_cpt1_number = 0;
        public int pizza_cpt2_number = 0;
        public int pizza_cpt3_number = 0;
        public int pizza_cpt4_number = 0;
        public int pizza_cpt5_number = 0;
        public int pizza_cpt6_number = 0;
        public int pizza_cpt7_number = 0;
        public int pizza_cpt8_number = 0;
        public int pizza_cpt9_number = 0;
        public int pizza_cpt10_number = 0;
        public int pizza_cpt11_number = 0;
        public int pizza_cpt12_number = 0;
        public int pizza_cpt13_number = 0;
        public int pizza_cpt14_number = 0;

        //cpt multiplyer
        //ist dann für die upgrades der cpt's
        public int pizza_cpt1_multiplier = 0;
        public int pizza_cpt2_multiplier = 0;
        public int pizza_cpt3_multiplier = 0;
        public int pizza_cpt4_multiplier = 0;
        public int pizza_cpt5_multiplier = 0;
        public int pizza_cpt6_multiplier = 0;
        public int pizza_cpt7_multiplier = 0;
        public int pizza_cpt8_multiplier = 0;
        public int pizza_cpt9_multiplier = 0;
        public int pizza_cpt10_multiplier = 0;
        public int pizza_cpt11_multiplier = 0;
        public int pizza_cpt12_multiplier = 0;
        public int pizza_cpt13_multiplier = 0;
        public int pizza_cpt14_multiplier = 0;



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


        private void shop_cpt2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt2_cost)
            {
                pizza_cpt += 1;
                pizza_count -= pizza_cpt2_cost;
                pizza_cpt2_number++;
                pizza_cpt2_cost = Convert.ToInt64(Convert.ToDouble(pizza_cpt2_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;
            }
        }

        private void shop_cpt3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt3_cost)
            {
                pizza_cpt += 8;
                pizza_cpt3_number++;
                pizza_count -= pizza_cpt3_cost;
                pizza_cpt3_cost = Convert.ToInt64(Convert.ToDouble(pizza_cpt3_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;
            }
        }




    }
}
//jayden hat ein geilen lsdefgiouv8s9doynhizgtfisgsghjsrgusicogzbshzfubsizfgtszfuilsfbgsufhjsikiongding dog
