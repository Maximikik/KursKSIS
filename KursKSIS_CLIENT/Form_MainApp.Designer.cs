namespace KursKSIS_CLIENT
{
    partial class Form_MainApp
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
            this.button_Learn = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_leave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Lec1 = new System.Windows.Forms.Button();
            this.button_Lec2 = new System.Windows.Forms.Button();
            this.button_Lec3 = new System.Windows.Forms.Button();
            this.listBox_Lesons = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Learn
            // 
            this.button_Learn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Learn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Learn.Location = new System.Drawing.Point(0, 0);
            this.button_Learn.Name = "button_Learn";
            this.button_Learn.Size = new System.Drawing.Size(601, 67);
            this.button_Learn.TabIndex = 0;
            this.button_Learn.Text = "Лекции";
            this.button_Learn.UseVisualStyleBackColor = true;
            this.button_Learn.Click += new System.EventHandler(this.button_Learn_Click);
            // 
            // button_Test
            // 
            this.button_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Test.Location = new System.Drawing.Point(607, 0);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(532, 67);
            this.button_Test.TabIndex = 1;
            this.button_Test.Text = "Тесты";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // button_leave
            // 
            this.button_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_leave.Location = new System.Drawing.Point(544, 589);
            this.button_leave.Name = "button_leave";
            this.button_leave.Size = new System.Drawing.Size(75, 30);
            this.button_leave.TabIndex = 2;
            this.button_leave.Text = "Выйти";
            this.button_leave.UseVisualStyleBackColor = true;
            this.button_leave.Click += new System.EventHandler(this.button_leave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_Lesons);
            this.panel1.Controls.Add(this.button_Lec3);
            this.panel1.Controls.Add(this.button_Lec2);
            this.panel1.Controls.Add(this.button_Lec1);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 510);
            this.panel1.TabIndex = 3;
            // 
            // button_Lec1
            // 
            this.button_Lec1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Lec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Lec1.Location = new System.Drawing.Point(27, 3);
            this.button_Lec1.Name = "button_Lec1";
            this.button_Lec1.Size = new System.Drawing.Size(145, 33);
            this.button_Lec1.TabIndex = 0;
            this.button_Lec1.Text = "Lesson 1";
            this.button_Lec1.UseVisualStyleBackColor = true;
            this.button_Lec1.Click += new System.EventHandler(this.button_Lec1_Click);
            // 
            // button_Lec2
            // 
            this.button_Lec2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Lec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Lec2.Location = new System.Drawing.Point(392, 3);
            this.button_Lec2.Name = "button_Lec2";
            this.button_Lec2.Size = new System.Drawing.Size(145, 33);
            this.button_Lec2.TabIndex = 1;
            this.button_Lec2.Text = "Lesson 3";
            this.button_Lec2.UseVisualStyleBackColor = true;
            this.button_Lec2.Click += new System.EventHandler(this.button_Lec2_Click);
            // 
            // button_Lec3
            // 
            this.button_Lec3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Lec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Lec3.Location = new System.Drawing.Point(204, 3);
            this.button_Lec3.Name = "button_Lec3";
            this.button_Lec3.Size = new System.Drawing.Size(145, 33);
            this.button_Lec3.TabIndex = 2;
            this.button_Lec3.Text = "Lesson 2";
            this.button_Lec3.UseVisualStyleBackColor = true;
            this.button_Lec3.Click += new System.EventHandler(this.button_Lec3_Click);
            // 
            // listBox_Lesons
            // 
            this.listBox_Lesons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Lesons.FormattingEnabled = true;
            this.listBox_Lesons.HorizontalScrollbar = true;
            this.listBox_Lesons.ItemHeight = 24;
            this.listBox_Lesons.Location = new System.Drawing.Point(3, 38);
            this.listBox_Lesons.Name = "listBox_Lesons";
            this.listBox_Lesons.Size = new System.Drawing.Size(1114, 460);
            this.listBox_Lesons.TabIndex = 3;
            this.listBox_Lesons.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_Lesons_DrawItem);
            // 
            // Form_MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_leave);
            this.Controls.Add(this.button_Test);
            this.Controls.Add(this.button_Learn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MainApp";
            this.Text = "Form_MainApp";
            this.Load += new System.EventHandler(this.Form_MainApp_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Learn;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Button button_leave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Lec3;
        private System.Windows.Forms.Button button_Lec2;
        private System.Windows.Forms.Button button_Lec1;
        private System.Windows.Forms.ListBox listBox_Lesons;
    }
}