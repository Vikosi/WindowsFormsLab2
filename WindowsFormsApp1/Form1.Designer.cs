namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddButton = new System.Windows.Forms.Button();
            this.DrawAsLines = new System.Windows.Forms.Button();
            this.DrawAsSpline = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ChooseGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(532, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(316, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend2.Name = "Legend2";
            this.chart1.Legends.Add(legend1);
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 59);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "X";
            series1.YValueMembers = "Y";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend2";
            series2.Name = "Series2";
            series2.XValueMember = "X";
            series2.YValueMembers = "Y";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(514, 379);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(637, 35);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DrawAsLines
            // 
            this.DrawAsLines.Location = new System.Drawing.Point(556, 310);
            this.DrawAsLines.Name = "DrawAsLines";
            this.DrawAsLines.Size = new System.Drawing.Size(94, 47);
            this.DrawAsLines.TabIndex = 3;
            this.DrawAsLines.Text = "Draw as lines";
            this.DrawAsLines.UseVisualStyleBackColor = true;
            this.DrawAsLines.Click += new System.EventHandler(this.DrawAsLines_Click);
            // 
            // DrawAsSpline
            // 
            this.DrawAsSpline.Location = new System.Drawing.Point(556, 363);
            this.DrawAsSpline.Name = "DrawAsSpline";
            this.DrawAsSpline.Size = new System.Drawing.Size(94, 47);
            this.DrawAsSpline.TabIndex = 4;
            this.DrawAsSpline.Text = "Draw as spline";
            this.DrawAsSpline.UseVisualStyleBackColor = true;
            this.DrawAsSpline.Click += new System.EventHandler(this.DrawAsSpline_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Draw as Lines",
            "Draw as Spline"});
            this.comboBox1.Location = new System.Drawing.Point(116, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(735, 310);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(85, 47);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(735, 364);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(85, 46);
            this.Open.TabIndex = 7;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(891, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(325, 196);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGriwView2_Paint);
            // 
            // ChooseGraph
            // 
            this.ChooseGraph.Location = new System.Drawing.Point(1005, 310);
            this.ChooseGraph.Name = "ChooseGraph";
            this.ChooseGraph.Size = new System.Drawing.Size(109, 47);
            this.ChooseGraph.TabIndex = 9;
            this.ChooseGraph.Text = "ChooseGraph";
            this.ChooseGraph.UseVisualStyleBackColor = true;
            this.ChooseGraph.Click += new System.EventHandler(this.ChooseGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 460);
            this.Controls.Add(this.ChooseGraph);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DrawAsSpline);
            this.Controls.Add(this.DrawAsLines);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DrawAsLines;
        private System.Windows.Forms.Button DrawAsSpline;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ChooseGraph;
    }
}

