﻿namespace Pizza_Clicker_WhoaGeilEy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPizza_click = new System.Windows.Forms.Button();
            this.lblPizza_count = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer_test = new System.Windows.Forms.Timer(this.components);
            this.shop_cpt2 = new System.Windows.Forms.Button();
            this.shop_cpt3 = new System.Windows.Forms.Button();
            this.lbl_cpt2_cost = new System.Windows.Forms.Label();
            this.lbl_cpt2_pizzen = new System.Windows.Forms.Label();
            this.lbl_cpt2_number = new System.Windows.Forms.Label();
            this.lbl_cpt3_number = new System.Windows.Forms.Label();
            this.lbl_cpt3_pizzen = new System.Windows.Forms.Label();
            this.lbl_cpt3_cost = new System.Windows.Forms.Label();
            this.lbl_cpt_ps = new System.Windows.Forms.Label();
            this.lbl_cpt4_number = new System.Windows.Forms.Label();
            this.lbl_cpt4_pizzen = new System.Windows.Forms.Label();
            this.lbl_cpt4_cost = new System.Windows.Forms.Label();
            this.shop_cpt4 = new System.Windows.Forms.Button();
            this.btn_click_up1 = new System.Windows.Forms.Button();
            this.btn_click_up2 = new System.Windows.Forms.Button();
            this.btn_click_up4 = new System.Windows.Forms.Button();
            this.btn_click_up3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPizza_click
            // 
            this.btnPizza_click.Location = new System.Drawing.Point(301, 237);
            this.btnPizza_click.Name = "btnPizza_click";
            this.btnPizza_click.Size = new System.Drawing.Size(178, 57);
            this.btnPizza_click.TabIndex = 0;
            this.btnPizza_click.Text = "Click";
            this.btnPizza_click.UseVisualStyleBackColor = true;
            this.btnPizza_click.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPizza_count
            // 
            this.lblPizza_count.AutoSize = true;
            this.lblPizza_count.Location = new System.Drawing.Point(374, 203);
            this.lblPizza_count.Name = "lblPizza_count";
            this.lblPizza_count.Size = new System.Drawing.Size(38, 13);
            this.lblPizza_count.TabIndex = 1;
            this.lblPizza_count.Text = "Pizzen";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer_test
            // 
            this.timer_test.Interval = 50;
            this.timer_test.Tick += new System.EventHandler(this.timer_test_Tick);
            // 
            // shop_cpt2
            // 
            this.shop_cpt2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.shop_cpt2.FlatAppearance.BorderSize = 0;
            this.shop_cpt2.Location = new System.Drawing.Point(737, 12);
            this.shop_cpt2.Name = "shop_cpt2";
            this.shop_cpt2.Size = new System.Drawing.Size(51, 84);
            this.shop_cpt2.TabIndex = 3;
            this.shop_cpt2.Text = "UP 2";
            this.shop_cpt2.UseVisualStyleBackColor = true;
            this.shop_cpt2.Click += new System.EventHandler(this.shop_cpt2_Click);
            // 
            // shop_cpt3
            // 
            this.shop_cpt3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.shop_cpt3.FlatAppearance.BorderSize = 0;
            this.shop_cpt3.Location = new System.Drawing.Point(737, 115);
            this.shop_cpt3.Name = "shop_cpt3";
            this.shop_cpt3.Size = new System.Drawing.Size(51, 82);
            this.shop_cpt3.TabIndex = 4;
            this.shop_cpt3.Text = "UP 3";
            this.shop_cpt3.UseVisualStyleBackColor = true;
            this.shop_cpt3.Click += new System.EventHandler(this.shop_cpt3_Click);
            // 
            // lbl_cpt2_cost
            // 
            this.lbl_cpt2_cost.AutoSize = true;
            this.lbl_cpt2_cost.Location = new System.Drawing.Point(670, 12);
            this.lbl_cpt2_cost.Name = "lbl_cpt2_cost";
            this.lbl_cpt2_cost.Size = new System.Drawing.Size(25, 13);
            this.lbl_cpt2_cost.TabIndex = 5;
            this.lbl_cpt2_cost.Text = "100";
            // 
            // lbl_cpt2_pizzen
            // 
            this.lbl_cpt2_pizzen.AutoSize = true;
            this.lbl_cpt2_pizzen.Location = new System.Drawing.Point(673, 29);
            this.lbl_cpt2_pizzen.Name = "lbl_cpt2_pizzen";
            this.lbl_cpt2_pizzen.Size = new System.Drawing.Size(13, 13);
            this.lbl_cpt2_pizzen.TabIndex = 6;
            this.lbl_cpt2_pizzen.Text = "1";
            // 
            // lbl_cpt2_number
            // 
            this.lbl_cpt2_number.AutoSize = true;
            this.lbl_cpt2_number.Location = new System.Drawing.Point(673, 46);
            this.lbl_cpt2_number.Name = "lbl_cpt2_number";
            this.lbl_cpt2_number.Size = new System.Drawing.Size(13, 13);
            this.lbl_cpt2_number.TabIndex = 7;
            this.lbl_cpt2_number.Text = "0";
            // 
            // lbl_cpt3_number
            // 
            this.lbl_cpt3_number.AutoSize = true;
            this.lbl_cpt3_number.Location = new System.Drawing.Point(673, 149);
            this.lbl_cpt3_number.Name = "lbl_cpt3_number";
            this.lbl_cpt3_number.Size = new System.Drawing.Size(13, 13);
            this.lbl_cpt3_number.TabIndex = 10;
            this.lbl_cpt3_number.Text = "0";
            // 
            // lbl_cpt3_pizzen
            // 
            this.lbl_cpt3_pizzen.AutoSize = true;
            this.lbl_cpt3_pizzen.Location = new System.Drawing.Point(673, 132);
            this.lbl_cpt3_pizzen.Name = "lbl_cpt3_pizzen";
            this.lbl_cpt3_pizzen.Size = new System.Drawing.Size(13, 13);
            this.lbl_cpt3_pizzen.TabIndex = 9;
            this.lbl_cpt3_pizzen.Text = "8";
            // 
            // lbl_cpt3_cost
            // 
            this.lbl_cpt3_cost.AutoSize = true;
            this.lbl_cpt3_cost.Location = new System.Drawing.Point(670, 115);
            this.lbl_cpt3_cost.Name = "lbl_cpt3_cost";
            this.lbl_cpt3_cost.Size = new System.Drawing.Size(31, 13);
            this.lbl_cpt3_cost.TabIndex = 8;
            this.lbl_cpt3_cost.Text = "1100";
            // 
            // lbl_cpt_ps
            // 
            this.lbl_cpt_ps.AutoSize = true;
            this.lbl_cpt_ps.Location = new System.Drawing.Point(374, 221);
            this.lbl_cpt_ps.Name = "lbl_cpt_ps";
            this.lbl_cpt_ps.Size = new System.Drawing.Size(48, 13);
            this.lbl_cpt_ps.TabIndex = 11;
            this.lbl_cpt_ps.Text = "Pizza/s: ";
            // 
            // lbl_cpt4_number
            // 
            this.lbl_cpt4_number.AutoSize = true;
            this.lbl_cpt4_number.Location = new System.Drawing.Point(673, 246);
            this.lbl_cpt4_number.Name = "lbl_cpt4_number";
            this.lbl_cpt4_number.Size = new System.Drawing.Size(13, 13);
            this.lbl_cpt4_number.TabIndex = 15;
            this.lbl_cpt4_number.Text = "0";
            // 
            // lbl_cpt4_pizzen
            // 
            this.lbl_cpt4_pizzen.AutoSize = true;
            this.lbl_cpt4_pizzen.Location = new System.Drawing.Point(673, 229);
            this.lbl_cpt4_pizzen.Name = "lbl_cpt4_pizzen";
            this.lbl_cpt4_pizzen.Size = new System.Drawing.Size(19, 13);
            this.lbl_cpt4_pizzen.TabIndex = 14;
            this.lbl_cpt4_pizzen.Text = "47";
            // 
            // lbl_cpt4_cost
            // 
            this.lbl_cpt4_cost.AutoSize = true;
            this.lbl_cpt4_cost.Location = new System.Drawing.Point(670, 212);
            this.lbl_cpt4_cost.Name = "lbl_cpt4_cost";
            this.lbl_cpt4_cost.Size = new System.Drawing.Size(40, 13);
            this.lbl_cpt4_cost.TabIndex = 13;
            this.lbl_cpt4_cost.Text = "12.000";
            // 
            // shop_cpt4
            // 
            this.shop_cpt4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.shop_cpt4.FlatAppearance.BorderSize = 0;
            this.shop_cpt4.Location = new System.Drawing.Point(737, 212);
            this.shop_cpt4.Name = "shop_cpt4";
            this.shop_cpt4.Size = new System.Drawing.Size(51, 82);
            this.shop_cpt4.TabIndex = 12;
            this.shop_cpt4.Text = "UP 4";
            this.shop_cpt4.UseVisualStyleBackColor = true;
            this.shop_cpt4.Click += new System.EventHandler(this.shop_cpt4_Click);
            // 
            // btn_click_up1
            // 
            this.btn_click_up1.Location = new System.Drawing.Point(12, 36);
            this.btn_click_up1.Name = "btn_click_up1";
            this.btn_click_up1.Size = new System.Drawing.Size(75, 23);
            this.btn_click_up1.TabIndex = 16;
            this.btn_click_up1.Text = "click up1";
            this.btn_click_up1.UseVisualStyleBackColor = true;
            this.btn_click_up1.Click += new System.EventHandler(this.btn_click_up1_Click);
            // 
            // btn_click_up2
            // 
            this.btn_click_up2.Location = new System.Drawing.Point(12, 58);
            this.btn_click_up2.Name = "btn_click_up2";
            this.btn_click_up2.Size = new System.Drawing.Size(75, 23);
            this.btn_click_up2.TabIndex = 17;
            this.btn_click_up2.Text = "click up2";
            this.btn_click_up2.UseVisualStyleBackColor = true;
            this.btn_click_up2.Click += new System.EventHandler(this.btn_click_up2_Click);
            // 
            // btn_click_up4
            // 
            this.btn_click_up4.Location = new System.Drawing.Point(12, 97);
            this.btn_click_up4.Name = "btn_click_up4";
            this.btn_click_up4.Size = new System.Drawing.Size(75, 23);
            this.btn_click_up4.TabIndex = 19;
            this.btn_click_up4.Text = "click up4";
            this.btn_click_up4.UseVisualStyleBackColor = true;
            this.btn_click_up4.Click += new System.EventHandler(this.btn_click_up4_Click);
            // 
            // btn_click_up3
            // 
            this.btn_click_up3.Location = new System.Drawing.Point(12, 75);
            this.btn_click_up3.Name = "btn_click_up3";
            this.btn_click_up3.Size = new System.Drawing.Size(75, 23);
            this.btn_click_up3.TabIndex = 18;
            this.btn_click_up3.Text = "click up3";
            this.btn_click_up3.UseVisualStyleBackColor = true;
            this.btn_click_up3.Click += new System.EventHandler(this.btn_click_up3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "click +1% von cpt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "50.000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "5.000.000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "500.000.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "50.000.000.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_click_up4);
            this.Controls.Add(this.btn_click_up3);
            this.Controls.Add(this.btn_click_up2);
            this.Controls.Add(this.btn_click_up1);
            this.Controls.Add(this.lbl_cpt4_number);
            this.Controls.Add(this.lbl_cpt4_pizzen);
            this.Controls.Add(this.lbl_cpt4_cost);
            this.Controls.Add(this.shop_cpt4);
            this.Controls.Add(this.lbl_cpt_ps);
            this.Controls.Add(this.lbl_cpt3_number);
            this.Controls.Add(this.lbl_cpt3_pizzen);
            this.Controls.Add(this.lbl_cpt3_cost);
            this.Controls.Add(this.lbl_cpt2_number);
            this.Controls.Add(this.lbl_cpt2_pizzen);
            this.Controls.Add(this.lbl_cpt2_cost);
            this.Controls.Add(this.shop_cpt3);
            this.Controls.Add(this.shop_cpt2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPizza_count);
            this.Controls.Add(this.btnPizza_click);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza_Clicker made by GMJGmbH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPizza_click;
        private System.Windows.Forms.Label lblPizza_count;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer_test;
        private System.Windows.Forms.Button shop_cpt2;
        private System.Windows.Forms.Button shop_cpt3;
        private System.Windows.Forms.Label lbl_cpt2_cost;
        private System.Windows.Forms.Label lbl_cpt2_pizzen;
        private System.Windows.Forms.Label lbl_cpt2_number;
        private System.Windows.Forms.Label lbl_cpt3_number;
        private System.Windows.Forms.Label lbl_cpt3_pizzen;
        private System.Windows.Forms.Label lbl_cpt3_cost;
        private System.Windows.Forms.Label lbl_cpt_ps;
        private System.Windows.Forms.Label lbl_cpt4_number;
        private System.Windows.Forms.Label lbl_cpt4_pizzen;
        private System.Windows.Forms.Label lbl_cpt4_cost;
        private System.Windows.Forms.Button shop_cpt4;
        private System.Windows.Forms.Button btn_click_up1;
        private System.Windows.Forms.Button btn_click_up2;
        private System.Windows.Forms.Button btn_click_up4;
        private System.Windows.Forms.Button btn_click_up3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

