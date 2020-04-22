namespace WindowsFormsApp2
{
    partial class CheckOutUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaymentButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.textBoxList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PaymentButton
            // 
            this.PaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.Location = new System.Drawing.Point(484, 405);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(197, 42);
            this.PaymentButton.TabIndex = 0;
            this.PaymentButton.Text = "Check out";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(43, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(333, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Your Cart";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(45, 414);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(75, 31);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Total:";
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.Location = new System.Drawing.Point(135, 414);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(241, 31);
            this.totalBox.TabIndex = 1;
            this.totalBox.Text = "0";
            // 
            // textBoxList
            // 
            this.textBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxList.Location = new System.Drawing.Point(43, 67);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.ReadOnly = true;
            this.textBoxList.Size = new System.Drawing.Size(638, 332);
            this.textBoxList.TabIndex = 2;
            this.textBoxList.Text = "";
            // 
            // CheckOutUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PaymentButton);
            this.Name = "CheckOutUC";
            this.Size = new System.Drawing.Size(695, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.RichTextBox textBoxList;
    }
}
