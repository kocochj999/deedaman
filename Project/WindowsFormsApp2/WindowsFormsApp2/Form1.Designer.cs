namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.GameHourButton = new System.Windows.Forms.Button();
            this.CardsButton = new System.Windows.Forms.Button();
            this.DrinkButton = new System.Windows.Forms.Button();
            this.FoodButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CheckOutButton);
            this.panel1.Controls.Add(this.GameHourButton);
            this.panel1.Controls.Add(this.CardsButton);
            this.panel1.Controls.Add(this.DrinkButton);
            this.panel1.Controls.Add(this.FoodButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 530);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Blue;
            this.SidePanel.Location = new System.Drawing.Point(0, 63);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 67);
            this.SidePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cabin Sketch", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "      Knight Game";
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.CheckOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckOutButton.Location = new System.Drawing.Point(12, 442);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(194, 67);
            this.CheckOutButton.TabIndex = 2;
            this.CheckOutButton.Text = "Checkout";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // GameHourButton
            // 
            this.GameHourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(40)))), ((int)(((byte)(31)))));
            this.GameHourButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.GameHourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameHourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameHourButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.GameHourButton.Location = new System.Drawing.Point(12, 264);
            this.GameHourButton.Name = "GameHourButton";
            this.GameHourButton.Size = new System.Drawing.Size(194, 67);
            this.GameHourButton.TabIndex = 2;
            this.GameHourButton.Text = "Game Hours";
            this.GameHourButton.UseVisualStyleBackColor = false;
            this.GameHourButton.Click += new System.EventHandler(this.GameHourButton_Click);
            // 
            // CardsButton
            // 
            this.CardsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(40)))), ((int)(((byte)(31)))));
            this.CardsButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.CardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardsButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CardsButton.Location = new System.Drawing.Point(12, 197);
            this.CardsButton.Name = "CardsButton";
            this.CardsButton.Size = new System.Drawing.Size(194, 67);
            this.CardsButton.TabIndex = 2;
            this.CardsButton.Text = "Cards";
            this.CardsButton.UseVisualStyleBackColor = false;
            this.CardsButton.Click += new System.EventHandler(this.CardsButton_Click);
            // 
            // DrinkButton
            // 
            this.DrinkButton.AccessibleName = "";
            this.DrinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(40)))), ((int)(((byte)(31)))));
            this.DrinkButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.DrinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DrinkButton.Location = new System.Drawing.Point(12, 130);
            this.DrinkButton.Name = "DrinkButton";
            this.DrinkButton.Size = new System.Drawing.Size(194, 67);
            this.DrinkButton.TabIndex = 2;
            this.DrinkButton.Text = "Drinks";
            this.DrinkButton.UseVisualStyleBackColor = false;
            this.DrinkButton.Click += new System.EventHandler(this.DrinkButton_Click);
            // 
            // FoodButton
            // 
            this.FoodButton.AccessibleName = "";
            this.FoodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(40)))), ((int)(((byte)(31)))));
            this.FoodButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.FoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FoodButton.Location = new System.Drawing.Point(12, 63);
            this.FoodButton.Name = "FoodButton";
            this.FoodButton.Size = new System.Drawing.Size(194, 67);
            this.FoodButton.TabIndex = 2;
            this.FoodButton.Text = "Food";
            this.FoodButton.UseVisualStyleBackColor = false;
            this.FoodButton.Click += new System.EventHandler(this.FoodButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(207, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 43);
            this.panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(553, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 33);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(682, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "đ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(530, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Location = new System.Drawing.Point(212, 49);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(712, 481);
            this.MainPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(925, 530);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cyber Service";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button GameHourButton;
        private System.Windows.Forms.Button CardsButton;
        private System.Windows.Forms.Button DrinkButton;
        private System.Windows.Forms.Button FoodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel MainPanel;
    }
}

