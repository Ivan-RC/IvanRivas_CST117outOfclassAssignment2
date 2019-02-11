namespace IvanRivas_CST117outOfclassAssignment2
{
    partial class Form1
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
            this.listBox1_drinks = new System.Windows.Forms.ListBox();
            this.radioButton1_small = new System.Windows.Forms.RadioButton();
            this.radioButton2_medium = new System.Windows.Forms.RadioButton();
            this.radioButton3_large = new System.Windows.Forms.RadioButton();
            this.checkBox1_sugar = new System.Windows.Forms.CheckBox();
            this.checkBox2_cream = new System.Windows.Forms.CheckBox();
            this.checkBox3_honey = new System.Windows.Forms.CheckBox();
            this.checkBox4_whip = new System.Windows.Forms.CheckBox();
            this.radioButton4_extraLarge = new System.Windows.Forms.RadioButton();
            this.btn1_Order = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1_drinks
            // 
            this.listBox1_drinks.FormattingEnabled = true;
            this.listBox1_drinks.ItemHeight = 16;
            this.listBox1_drinks.Items.AddRange(new object[] {
            "coffee",
            "tea",
            "milkshake",
            "orange juice",
            "apple juice",
            "smoothie",
            "water"});
            this.listBox1_drinks.Location = new System.Drawing.Point(11, 21);
            this.listBox1_drinks.Name = "listBox1_drinks";
            this.listBox1_drinks.Size = new System.Drawing.Size(164, 84);
            this.listBox1_drinks.TabIndex = 0;
            // 
            // radioButton1_small
            // 
            this.radioButton1_small.AutoSize = true;
            this.radioButton1_small.Location = new System.Drawing.Point(279, 50);
            this.radioButton1_small.Name = "radioButton1_small";
            this.radioButton1_small.Size = new System.Drawing.Size(63, 21);
            this.radioButton1_small.TabIndex = 1;
            this.radioButton1_small.TabStop = true;
            this.radioButton1_small.Text = "Small";
            this.radioButton1_small.UseVisualStyleBackColor = true;
            // 
            // radioButton2_medium
            // 
            this.radioButton2_medium.AutoSize = true;
            this.radioButton2_medium.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2_medium.Location = new System.Drawing.Point(279, 77);
            this.radioButton2_medium.Name = "radioButton2_medium";
            this.radioButton2_medium.Size = new System.Drawing.Size(78, 21);
            this.radioButton2_medium.TabIndex = 2;
            this.radioButton2_medium.TabStop = true;
            this.radioButton2_medium.Text = "Medium";
            this.radioButton2_medium.UseVisualStyleBackColor = true;
            // 
            // radioButton3_large
            // 
            this.radioButton3_large.AutoSize = true;
            this.radioButton3_large.Location = new System.Drawing.Point(279, 104);
            this.radioButton3_large.Name = "radioButton3_large";
            this.radioButton3_large.Size = new System.Drawing.Size(66, 21);
            this.radioButton3_large.TabIndex = 3;
            this.radioButton3_large.TabStop = true;
            this.radioButton3_large.Text = "Large";
            this.radioButton3_large.UseVisualStyleBackColor = true;
            // 
            // checkBox1_sugar
            // 
            this.checkBox1_sugar.AutoSize = true;
            this.checkBox1_sugar.Location = new System.Drawing.Point(84, 234);
            this.checkBox1_sugar.Name = "checkBox1_sugar";
            this.checkBox1_sugar.Size = new System.Drawing.Size(68, 21);
            this.checkBox1_sugar.TabIndex = 4;
            this.checkBox1_sugar.Text = "Sugar";
            this.checkBox1_sugar.UseVisualStyleBackColor = true;
            this.checkBox1_sugar.CheckedChanged += new System.EventHandler(this.checkBox1_sugar_CheckedChanged);
            // 
            // checkBox2_cream
            // 
            this.checkBox2_cream.AutoSize = true;
            this.checkBox2_cream.Location = new System.Drawing.Point(84, 261);
            this.checkBox2_cream.Name = "checkBox2_cream";
            this.checkBox2_cream.Size = new System.Drawing.Size(71, 21);
            this.checkBox2_cream.TabIndex = 5;
            this.checkBox2_cream.Text = "Cream";
            this.checkBox2_cream.UseVisualStyleBackColor = true;
            this.checkBox2_cream.CheckedChanged += new System.EventHandler(this.checkBox2_cream_CheckedChanged);
            // 
            // checkBox3_honey
            // 
            this.checkBox3_honey.AutoSize = true;
            this.checkBox3_honey.Location = new System.Drawing.Point(84, 288);
            this.checkBox3_honey.Name = "checkBox3_honey";
            this.checkBox3_honey.Size = new System.Drawing.Size(71, 21);
            this.checkBox3_honey.TabIndex = 6;
            this.checkBox3_honey.Text = "Honey";
            this.checkBox3_honey.UseVisualStyleBackColor = true;
            this.checkBox3_honey.CheckedChanged += new System.EventHandler(this.checkBox3_honey_CheckedChanged);
            // 
            // checkBox4_whip
            // 
            this.checkBox4_whip.AutoSize = true;
            this.checkBox4_whip.Location = new System.Drawing.Point(84, 315);
            this.checkBox4_whip.Name = "checkBox4_whip";
            this.checkBox4_whip.Size = new System.Drawing.Size(107, 21);
            this.checkBox4_whip.TabIndex = 7;
            this.checkBox4_whip.Text = "Whip Cream";
            this.checkBox4_whip.UseVisualStyleBackColor = true;
            this.checkBox4_whip.CheckedChanged += new System.EventHandler(this.checkBox4_whip_CheckedChanged);
            // 
            // radioButton4_extraLarge
            // 
            this.radioButton4_extraLarge.AutoSize = true;
            this.radioButton4_extraLarge.Location = new System.Drawing.Point(279, 131);
            this.radioButton4_extraLarge.Name = "radioButton4_extraLarge";
            this.radioButton4_extraLarge.Size = new System.Drawing.Size(102, 21);
            this.radioButton4_extraLarge.TabIndex = 8;
            this.radioButton4_extraLarge.TabStop = true;
            this.radioButton4_extraLarge.Text = "Extra Large";
            this.radioButton4_extraLarge.UseVisualStyleBackColor = true;
            // 
            // btn1_Order
            // 
            this.btn1_Order.Location = new System.Drawing.Point(279, 158);
            this.btn1_Order.Name = "btn1_Order";
            this.btn1_Order.Size = new System.Drawing.Size(106, 42);
            this.btn1_Order.TabIndex = 10;
            this.btn1_Order.Text = "Order";
            this.btn1_Order.UseVisualStyleBackColor = true;
            this.btn1_Order.Click += new System.EventHandler(this.btn1_Order_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(84, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extras";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1_drinks);
            this.groupBox2.Location = new System.Drawing.Point(73, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 178);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drinks and sizes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 559);
            this.Controls.Add(this.btn1_Order);
            this.Controls.Add(this.radioButton4_extraLarge);
            this.Controls.Add(this.checkBox4_whip);
            this.Controls.Add(this.checkBox3_honey);
            this.Controls.Add(this.checkBox2_cream);
            this.Controls.Add(this.checkBox1_sugar);
            this.Controls.Add(this.radioButton3_large);
            this.Controls.Add(this.radioButton2_medium);
            this.Controls.Add(this.radioButton1_small);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Ivan\'s drinks";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_drinks;
        private System.Windows.Forms.RadioButton radioButton1_small;
        private System.Windows.Forms.RadioButton radioButton3_large;
        private System.Windows.Forms.CheckBox checkBox1_sugar;
        private System.Windows.Forms.CheckBox checkBox2_cream;
        private System.Windows.Forms.CheckBox checkBox3_honey;
        private System.Windows.Forms.CheckBox checkBox4_whip;
        private System.Windows.Forms.RadioButton radioButton4_extraLarge;
        private System.Windows.Forms.Button btn1_Order;
        private System.Windows.Forms.RadioButton radioButton2_medium;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

