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
        public int pizza_count = 0; // Gibt an wie viele Pizzen wir haben.
        public int pizza_click = 1; // Gibt an wie viele Pizzen ein Click auf den Button gibt.
        public int pizza_cot = 1; //Gibt an wie viele Clicks man pro Sekunde bekommt. (Autoclicks)


        // Timer value
        // public int timerCount = 0;

        //private static void SetTimer()
        // {
        // 
        //    aTimer = new System.Timers.Timer(2000);
        // }
       

        public Form1()
        {
            InitializeComponent();
            // timer1_Tick.start();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            pizza_count += pizza_click; // = pizza_count = pizza_count + pizza_click;
            lblPizza_count.Text = "Pizzen: " + pizza_count;
        }

       // private void timer1_Tick(object sender, EventArgs e)
       // {
       //      
       //     timers timerCounter += 1;
       //     pizza_count += pizza_cot;
       // }
    }
}
//jayden hat ein geilen lsdefgiouv8s9doynhizgtfisgsghjsrgusicogzbshzfubsizfgtszfuilsfbgsufhjsikiongding dog
