namespace ЛР7
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
            this.PeopleLB = new System.Windows.Forms.ListBox();
            this.NameL = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.BalanceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetMessageBTN = new System.Windows.Forms.Button();
            this.GetMessageStringBTN = new System.Windows.Forms.Button();
            this.SendMessageBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CompareCmB = new System.Windows.Forms.ComboBox();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.MessageRTB = new System.Windows.Forms.RichTextBox();
            this.TransferCmB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendMoneyTB = new System.Windows.Forms.TextBox();
            this.SendMoneyBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleLB
            // 
            this.PeopleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleLB.FormattingEnabled = true;
            this.PeopleLB.ItemHeight = 20;
            this.PeopleLB.Location = new System.Drawing.Point(12, 12);
            this.PeopleLB.Name = "PeopleLB";
            this.PeopleLB.Size = new System.Drawing.Size(240, 364);
            this.PeopleLB.TabIndex = 0;
            this.PeopleLB.DoubleClick += new System.EventHandler(this.PeopleLB_DoubleClick);
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameL.Location = new System.Drawing.Point(258, 15);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(44, 20);
            this.NameL.TabIndex = 1;
            this.NameL.Text = "Имя:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(333, 12);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(203, 26);
            this.NameTB.TabIndex = 2;
            // 
            // BalanceTB
            // 
            this.BalanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceTB.Location = new System.Drawing.Point(333, 44);
            this.BalanceTB.Name = "BalanceTB";
            this.BalanceTB.Size = new System.Drawing.Size(203, 26);
            this.BalanceTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(258, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Баланс:";
            // 
            // GetMessageBTN
            // 
            this.GetMessageBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetMessageBTN.Location = new System.Drawing.Point(262, 114);
            this.GetMessageBTN.Name = "GetMessageBTN";
            this.GetMessageBTN.Size = new System.Drawing.Size(274, 32);
            this.GetMessageBTN.TabIndex = 5;
            this.GetMessageBTN.Text = "Вывести сообщение";
            this.GetMessageBTN.UseVisualStyleBackColor = true;
            this.GetMessageBTN.Visible = false;
            this.GetMessageBTN.Click += new System.EventHandler(this.GetMessageBTN_Click);
            // 
            // GetMessageStringBTN
            // 
            this.GetMessageStringBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetMessageStringBTN.Location = new System.Drawing.Point(262, 152);
            this.GetMessageStringBTN.Name = "GetMessageStringBTN";
            this.GetMessageStringBTN.Size = new System.Drawing.Size(274, 32);
            this.GetMessageStringBTN.TabIndex = 6;
            this.GetMessageStringBTN.Text = "Вывести сообщение прописью";
            this.GetMessageStringBTN.UseVisualStyleBackColor = true;
            this.GetMessageStringBTN.Visible = false;
            this.GetMessageStringBTN.Click += new System.EventHandler(this.GetMessageStringBTN_Click);
            // 
            // SendMessageBTN
            // 
            this.SendMessageBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMessageBTN.Location = new System.Drawing.Point(262, 245);
            this.SendMessageBTN.Name = "SendMessageBTN";
            this.SendMessageBTN.Size = new System.Drawing.Size(274, 32);
            this.SendMessageBTN.TabIndex = 7;
            this.SendMessageBTN.Text = "Отправить сообщение";
            this.SendMessageBTN.UseVisualStyleBackColor = true;
            this.SendMessageBTN.Visible = false;
            this.SendMessageBTN.Click += new System.EventHandler(this.SendMessageBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(258, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сравнить с:";
            this.label2.Visible = false;
            // 
            // CompareCmB
            // 
            this.CompareCmB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompareCmB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompareCmB.FormattingEnabled = true;
            this.CompareCmB.Location = new System.Drawing.Point(363, 283);
            this.CompareCmB.MaxDropDownItems = 2;
            this.CompareCmB.Name = "CompareCmB";
            this.CompareCmB.Size = new System.Drawing.Size(173, 28);
            this.CompareCmB.TabIndex = 9;
            this.CompareCmB.Visible = false;
            this.CompareCmB.SelectedIndexChanged += new System.EventHandler(this.CompareCmB_SelectedIndexChanged);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBTN.Location = new System.Drawing.Point(262, 76);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(167, 32);
            this.SaveBTN.TabIndex = 10;
            this.SaveBTN.Text = "Сохранить";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // MessageRTB
            // 
            this.MessageRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageRTB.Location = new System.Drawing.Point(262, 190);
            this.MessageRTB.Name = "MessageRTB";
            this.MessageRTB.Size = new System.Drawing.Size(274, 49);
            this.MessageRTB.TabIndex = 11;
            this.MessageRTB.Text = "";
            this.MessageRTB.Visible = false;
            // 
            // TransferCmB
            // 
            this.TransferCmB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransferCmB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferCmB.FormattingEnabled = true;
            this.TransferCmB.Location = new System.Drawing.Point(363, 317);
            this.TransferCmB.MaxDropDownItems = 2;
            this.TransferCmB.Name = "TransferCmB";
            this.TransferCmB.Size = new System.Drawing.Size(173, 28);
            this.TransferCmB.TabIndex = 13;
            this.TransferCmB.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(258, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Перевести:";
            this.label3.Visible = false;
            // 
            // SendMoneyTB
            // 
            this.SendMoneyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMoneyTB.Location = new System.Drawing.Point(262, 351);
            this.SendMoneyTB.Name = "SendMoneyTB";
            this.SendMoneyTB.Size = new System.Drawing.Size(167, 26);
            this.SendMoneyTB.TabIndex = 14;
            this.SendMoneyTB.Visible = false;
            // 
            // SendMoneyBTN
            // 
            this.SendMoneyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMoneyBTN.Location = new System.Drawing.Point(435, 348);
            this.SendMoneyBTN.Name = "SendMoneyBTN";
            this.SendMoneyBTN.Size = new System.Drawing.Size(101, 32);
            this.SendMoneyBTN.TabIndex = 15;
            this.SendMoneyBTN.Text = "Отправить";
            this.SendMoneyBTN.UseVisualStyleBackColor = true;
            this.SendMoneyBTN.Visible = false;
            this.SendMoneyBTN.Click += new System.EventHandler(this.SendMoneyBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBTN.Location = new System.Drawing.Point(435, 76);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(101, 32);
            this.CloseBTN.TabIndex = 16;
            this.CloseBTN.Text = "Закрыть";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Visible = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 388);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.SendMoneyBTN);
            this.Controls.Add(this.SendMoneyTB);
            this.Controls.Add(this.TransferCmB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MessageRTB);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.CompareCmB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendMessageBTN);
            this.Controls.Add(this.GetMessageStringBTN);
            this.Controls.Add(this.GetMessageBTN);
            this.Controls.Add(this.BalanceTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.PeopleLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛР7 Быстров Олег 944691";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleLB;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox BalanceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetMessageBTN;
        private System.Windows.Forms.Button GetMessageStringBTN;
        private System.Windows.Forms.Button SendMessageBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CompareCmB;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.RichTextBox MessageRTB;
        private System.Windows.Forms.ComboBox TransferCmB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SendMoneyTB;
        private System.Windows.Forms.Button SendMoneyBTN;
        private System.Windows.Forms.Button CloseBTN;
    }
}

