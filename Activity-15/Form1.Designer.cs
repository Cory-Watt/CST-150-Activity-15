namespace Activity_15
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
            this.birthYear = new System.Windows.Forms.ComboBox();
            this.birthMonth = new System.Windows.Forms.ComboBox();
            this.favoriteColor = new System.Windows.Forms.ComboBox();
            this.birthDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuckyNumber = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthYear
            // 
            this.birthYear.BackColor = System.Drawing.Color.Turquoise;
            this.birthYear.FormattingEnabled = true;
            this.birthYear.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.birthYear.Location = new System.Drawing.Point(183, 19);
            this.birthYear.Name = "birthYear";
            this.birthYear.Size = new System.Drawing.Size(121, 21);
            this.birthYear.TabIndex = 0;
            this.birthYear.SelectedIndexChanged += new System.EventHandler(this.birthYear_SelectedIndexChanged);
            // 
            // birthMonth
            // 
            this.birthMonth.BackColor = System.Drawing.Color.Turquoise;
            this.birthMonth.FormattingEnabled = true;
            this.birthMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.birthMonth.Location = new System.Drawing.Point(183, 56);
            this.birthMonth.Name = "birthMonth";
            this.birthMonth.Size = new System.Drawing.Size(121, 21);
            this.birthMonth.TabIndex = 1;
            this.birthMonth.SelectedIndexChanged += new System.EventHandler(this.birthMonth_SelectedIndexChanged);
            // 
            // favoriteColor
            // 
            this.favoriteColor.BackColor = System.Drawing.Color.Turquoise;
            this.favoriteColor.FormattingEnabled = true;
            this.favoriteColor.Items.AddRange(new object[] {
            "Black",
            "Green",
            "Blue",
            "Red",
            "Purple",
            "Yellow",
            "Orange",
            "Magenta",
            "Brown",
            "White"});
            this.favoriteColor.Location = new System.Drawing.Point(183, 132);
            this.favoriteColor.Name = "favoriteColor";
            this.favoriteColor.Size = new System.Drawing.Size(121, 21);
            this.favoriteColor.TabIndex = 2;
            // 
            // birthDay
            // 
            this.birthDay.BackColor = System.Drawing.Color.Turquoise;
            this.birthDay.FormattingEnabled = true;
            this.birthDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.birthDay.Location = new System.Drawing.Point(183, 92);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(121, 21);
            this.birthDay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your birth year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your birth month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter your birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter your favorite color:";
            // 
            // btnLuckyNumber
            // 
            this.btnLuckyNumber.BackColor = System.Drawing.Color.Turquoise;
            this.btnLuckyNumber.Location = new System.Drawing.Point(34, 195);
            this.btnLuckyNumber.Name = "btnLuckyNumber";
            this.btnLuckyNumber.Size = new System.Drawing.Size(256, 41);
            this.btnLuckyNumber.TabIndex = 8;
            this.btnLuckyNumber.Text = "Get your lucky number!";
            this.btnLuckyNumber.UseVisualStyleBackColor = false;
            this.btnLuckyNumber.Click += new System.EventHandler(this.btnLuckyNumber_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLuckyNumber);
            this.panel1.Controls.Add(this.birthYear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.birthMonth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.favoriteColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.birthDay);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 261);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(363, 291);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox birthYear;
        private System.Windows.Forms.ComboBox birthMonth;
        private System.Windows.Forms.ComboBox favoriteColor;
        private System.Windows.Forms.ComboBox birthDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuckyNumber;
        private System.Windows.Forms.Panel panel1;
    }
}