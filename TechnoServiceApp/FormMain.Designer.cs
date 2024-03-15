namespace TechnoServiceApp
{
    partial class FormMain
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
            this.panelBtns = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMetric = new System.Windows.Forms.Button();
            this.btnCreateApplication = new System.Windows.Forms.Button();
            this.flowLayoutPanelApplications = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.panelBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBtns
            // 
            this.panelBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBtns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBtns.Controls.Add(this.btnExit);
            this.panelBtns.Controls.Add(this.btnMetric);
            this.panelBtns.Controls.Add(this.btnCreateApplication);
            this.panelBtns.Location = new System.Drawing.Point(1, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(242, 509);
            this.panelBtns.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(3, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(236, 57);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMetric
            // 
            this.btnMetric.Location = new System.Drawing.Point(3, 66);
            this.btnMetric.Name = "btnMetric";
            this.btnMetric.Size = new System.Drawing.Size(236, 57);
            this.btnMetric.TabIndex = 1;
            this.btnMetric.Text = "Статистика работы";
            this.btnMetric.UseVisualStyleBackColor = true;
            this.btnMetric.Click += new System.EventHandler(this.btnMetric_Click);
            // 
            // btnCreateApplication
            // 
            this.btnCreateApplication.Location = new System.Drawing.Point(3, 3);
            this.btnCreateApplication.Name = "btnCreateApplication";
            this.btnCreateApplication.Size = new System.Drawing.Size(236, 57);
            this.btnCreateApplication.TabIndex = 0;
            this.btnCreateApplication.Text = "Создать заявку";
            this.btnCreateApplication.UseVisualStyleBackColor = true;
            this.btnCreateApplication.Click += new System.EventHandler(this.btnCreateApplication_Click);
            // 
            // flowLayoutPanelApplications
            // 
            this.flowLayoutPanelApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelApplications.AutoScroll = true;
            this.flowLayoutPanelApplications.Location = new System.Drawing.Point(249, 40);
            this.flowLayoutPanelApplications.Name = "flowLayoutPanelApplications";
            this.flowLayoutPanelApplications.Size = new System.Drawing.Size(674, 456);
            this.flowLayoutPanelApplications.TabIndex = 0;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFind.Location = new System.Drawing.Point(249, 12);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(674, 22);
            this.textBoxFind.TabIndex = 1;
            this.textBoxFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFind_KeyUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(935, 508);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.flowLayoutPanelApplications);
            this.Controls.Add(this.panelBtns);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT-Решение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.panelBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelApplications;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button btnCreateApplication;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMetric;
    }
}