namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnClearChartMidTime = new System.Windows.Forms.Button();
            this.btnOpenVisualMethodsSortForm = new System.Windows.Forms.Button();
            this.txtBoxLenArr = new System.Windows.Forms.TextBox();
            this.txtBoxRangeFrom = new System.Windows.Forms.TextBox();
            this.txtBoxRangeTo = new System.Windows.Forms.TextBox();
            this.lblMethodsSort = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblLenArr = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.chartMidTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxSelectionMethodsSort = new System.Windows.Forms.ComboBox();
            this.btnMidTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMidTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearChartMidTime
            // 
            this.btnClearChartMidTime.Location = new System.Drawing.Point(821, 176);
            this.btnClearChartMidTime.Name = "btnClearChartMidTime";
            this.btnClearChartMidTime.Size = new System.Drawing.Size(175, 23);
            this.btnClearChartMidTime.TabIndex = 20;
            this.btnClearChartMidTime.Text = "очистить график";
            this.btnClearChartMidTime.UseVisualStyleBackColor = true;
            this.btnClearChartMidTime.Click += new System.EventHandler(this.btnClearChartMidTime_Click);
            // 
            // btnOpenVisualMethodsSortForm
            // 
            this.btnOpenVisualMethodsSortForm.Location = new System.Drawing.Point(821, 147);
            this.btnOpenVisualMethodsSortForm.Name = "btnOpenVisualMethodsSortForm";
            this.btnOpenVisualMethodsSortForm.Size = new System.Drawing.Size(175, 23);
            this.btnOpenVisualMethodsSortForm.TabIndex = 12;
            this.btnOpenVisualMethodsSortForm.Text = "визуализация метода";
            this.btnOpenVisualMethodsSortForm.UseVisualStyleBackColor = true;
            this.btnOpenVisualMethodsSortForm.Click += new System.EventHandler(this.btnOpenVisualMethodsSortForm_Click);
            // 
            // txtBoxLenArr
            // 
            this.txtBoxLenArr.Location = new System.Drawing.Point(821, 26);
            this.txtBoxLenArr.MaxLength = 5;
            this.txtBoxLenArr.Name = "txtBoxLenArr";
            this.txtBoxLenArr.Size = new System.Drawing.Size(87, 20);
            this.txtBoxLenArr.TabIndex = 10;
            this.txtBoxLenArr.Text = "100";
            this.txtBoxLenArr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLenArr_KeyPress);
            // 
            // txtBoxRangeFrom
            // 
            this.txtBoxRangeFrom.Location = new System.Drawing.Point(917, 26);
            this.txtBoxRangeFrom.MaxLength = 3;
            this.txtBoxRangeFrom.Name = "txtBoxRangeFrom";
            this.txtBoxRangeFrom.Size = new System.Drawing.Size(55, 20);
            this.txtBoxRangeFrom.TabIndex = 13;
            this.txtBoxRangeFrom.Text = "0";
            this.txtBoxRangeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRangeFrom_KeyPress);
            // 
            // txtBoxRangeTo
            // 
            this.txtBoxRangeTo.Location = new System.Drawing.Point(917, 52);
            this.txtBoxRangeTo.MaxLength = 3;
            this.txtBoxRangeTo.Name = "txtBoxRangeTo";
            this.txtBoxRangeTo.Size = new System.Drawing.Size(55, 20);
            this.txtBoxRangeTo.TabIndex = 14;
            this.txtBoxRangeTo.Text = "100";
            this.txtBoxRangeTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRangeTo_KeyPress);
            // 
            // lblMethodsSort
            // 
            this.lblMethodsSort.AutoSize = true;
            this.lblMethodsSort.Location = new System.Drawing.Point(821, 75);
            this.lblMethodsSort.Name = "lblMethodsSort";
            this.lblMethodsSort.Size = new System.Drawing.Size(109, 13);
            this.lblMethodsSort.TabIndex = 8;
            this.lblMethodsSort.Text = "Методы сортировки";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(914, 10);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(58, 13);
            this.lblRange.TabIndex = 15;
            this.lblRange.Text = "Диапазон";
            // 
            // lblLenArr
            // 
            this.lblLenArr.AutoSize = true;
            this.lblLenArr.Location = new System.Drawing.Point(821, 10);
            this.lblLenArr.Name = "lblLenArr";
            this.lblLenArr.Size = new System.Drawing.Size(87, 13);
            this.lblLenArr.TabIndex = 16;
            this.lblLenArr.Text = "Длина массива";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(978, 29);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(18, 13);
            this.lblFrom.TabIndex = 17;
            this.lblFrom.Text = "от";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(978, 52);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(19, 13);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "до";
            // 
            // chartMidTime
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMidTime.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMidTime.Legends.Add(legend1);
            this.chartMidTime.Location = new System.Drawing.Point(12, 12);
            this.chartMidTime.Name = "chartMidTime";
            this.chartMidTime.Size = new System.Drawing.Size(803, 449);
            this.chartMidTime.TabIndex = 19;
            this.chartMidTime.Text = "ChartMidTime";
            // 
            // comboBoxSelectionMethodsSort
            // 
            this.comboBoxSelectionMethodsSort.FormattingEnabled = true;
            this.comboBoxSelectionMethodsSort.Items.AddRange(new object[] {
            "метод пузырька",
            "метод прямого включения",
            "метод прямого выбора",
            "метод шейкера",
            "метод Шелла",
            "метод Хоара"});
            this.comboBoxSelectionMethodsSort.Location = new System.Drawing.Point(821, 91);
            this.comboBoxSelectionMethodsSort.Name = "comboBoxSelectionMethodsSort";
            this.comboBoxSelectionMethodsSort.Size = new System.Drawing.Size(151, 21);
            this.comboBoxSelectionMethodsSort.TabIndex = 21;
            this.comboBoxSelectionMethodsSort.Text = "выбрать метод";
            // 
            // btnMidTime
            // 
            this.btnMidTime.Location = new System.Drawing.Point(821, 118);
            this.btnMidTime.Name = "btnMidTime";
            this.btnMidTime.Size = new System.Drawing.Size(175, 23);
            this.btnMidTime.TabIndex = 22;
            this.btnMidTime.Text = "анализ вр. эффективности";
            this.btnMidTime.UseVisualStyleBackColor = true;
            this.btnMidTime.Click += new System.EventHandler(this.btnMidTime_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.btnMidTime);
            this.Controls.Add(this.comboBoxSelectionMethodsSort);
            this.Controls.Add(this.btnClearChartMidTime);
            this.Controls.Add(this.chartMidTime);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblLenArr);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.txtBoxRangeTo);
            this.Controls.Add(this.txtBoxRangeFrom);
            this.Controls.Add(this.btnOpenVisualMethodsSortForm);
            this.Controls.Add(this.txtBoxLenArr);
            this.Controls.Add(this.lblMethodsSort);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MainForm";
            this.Text = "Методы сортировки";
            ((System.ComponentModel.ISupportInitialize)(this.chartMidTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMethodsSort; 
        private System.Windows.Forms.TextBox txtBoxLenArr; 
        private System.Windows.Forms.Button btnOpenVisualMethodsSortForm; 
        private System.Windows.Forms.TextBox txtBoxRangeFrom; 
        private System.Windows.Forms.TextBox txtBoxRangeTo; 
        private System.Windows.Forms.Label lblRange; 
        private System.Windows.Forms.Label lblLenArr; 
        private System.Windows.Forms.Label lblFrom; 
        private System.Windows.Forms.Label lblTo; 
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMidTime;
        private System.Windows.Forms.Button btnClearChartMidTime;
        private System.Windows.Forms.ComboBox comboBoxSelectionMethodsSort;
        private System.Windows.Forms.Button btnMidTime;
    }
}

