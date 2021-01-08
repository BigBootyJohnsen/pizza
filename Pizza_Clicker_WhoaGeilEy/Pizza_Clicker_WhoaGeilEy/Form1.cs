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
        public double pizza_only_click = 0; //Gibt an wie viel pizzen nur durch click generiert wurden

        public double cpt1_up4_val = 0; //wird ab cpt1 stufe vier benötigt  

        //cpt costs
        public double pizza_cpt1_cost = 15;                     // Kosten für Unlock 1
        public double pizza_cpt2_cost = 100;                    // Kosten für Unlock 2
        public double pizza_cpt3_cost = 1100;                   // Kosten für Unlock 3
        public double pizza_cpt4_cost = 12000;                  // Kosten für Unlock 4
        public double pizza_cpt5_cost = 130000;                 // Kosten für Unlock 5
        public double pizza_cpt6_cost = 1400000;                // Kosten für Unlock 6
        public double pizza_cpt7_cost = 20000000;               // Kosten für Unlock 7
        public double pizza_cpt8_cost = 330000000;              // Kosten für Unlock 8
        public double pizza_cpt9_cost = 510000000;              // Kosten für Unlock 9
        public double pizza_cpt10_cost = 75000000000;           // Kosten für Unlock 10
        public double pizza_cpt11_cost = 1000000000000;         // Kosten für Unlock 11
        public double pizza_cpt12_cost = 14000000000000;        // Kosten für Unlock 12
        public double pizza_cpt13_cost = 170000000000000;       // Kosten für Unlock 13
        public double pizza_cpt14_cost = 2100000000000000;      // Kosten für Unlock 14

        //cpt anzahl-
        public double pizza_cpt1_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 1
        public double pizza_cpt2_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 2
        public double pizza_cpt3_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 3
        public double pizza_cpt4_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 4
        public double pizza_cpt5_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 5
        public double pizza_cpt6_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 6
        public double pizza_cpt7_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 7
        public double pizza_cpt8_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 8
        public double pizza_cpt9_number = 0;                    // Anzahl der vorhanden cpt für Upgrade 9
        public double pizza_cpt10_number = 0;                   // Anzahl der vorhanden cpt für Upgrade 10
        public double pizza_cpt11_number = 0;                   // Anzahl der vorhanden cpt für Upgrade 11
        public double pizza_cpt12_number = 0;                   // Anzahl der vorhanden cpt für Upgrade 12
        public double pizza_cpt13_number = 0;                   // Anzahl der vorhanden cpt für Upgrade 13
        public double pizza_cpt14_number = 0;                   // Anzahl der vorhanden cpt für Upgrade 14

        //cpt multiplyer
        //was man bekommt
        public double pizza_cpt1_pizzen = 0.1;                  // Was man für das cpt 1 bekommt
        public double pizza_cpt2_pizzen = 1;                    // Was man für das cpt 2 bekommt 
        public double pizza_cpt3_pizzen = 8;                    // Was man für das cpt 3 bekommt 
        public double pizza_cpt4_pizzen = 47;                   // Was man für das cpt 4 bekommt 
        public double pizza_cpt5_pizzen = 260;                  // Was man für das cpt 5 bekommt 
        public double pizza_cpt6_pizzen = 1400;                 // Was man für das cpt 6 bekommt 
        public double pizza_cpt7_pizzen = 7800;                 // Was man für das cpt 7 bekommt 
        public double pizza_cpt8_pizzen = 44000;                // Was man für das cpt 8 bekommt 
        public double pizza_cpt9_pizzen = 260000;               // Was man für das cpt 9 bekommt 
        public double pizza_cpt10_pizzen = 1600000;             // Was man für das cpt 10 bekommt 
        public double pizza_cpt11_pizzen = 10000000;            // Was man für das cpt 11 bekommt 
        public double pizza_cpt12_pizzen = 65000000;            // Was man für das cpt 12 bekommt 
        public double pizza_cpt13_pizzen = 430000000;           // Was man für das cpt 13 bekommt 
        public double pizza_cpt14_pizzen = 29000000000;         // Was man für das cpt 14 bekommt 


        //click up multiplyer
        public double pizza_click_up1_multiplyer = 0;
        public double pizza_click_up2_multiplyer = 0;
        public double pizza_click_up3_multiplyer = 0;
        public double pizza_click_up4_multiplyer = 0;


        public bool pizza_click_up1_display = true;
        public bool pizza_click_up2_display = true;
        public bool pizza_click_up3_display = true;
        public bool pizza_click_up4_display = true;

        public bool pizza_cpt1_up1_display = true;
        public bool pizza_cpt1_up2_display = true;
        public bool pizza_cpt1_up3_display = true;
        public bool pizza_cpt1_up4_display = true;
        public bool pizza_cpt1_up5_display = true;
        public bool pizza_cpt1_up6_display = true;
        public bool pizza_cpt1_up7_display = true;
        public bool pizza_cpt1_up8_display = true;

        public bool pizza_cpt2_up1_display = true;
        public bool pizza_cpt2_up2_display = true;
        public bool pizza_cpt2_up3_display = true;
        public bool pizza_cpt2_up4_display = true;
        public bool pizza_cpt2_up5_display = true;
        public bool pizza_cpt2_up6_display = true;
        public bool pizza_cpt2_up7_display = true;

        public bool pizza_cpt3_up1_display = true;
        public bool pizza_cpt3_up2_display = true;
        public bool pizza_cpt3_up3_display = true;
        public bool pizza_cpt3_up4_display = true;
        public bool pizza_cpt3_up5_display = true;
        public bool pizza_cpt3_up6_display = true;
        public bool pizza_cpt3_up7_display = true;

        public bool pizza_cpt4_up1_display = true;
        public bool pizza_cpt4_up2_display = true;
        public bool pizza_cpt4_up3_display = true;
        public bool pizza_cpt4_up4_display = true;
        public bool pizza_cpt4_up5_display = true;
        public bool pizza_cpt4_up6_display = true;
        public bool pizza_cpt4_up7_display = true;
        public bool pizza_cpt4_up8_display = true;

        public bool pizza_cpt5_up1_display = true;
        public bool pizza_cpt5_up2_display = true;
        public bool pizza_cpt5_up3_display = true;
        public bool pizza_cpt5_up4_display = true;
        public bool pizza_cpt5_up5_display = true;
        public bool pizza_cpt5_up6_display = true;
        public bool pizza_cpt5_up7_display = true;
        public bool pizza_cpt5_up8_display = true;

        public bool pizza_cpt6_up1_display = true;
        public bool pizza_cpt6_up2_display = true;
        public bool pizza_cpt6_up3_display = true;
        public bool pizza_cpt6_up4_display = true;
        public bool pizza_cpt6_up5_display = true;
        public bool pizza_cpt6_up6_display = true;
        public bool pizza_cpt6_up7_display = true;
        public bool pizza_cpt6_up8_display = true;

        public bool pizza_cpt7_up1_display = true;
        public bool pizza_cpt7_up2_display = true;
        public bool pizza_cpt7_up3_display = true;
        public bool pizza_cpt7_up4_display = true;
        public bool pizza_cpt7_up5_display = true;
        public bool pizza_cpt7_up6_display = true;
        public bool pizza_cpt7_up7_display = true;
        public bool pizza_cpt7_up8_display = true;

        public bool pizza_cpt8_up1_display = true;
        public bool pizza_cpt8_up2_display = true;
        public bool pizza_cpt8_up3_display = true;
        public bool pizza_cpt8_up4_display = true;
        public bool pizza_cpt8_up5_display = true;
        public bool pizza_cpt8_up6_display = true;
        public bool pizza_cpt8_up7_display = true;
        public bool pizza_cpt8_up8_display = true;

        // Timer
        public Form1()
        {
            InitializeComponent();
            timer_test.Start(); // startet den timer(den Zähler)
            this.TopMost = true;


        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            pizza_count += (pizza_click + ((pizza_click_up1_multiplyer * pizza_cpt) + (pizza_click_up2_multiplyer * pizza_cpt) + (pizza_click_up3_multiplyer * pizza_cpt) + (pizza_click_up4_multiplyer * pizza_cpt))); // = pizza_count = pizza_count + pizza_click + click_up;


            pizza_only_click += (pizza_click + ((pizza_click_up1_multiplyer * pizza_cpt) + (pizza_click_up2_multiplyer * pizza_cpt) + (pizza_click_up3_multiplyer * pizza_cpt) + (pizza_click_up4_multiplyer * pizza_cpt))); // = pizza_only_click = pizza_count + pizza_click + click_up;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//Schliest das fenster
        }

        private void timer_test_Tick(object sender, EventArgs e)
        {
            //Für zufall 
            //Random rnd = new Random();

            pizza_count += (pizza_cpt) / 20; // cpt wird hinzugegeben 
            lblPizza_count.Text = "Pizzen: " + Convert.ToInt64(pizza_count);

            lbl_cpt_ps.Text = "Pizzen/s: " + Convert.ToString(pizza_cpt);//wie viele pizzen pro sekunde produziert werden



            //anzeige des actuellem pizza_click wertes 
            click.Text = Convert.ToString(pizza_click  + ((pizza_click_up1_multiplyer * pizza_cpt) + (pizza_click_up2_multiplyer * pizza_cpt) + (pizza_click_up3_multiplyer * pizza_cpt) + (pizza_click_up4_multiplyer * pizza_cpt)));


            //anzeigen der upgrade button, wenn die bedingung erfüllt ist
            if ((pizza_click_up1_display == true) && (pizza_only_click >= 1000))
            {
                pnl_click_up1.Visible = true;
            }
            if ((pizza_click_up2_display == true) && (pizza_only_click >= 100000))
            {
                pnl_click_up2.Visible = true;
            }
            if ((pizza_click_up3_display == true) && (pizza_only_click >= 10000000))
            {
                pnl_click_up3.Visible = true;
            }
            if ((pizza_click_up4_display == true) && (pizza_only_click >= 1000000000))
            {
                pnl_click_up4.Visible = true;
            }





            if ((pizza_cpt1_up1_display == true) && (pizza_cpt1_number == 1))
            {
                pnl_cpt1_click_up1.Visible = true;
            }
            if ((pizza_cpt1_up1_display == true) && (pizza_cpt1_number == 1))
            {
                pnl_cpt1_click_up2.Visible = true;
            }
            if ((pizza_cpt1_up1_display == true) && (pizza_cpt1_number == 10))
            {
                pnl_cpt1_click_up3.Visible = true;
            }
            if ((pizza_cpt1_up4_display == true) && (pizza_cpt1_number == 25))
            {
                pnl_cpt1_click_up4.Visible = true;
            }
            if ((pizza_cpt1_up5_display == true) && (pizza_cpt1_number == 50))
            {
                pnl_cpt1_click_up5.Visible = true;
            }
            if ((pizza_cpt1_up6_display == true) && (pizza_cpt1_number == 100))
            {
                pnl_cpt1_click_up6.Visible = true;
            }
            if ((pizza_cpt1_up7_display == true) && (pizza_cpt1_number == 150))
            {
                pnl_cpt1_click_up7.Visible = true;
            }
            if ((pizza_cpt1_up8_display == true) && (pizza_cpt1_number == 200))
            {
                pnl_cpt1_click_up8.Visible = true;
            }
            

            if ((pizza_cpt2_up1_display == true) && (pizza_cpt2_number == 1))
            {
                pnl_cpt2_up1.Visible = true;
            }
            if ((pizza_cpt2_up2_display == true) && (pizza_cpt2_number == 5))
            {
                pnl_cpt2_up2.Visible = true;
            }
            if ((pizza_cpt2_up3_display == true) && (pizza_cpt2_number == 25))
            {
                pnl_cpt2_up3.Visible = true;
            }
            if ((pizza_cpt2_up4_display == true) && (pizza_cpt2_number == 50))
            {
                pnl_cpt2_up4.Visible = true;
            }
            if ((pizza_cpt2_up5_display == true) && (pizza_cpt2_number == 100))
            {
                pnl_cpt2_up5.Visible = true;
            }
            if ((pizza_cpt2_up6_display == true) && (pizza_cpt2_number == 150))
            {
                pnl_cpt2_up6.Visible = true;
            }
            if ((pizza_cpt2_up7_display == true) && (pizza_cpt2_number == 200))
            {
                pnl_cpt2_up7.Visible = true;
            }


            if ((pizza_cpt3_up1_display == true) && (pizza_cpt3_number == 1))
            {
                pnl_cpt3_up1.Visible = true;
            }
            if ((pizza_cpt3_up2_display == true) && (pizza_cpt3_number == 5))
            {
                pnl_cpt3_up2.Visible = true;
            }
            if ((pizza_cpt3_up3_display == true) && (pizza_cpt3_number == 25))
            {
                pnl_cpt3_up3.Visible = true;
            }
            if ((pizza_cpt3_up4_display == true) && (pizza_cpt3_number == 50))
            {
                pnl_cpt3_up4.Visible = true;
            }
            if ((pizza_cpt3_up5_display == true) && (pizza_cpt3_number == 100))
            {
                pnl_cpt3_up5.Visible = true;
            }
            if ((pizza_cpt3_up6_display == true) && (pizza_cpt3_number == 150))
            {
                pnl_cpt3_up6.Visible = true;
            }
            if ((pizza_cpt3_up7_display == true) && (pizza_cpt3_number == 200))
            {
                pnl_cpt3_up7.Visible = true;
            }


            if ((pizza_cpt4_up1_display == true) && (pizza_cpt4_number == 1))
            {
                pnl_cpt4_up1.Visible = true;
            }
            if ((pizza_cpt4_up2_display == true) && (pizza_cpt4_number == 5))
            {
                pnl_cpt4_up2.Visible = true;
            }
            if ((pizza_cpt4_up3_display == true) && (pizza_cpt4_number == 25))
            {
                pnl_cpt4_up3.Visible = true;
            }
            if ((pizza_cpt4_up4_display == true) && (pizza_cpt4_number == 50))
            {
                pnl_cpt4_up4.Visible = true;
            }
            if ((pizza_cpt4_up5_display == true) && (pizza_cpt4_number == 100))
            {
                pnl_cpt4_up5.Visible = true;
            }
            if ((pizza_cpt4_up6_display == true) && (pizza_cpt4_number == 150))
            {
                pnl_cpt4_up6.Visible = true;
            }
            if ((pizza_cpt4_up7_display == true) && (pizza_cpt4_number == 200))
            {
                pnl_cpt4_up7.Visible = true;
            }
            if ((pizza_cpt4_up8_display == true) && (pizza_cpt4_number == 200))
            {
                pnl_cpt4_up8.Visible = true;
            }


            if ((pizza_cpt5_up1_display == true) && (pizza_cpt5_number == 1))
            {
                pnl_cpt5_up1.Visible = true;
            }
            if ((pizza_cpt5_up2_display == true) && (pizza_cpt5_number == 5))
            {
                pnl_cpt5_up2.Visible = true;
            }
            if ((pizza_cpt5_up3_display == true) && (pizza_cpt5_number == 25))
            {
                pnl_cpt5_up3.Visible = true;
            }
            if ((pizza_cpt5_up4_display == true) && (pizza_cpt5_number == 50))
            {
                pnl_cpt5_up4.Visible = true;
            }
            if ((pizza_cpt5_up5_display == true) && (pizza_cpt5_number == 100))
            {
                pnl_cpt5_up5.Visible = true;
            }
            if ((pizza_cpt5_up6_display == true) && (pizza_cpt5_number == 150))
            {
                pnl_cpt5_up6.Visible = true;
            }
            if ((pizza_cpt5_up7_display == true) && (pizza_cpt5_number == 200))
            {
                pnl_cpt5_up7.Visible = true;
            }
            if ((pizza_cpt5_up8_display == true) && (pizza_cpt5_number == 200))
            {
                pnl_cpt5_up8.Visible = true;
            }


            if ((pizza_cpt6_up1_display == true) && (pizza_cpt6_number == 1))
            {
                pnl_cpt6_up1.Visible = true;
            }
            if ((pizza_cpt6_up2_display == true) && (pizza_cpt6_number == 5))
            {
                pnl_cpt6_up2.Visible = true;
            }
            if ((pizza_cpt6_up3_display == true) && (pizza_cpt6_number == 25))
            {
                pnl_cpt6_up3.Visible = true;
            }
            if ((pizza_cpt6_up4_display == true) && (pizza_cpt6_number == 50))
            {
                pnl_cpt6_up4.Visible = true;
            }
            if ((pizza_cpt6_up5_display == true) && (pizza_cpt6_number == 100))
            {
                pnl_cpt6_up5.Visible = true;
            }
            if ((pizza_cpt6_up6_display == true) && (pizza_cpt6_number == 150))
            {
                pnl_cpt6_up6.Visible = true;
            }
            if ((pizza_cpt6_up7_display == true) && (pizza_cpt6_number == 200))
            {
                pnl_cpt6_up7.Visible = true;
            }
            if ((pizza_cpt6_up8_display == true) && (pizza_cpt6_number == 200))
            {
                pnl_cpt6_up8.Visible = true;
            }


            if ((pizza_cpt7_up1_display == true) && (pizza_cpt7_number == 1))
            {
                pnl_cpt7_up1.Visible = true;
            }
            if ((pizza_cpt7_up2_display == true) && (pizza_cpt7_number == 5))
            {
                pnl_cpt7_up2.Visible = true;
            }
            if ((pizza_cpt7_up3_display == true) && (pizza_cpt7_number == 25))
            {
                pnl_cpt7_up3.Visible = true;
            }
            if ((pizza_cpt7_up4_display == true) && (pizza_cpt7_number == 50))
            {
                pnl_cpt7_up4.Visible = true;
            }
            if ((pizza_cpt7_up5_display == true) && (pizza_cpt7_number == 100))
            {
                pnl_cpt7_up5.Visible = true;
            }
            if ((pizza_cpt7_up6_display == true) && (pizza_cpt7_number == 150))
            {
                pnl_cpt7_up6.Visible = true;
            }
            if ((pizza_cpt7_up7_display == true) && (pizza_cpt7_number == 200))
            {
                pnl_cpt7_up7.Visible = true;
            }



            if ((pizza_cpt8_up1_display == true) && (pizza_cpt8_number == 1))
            {
                pnl_cpt8_up1.Visible = true;
            }
            if ((pizza_cpt8_up2_display == true) && (pizza_cpt8_number == 5))
            {
                pnl_cpt8_up2.Visible = true;
            }
            if ((pizza_cpt8_up3_display == true) && (pizza_cpt8_number == 25))
            {
                pnl_cpt8_up3.Visible = true;
            }
            if ((pizza_cpt8_up4_display == true) && (pizza_cpt8_number == 50))
            {
                pnl_cpt8_up4.Visible = true;
            }
            if ((pizza_cpt8_up5_display == true) && (pizza_cpt8_number == 100))
            {
                pnl_cpt8_up5.Visible = true;
            }
            if ((pizza_cpt8_up6_display == true) && (pizza_cpt8_number == 150))
            {
                pnl_cpt8_up6.Visible = true;
            }
  

            /*
            int x = move.Left;
            int y = move.Top;
            move.Left = x + rnd.Next(-30, 30);
            move.Top = y + rnd.Next ( 5, 7);
            */
        }





        //shop
        private void shop_cpt1_Click_1(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt1_cost)
            {
                pizza_cpt += pizza_cpt1_pizzen; //dem gesamtem cpt wird der cpt des gekauften hinzugefügt 
                pizza_count -= pizza_cpt1_cost;
                pizza_cpt1_number++;
                pizza_cpt1_cost = Convert.ToInt64(pizza_cpt1_cost * 1.15);

                //gibt die infos über das cpt weiter an die lbl
                lbl_cpt1_number.Text = Convert.ToString(pizza_cpt1_number);
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                lbl_cpt1_cost.Text = Convert.ToString(pizza_cpt1_cost);

            }
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

        private void shop_cpt5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt5_cost)
            {
                pizza_cpt += pizza_cpt5_pizzen; //dem gesamtem cpt wird der cpt des gekauften hinzugefügt 
                pizza_cpt5_number++;
                pizza_count -= pizza_cpt5_cost;
                pizza_cpt5_cost = Convert.ToInt64(Convert.ToDouble(pizza_cpt5_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;

                //gibt die infos über das cpt weiter an die lbl
                lbl_cpt5_number.Text = Convert.ToString(pizza_cpt5_number);
                lbl_cpt5_pizzen.Text = Convert.ToString(pizza_cpt5_pizzen);
                lbl_cpt5_cost.Text = Convert.ToString(pizza_cpt5_cost);
            }
        }
        private void shop_cpt6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt6_cost)
            {
                pizza_cpt += pizza_cpt6_pizzen; //dem gesamtem cpt wird der cpt des gekauften hinzugefügt 
                pizza_cpt6_number++;
                pizza_count -= pizza_cpt6_cost;
                pizza_cpt6_cost = Convert.ToInt64(Convert.ToDouble(pizza_cpt6_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;

                //gibt die infos über das cpt weiter an die lbl
                lbl_cpt6_number.Text = Convert.ToString(pizza_cpt6_number);
                lbl_cpt6_pizzen.Text = Convert.ToString(pizza_cpt6_pizzen);
                lbl_cpt6_cost.Text = Convert.ToString(pizza_cpt6_cost);
            }
        }

        private void shop_cpt7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt7_cost)
            {
                pizza_cpt += pizza_cpt7_pizzen; //dem gesamtem cpt wird der cpt des gekauften hinzugefügt 
                pizza_cpt7_number++;
                pizza_count -= pizza_cpt7_cost;
                pizza_cpt7_cost = Convert.ToInt64(Convert.ToDouble(pizza_cpt7_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;

                //gibt die infos über das cpt weiter an die lbl
                lbl_cpt7_number.Text = Convert.ToString(pizza_cpt7_number);
                lbl_cpt7_pizzen.Text = Convert.ToString(pizza_cpt7_pizzen);
                lbl_cpt7_cost.Text = Convert.ToString(pizza_cpt7_cost);
            }
        }

        private void shop_cpt8_Click(object sender, EventArgs e)
        {
            if (pizza_count >= pizza_cpt8_cost)
            {
                pizza_cpt += pizza_cpt8_pizzen; //dem gesamtem cpt wird der cpt des gekauften hinzugefügt 
                pizza_cpt8_number++;
                pizza_count -= pizza_cpt8_cost;
                pizza_cpt8_cost = Convert.ToInt64(Convert.ToDouble(pizza_cpt8_cost) * 1.15);
                lblPizza_count.Text = "Pizzen: " + pizza_count;

                //gibt die infos über das cpt weiter an die lbl
                lbl_cpt8_number.Text = Convert.ToString(pizza_cpt8_number);
                lbl_cpt8_pizzen.Text = Convert.ToString(pizza_cpt8_pizzen);
                lbl_cpt8_cost.Text = Convert.ToString(pizza_cpt8_cost);
            }
        }



        //click up
        private void btn_click_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000)
            {
                
                pizza_click_up1_multiplyer = 0.01;
                pnl_click_up1.Visible = false;
                pizza_click_up1_display = false;

            }
        }

        private void btn_click_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 5000000)
            {
                pizza_click_up2_multiplyer = 0.01;
                pnl_click_up2.Visible = false;
                pizza_click_up2_display = false;
            }
        }

        private void btn_click_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 500000000)
            {
                pizza_click_up3_multiplyer = 0.01;
                pnl_click_up3.Visible = false;
                pizza_click_up3_display = false;
            }
        }

        private void btn_click_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000000000)
            {
                pizza_click_up4_multiplyer = 0.01;
                pnl_click_up4.Visible = false;
                pizza_click_up4_display = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pizza_count += 10000000000000;
        }





        //cpt 1 up

        private void btn_cpt1_click_up1_Click_1(object sender, EventArgs e)
        {
            if (pizza_count >= 100)
            {
                pizza_count -= 100;
                pizza_click *= 2;
                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up1.Visible = false;
                pizza_cpt1_up1_display = false;
            }
        }
        private void btn_cpt1_click_up2_Click_1(object sender, EventArgs e)
        {
            if (pizza_count >= 500)
            {
                pizza_count -= 500;
                pizza_click *= 2;
                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up2.Visible = false;
                pizza_cpt1_up2_display = false;

            }
        }

        private void btn_cpt1_click_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 1000)
            {
                pizza_click *= 2;

                pizza_count -= 1000;

                pizza_cpt += (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up3.Visible = false;
                pizza_cpt1_up3_display = false;

            }
        }

        private void btn_cpt1_click_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 100000)
            {
                pizza_click *= 2;
                pizza_count -= 100000;

                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up4.Visible = false;
                pizza_cpt1_up4_display = false;
            }
        }

        private void btn_cpt1_click_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 10000000)
            {
                pizza_click *= 2;
                pizza_count -= 10000000;

                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up5.Visible = false;
                pizza_cpt1_up5_display = false;
            }
        }

        private void btn_cpt1_click_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 100000000)
            {
                pizza_click *= 2;
                pizza_count -= 100000000;

                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up6.Visible = false;
                pizza_cpt1_up6_display = false;
            }
        }

        private void btn_cpt1_click_up7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 1000000000)
            {
                pizza_click *= 2;
                pizza_count -= 1000000000;

                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up7.Visible = false;
                pizza_cpt1_up7_display = false;
            }
        }

        private void btn_cpt1_click_up8_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 10000000000)
            {
                pizza_click *= 2;
                pizza_count -= 10000000000;

                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up8.Visible = false;
                pizza_cpt1_up8_display = false;
            }
        }









        //cpt 2 up
        private void btn_cpt2_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 1000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt2_number * pizza_cpt2_pizzen);
                pizza_cpt2_pizzen *= 2;
                lbl_cpt2_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                pnl_cpt2_up1.Visible = false;
                pizza_cpt2_up1_display = false;
                pizza_count -= 1000;

            }
        }

        private void btn_cpt2_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 5000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt2_number * pizza_cpt2_pizzen);
                pizza_cpt2_pizzen *= 2;
                lbl_cpt2_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                pnl_cpt2_up2.Visible = false;
                pizza_cpt2_up2_display = false;
                pizza_count -= 5000;

            }
        }

        private void btn_cpt2_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt2_number * pizza_cpt2_pizzen);
                pizza_cpt2_pizzen *= 2;
                lbl_cpt2_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                pnl_cpt2_up3.Visible = false;
                pizza_cpt2_up3_display = false;
                pizza_count -= 50000;

            }
        }

        private void btn_cpt2_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 5000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt2_number * pizza_cpt2_pizzen);
                pizza_cpt2_pizzen *= 2;
                lbl_cpt2_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                pnl_cpt2_up3.Visible = false;
                pizza_cpt2_up4_display = false;
                pizza_count -= 5000000;

            }
        }

        private void btn_cpt2_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 500000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt2_number * pizza_cpt2_pizzen);
                pizza_cpt2_pizzen *= 2;
                lbl_cpt2_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                pnl_cpt2_up5.Visible = false;
                pizza_cpt2_up5_display = false;
                pizza_count -= 500000000;

            }
        }

        private void btn_cpt2_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt2_number * pizza_cpt2_pizzen);
                pizza_cpt2_pizzen *= 2;
                lbl_cpt2_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                pnl_cpt2_up6.Visible = false;
                pizza_cpt2_up6_display = false;
                pizza_count -= 50000000000;

            }
        }

        private void btn_cpt2_up7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt2_number * pizza_cpt2_pizzen);
                pizza_cpt2_pizzen *= 2;
                lbl_cpt2_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                pnl_cpt2_up7.Visible = false;
                pizza_cpt2_up7_display = false;
                pizza_count -= 50000000000000;

            }
        }





        //cpt3 up
        private void btn_cpt3_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 11000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt3_number * pizza_cpt3_pizzen);
                pizza_cpt3_pizzen *= 2;
                lbl_cpt3_pizzen.Text = Convert.ToString(pizza_cpt3_pizzen);
                pnl_cpt3_up1.Visible = false;
                pizza_cpt3_up1_display = false;

                pizza_count -= 11000;

            }
        }

        private void btn_cpt3_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt3_number * pizza_cpt3_pizzen);
                pizza_cpt3_pizzen *= 2;
                lbl_cpt3_pizzen.Text = Convert.ToString(pizza_cpt3_pizzen);
                pnl_cpt3_up2.Visible = false;
                pizza_count -= 50000;
                pizza_cpt3_up2_display = false;

            }
        }

        private void btn_cpt3_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 550000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt3_number * pizza_cpt3_pizzen);
                pizza_cpt3_pizzen *= 2;
                lbl_cpt3_pizzen.Text = Convert.ToString(pizza_cpt3_pizzen);
                pnl_cpt3_up3.Visible = false;
                pizza_count -= 550000;
                pizza_cpt3_up3_display = false;

            }
        }

        private void btn_cpt3_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 55000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt3_number * pizza_cpt3_pizzen);
                pizza_cpt3_pizzen *= 2;
                lbl_cpt3_pizzen.Text = Convert.ToString(pizza_cpt3_pizzen);
                pnl_cpt3_up4.Visible = false;
                pizza_count -= 55000000;
                pizza_cpt3_up4_display = false;

            }
        }

        private void btn_cpt3_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 5500000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt3_number * pizza_cpt3_pizzen);
                pizza_cpt3_pizzen *= 2;
                lbl_cpt3_pizzen.Text = Convert.ToString(pizza_cpt3_pizzen);
                pnl_cpt3_up5.Visible = false;
                pizza_count -= 5500000000;
                pizza_cpt3_up5_display = false;

            }
        }

        private void btn_cpt3_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 550000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt3_number * pizza_cpt3_pizzen);
                pizza_cpt3_pizzen *= 2;
                lbl_cpt3_pizzen.Text = Convert.ToString(pizza_cpt3_pizzen);
                pnl_cpt3_up6.Visible = false;
                pizza_count -= 550000000000;
                pizza_cpt3_up6_display = false;

            }
        }

        private void btn_cpt3_up7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 550000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt3_number * pizza_cpt3_pizzen);
                pizza_cpt3_pizzen *= 2;
                lbl_cpt3_pizzen.Text = Convert.ToString(pizza_cpt3_pizzen);
                pnl_cpt3_up7.Visible = false;
                pizza_count -= 550000000000000;
                pizza_cpt3_up7_display = false;

            }
        }

        private void btn_cpt4_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 120000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt4_number * pizza_cpt4_pizzen);
                pizza_cpt4_pizzen *= 2;
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt2_pizzen);
                pnl_cpt4_up1.Visible = false;
                pizza_cpt4_up1_display = false;
                pizza_count -= 120000;
            }
        }

        private void btn_cpt4_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 600000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt4_number * pizza_cpt4_pizzen);
                pizza_cpt4_pizzen *= 2;
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt4_pizzen);
                pnl_cpt4_up2.Visible = false;
                pizza_cpt4_up2_display = false;
                pizza_count -= 600000;
            }
        }

        private void btn_cpt4_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 6000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt4_number * pizza_cpt4_pizzen);
                pizza_cpt4_pizzen *= 2;
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt4_pizzen);
                pnl_cpt4_up3.Visible = false;
                pizza_cpt4_up3_display = false;
                pizza_count -= 6000000;
            }
        }

        private void btn_cpt4_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 600000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt4_number * pizza_cpt4_pizzen);
                pizza_cpt4_pizzen *= 2;
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt4_pizzen);
                pnl_cpt4_up4.Visible = false;
                pizza_cpt4_up4_display = false;
                pizza_count -= 600000000;
            }
        }

        private void btn_cpt4_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 60000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt4_number * pizza_cpt4_pizzen);
                pizza_cpt4_pizzen *= 2;
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt4_pizzen);
                pnl_cpt4_up5.Visible = false;
                pizza_cpt4_up5_display = false;
                pizza_count -= 60000000000;
            }
        }

        private void btn_cpt4_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 6000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt4_number * pizza_cpt4_pizzen);
                pizza_cpt4_pizzen *= 2;
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt4_pizzen);
                pnl_cpt4_up6.Visible = false;
                pizza_cpt4_up6_display = false;
                pizza_count -= 6000000000000;
            }
        }

        private void btn_cpt4_up7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 6000000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt4_number * pizza_cpt4_pizzen);
                pizza_cpt4_pizzen *= 2;
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt4_pizzen);
                pnl_cpt4_up7.Visible = false;
                pizza_cpt4_up7_display = false;
                pizza_count -= 6000000000000000;
            }
        }

        private void btn_cpt4_up8_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 6000000000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt4_number * pizza_cpt4_pizzen);
                pizza_cpt4_pizzen *= 2;
                lbl_cpt4_pizzen.Text = Convert.ToString(pizza_cpt4_pizzen);
                pnl_cpt4_up8.Visible = false;
                pizza_cpt4_up8_display = false;
                pizza_count -= 6000000000000000000;
            }
        }









        private void btn_cpt5_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 1300000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt5_number * pizza_cpt5_pizzen);
                pizza_cpt5_pizzen *= 2;
                lbl_cpt5_pizzen.Text = Convert.ToString(pizza_cpt5_pizzen);
                pnl_cpt5_up1.Visible = false;
                pizza_cpt5_up1_display = false;
                pizza_count -= 1300000;
            }
        }

        private void btn_cpt5_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 6500000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt5_number * pizza_cpt5_pizzen);
                pizza_cpt5_pizzen *= 2;
                lbl_cpt5_pizzen.Text = Convert.ToString(pizza_cpt5_pizzen);
                pnl_cpt5_up2.Visible = false;
                pizza_cpt5_up2_display = false;
                pizza_count -= 6500000;
            }
        }

        private void btn_cpt5_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 65000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt5_number * pizza_cpt5_pizzen);
                pizza_cpt5_pizzen *= 2;
                lbl_cpt5_pizzen.Text = Convert.ToString(pizza_cpt5_pizzen);
                pnl_cpt5_up3.Visible = false;
                pizza_cpt5_up3_display = false;
                pizza_count -= 65000000;
            }
        }

        private void btn_cpt5_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 6500000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt5_number * pizza_cpt5_pizzen);
                pizza_cpt5_pizzen *= 2;
                lbl_cpt5_pizzen.Text = Convert.ToString(pizza_cpt5_pizzen);
                pnl_cpt5_up4.Visible = false;
                pizza_cpt5_up4_display = false;
                pizza_count -= 6500000000;
            }
        }

        private void btn_cpt5_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 650000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt5_number * pizza_cpt5_pizzen);
                pizza_cpt5_pizzen *= 2;
                lbl_cpt5_pizzen.Text = Convert.ToString(pizza_cpt5_pizzen);
                pnl_cpt5_up5.Visible = false;
                pizza_cpt5_up5_display = false;
                pizza_count -= 650000000000;
            }
        }

        private void btn_cpt5_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 65000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt5_number * pizza_cpt5_pizzen);
                pizza_cpt5_pizzen *= 2;
                lbl_cpt5_pizzen.Text = Convert.ToString(pizza_cpt5_pizzen);
                pnl_cpt5_up6.Visible = false;
                pizza_cpt5_up6_display = false;
                pizza_count -= 65000000000000;
            }
        }

        private void btn_cpt5_up7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 65000000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt5_number * pizza_cpt5_pizzen);
                pizza_cpt5_pizzen *= 2;
                lbl_cpt5_pizzen.Text = Convert.ToString(pizza_cpt5_pizzen);
                pnl_cpt5_up7.Visible = false;
                pizza_cpt5_up7_display = false;
                pizza_count -= 65000000000000000;
            }
        }




        private void btn_cpt6_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 14000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt6_number * pizza_cpt6_pizzen);
                pizza_cpt6_pizzen *= 2;
                lbl_cpt6_pizzen.Text = Convert.ToString(pizza_cpt6_pizzen);
                pnl_cpt6_up1.Visible = false;
                pizza_cpt6_up1_display = false;
                pizza_count -= 14000000;
            }
        }

        private void btn_cpt6_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 70000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt6_number * pizza_cpt6_pizzen);
                pizza_cpt6_pizzen *= 2;
                lbl_cpt6_pizzen.Text = Convert.ToString(pizza_cpt6_pizzen);
                pnl_cpt6_up2.Visible = false;
                pizza_cpt6_up2_display = false;
                pizza_count -= 70000000;
            }
        }

        private void btn_cpt6_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 700000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt6_number * pizza_cpt6_pizzen);
                pizza_cpt6_pizzen *= 2;
                lbl_cpt6_pizzen.Text = Convert.ToString(pizza_cpt6_pizzen);
                pnl_cpt6_up3.Visible = false;
                pizza_cpt6_up3_display = false;
                pizza_count -= 700000000;
            }
        }

        private void btn_cpt6_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 70000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt6_number * pizza_cpt6_pizzen);
                pizza_cpt6_pizzen *= 2;
                lbl_cpt6_pizzen.Text = Convert.ToString(pizza_cpt6_pizzen);
                pnl_cpt6_up4.Visible = false;
                pizza_cpt6_up4_display = false;
                pizza_count -= 70000000000;
            }
        }

        private void btn_cpt6_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 7000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt6_number * pizza_cpt6_pizzen);
                pizza_cpt6_pizzen *= 2;
                lbl_cpt6_pizzen.Text = Convert.ToString(pizza_cpt6_pizzen);
                pnl_cpt6_up5.Visible = false;
                pizza_cpt6_up5_display = false;
                pizza_count -= 7000000000000;
            }
        }

        private void btn_cpt6_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 700000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt6_number * pizza_cpt6_pizzen);
                pizza_cpt6_pizzen *= 2;
                lbl_cpt6_pizzen.Text = Convert.ToString(pizza_cpt6_pizzen);
                pnl_cpt6_up6.Visible = false;
                pizza_cpt6_up6_display = false;
                pizza_count -= 700000000000000;
            }
        }

        private void btn_cpt6_up7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 700000000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt6_number * pizza_cpt6_pizzen);
                pizza_cpt6_pizzen *= 2;
                lbl_cpt6_pizzen.Text = Convert.ToString(pizza_cpt6_pizzen);
                pnl_cpt6_up7.Visible = false;
                pizza_cpt6_up7_display = false;
                pizza_count -= 700000000000000000;
            }
        }




        private void btn_cpt7_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 200000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt7_number * pizza_cpt7_pizzen);
                pizza_cpt7_pizzen *= 2;
                lbl_cpt7_pizzen.Text = Convert.ToString(pizza_cpt7_pizzen);
                pnl_cpt7_up1.Visible = false;
                pizza_cpt7_up1_display = false;
                pizza_count -= 200000000;
            }
        }

        private void btn_cpt7_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 1000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt7_number * pizza_cpt7_pizzen);
                pizza_cpt7_pizzen *= 2;
                lbl_cpt7_pizzen.Text = Convert.ToString(pizza_cpt7_pizzen);
                pnl_cpt7_up2.Visible = false;
                pizza_cpt7_up2_display = false;
                pizza_count -= 1000000000;
            }
        }

        private void btn_cpt7_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 10000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt7_number * pizza_cpt7_pizzen);
                pizza_cpt7_pizzen *= 2;
                lbl_cpt7_pizzen.Text = Convert.ToString(pizza_cpt7_pizzen);
                pnl_cpt7_up3.Visible = false;
                pizza_cpt7_up3_display = false;
                pizza_count -= 10000000000;
            }
        }

        private void btn_cpt7_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 1000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt7_number * pizza_cpt7_pizzen);
                pizza_cpt7_pizzen *= 2;
                lbl_cpt7_pizzen.Text = Convert.ToString(pizza_cpt7_pizzen);
                pnl_cpt7_up4.Visible = false;
                pizza_cpt7_up4_display = false;
                pizza_count -= 1000000000000;
            }
        }

        private void btn_cpt7_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 100000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt7_number * pizza_cpt7_pizzen);
                pizza_cpt7_pizzen *= 2;
                lbl_cpt7_pizzen.Text = Convert.ToString(pizza_cpt7_pizzen);
                pnl_cpt7_up5.Visible = false;
                pizza_cpt7_up5_display = false;
                pizza_count -= 100000000000000;
            }
        }

        private void btn_cpt7_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 10000000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt7_number * pizza_cpt7_pizzen);
                pizza_cpt7_pizzen *= 2;
                lbl_cpt7_pizzen.Text = Convert.ToString(pizza_cpt7_pizzen);
                pnl_cpt7_up6.Visible = false;
                pizza_cpt7_up6_display = false;
                pizza_count -= 10000000000000000;
            }
        }

        private void btn_cpt7_up7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 10000000000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt7_number * pizza_cpt7_pizzen);
                pizza_cpt7_pizzen *= 2;
                lbl_cpt7_pizzen.Text = Convert.ToString(pizza_cpt7_pizzen);
                pnl_cpt7_up7.Visible = false;
                pizza_cpt7_up7_display = false;
                pizza_count -= 10000000000000000000;
            }
        }


        private void btn_cpt8_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 3300000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt8_number * pizza_cpt8_pizzen);
                pizza_cpt8_pizzen *= 2;
                lbl_cpt8_pizzen.Text = Convert.ToString(pizza_cpt8_pizzen);
                pnl_cpt8_up1.Visible = false;
                pizza_cpt8_up1_display = false;
                pizza_count -= 3300000000;
            }
        }

        private void btn_cpt8_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 16500000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt8_number * pizza_cpt8_pizzen);
                pizza_cpt8_pizzen *= 2;
                lbl_cpt8_pizzen.Text = Convert.ToString(pizza_cpt8_pizzen);
                pnl_cpt8_up2.Visible = false;
                pizza_cpt8_up2_display = false;
                pizza_count -= 16500000000;
            }
        }

        private void btn_cpt8_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 165000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt8_number * pizza_cpt8_pizzen);
                pizza_cpt8_pizzen *= 2;
                lbl_cpt8_pizzen.Text = Convert.ToString(pizza_cpt8_pizzen);
                pnl_cpt8_up3.Visible = false;
                pizza_cpt8_up3_display = false;
                pizza_count -= 165000000000;
            }
        }

        private void btn_cpt8_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 16500000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt8_number * pizza_cpt8_pizzen);
                pizza_cpt8_pizzen *= 2;
                lbl_cpt8_pizzen.Text = Convert.ToString(pizza_cpt8_pizzen);
                pnl_cpt8_up4.Visible = false;
                pizza_cpt8_up4_display = false;
                pizza_count -= 16500000000000;
            }
        }

        private void btn_cpt8_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 1650000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt8_number * pizza_cpt8_pizzen);
                pizza_cpt8_pizzen *= 2;
                lbl_cpt8_pizzen.Text = Convert.ToString(pizza_cpt8_pizzen);
                pnl_cpt8_up5.Visible = false;
                pizza_cpt8_up5_display = false;
                pizza_count -= 1650000000000000;
            }
        }

        private void btn_cpt8_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 165000000000000000)
            {
                pizza_cpt = pizza_cpt + (pizza_cpt8_number * pizza_cpt8_pizzen);
                pizza_cpt8_pizzen *= 2;
                lbl_cpt8_pizzen.Text = Convert.ToString(pizza_cpt8_pizzen);
                pnl_cpt8_up6.Visible = false;
                pizza_cpt8_up6_display = false;
                pizza_count -= 165000000000000000;
            }
        }


    }
}
//jayden hat ein geilen lsdefgiouv8s9doynhizgtfisgsghjsrgusicogzbshzfubsizfgtszfuilsfbgsufhjsikiongding dog
