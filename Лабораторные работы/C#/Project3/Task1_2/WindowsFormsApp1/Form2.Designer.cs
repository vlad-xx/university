namespace WindowsFormsApp1
{
    partial class VisualMethodsSortForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartArr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartArr)).BeginInit();
            this.SuspendLayout();
            // 
            // chartArr
            // 
            chartArea2.Name = "ChartArea1";
            this.chartArr.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartArr.Legends.Add(legend2);
            this.chartArr.Location = new System.Drawing.Point(12, 5);
            this.chartArr.Name = "chartArr";
            this.chartArr.Size = new System.Drawing.Size(600, 424);
            this.chartArr.TabIndex = 0;
            this.chartArr.Text = "демонстрация метода сортировки методом пузырька";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(500, 48);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(94, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Отсортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(500, 77);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(94, 23);
            this.btnRand.TabIndex = 2;
            this.btnRand.Text = "Перемешать";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // VisualMethodsSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.chartArr);
            this.Name = "VisualMethodsSortForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chartArr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartArr;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRand;
    }
}