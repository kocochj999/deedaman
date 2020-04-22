namespace WindowsFormsApp2
{
    partial class ItemUC
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 198);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(147, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Cơm rang thập cẩm";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.SystemColors.Control;
            this.labelPrice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(156, 198);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 23);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "30000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "đ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số lượng";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(160, 228);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(76, 20);
            this.numericQuantity.TabIndex = 2;
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // ItemUC
            // 
            this.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.AutoSize = true;
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ItemUC";
            this.Size = new System.Drawing.Size(259, 269);
            this.Load += new System.EventHandler(this.UserControlFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericQuantity;
    }
}
