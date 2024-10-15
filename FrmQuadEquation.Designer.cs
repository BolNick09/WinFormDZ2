namespace My_Form_2
{
    partial class FrmQuadEquation
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
            tbA = new TextBox();
            label1 = new Label();
            tbB = new TextBox();
            label2 = new Label();
            tbC = new TextBox();
            label3 = new Label();
            btnSolve = new Button();
            SuspendLayout();
            // 
            // tbA
            // 
            tbA.Location = new Point(37, 52);
            tbA.Name = "tbA";
            tbA.Size = new Size(42, 27);
            tbA.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 55);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "*x^2 + ";
            // 
            // tbB
            // 
            tbB.Location = new Point(149, 52);
            tbB.Name = "tbB";
            tbB.Size = new Size(42, 27);
            tbB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 55);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "*x +";
            
            // 
            // tbC
            // 
            tbC.Location = new Point(239, 52);
            tbC.Name = "tbC";
            tbC.Size = new Size(42, 27);
            tbC.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 55);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 5;
            label3.Text = " = 0";
            
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(37, 85);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(285, 29);
            btnSolve.TabIndex = 6;
            btnSolve.Text = "Решить уравнение";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // FrmQuadEquation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 130);
            Controls.Add(btnSolve);
            Controls.Add(label3);
            Controls.Add(tbC);
            Controls.Add(label2);
            Controls.Add(tbB);
            Controls.Add(label1);
            Controls.Add(tbA);
            Name = "FrmQuadEquation";
            Text = "FrmQuadEquation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbA;
        private Label label1;
        private TextBox tbB;
        private Label label2;
        private TextBox tbC;
        private Label label3;
        private Button btnSolve;
    }
}