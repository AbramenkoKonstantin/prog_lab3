namespace Prog_lab3
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
            this.startDate = new System.Windows.Forms.TextBox();
            this.plusRB = new System.Windows.Forms.RadioButton();
            this.minusRB = new System.Windows.Forms.RadioButton();
            this.dataTB = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.equalityStartButton = new System.Windows.Forms.Button();
            this.dateForEquality = new System.Windows.Forms.TextBox();
            this.unEqualityRB = new System.Windows.Forms.RadioButton();
            this.equalityRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.equalityResult = new System.Windows.Forms.TextBox();
            this.dateFormat1 = new System.Windows.Forms.TextBox();
            this.dateFormat2 = new System.Windows.Forms.TextBox();
            this.dateFormat3 = new System.Windows.Forms.TextBox();
            this.dateFormat4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Enabled = false;
            this.startDate.Location = new System.Drawing.Point(6, 19);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(100, 20);
            this.startDate.TabIndex = 0;
            // 
            // plusRB
            // 
            this.plusRB.AutoSize = true;
            this.plusRB.Location = new System.Drawing.Point(126, 57);
            this.plusRB.Name = "plusRB";
            this.plusRB.Size = new System.Drawing.Size(31, 17);
            this.plusRB.TabIndex = 1;
            this.plusRB.TabStop = true;
            this.plusRB.Text = "+";
            this.plusRB.UseVisualStyleBackColor = true;
            // 
            // minusRB
            // 
            this.minusRB.AutoSize = true;
            this.minusRB.Location = new System.Drawing.Point(173, 57);
            this.minusRB.Name = "minusRB";
            this.minusRB.Size = new System.Drawing.Size(28, 17);
            this.minusRB.TabIndex = 2;
            this.minusRB.TabStop = true;
            this.minusRB.Text = "-";
            this.minusRB.UseVisualStyleBackColor = true;
            // 
            // dataTB
            // 
            this.dataTB.Location = new System.Drawing.Point(6, 54);
            this.dataTB.Name = "dataTB";
            this.dataTB.Size = new System.Drawing.Size(100, 20);
            this.dataTB.TabIndex = 3;
            this.dataTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForDays);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(126, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton);
            // 
            // equalityStartButton
            // 
            this.equalityStartButton.Location = new System.Drawing.Point(126, 16);
            this.equalityStartButton.Name = "equalityStartButton";
            this.equalityStartButton.Size = new System.Drawing.Size(75, 23);
            this.equalityStartButton.TabIndex = 9;
            this.equalityStartButton.Text = "Старт";
            this.equalityStartButton.UseVisualStyleBackColor = true;
            this.equalityStartButton.Click += new System.EventHandler(this.EqulityStartButton);
            // 
            // dateForEquality
            // 
            this.dateForEquality.Location = new System.Drawing.Point(6, 19);
            this.dateForEquality.Name = "dateForEquality";
            this.dateForEquality.Size = new System.Drawing.Size(100, 20);
            this.dateForEquality.TabIndex = 8;
            this.dateForEquality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForEquality);
            // 
            // unEqualityRB
            // 
            this.unEqualityRB.AutoSize = true;
            this.unEqualityRB.Location = new System.Drawing.Point(167, 58);
            this.unEqualityRB.Name = "unEqualityRB";
            this.unEqualityRB.Size = new System.Drawing.Size(34, 17);
            this.unEqualityRB.TabIndex = 7;
            this.unEqualityRB.TabStop = true;
            this.unEqualityRB.Text = "!=";
            this.unEqualityRB.UseVisualStyleBackColor = true;
            // 
            // equalityRB
            // 
            this.equalityRB.AutoSize = true;
            this.equalityRB.Location = new System.Drawing.Point(126, 57);
            this.equalityRB.Name = "equalityRB";
            this.equalityRB.Size = new System.Drawing.Size(37, 17);
            this.equalityRB.TabIndex = 6;
            this.equalityRB.TabStop = true;
            this.equalityRB.Text = "==";
            this.equalityRB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.dataTB);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Controls.Add(this.plusRB);
            this.groupBox1.Controls.Add(this.minusRB);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 116);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сложение/вычитание";
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(6, 90);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.equalityResult);
            this.groupBox2.Controls.Add(this.equalityRB);
            this.groupBox2.Controls.Add(this.unEqualityRB);
            this.groupBox2.Controls.Add(this.equalityStartButton);
            this.groupBox2.Controls.Add(this.dateForEquality);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 94);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сравнение";
            // 
            // equalityResult
            // 
            this.equalityResult.Enabled = false;
            this.equalityResult.Location = new System.Drawing.Point(6, 57);
            this.equalityResult.Name = "equalityResult";
            this.equalityResult.Size = new System.Drawing.Size(100, 20);
            this.equalityResult.TabIndex = 10;
            // 
            // dateFormat1
            // 
            this.dateFormat1.Enabled = false;
            this.dateFormat1.Location = new System.Drawing.Point(12, 234);
            this.dateFormat1.Name = "dateFormat1";
            this.dateFormat1.Size = new System.Drawing.Size(214, 20);
            this.dateFormat1.TabIndex = 12;
            // 
            // dateFormat2
            // 
            this.dateFormat2.Enabled = false;
            this.dateFormat2.Location = new System.Drawing.Point(12, 260);
            this.dateFormat2.Name = "dateFormat2";
            this.dateFormat2.Size = new System.Drawing.Size(214, 20);
            this.dateFormat2.TabIndex = 13;
            // 
            // dateFormat3
            // 
            this.dateFormat3.Enabled = false;
            this.dateFormat3.Location = new System.Drawing.Point(12, 286);
            this.dateFormat3.Name = "dateFormat3";
            this.dateFormat3.Size = new System.Drawing.Size(214, 20);
            this.dateFormat3.TabIndex = 14;
            // 
            // dateFormat4
            // 
            this.dateFormat4.Enabled = false;
            this.dateFormat4.Location = new System.Drawing.Point(12, 312);
            this.dateFormat4.Name = "dateFormat4";
            this.dateFormat4.Size = new System.Drawing.Size(214, 20);
            this.dateFormat4.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 341);
            this.Controls.Add(this.dateFormat4);
            this.Controls.Add(this.dateFormat3);
            this.Controls.Add(this.dateFormat2);
            this.Controls.Add(this.dateFormat1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.RadioButton plusRB;
        private System.Windows.Forms.RadioButton minusRB;
        private System.Windows.Forms.TextBox dataTB;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button equalityStartButton;
        private System.Windows.Forms.TextBox dateForEquality;
        private System.Windows.Forms.RadioButton unEqualityRB;
        private System.Windows.Forms.RadioButton equalityRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dateFormat1;
        private System.Windows.Forms.TextBox dateFormat2;
        private System.Windows.Forms.TextBox dateFormat3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox equalityResult;
        private System.Windows.Forms.TextBox dateFormat4;
    }
}

