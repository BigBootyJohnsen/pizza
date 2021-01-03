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
        public double pizza_count = 0; // Gibt an wie viele Pizzen wir haben.
        public double pizza_click = 1; // Gibt an wie viele Pizzen ein Click auf den Button gibt.
        public double pizza_cpt = 0; // Gibt an wie viele Clicks man pro Sekunde bekommt. (Autoclicks) (clicks per time)    
        public double pizza_only_click = 0; //Gibt an wie viel pizzen nur durch click generiert wurden

        public double cpt1_up4_val = 0; //wird ab cpt1 stufe vier benötigt  

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
        public double pizza_cpt1_pizzen = 0.1;
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


        //click up multiplyer
        public double pizza_click_up1_multiplyer = 1;
        public double pizza_click_up2_multiplyer = 1;
        public double pizza_click_up3_multiplyer = 1;
        public double pizza_click_up4_multiplyer = 1;




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






        public Form1()
        {
            InitializeComponent();
            timer_test.Start(); // startet den timer(den Zähler)
            this.TopMost = true;


        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            pizza_count += (pizza_click + (0.1 * cpt1_up4_val
                * pizza_cpt1_number
                * pizza_cpt2_number
                * pizza_cpt3_number
                * pizza_cpt4_number
                * pizza_cpt5_number
                * pizza_cpt6_number
                * pizza_cpt7_number
                * pizza_cpt8_number
                * pizza_cpt9_number
                * pizza_cpt10_number
                * pizza_cpt11_number
                * pizza_cpt12_number
                * pizza_cpt13_number
                * pizza_cpt14_number
                )) * pizza_click_up1_multiplyer * pizza_click_up2_multiplyer * pizza_click_up3_multiplyer * pizza_click_up4_multiplyer; // = pizza_count = pizza_count + pizza_click;


            pizza_only_click += (pizza_click + (0.1 * cpt1_up4_val
                * pizza_cpt1_number
                * pizza_cpt2_number
                * pizza_cpt3_number
                * pizza_cpt4_number
                * pizza_cpt5_number
                * pizza_cpt6_number
                * pizza_cpt7_number
                * pizza_cpt8_number
                * pizza_cpt9_number
                * pizza_cpt10_number
                * pizza_cpt11_number
                * pizza_cpt12_number
                * pizza_cpt13_number
                * pizza_cpt14_number
                )) * pizza_click_up1_multiplyer * pizza_click_up2_multiplyer * pizza_click_up3_multiplyer * pizza_click_up4_multiplyer; // = pizza_count = pizza_count + pizza_click;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//Schliest das fenster
        }

        private void timer_test_Tick(object sender, EventArgs e)
        {
            pizza_count += (pizza_cpt + (0.1 * cpt1_up4_val 
                * pizza_cpt1_number 
                * pizza_cpt2_number 
                * pizza_cpt3_number
                * pizza_cpt4_number
                * pizza_cpt5_number
                * pizza_cpt6_number
                * pizza_cpt7_number
                * pizza_cpt8_number
                * pizza_cpt9_number
                * pizza_cpt10_number
                * pizza_cpt11_number
                * pizza_cpt12_number
                * pizza_cpt13_number
                * pizza_cpt14_number
                )) / 20; // cpt wird hinzugegeben 
            lblPizza_count.Text = "Pizzen: " + Convert.ToInt64(pizza_count);

            lbl_cpt_ps.Text = "Pizzen/s: " + Convert.ToString(pizza_cpt);//wie viele pizzen pro sekunde produziert werden


            click.Text = Convert.ToString((pizza_click + (0.1 * cpt1_up4_val
                * pizza_cpt1_number
                * pizza_cpt2_number
                * pizza_cpt3_number
                * pizza_cpt4_number
                * pizza_cpt5_number
                * pizza_cpt6_number
                * pizza_cpt7_number
                * pizza_cpt8_number
                * pizza_cpt9_number
                * pizza_cpt10_number
                * pizza_cpt11_number
                * pizza_cpt12_number
                * pizza_cpt13_number
                * pizza_cpt14_number
                )) * pizza_click_up1_multiplyer * pizza_click_up2_multiplyer * pizza_click_up3_multiplyer * pizza_click_up4_multiplyer);
            

            //anzeigen der upgrade button, wenn die bedingung erfüllt ist
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
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if ((pizza_cpt1_up1_display == true) && (pizza_cpt1_number == 1))
            {
                pnl_cpt1_click_up1.Visible = true;
            }*/
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




        //click up
        private void btn_click_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000)
            {
                pizza_click_up1_multiplyer = 1.01;
                btn_click_up1.Visible = false;
            }
        }

        private void btn_click_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 5000000)
            {
                pizza_click_up2_multiplyer = 1.01;
                btn_click_up1.Visible = false;
            }
        }

        private void btn_click_up3_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 500000000)
            {
                pizza_click_up3_multiplyer = 1.01;
                btn_click_up1.Visible = false;
            }
        }

        private void btn_click_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000000000)
            {
                pizza_click_up4_multiplyer = 1.01;
                btn_click_up1.Visible = false;
            }
        }
        private void btn_click_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 50000000000)
            {
                pizza_click = pizza_click + (pizza_click * 1.01);
                btn_click_up1.Visible = false;

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
        private void btn_cpt1_click_up1_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 100)
            {
                pizza_click *= 2;
                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                pnl_cpt1_click_up1.Visible = false;
                pizza_cpt1_up1_display = false;
            }
        }

        private void btn_cpt1_click_up2_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 500)
            {
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
                pizza_cpt = pizza_cpt + (pizza_cpt1_number * pizza_cpt1_pizzen);
                pizza_cpt1_pizzen *= 2;
                lbl_cpt1_pizzen.Text = Convert.ToString(pizza_cpt1_pizzen);
                btn_cpt1_click_up3.Visible = false;
                pizza_cpt1_up3_display = false;

            }
        }

        private void btn_cpt1_click_up4_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 100000)
            {
                cpt1_up4_val = 1;

                btn_cpt1_click_up4.Visible = false;
                pizza_cpt1_up4_display = false;

            }
        }
        private void btn_cpt1_click_up5_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 10000000)
            {
                cpt1_up4_val *= 5;
                btn_cpt1_click_up5.Visible = false;
                pizza_cpt1_up5_display = false;
            }
        }

        private void btn_cpt1_click_up6_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 100000000)
            {
                cpt1_up4_val *= 10;
                btn_cpt1_click_up6.Visible = false;
                pizza_cpt1_up6_display = false;
            }
        }

        private void btn_cpt1_click_up7_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 1000000000)
            {
                cpt1_up4_val *= 20;
                btn_cpt1_click_up7.Visible = false;
                pizza_cpt1_up7_display = false;
            }
        }

        private void btn_cpt1_click_up8_Click(object sender, EventArgs e)
        {
            if (pizza_count >= 10000000000)
            {
                cpt1_up4_val *= 20;
                btn_cpt1_click_up8.Visible = false;
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
            }
        }




    }
}
//jayden hat ein geilen lsdefgiouv8s9doynhizgtfisgsghjsrgusicogzbshzfubsizfgtszfuilsfbgsufhjsikiongding dog
