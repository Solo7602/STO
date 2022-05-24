namespace EmployeeView
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
            this.button_Report = new System.Windows.Forms.Button();
            this.button_Work = new System.Windows.Forms.Button();
            this.button_Order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(12, 12);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(136, 56);
            this.button_Report.TabIndex = 0;
            this.button_Report.Text = "Получить отчёт";
            this.button_Report.UseVisualStyleBackColor = true;
            // 
            // button_Work
            // 
            this.button_Work.Location = new System.Drawing.Point(154, 12);
            this.button_Work.Name = "button_Work";
            this.button_Work.Size = new System.Drawing.Size(136, 56);
            this.button_Work.TabIndex = 1;
            this.button_Work.Text = "Список работ";
            this.button_Work.UseVisualStyleBackColor = true;
            this.button_Work.Click += new System.EventHandler(this.button_Work_Click);
            // 
            // button_Order
            // 
            this.button_Order.Location = new System.Drawing.Point(296, 12);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(136, 56);
            this.button_Order.TabIndex = 2;
            this.button_Order.Text = "Списки заказов";
            this.button_Order.UseVisualStyleBackColor = true;
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 92);
            this.Controls.Add(this.button_Order);
            this.Controls.Add(this.button_Work);
            this.Controls.Add(this.button_Report);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.Button button_Work;
        private System.Windows.Forms.Button button_Order;
    }
}