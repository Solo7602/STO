namespace ClientView
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateRepair = new System.Windows.Forms.Button();
            this.buttonUpdateRepair = new System.Windows.Forms.Button();
            this.groupeBox = new System.Windows.Forms.GroupBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonDeleteRepair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(615, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(6, 59);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(119, 28);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Неизвестно";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(6, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(119, 28);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Неизвестно";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(39, 138);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(713, 300);
            this.dataGridView.TabIndex = 4;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 125;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Название";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Итоговая сумма";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Статус";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Дата начала";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Дата завершения";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Мои ремонты";
            // 
            // buttonCreateRepair
            // 
            this.buttonCreateRepair.Location = new System.Drawing.Point(21, 26);
            this.buttonCreateRepair.Name = "buttonCreateRepair";
            this.buttonCreateRepair.Size = new System.Drawing.Size(135, 40);
            this.buttonCreateRepair.TabIndex = 6;
            this.buttonCreateRepair.Text = "Создать";
            this.buttonCreateRepair.UseVisualStyleBackColor = true;
            this.buttonCreateRepair.Click += new System.EventHandler(this.buttonCreateRepair_Click);
            // 
            // buttonUpdateRepair
            // 
            this.buttonUpdateRepair.Location = new System.Drawing.Point(175, 26);
            this.buttonUpdateRepair.Name = "buttonUpdateRepair";
            this.buttonUpdateRepair.Size = new System.Drawing.Size(126, 40);
            this.buttonUpdateRepair.TabIndex = 7;
            this.buttonUpdateRepair.Text = "Обновить";
            this.buttonUpdateRepair.UseVisualStyleBackColor = true;
            this.buttonUpdateRepair.Click += new System.EventHandler(this.buttonUpdateRepair_Click);
            // 
            // groupeBox
            // 
            this.groupeBox.Controls.Add(this.buttonPay);
            this.groupeBox.Controls.Add(this.buttonDeleteRepair);
            this.groupeBox.Controls.Add(this.buttonCreateRepair);
            this.groupeBox.Controls.Add(this.buttonUpdateRepair);
            this.groupeBox.Location = new System.Drawing.Point(12, 28);
            this.groupeBox.Name = "groupeBox";
            this.groupeBox.Size = new System.Drawing.Size(597, 84);
            this.groupeBox.TabIndex = 8;
            this.groupeBox.TabStop = false;
            this.groupeBox.Text = "Ремонт";
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(312, 26);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(126, 40);
            this.buttonPay.TabIndex = 9;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonDeleteRepair
            // 
            this.buttonDeleteRepair.Location = new System.Drawing.Point(449, 26);
            this.buttonDeleteRepair.Name = "buttonDeleteRepair";
            this.buttonDeleteRepair.Size = new System.Drawing.Size(142, 40);
            this.buttonDeleteRepair.TabIndex = 8;
            this.buttonDeleteRepair.Text = "Удалить";
            this.buttonDeleteRepair.UseVisualStyleBackColor = true;
            this.buttonDeleteRepair.Click += new System.EventHandler(this.buttonDeleteRepair_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupeBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateRepair;
        private System.Windows.Forms.Button buttonUpdateRepair;
        private System.Windows.Forms.GroupBox groupeBox;
        private System.Windows.Forms.Button buttonDeleteRepair;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
