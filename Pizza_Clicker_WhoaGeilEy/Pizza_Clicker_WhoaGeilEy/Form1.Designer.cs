namespace Pizza_Clicker_WhoaGeilEy
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
            this.lblPizza_count.Location = new System.Drawing.Point(371, 221);
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
            this.timer_test.Interval = 1000;
            this.timer_test.Tick += new System.EventHandler(this.timer_test_Tick);
            // 
            // shop_cpt2
            // 
            this.shop_cpt2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.shop_cpt2.FlatAppearance.BorderSize = 0;
            this.shop_cpt2.Location = new System.Drawing.Point(685, 73);
            this.shop_cpt2.Name = "shop_cpt2";
            this.shop_cpt2.Size = new System.Drawing.Size(103, 23);
            this.shop_cpt2.TabIndex = 3;
            this.shop_cpt2.Text = "UP 2";
            this.shop_cpt2.UseVisualStyleBackColor = true;
            this.shop_cpt2.Click += new System.EventHandler(this.shop_cpt2_Click);
            // 
            // shop_cpt3
            // 
            this.shop_cpt3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.shop_cpt3.FlatAppearance.BorderSize = 0;
            this.shop_cpt3.Location = new System.Drawing.Point(685, 115);
            this.shop_cpt3.Name = "shop_cpt3";
            this.shop_cpt3.Size = new System.Drawing.Size(103, 23);
            this.shop_cpt3.TabIndex = 4;
            this.shop_cpt3.Text = "UP 3";
            this.shop_cpt3.UseVisualStyleBackColor = true;
            this.shop_cpt3.Click += new System.EventHandler(this.shop_cpt3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

