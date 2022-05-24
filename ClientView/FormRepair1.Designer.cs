﻿namespace EmployeeView
{
    partial class FormRepair1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_Report = new System.Windows.Forms.Button();
            this.buttonReady = new System.Windows.Forms.Button();
            this.buttonTake = new System.Windows.Forms.Button();
            this.Column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IdWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Id,
            this.Column_Name,
            this.Column_Sum,
            this.Employee,
            this.Status,
            this.Column_StartTime,
            this.Column_EndTime,
            this.Column_IdWork});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(670, 426);
            this.dataGridView.TabIndex = 0;
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(702, 12);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(75, 57);
            this.button_Report.TabIndex = 3;
            this.button_Report.Text = "Получить отчет по заказу";
            this.button_Report.UseVisualStyleBackColor = true;
            // 
            // buttonReady
            // 
            this.buttonReady.Location = new System.Drawing.Point(702, 136);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(75, 50);
            this.buttonReady.TabIndex = 4;
            this.buttonReady.Text = "Заказ Готов";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(702, 75);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 55);
            this.buttonTake.TabIndex = 5;
            this.buttonTake.Text = "Принять заказ";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // Column_Id
            // 
            this.Column_Id.HeaderText = "";
            this.Column_Id.Name = "Column_Id";
            this.Column_Id.Visible = false;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Название";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.Width = 150;
            // 
            // Column_Sum
            // 
            this.Column_Sum.HeaderText = "Стоимость";
            this.Column_Sum.Name = "Column_Sum";
            this.Column_Sum.Width = 150;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Исполниель";
            this.Employee.Name = "Employee";
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // Column_StartTime
            // 
            this.Column_StartTime.HeaderText = "Дата начала";
            this.Column_StartTime.Name = "Column_StartTime";
            this.Column_StartTime.Width = 120;
            // 
            // Column_EndTime
            // 
            this.Column_EndTime.HeaderText = "Дата конца";
            this.Column_EndTime.Name = "Column_EndTime";
            this.Column_EndTime.Width = 120;
            // 
            // Column_IdWork
            // 
            this.Column_IdWork.HeaderText = "ID работы";
            this.Column_IdWork.Name = "Column_IdWork";
            this.Column_IdWork.Visible = false;
            this.Column_IdWork.Width = 80;
            // 
            // buttonOver
            // 
            this.buttonOver.Location = new System.Drawing.Point(702, 192);
            this.buttonOver.Name = "buttonOver";
            this.buttonOver.Size = new System.Drawing.Size(75, 50);
            this.buttonOver.TabIndex = 6;
            this.buttonOver.Text = "Отправить";
            this.buttonOver.UseVisualStyleBackColor = true;
            this.buttonOver.Click += new System.EventHandler(this.buttonOver_Click);
            // 
            // FormRepair1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOver);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormRepair1";
            this.Text = "FormRepair";
            this.Load += new System.EventHandler(this.FormRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IdWork;
        private System.Windows.Forms.Button buttonOver;
    }
}