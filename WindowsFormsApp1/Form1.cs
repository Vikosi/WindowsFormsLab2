using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public BindingSource Data { get; set; }
        public BindingSource Data2 { get; set; }
        public Form1()
        {
            Data = new BindingSource();
            Data2 = new BindingSource();
            Data.Add(new Data() { X = 0, Y = 0 });
            Data.Add(new Data() { X = 1, Y = 1 });
            Data.Add(new Data() { X = 2, Y = 4 });
            InitializeComponent();
            dataGridView1.DataSource = Data;
            dataGridView2.DataSource = Data2;
        }
        public void DrawLines()
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].BorderWidth = 2;
        }
        public void DrawSpline()
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[1].BorderWidth = 2;
        }
        public void DrawChart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            switch (comboBox1.SelectedIndex) {

                case 0:
                    DrawLines();
                    break;
                case 1:
                    DrawSpline();
                    break;
            }
            foreach (Data dataItem in Data.List )
            {
                chart1.Series[0].Points.AddXY(dataItem.X, dataItem.Y);
            }
            foreach (Data dataItem2 in Data2.List)
            {
                chart1.Series[1].Points.AddXY(dataItem2.X, dataItem2.Y);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Data.Add(new Data() { X = 4, Y = 16 });
            Invalidate();
        }
        private void DrawAsLines_Click(object sender, EventArgs e)
        {
            chart1.DataSource = null;
            DrawLines();

        }
        private void DrawAsSpline_Click(object sender, EventArgs e)
        {
            chart1.DataSource = null;
            DrawSpline();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart();
        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < dataGridView1.ColumnCount; x++) 
            {
                for (int y = 0; y < dataGridView1.RowCount; y++) 
                {
                    if (dataGridView1[x, y].Value != null) 
                    {
                        DrawChart();
                    }
                }
            }
        }
        private void Open_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    Data.Clear();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            fileContent = reader.ReadLine();
                            if (fileContent != null)
                            {
                                var tmp = fileContent.Split();
                                Data.Add(new Data() { X = double.Parse(tmp[0]), Y = double.Parse(tmp[1]) });
                            }
                        }
                    }
                    Invalidate();
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (Data item in Data)
                    {
                        sw.WriteLine(item.X.ToString() + "\t" + item.Y.ToString());
                    }
                }
            }
        }

        private void ChooseGraph_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    Data2.Clear();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            fileContent = reader.ReadLine();
                            if (fileContent != null)
                            {
                                var tmp = fileContent.Split();
                                Data2.Add(new Data() { X = double.Parse(tmp[0]), Y = double.Parse(tmp[1]) });
                            }
                        }
                    }
                    Invalidate();
                }
            }
        }

        private void dataGriwView2_Paint(object sender, PaintEventArgs e)
        {
            for(int x = 0; x < dataGridView2.ColumnCount; x++) 
            {
                for (int y = 0; y < dataGridView2.RowCount; y++)
                {
                    if (dataGridView2[x, y].Value != null)
                    {
                        DrawChart();
                    }
                }
            }
        }
    }
    public class Data
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}

