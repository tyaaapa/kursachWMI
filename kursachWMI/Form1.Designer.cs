namespace kursachWMI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.procCash = new System.Windows.Forms.Label();
            this.procTakt = new System.Windows.Forms.Label();
            this.procCore = new System.Windows.Forms.Label();
            this.procMan = new System.Windows.Forms.Label();
            this.procName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.videoDriver = new System.Windows.Forms.Label();
            this.videoDAC = new System.Windows.Forms.Label();
            this.videoRam = new System.Windows.Forms.Label();
            this.videoName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.procCash);
            this.tabPage1.Controls.Add(this.procTakt);
            this.tabPage1.Controls.Add(this.procCore);
            this.tabPage1.Controls.Add(this.procMan);
            this.tabPage1.Controls.Add(this.procName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Процессор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // procCash
            // 
            this.procCash.AutoSize = true;
            this.procCash.Location = new System.Drawing.Point(6, 116);
            this.procCash.Name = "procCash";
            this.procCash.Size = new System.Drawing.Size(52, 13);
            this.procCash.TabIndex = 4;
            this.procCash.Text = "procCash";
            // 
            // procTakt
            // 
            this.procTakt.AutoSize = true;
            this.procTakt.Location = new System.Drawing.Point(6, 91);
            this.procTakt.Name = "procTakt";
            this.procTakt.Size = new System.Drawing.Size(50, 13);
            this.procTakt.TabIndex = 3;
            this.procTakt.Text = "procTakt";
            // 
            // procCore
            // 
            this.procCore.AutoSize = true;
            this.procCore.Location = new System.Drawing.Point(6, 66);
            this.procCore.Name = "procCore";
            this.procCore.Size = new System.Drawing.Size(50, 13);
            this.procCore.TabIndex = 2;
            this.procCore.Text = "procCore";
            // 
            // procMan
            // 
            this.procMan.AutoSize = true;
            this.procMan.Location = new System.Drawing.Point(6, 40);
            this.procMan.Name = "procMan";
            this.procMan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.procMan.Size = new System.Drawing.Size(49, 13);
            this.procMan.TabIndex = 1;
            this.procMan.Text = "procMan";
            // 
            // procName
            // 
            this.procName.AutoSize = true;
            this.procName.Location = new System.Drawing.Point(6, 15);
            this.procName.Name = "procName";
            this.procName.Size = new System.Drawing.Size(56, 13);
            this.procName.TabIndex = 0;
            this.procName.Text = "procName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.videoDriver);
            this.tabPage2.Controls.Add(this.videoDAC);
            this.tabPage2.Controls.Add(this.videoRam);
            this.tabPage2.Controls.Add(this.videoName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(427, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Видеокарта";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // videoDriver
            // 
            this.videoDriver.AutoSize = true;
            this.videoDriver.Location = new System.Drawing.Point(7, 81);
            this.videoDriver.Name = "videoDriver";
            this.videoDriver.Size = new System.Drawing.Size(61, 13);
            this.videoDriver.TabIndex = 3;
            this.videoDriver.Text = "videoDriver";
            // 
            // videoDAC
            // 
            this.videoDAC.AutoSize = true;
            this.videoDAC.Location = new System.Drawing.Point(7, 59);
            this.videoDAC.Name = "videoDAC";
            this.videoDAC.Size = new System.Drawing.Size(55, 13);
            this.videoDAC.TabIndex = 2;
            this.videoDAC.Text = "videoDAC";
            // 
            // videoRam
            // 
            this.videoRam.AutoSize = true;
            this.videoRam.Location = new System.Drawing.Point(7, 35);
            this.videoRam.Name = "videoRam";
            this.videoRam.Size = new System.Drawing.Size(55, 13);
            this.videoRam.TabIndex = 1;
            this.videoRam.Text = "videoRam";
            // 
            // videoName
            // 
            this.videoName.AutoSize = true;
            this.videoName.Location = new System.Drawing.Point(7, 12);
            this.videoName.Name = "videoName";
            this.videoName.Size = new System.Drawing.Size(61, 13);
            this.videoName.TabIndex = 0;
            this.videoName.Text = "videoName";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(427, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Жесткий диск";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 432);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WMI project";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Label procName;
        private System.Windows.Forms.Label procMan;
        private System.Windows.Forms.Label procCash;
        private System.Windows.Forms.Label procTakt;
        private System.Windows.Forms.Label procCore;
        private System.Windows.Forms.Label videoName;
        private System.Windows.Forms.Label videoDriver;
        private System.Windows.Forms.Label videoDAC;
        private System.Windows.Forms.Label videoRam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

