namespace Lab5
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
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.txtMarsWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtObjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVenusWeight = new System.Windows.Forms.TextBox();
            this.txtMercuryWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Location = new System.Drawing.Point(234, 421);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(194, 20);
            this.txtEarthWeight.TabIndex = 1;
            // 
            // txtMarsWeight
            // 
            this.txtMarsWeight.Location = new System.Drawing.Point(596, 263);
            this.txtMarsWeight.Name = "txtMarsWeight";
            this.txtMarsWeight.ReadOnly = true;
            this.txtMarsWeight.Size = new System.Drawing.Size(194, 20);
            this.txtMarsWeight.TabIndex = 2;
            this.txtMarsWeight.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight on Earth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight on Mars";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(234, 459);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtObjectName
            // 
            this.txtObjectName.Location = new System.Drawing.Point(234, 385);
            this.txtObjectName.MaxLength = 50;
            this.txtObjectName.Name = "txtObjectName";
            this.txtObjectName.Size = new System.Drawing.Size(194, 20);
            this.txtObjectName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(128, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Object Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 542);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Weight on Venus";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtVenusWeight
            // 
            this.txtVenusWeight.Location = new System.Drawing.Point(596, 237);
            this.txtVenusWeight.Name = "txtVenusWeight";
            this.txtVenusWeight.ReadOnly = true;
            this.txtVenusWeight.Size = new System.Drawing.Size(194, 20);
            this.txtVenusWeight.TabIndex = 9;
            this.txtVenusWeight.TabStop = false;
            // 
            // txtMercuryWeight
            // 
            this.txtMercuryWeight.Location = new System.Drawing.Point(596, 211);
            this.txtMercuryWeight.Name = "txtMercuryWeight";
            this.txtMercuryWeight.ReadOnly = true;
            this.txtMercuryWeight.Size = new System.Drawing.Size(194, 20);
            this.txtMercuryWeight.TabIndex = 10;
            this.txtMercuryWeight.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Weight on Mercury";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMercuryWeight);
            this.Controls.Add(this.txtVenusWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObjectName);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarsWeight);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Planetary Weight Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.TextBox txtMarsWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtObjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVenusWeight;
        private System.Windows.Forms.TextBox txtMercuryWeight;
        private System.Windows.Forms.Label label5;
    }
}

