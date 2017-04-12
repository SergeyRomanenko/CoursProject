namespace cours
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
            this.button1 = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Малювати фігури";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb1
            // 
            this.pb1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb1.Location = new System.Drawing.Point(0, 24);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(442, 465);
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(789, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 67);
            this.button2.TabIndex = 4;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(448, 24);
            this.txb1.Multiline = true;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(335, 465);
            this.txb1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(790, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 63);
            this.button3.TabIndex = 6;
            this.button3.Text = "Показати точки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(790, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 65);
            this.button4.TabIndex = 7;
            this.button4.Text = "Інфо про фігури (вивести и записати)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(790, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 62);
            this.button5.TabIndex = 8;
            this.button5.Text = "Приховати точки та інфо про фігури";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(899, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 64);
            this.button6.TabIndex = 9;
            this.button6.Text = "Інфо про фігури показати";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(898, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 67);
            this.button7.TabIndex = 10;
            this.button7.Text = "Зафарбувати, провести діагоналі";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 489);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
    }
}

