namespace My_Form_2
{
    partial class FrmDayOfWeek
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
            dtpGuessDay = new DateTimePicker();
            btnGetDay = new Button();
            SuspendLayout();
            // 
            // dtpGuessDay
            // 
            dtpGuessDay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpGuessDay.Location = new Point(12, 12);
            dtpGuessDay.Name = "dtpGuessDay";
            dtpGuessDay.Size = new Size(174, 27);
            dtpGuessDay.TabIndex = 0;
            // 
            // btnGetDay
            // 
            btnGetDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGetDay.Location = new Point(12, 45);
            btnGetDay.Name = "btnGetDay";
            btnGetDay.Size = new Size(174, 29);
            btnGetDay.TabIndex = 1;
            btnGetDay.Text = "Получить день недели";
            btnGetDay.UseVisualStyleBackColor = true;
            btnGetDay.Click += btnGetDay_Click;
            // 
            // FrmDayOfWeek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 92);
            Controls.Add(btnGetDay);
            Controls.Add(dtpGuessDay);
            Name = "FrmDayOfWeek";
            Text = "FrmDayOfWeek";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpGuessDay;
        private Button btnGetDay;
    }
}