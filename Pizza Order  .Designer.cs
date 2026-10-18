namespace MyFirstWinFormProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBLarge = new System.Windows.Forms.RadioButton();
            this.RBMedium = new System.Windows.Forms.RadioButton();
            this.RBSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlivies = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RBThikCrust = new System.Windows.Forms.RadioButton();
            this.RBThinCrust = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RBTakeOut = new System.Windows.Forms.RadioButton();
            this.RBEatIn = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Location = new System.Drawing.Point(282, 517);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(70, 29);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Text = "Price";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.lbWhereToEat.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.ForeColor = System.Drawing.Color.Red;
            this.lbWhereToEat.Location = new System.Drawing.Point(268, 470);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(85, 29);
            this.lbWhereToEat.TabIndex = 19;
            this.lbWhereToEat.Text = "Choise";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.BackColor = System.Drawing.Color.Transparent;
            this.lblCrust.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrust.ForeColor = System.Drawing.Color.Red;
            this.lblCrust.Location = new System.Drawing.Point(282, 243);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(85, 29);
            this.lblCrust.TabIndex = 18;
            this.lblCrust.Text = "Choise";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Red;
            this.lbSize.Location = new System.Drawing.Point(303, 202);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(85, 29);
            this.lbSize.TabIndex = 16;
            this.lbSize.Text = "Choise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Order Summary";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBLarge);
            this.groupBox1.Controls.Add(this.RBMedium);
            this.groupBox1.Controls.Add(this.RBSmall);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(475, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 131);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // RBLarge
            // 
            this.RBLarge.AutoSize = true;
            this.RBLarge.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBLarge.Location = new System.Drawing.Point(6, 94);
            this.RBLarge.Name = "RBLarge";
            this.RBLarge.Size = new System.Drawing.Size(64, 26);
            this.RBLarge.TabIndex = 2;
            this.RBLarge.Tag = "40";
            this.RBLarge.Text = "Larg";
            this.RBLarge.UseVisualStyleBackColor = true;
            this.RBLarge.CheckedChanged += new System.EventHandler(this.RBLarge_CheckedChanged);
            // 
            // RBMedium
            // 
            this.RBMedium.AutoSize = true;
            this.RBMedium.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMedium.Location = new System.Drawing.Point(6, 62);
            this.RBMedium.Name = "RBMedium";
            this.RBMedium.Size = new System.Drawing.Size(92, 26);
            this.RBMedium.TabIndex = 1;
            this.RBMedium.Tag = "30";
            this.RBMedium.Text = "Medium";
            this.RBMedium.UseVisualStyleBackColor = true;
            this.RBMedium.CheckedChanged += new System.EventHandler(this.RBMedium_CheckedChanged);
            // 
            // RBSmall
            // 
            this.RBSmall.AutoSize = true;
            this.RBSmall.BackColor = System.Drawing.Color.Transparent;
            this.RBSmall.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSmall.ForeColor = System.Drawing.Color.Black;
            this.RBSmall.Location = new System.Drawing.Point(6, 30);
            this.RBSmall.Name = "RBSmall";
            this.RBSmall.Size = new System.Drawing.Size(72, 26);
            this.RBSmall.TabIndex = 0;
            this.RBSmall.Tag = "20";
            this.RBSmall.Text = "Small";
            this.RBSmall.UseVisualStyleBackColor = false;
            this.RBSmall.CheckedChanged += new System.EventHandler(this.RBSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkGreenPeppers);
            this.groupBox2.Controls.Add(this.chkOlivies);
            this.groupBox2.Controls.Add(this.chkOnion);
            this.groupBox2.Controls.Add(this.chkTomatoes);
            this.groupBox2.Controls.Add(this.chkMushrooms);
            this.groupBox2.Controls.Add(this.chkExtraCheese);
            this.groupBox2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(475, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 120);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(168, 88);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(145, 26);
            this.chkGreenPeppers.TabIndex = 11;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlivies
            // 
            this.chkOlivies.AutoSize = true;
            this.chkOlivies.Location = new System.Drawing.Point(168, 59);
            this.chkOlivies.Name = "chkOlivies";
            this.chkOlivies.Size = new System.Drawing.Size(75, 26);
            this.chkOlivies.TabIndex = 10;
            this.chkOlivies.Tag = "5";
            this.chkOlivies.Text = "Olives";
            this.chkOlivies.UseVisualStyleBackColor = true;
            this.chkOlivies.CheckedChanged += new System.EventHandler(this.chkOlivies_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(168, 27);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(75, 26);
            this.chkOnion.TabIndex = 9;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(15, 85);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(108, 26);
            this.chkTomatoes.TabIndex = 8;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(15, 59);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(120, 26);
            this.chkMushrooms.TabIndex = 7;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(15, 33);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(132, 26);
            this.chkExtraCheese.TabIndex = 6;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RBThikCrust);
            this.groupBox3.Controls.Add(this.RBThinCrust);
            this.groupBox3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(671, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 131);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crust Type";
            // 
            // RBThikCrust
            // 
            this.RBThikCrust.AutoSize = true;
            this.RBThikCrust.Location = new System.Drawing.Point(6, 48);
            this.RBThikCrust.Name = "RBThikCrust";
            this.RBThikCrust.Size = new System.Drawing.Size(113, 26);
            this.RBThikCrust.TabIndex = 6;
            this.RBThikCrust.TabStop = true;
            this.RBThikCrust.Tag = "10";
            this.RBThikCrust.Text = "Thik Crust";
            this.RBThikCrust.UseVisualStyleBackColor = true;
            this.RBThikCrust.CheckedChanged += new System.EventHandler(this.RBThikCrust_CheckedChanged);
            // 
            // RBThinCrust
            // 
            this.RBThinCrust.AutoSize = true;
            this.RBThinCrust.Location = new System.Drawing.Point(6, 80);
            this.RBThinCrust.Name = "RBThinCrust";
            this.RBThinCrust.Size = new System.Drawing.Size(114, 26);
            this.RBThinCrust.TabIndex = 0;
            this.RBThinCrust.TabStop = true;
            this.RBThinCrust.Tag = "0";
            this.RBThinCrust.Text = "Thin Crust";
            this.RBThinCrust.UseVisualStyleBackColor = true;
            this.RBThinCrust.CheckedChanged += new System.EventHandler(this.RBThinCrust_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.RBTakeOut);
            this.groupBox4.Controls.Add(this.RBEatIn);
            this.groupBox4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(475, 476);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 80);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where To Eat";
            // 
            // RBTakeOut
            // 
            this.RBTakeOut.AutoSize = true;
            this.RBTakeOut.Location = new System.Drawing.Point(120, 34);
            this.RBTakeOut.Name = "RBTakeOut";
            this.RBTakeOut.Size = new System.Drawing.Size(104, 26);
            this.RBTakeOut.TabIndex = 1;
            this.RBTakeOut.TabStop = true;
            this.RBTakeOut.Text = "Take Out";
            this.RBTakeOut.UseVisualStyleBackColor = true;
            this.RBTakeOut.CheckedChanged += new System.EventHandler(this.RBTakeOut_CheckedChanged);
            // 
            // RBEatIn
            // 
            this.RBEatIn.AutoSize = true;
            this.RBEatIn.Location = new System.Drawing.Point(12, 34);
            this.RBEatIn.Name = "RBEatIn";
            this.RBEatIn.Size = new System.Drawing.Size(80, 26);
            this.RBEatIn.TabIndex = 0;
            this.RBEatIn.TabStop = true;
            this.RBEatIn.Text = "Eat In";
            this.RBEatIn.UseVisualStyleBackColor = true;
            this.RBEatIn.CheckedChanged += new System.EventHandler(this.RBEatIn_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(308, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 40);
            this.button2.TabIndex = 26;
            this.button2.Text = "Reset Form ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(146, 576);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(145, 40);
            this.btnOrderPizza.TabIndex = 25;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Crust Type : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Where To Eat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(141, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total Price : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(107, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Toppings : ";
          
            // 
            // lblToppings
            // 
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Red;
            this.lblToppings.Location = new System.Drawing.Point(107, 332);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(328, 138);
            this.lblToppings.TabIndex = 28;
            this.lblToppings.Text = "Choise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "Make Your Pizza ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 628);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lbWhereToEat);
            this.Controls.Add(this.lblCrust);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBLarge;
        private System.Windows.Forms.RadioButton RBMedium;
        private System.Windows.Forms.RadioButton RBSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlivies;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RBThikCrust;
        private System.Windows.Forms.RadioButton RBThinCrust;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RBTakeOut;
        private System.Windows.Forms.RadioButton RBEatIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label3;
    }
}