namespace Application_interface
{
    partial class booking
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bookidTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tstatiTxt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.jdateDate = new System.Windows.Forms.DateTimePicker();
            this.bookstCb = new System.Windows.Forms.ComboBox();
            this.fstatiCb = new System.Windows.Forms.ComboBox();
            this.trainidTxt = new System.Windows.Forms.TextBox();
            this.bdateDate = new System.Windows.Forms.DateTimePicker();
            this.amountCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(217, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(614, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Railway Service Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 551);
            this.panel1.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 92);
            this.panel4.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(17, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 34);
            this.label14.TabIndex = 23;
            this.label14.Text = "BOOKING";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(259, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 188);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Booking ID";
            // 
            // bookidTxt
            // 
            this.bookidTxt.Location = new System.Drawing.Point(145, 49);
            this.bookidTxt.Multiline = true;
            this.bookidTxt.Name = "bookidTxt";
            this.bookidTxt.Size = new System.Drawing.Size(121, 21);
            this.bookidTxt.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(342, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "To Station";
            // 
            // tstatiTxt
            // 
            this.tstatiTxt.FormattingEnabled = true;
            this.tstatiTxt.Items.AddRange(new object[] {
            "Malindi",
            "Dodoma",
            "Harare",
            "Port Harcourt"});
            this.tstatiTxt.Location = new System.Drawing.Point(436, 92);
            this.tstatiTxt.Name = "tstatiTxt";
            this.tstatiTxt.Size = new System.Drawing.Size(121, 21);
            this.tstatiTxt.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(270, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(386, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Buy Ticket";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(160, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.amountCb);
            this.panel5.Controls.Add(this.bdateDate);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.trainidTxt);
            this.panel5.Controls.Add(this.fstatiCb);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.bookstCb);
            this.panel5.Controls.Add(this.jdateDate);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.tstatiTxt);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.bookidTxt);
            this.panel5.Location = new System.Drawing.Point(211, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 334);
            this.panel5.TabIndex = 34;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "From Station";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "Train ID";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "Journey Date";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(371, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(298, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 21);
            this.label16.TabIndex = 32;
            this.label16.Text = "Booking Station";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 21);
            this.label17.TabIndex = 33;
            this.label17.Text = "Booking Date";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // jdateDate
            // 
            this.jdateDate.Location = new System.Drawing.Point(145, 227);
            this.jdateDate.Name = "jdateDate";
            this.jdateDate.Size = new System.Drawing.Size(200, 20);
            this.jdateDate.TabIndex = 35;
            // 
            // bookstCb
            // 
            this.bookstCb.FormattingEnabled = true;
            this.bookstCb.Items.AddRange(new object[] {
            "Booked ",
            "Not Booked"});
            this.bookstCb.Location = new System.Drawing.Point(436, 133);
            this.bookstCb.Name = "bookstCb";
            this.bookstCb.Size = new System.Drawing.Size(121, 21);
            this.bookstCb.TabIndex = 36;
            this.bookstCb.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // fstatiCb
            // 
            this.fstatiCb.FormattingEnabled = true;
            this.fstatiCb.Items.AddRange(new object[] {
            "Mombasa",
            "Nairobi",
            "Kisumu",
            "Lamu"});
            this.fstatiCb.Location = new System.Drawing.Point(145, 89);
            this.fstatiCb.Name = "fstatiCb";
            this.fstatiCb.Size = new System.Drawing.Size(121, 21);
            this.fstatiCb.TabIndex = 37;
            // 
            // trainidTxt
            // 
            this.trainidTxt.Location = new System.Drawing.Point(145, 136);
            this.trainidTxt.Multiline = true;
            this.trainidTxt.Name = "trainidTxt";
            this.trainidTxt.Size = new System.Drawing.Size(121, 21);
            this.trainidTxt.TabIndex = 38;
            this.trainidTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bdateDate
            // 
            this.bdateDate.Location = new System.Drawing.Point(145, 179);
            this.bdateDate.Name = "bdateDate";
            this.bdateDate.Size = new System.Drawing.Size(200, 20);
            this.bdateDate.TabIndex = 39;
            // 
            // amountCb
            // 
            this.amountCb.FormattingEnabled = true;
            this.amountCb.Items.AddRange(new object[] {
            "200",
            "450",
            "500",
            "600",
            "1000"});
            this.amountCb.Location = new System.Drawing.Point(449, 251);
            this.amountCb.Name = "amountCb";
            this.amountCb.Size = new System.Drawing.Size(121, 21);
            this.amountCb.TabIndex = 40;
            // 
            // booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "booking";
            this.Text = "CustomerInterface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookidTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tstatiTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker jdateDate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox bookstCb;
        private System.Windows.Forms.TextBox trainidTxt;
        private System.Windows.Forms.ComboBox fstatiCb;
        private System.Windows.Forms.DateTimePicker bdateDate;
        private System.Windows.Forms.ComboBox amountCb;
    }
}