namespace KursKSIS_CLIENT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_leave = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button_leave
            // 
            this.button_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_leave.Location = new System.Drawing.Point(348, 247);
            this.button_leave.Name = "button_leave";
            this.button_leave.Size = new System.Drawing.Size(131, 46);
            this.button_leave.TabIndex = 0;
            this.button_leave.Text = "Leave";
            this.button_leave.UseVisualStyleBackColor = true;
            this.button_leave.Click += new System.EventHandler(this.button_leave_Click);
            // 
            // button_Info
            // 
            this.button_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Info.Location = new System.Drawing.Point(348, 172);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(131, 46);
            this.button_Info.TabIndex = 1;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Start
            // 
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(348, 93);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(131, 46);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.button_leave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_leave;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

