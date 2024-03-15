namespace TechnoServiceApp
{
    partial class FormCreateApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTypeFault = new System.Windows.Forms.Label();
            this.labelDescProblem = new System.Windows.Forms.Label();
            this.labelTelephoneClient = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxHardware = new System.Windows.Forms.TextBox();
            this.textBoxTypeFault = new System.Windows.Forms.TextBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.richTextBoxDescProblem = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оборудование, требующее ремонта: ";
            // 
            // labelTypeFault
            // 
            this.labelTypeFault.AutoSize = true;
            this.labelTypeFault.Location = new System.Drawing.Point(12, 55);
            this.labelTypeFault.Name = "labelTypeFault";
            this.labelTypeFault.Size = new System.Drawing.Size(142, 16);
            this.labelTypeFault.TabIndex = 4;
            this.labelTypeFault.Text = "Тип неисправности: ";
            // 
            // labelDescProblem
            // 
            this.labelDescProblem.AutoSize = true;
            this.labelDescProblem.Location = new System.Drawing.Point(12, 85);
            this.labelDescProblem.Name = "labelDescProblem";
            this.labelDescProblem.Size = new System.Drawing.Size(147, 16);
            this.labelDescProblem.TabIndex = 5;
            this.labelDescProblem.Text = "Описание проблемы: ";
            // 
            // labelTelephoneClient
            // 
            this.labelTelephoneClient.AutoSize = true;
            this.labelTelephoneClient.Location = new System.Drawing.Point(12, 221);
            this.labelTelephoneClient.Name = "labelTelephoneClient";
            this.labelTelephoneClient.Size = new System.Drawing.Size(125, 16);
            this.labelTelephoneClient.TabIndex = 8;
            this.labelTelephoneClient.Text = "Номер телефона: ";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 193);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(60, 16);
            this.labelClient.TabIndex = 9;
            this.labelClient.Text = "Клиент: ";
            // 
            // textBoxHardware
            // 
            this.textBoxHardware.Location = new System.Drawing.Point(268, 21);
            this.textBoxHardware.Name = "textBoxHardware";
            this.textBoxHardware.Size = new System.Drawing.Size(479, 22);
            this.textBoxHardware.TabIndex = 10;
            // 
            // textBoxTypeFault
            // 
            this.textBoxTypeFault.Location = new System.Drawing.Point(268, 49);
            this.textBoxTypeFault.Name = "textBoxTypeFault";
            this.textBoxTypeFault.Size = new System.Drawing.Size(479, 22);
            this.textBoxTypeFault.TabIndex = 11;
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(268, 187);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(479, 22);
            this.textBoxClient.TabIndex = 13;
            // 
            // richTextBoxDescProblem
            // 
            this.richTextBoxDescProblem.Location = new System.Drawing.Point(268, 77);
            this.richTextBoxDescProblem.Name = "richTextBoxDescProblem";
            this.richTextBoxDescProblem.Size = new System.Drawing.Size(479, 104);
            this.richTextBoxDescProblem.TabIndex = 15;
            this.richTextBoxDescProblem.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(268, 243);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(479, 37);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 243);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(247, 37);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Отмена";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(268, 215);
            this.maskedTextBoxTelephone.Mask = "+7 (999) 000-00-00";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(479, 22);
            this.maskedTextBoxTelephone.TabIndex = 18;
            // 
            // FormCreateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 285);
            this.Controls.Add(this.maskedTextBoxTelephone);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.richTextBoxDescProblem);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.textBoxTypeFault);
            this.Controls.Add(this.textBoxHardware);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelTelephoneClient);
            this.Controls.Add(this.labelDescProblem);
            this.Controls.Add(this.labelTypeFault);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTypeFault;
        private System.Windows.Forms.Label labelDescProblem;
        private System.Windows.Forms.Label labelTelephoneClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxHardware;
        private System.Windows.Forms.TextBox textBoxTypeFault;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.RichTextBox richTextBoxDescProblem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
    }
}