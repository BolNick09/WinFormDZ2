namespace My_Form_2
{
    partial class FrmLesson
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdbMale = new RadioButton();
            pnlMain = new Panel();
            label7 = new Label();
            rdbFemale = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(123, 272);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(93, 24);
            rdbMale.TabIndex = 13;
            rdbMale.Text = "Мужской";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(label7);
            pnlMain.Controls.Add(rdbFemale);
            pnlMain.Controls.Add(rdbMale);
            pnlMain.Controls.Add(label6);
            pnlMain.Controls.Add(label5);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(dateTimePicker1);
            pnlMain.Controls.Add(textBox6);
            pnlMain.Controls.Add(textBox5);
            pnlMain.Controls.Add(textBox4);
            pnlMain.Controls.Add(textBox3);
            pnlMain.Controls.Add(textBox2);
            pnlMain.Controls.Add(textBox1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(374, 362);
            pnlMain.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F);
            label7.Location = new Point(12, 276);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 15;
            label7.Text = "Пол";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(222, 272);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(92, 24);
            rdbFemale.TabIndex = 14;
            rdbFemale.Text = "Женский";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F);
            label6.Location = new Point(12, 234);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 12;
            label6.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F);
            label5.Location = new Point(12, 201);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 11;
            label5.Text = "Город";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F);
            label4.Location = new Point(11, 168);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 10;
            label4.Text = "Страна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F);
            label3.Location = new Point(11, 103);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 9;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F);
            label2.Location = new Point(11, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 8;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F);
            label1.Location = new Point(11, 33);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 7;
            label1.Text = "Фамилия";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 302);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(102, 231);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(102, 198);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 362);
            Controls.Add(pnlMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private RadioButton rdbMale;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private RadioButton rdbFemale;
    }
}
