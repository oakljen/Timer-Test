namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_starter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stop_timer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_starter
            // 
            this.timer_starter.Location = new System.Drawing.Point(143, 31);
            this.timer_starter.Name = "timer_starter";
            this.timer_starter.Size = new System.Drawing.Size(75, 23);
            this.timer_starter.TabIndex = 0;
            this.timer_starter.Text = "Start Timer";
            this.timer_starter.UseVisualStyleBackColor = true;
            this.timer_starter.Click += new System.EventHandler(this.timer_starter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // stop_timer
            // 
            this.stop_timer.Location = new System.Drawing.Point(143, 60);
            this.stop_timer.Name = "stop_timer";
            this.stop_timer.Size = new System.Drawing.Size(75, 23);
            this.stop_timer.TabIndex = 2;
            this.stop_timer.Text = "Stop Timer";
            this.stop_timer.UseVisualStyleBackColor = true;
            this.stop_timer.Click += new System.EventHandler(this.stop_timer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop_timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer_starter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button timer_starter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop_timer;
    }
}

