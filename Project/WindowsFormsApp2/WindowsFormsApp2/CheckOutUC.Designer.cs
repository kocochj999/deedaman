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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
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
            this.textBox1.Size = new System.Drawing.Size(333, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Mặt hàng";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(541, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Giá";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(398, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 31);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Số lượng";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(45, 414);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 31);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Tổng:";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(135, 414);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(241, 31);
            this.resultBox.TabIndex = 1;
            this.resultBox.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(43, 67);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(333, 242);
            this.textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(398, 67);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 31);
            this.textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(541, 67);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 31);
            this.textBox8.TabIndex = 1;
            // 
            // UserControlCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PaymentButton);
            this.Name = "UserControlCheckout";
            this.Size = new System.Drawing.Size(695, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}
