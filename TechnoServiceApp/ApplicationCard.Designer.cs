namespace TechnoServiceApp
{
    partial class ApplicationCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHardware = new System.Windows.Forms.Label();
            this.labelTypeFault = new System.Windows.Forms.Label();
            this.labelDescProblem = new System.Windows.Forms.Label();
            this.richTextBoxDecsProblem = new System.Windows.Forms.RichTextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelTelephoneClient = new System.Windows.Forms.Label();
            this.comboBoxStaffs = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelTelephoneStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(0, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(99, 16);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер заявки";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(156, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(94, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Дата заявки: ";
            // 
            // labelHardware
            // 
            this.labelHardware.AutoSize = true;
            this.labelHardware.Location = new System.Drawing.Point(0, 60);
            this.labelHardware.Name = "labelHardware";
            this.labelHardware.Size = new System.Drawing.Size(250, 16);
            this.labelHardware.TabIndex = 2;
            this.labelHardware.Text = "Оборудование, требующее ремонта: ";
            // 
            // labelTypeFault
            // 
            this.labelTypeFault.AutoSize = true;
            this.labelTypeFault.Location = new System.Drawing.Point(0, 76);
            this.labelTypeFault.Name = "labelTypeFault";
            this.labelTypeFault.Size = new System.Drawing.Size(143, 16);
            this.labelTypeFault.TabIndex = 3;
            this.labelTypeFault.Text = "Тип немсправности: ";
            // 
            // labelDescProblem
            // 
            this.labelDescProblem.AutoSize = true;
            this.labelDescProblem.Location = new System.Drawing.Point(0, 92);
            this.labelDescProblem.Name = "labelDescProblem";
            this.labelDescProblem.Size = new System.Drawing.Size(147, 16);
            this.labelDescProblem.TabIndex = 4;
            this.labelDescProblem.Text = "Описание проблемы: ";
            // 
            // richTextBoxDecsProblem
            // 
            this.richTextBoxDecsProblem.Location = new System.Drawing.Point(153, 95);
            this.richTextBoxDecsProblem.Name = "richTextBoxDecsProblem";
            this.richTextBoxDecsProblem.Size = new System.Drawing.Size(640, 96);
            this.richTextBoxDecsProblem.TabIndex = 5;
            this.richTextBoxDecsProblem.Text = "";
            this.richTextBoxDecsProblem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBoxDecsProblem_KeyUp);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(0, 16);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(60, 16);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Клиент: ";
            // 
            // labelTelephoneClient
            // 
            this.labelTelephoneClient.AutoSize = true;
            this.labelTelephoneClient.Location = new System.Drawing.Point(0, 32);
            this.labelTelephoneClient.Name = "labelTelephoneClient";
            this.labelTelephoneClient.Size = new System.Drawing.Size(125, 16);
            this.labelTelephoneClient.TabIndex = 7;
            this.labelTelephoneClient.Text = "Номер телефона: ";
            // 
            // comboBoxStaffs
            // 
            this.comboBoxStaffs.FormattingEnabled = true;
            this.comboBoxStaffs.Location = new System.Drawing.Point(432, 4);
            this.comboBoxStaffs.Name = "comboBoxStaffs";
            this.comboBoxStaffs.Size = new System.Drawing.Size(368, 24);
            this.comboBoxStaffs.TabIndex = 8;
            this.comboBoxStaffs.SelectedIndexChanged += new System.EventHandler(this.comboBoxStaffs_SelectedIndexChanged);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(525, 68);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(108, 16);
            this.labelState.TabIndex = 9;
            this.labelState.Text = "Статус заявки: ";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "В ожидании",
            "В работе",
            "Выполнена",
            "Не выполнена"});
            this.comboBoxState.Location = new System.Drawing.Point(639, 65);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(154, 24);
            this.comboBoxState.TabIndex = 10;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            // 
            // labelTelephoneStaff
            // 
            this.labelTelephoneStaff.AutoSize = true;
            this.labelTelephoneStaff.Location = new System.Drawing.Point(429, 31);
            this.labelTelephoneStaff.Name = "labelTelephoneStaff";
            this.labelTelephoneStaff.Size = new System.Drawing.Size(125, 16);
            this.labelTelephoneStaff.TabIndex = 11;
            this.labelTelephoneStaff.Text = "Номер телефона: ";
            // 
            // ApplicationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelTelephoneStaff);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.comboBoxStaffs);
            this.Controls.Add(this.labelTelephoneClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.richTextBoxDecsProblem);
            this.Controls.Add(this.labelDescProblem);
            this.Controls.Add(this.labelTypeFault);
            this.Controls.Add(this.labelHardware);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNumber);
            this.Name = "ApplicationCard";
            this.Size = new System.Drawing.Size(803, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelHardware;
        private System.Windows.Forms.Label labelTypeFault;
        private System.Windows.Forms.Label labelDescProblem;
        private System.Windows.Forms.RichTextBox richTextBoxDecsProblem;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelTelephoneClient;
        private System.Windows.Forms.ComboBox comboBoxStaffs;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelTelephoneStaff;
    }
}
