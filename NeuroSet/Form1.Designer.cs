﻿namespace NeuroSet
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawField = new System.Windows.Forms.PictureBox();
            this.selectedSymbol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_SaveSymbol = new System.Windows.Forms.Button();
            this.b_LoadSymbol = new System.Windows.Forms.Button();
            this.b_ClearField = new System.Windows.Forms.Button();
            this.b_SaveInFile = new System.Windows.Forms.Button();
            this.b_ReadFromFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawField)).BeginInit();
            this.SuspendLayout();
            // 
            // drawField
            // 
            this.drawField.InitialImage = null;
            this.drawField.Location = new System.Drawing.Point(12, 12);
            this.drawField.Name = "drawField";
            this.drawField.Size = new System.Drawing.Size(301, 301);
            this.drawField.TabIndex = 0;
            this.drawField.TabStop = false;
            this.drawField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawField_MouseClick);
            // 
            // selectedSymbol
            // 
            this.selectedSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedSymbol.FormattingEnabled = true;
            this.selectedSymbol.Items.AddRange(new object[] {
            "А",
            "Б",
            "В",
            "Г",
            "Д",
            "Е",
            "Ё",
            "Ж",
            "З",
            "И",
            "Й",
            "К",
            "Л",
            "М",
            "Н",
            "О",
            "П",
            "Р",
            "С",
            "Т",
            "У",
            "Ф",
            "Х",
            "Ц",
            "Ч",
            "Ш",
            "Щ",
            "Ъ",
            "Ы",
            "Ь",
            "Э",
            "Ю",
            "Я",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.selectedSymbol.Location = new System.Drawing.Point(67, 319);
            this.selectedSymbol.Name = "selectedSymbol";
            this.selectedSymbol.Size = new System.Drawing.Size(46, 21);
            this.selectedSymbol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Символ:";
            // 
            // b_SaveSymbol
            // 
            this.b_SaveSymbol.Location = new System.Drawing.Point(119, 317);
            this.b_SaveSymbol.Name = "b_SaveSymbol";
            this.b_SaveSymbol.Size = new System.Drawing.Size(69, 23);
            this.b_SaveSymbol.TabIndex = 3;
            this.b_SaveSymbol.Text = "Сохранить";
            this.b_SaveSymbol.UseVisualStyleBackColor = true;
            this.b_SaveSymbol.Click += new System.EventHandler(this.b_SaveSymbol_Click);
            // 
            // b_LoadSymbol
            // 
            this.b_LoadSymbol.Location = new System.Drawing.Point(194, 317);
            this.b_LoadSymbol.Name = "b_LoadSymbol";
            this.b_LoadSymbol.Size = new System.Drawing.Size(69, 23);
            this.b_LoadSymbol.TabIndex = 4;
            this.b_LoadSymbol.Text = "Загрузить";
            this.b_LoadSymbol.UseVisualStyleBackColor = true;
            this.b_LoadSymbol.Click += new System.EventHandler(this.b_LoadSymbol_Click);
            // 
            // b_ClearField
            // 
            this.b_ClearField.Location = new System.Drawing.Point(269, 317);
            this.b_ClearField.Name = "b_ClearField";
            this.b_ClearField.Size = new System.Drawing.Size(44, 23);
            this.b_ClearField.TabIndex = 5;
            this.b_ClearField.Text = "DEL";
            this.b_ClearField.UseVisualStyleBackColor = true;
            this.b_ClearField.Click += new System.EventHandler(this.b_ClearField_Click);
            // 
            // b_SaveInFile
            // 
            this.b_SaveInFile.Location = new System.Drawing.Point(15, 346);
            this.b_SaveInFile.Name = "b_SaveInFile";
            this.b_SaveInFile.Size = new System.Drawing.Size(133, 23);
            this.b_SaveInFile.TabIndex = 6;
            this.b_SaveInFile.Text = "Сохранить в файл";
            this.b_SaveInFile.UseVisualStyleBackColor = true;
            this.b_SaveInFile.Click += new System.EventHandler(this.b_SaveInFile_Click);
            // 
            // b_ReadFromFile
            // 
            this.b_ReadFromFile.Location = new System.Drawing.Point(180, 346);
            this.b_ReadFromFile.Name = "b_ReadFromFile";
            this.b_ReadFromFile.Size = new System.Drawing.Size(133, 23);
            this.b_ReadFromFile.TabIndex = 7;
            this.b_ReadFromFile.Text = "Загрузить из файла";
            this.b_ReadFromFile.UseVisualStyleBackColor = true;
            this.b_ReadFromFile.Click += new System.EventHandler(this.b_ReadFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 403);
            this.Controls.Add(this.b_ReadFromFile);
            this.Controls.Add(this.b_SaveInFile);
            this.Controls.Add(this.b_ClearField);
            this.Controls.Add(this.b_LoadSymbol);
            this.Controls.Add(this.b_SaveSymbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedSymbol);
            this.Controls.Add(this.drawField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нейро Сеть";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectedSymbol;
        private System.Windows.Forms.Button b_SaveSymbol;
        private System.Windows.Forms.Button b_LoadSymbol;
        private System.Windows.Forms.Button b_ClearField;
        private System.Windows.Forms.Button b_SaveInFile;
        private System.Windows.Forms.Button b_ReadFromFile;




    }
}

