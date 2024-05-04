namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.razdel1 = new System.Windows.Forms.ListBox();
            this.razdel2 = new System.Windows.Forms.ListBox();
            this.buttonRightWord = new System.Windows.Forms.Button();
            this.buttonLeftWord = new System.Windows.Forms.Button();
            this.buttonRightLine = new System.Windows.Forms.Button();
            this.buttonLeftLine = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonSort1 = new System.Windows.Forms.Button();
            this.buttonSort2 = new System.Windows.Forms.Button();
            this.buttonClear1 = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SearchGrBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SearchGrBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Раздел 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Раздел 2";
            // 
            // razdel1
            // 
            this.razdel1.FormattingEnabled = true;
            this.razdel1.Location = new System.Drawing.Point(12, 64);
            this.razdel1.Name = "razdel1";
            this.razdel1.Size = new System.Drawing.Size(120, 160);
            this.razdel1.TabIndex = 2;
            this.razdel1.SelectedIndexChanged += new System.EventHandler(this.razdel1_SelectedIndexChanged);
            // 
            // razdel2
            // 
            this.razdel2.FormattingEnabled = true;
            this.razdel2.Location = new System.Drawing.Point(243, 64);
            this.razdel2.Name = "razdel2";
            this.razdel2.Size = new System.Drawing.Size(120, 160);
            this.razdel2.TabIndex = 3;
            // 
            // buttonRightWord
            // 
            this.buttonRightWord.Location = new System.Drawing.Point(152, 64);
            this.buttonRightWord.Name = "buttonRightWord";
            this.buttonRightWord.Size = new System.Drawing.Size(75, 23);
            this.buttonRightWord.TabIndex = 4;
            this.buttonRightWord.Text = ">";
            this.buttonRightWord.UseVisualStyleBackColor = true;
            // 
            // buttonLeftWord
            // 
            this.buttonLeftWord.Location = new System.Drawing.Point(152, 108);
            this.buttonLeftWord.Name = "buttonLeftWord";
            this.buttonLeftWord.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftWord.TabIndex = 5;
            this.buttonLeftWord.Text = "<";
            this.buttonLeftWord.UseVisualStyleBackColor = true;
            // 
            // buttonRightLine
            // 
            this.buttonRightLine.Location = new System.Drawing.Point(152, 153);
            this.buttonRightLine.Name = "buttonRightLine";
            this.buttonRightLine.Size = new System.Drawing.Size(75, 23);
            this.buttonRightLine.TabIndex = 6;
            this.buttonRightLine.Text = ">>";
            this.buttonRightLine.UseVisualStyleBackColor = true;
            // 
            // buttonLeftLine
            // 
            this.buttonLeftLine.Location = new System.Drawing.Point(152, 191);
            this.buttonLeftLine.Name = "buttonLeftLine";
            this.buttonLeftLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftLine.TabIndex = 7;
            this.buttonLeftLine.Text = "<<";
            this.buttonLeftLine.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(242, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // buttonSort1
            // 
            this.buttonSort1.Location = new System.Drawing.Point(31, 230);
            this.buttonSort1.Name = "buttonSort1";
            this.buttonSort1.Size = new System.Drawing.Size(84, 23);
            this.buttonSort1.TabIndex = 10;
            this.buttonSort1.Text = "Сортировать";
            this.buttonSort1.UseVisualStyleBackColor = true;
            // 
            // buttonSort2
            // 
            this.buttonSort2.Location = new System.Drawing.Point(257, 230);
            this.buttonSort2.Name = "buttonSort2";
            this.buttonSort2.Size = new System.Drawing.Size(84, 23);
            this.buttonSort2.TabIndex = 11;
            this.buttonSort2.Text = "Сортировать";
            this.buttonSort2.UseVisualStyleBackColor = true;
            // 
            // buttonClear1
            // 
            this.buttonClear1.Location = new System.Drawing.Point(31, 273);
            this.buttonClear1.Name = "buttonClear1";
            this.buttonClear1.Size = new System.Drawing.Size(84, 23);
            this.buttonClear1.TabIndex = 12;
            this.buttonClear1.Text = "Очистить";
            this.buttonClear1.UseVisualStyleBackColor = true;
            // 
            // buttonClear2
            // 
            this.buttonClear2.Location = new System.Drawing.Point(257, 273);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(84, 23);
            this.buttonClear2.TabIndex = 13;
            this.buttonClear2.Text = "Очистить";
            this.buttonClear2.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(152, 272);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // SearchGrBox
            // 
            this.SearchGrBox.Controls.Add(this.buttonFind);
            this.SearchGrBox.Controls.Add(this.listBox3);
            this.SearchGrBox.Controls.Add(this.checkBox2);
            this.SearchGrBox.Controls.Add(this.checkBox1);
            this.SearchGrBox.Controls.Add(this.textBox1);
            this.SearchGrBox.Controls.Add(this.label3);
            this.SearchGrBox.Location = new System.Drawing.Point(15, 366);
            this.SearchGrBox.Name = "SearchGrBox";
            this.SearchGrBox.Size = new System.Drawing.Size(239, 174);
            this.SearchGrBox.TabIndex = 15;
            this.SearchGrBox.TabStop = false;
            this.SearchGrBox.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите искомое слово";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(156, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Раздел 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(156, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Раздел 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(10, 62);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 4;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(156, 90);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(72, 67);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(272, 419);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 42);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(272, 494);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(91, 46);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 334);
            this.textBox2.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(415, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 174);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор слов";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Все";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(128, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Содержащие цифры";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(121, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Содержащие e-mail";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(152, 230);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 552);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.SearchGrBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear2);
            this.Controls.Add(this.buttonClear1);
            this.Controls.Add(this.buttonSort2);
            this.Controls.Add(this.buttonSort1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonLeftLine);
            this.Controls.Add(this.buttonRightLine);
            this.Controls.Add(this.buttonLeftWord);
            this.Controls.Add(this.buttonRightWord);
            this.Controls.Add(this.razdel2);
            this.Controls.Add(this.razdel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SearchGrBox.ResumeLayout(false);
            this.SearchGrBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.ListBox razdel1;
        public System.Windows.Forms.ListBox razdel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonRightWord;
        public System.Windows.Forms.Button buttonLeftWord;
        public System.Windows.Forms.Button buttonRightLine;
        public System.Windows.Forms.Button buttonLeftLine;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Button buttonSort1;
        public System.Windows.Forms.Button buttonSort2;
        public System.Windows.Forms.Button buttonClear1;
        public System.Windows.Forms.Button buttonClear2;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.GroupBox SearchGrBox;
        public System.Windows.Forms.Button buttonReset;
        public System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button buttonAdd;
    }
}

