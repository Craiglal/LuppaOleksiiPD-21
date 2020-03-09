namespace ButtonMove
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_no = new System.Windows.Forms.Button();
            this.bt_yes = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_no
            // 
            this.bt_no.Location = new System.Drawing.Point(162, 300);
            this.bt_no.Name = "bt_no";
            this.bt_no.Size = new System.Drawing.Size(75, 23);
            this.bt_no.TabIndex = 2;
            this.bt_no.TabStop = false;
            this.bt_no.Text = "No";
            this.bt_no.UseVisualStyleBackColor = true;
            // 
            // bt_yes
            // 
            this.bt_yes.Location = new System.Drawing.Point(162, 253);
            this.bt_yes.Name = "bt_yes";
            this.bt_yes.Size = new System.Drawing.Size(75, 23);
            this.bt_yes.TabIndex = 1;
            this.bt_yes.TabStop = false;
            this.bt_yes.Text = "Yes";
            this.bt_yes.UseVisualStyleBackColor = true;
            this.bt_yes.Click += new System.EventHandler(this.bt_yes_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 612);
            this.Controls.Add(this.bt_no);
            this.Controls.Add(this.bt_yes);
            this.Name = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_no;
        private System.Windows.Forms.Button bt_yes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

