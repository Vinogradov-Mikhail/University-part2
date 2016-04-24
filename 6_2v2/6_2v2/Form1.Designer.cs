namespace _6_2v2
{
    partial class ClockForMe
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
            this.clock = new System.Windows.Forms.Label();
            this.timerChange = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clock.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clock.Location = new System.Drawing.Point(12, 96);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(455, 60);
            this.clock.TabIndex = 0;
            this.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerChange
            // 
            this.timerChange.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClockForMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.clock);
            this.Name = "ClockForMe";
            this.Text = "Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timerChange;
    }
}

