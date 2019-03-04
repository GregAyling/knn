using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;


namespace knn
{
    public partial class KNN : Form
    {
        string fname = ""; // Filename to use.
        string fdir = @"c:\test\"; // Initial directory in which to look for files.
        string ffilter = "All files (*.*)|*.*|CSV files (*.csv)|*.csv"; // File filter.
        Point clickPosition;
        DataTable dataTable = new DataTable();

        public KNN()
        {
            InitializeComponent();
        }

        private void kField_Validating(object sender, CancelEventArgs e)
        {
            try { int k = Convert.ToInt16(kField.Text); }
            catch (Exception ex) { e.Cancel = true; MessageBox.Show("k must be an integer value"); }
        }

        private void importButton_Click(object sender, EventArgs e)
        {

            // Request a file.
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Import File";
            fdlg.InitialDirectory = fdir;
            fdlg.Filter = ffilter;
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                this.fname = fdlg.FileName;
            }
            fdlg.Dispose();

            // Clear series.
            chart1.Series.Clear();

            // Set up chart properties.
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0";
            chart1.ChartAreas[0].AxisX.RoundAxisValues();

            // Set up series 1.
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Original Data",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Point
            };
            this.chart1.Series.Add(series1);

            // Set up data grid.
            dataTable.Rows.Clear();
            if (dataTable.Columns.Count == 0)
            {
                dataTable.Columns.Add("x");
                dataTable.Columns.Add("y");
                dataTable.Columns.Add("Category");
            }

            StreamReader streamReader = new StreamReader(this.fname);
            string[] dataLine = new string[File.ReadAllLines(this.fname).Length];
            double x, y;
            string category;

            // Read first line.
            dataLine = streamReader.ReadLine().Split(',');
            x = Convert.ToDouble(dataLine[0]);
            y = Convert.ToDouble(dataLine[1]);
            category = Convert.ToString(dataLine[2]);
            dataTable.Rows.Add(x, y, category);

            // Read rest of lines.
            while (!streamReader.EndOfStream)
            {
                dataLine = streamReader.ReadLine().Split(',');
                x = Convert.ToDouble(dataLine[0]);
                y = Convert.ToDouble(dataLine[1]);
                category = Convert.ToString(dataLine[2]);
                dataTable.Rows.Add(x, y, category);
            }

            // Close file
            streamReader.Close();

            // Display data grid.
            dataGridView1.DataSource = dataTable;

            // Display chart.
            refreshChart(sender, e);

        }

        private void refreshChart(object sender, EventArgs e)
        {
            double x, y;
            string category;

            DataTable xy = new DataTable();
            xy = (DataTable)this.dataGridView1.DataSource;

            // Reset original data.
            chart1.Series["Original Data"].Points.Clear();
            chart1.Series["Original Data"].IsVisibleInLegend = false;
            chart1.Series["Original Data"].IsXValueIndexed = false;
            chart1.Series["Original Data"].MarkerSize = 20;
            chart1.Series["Original Data"].MarkerStyle = MarkerStyle.Circle;
            
            // Refresh from data grid.
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                var xcell = dataGridView1.Rows[rows].Cells[0].Value;
                var ycell = dataGridView1.Rows[rows].Cells[1].Value;
                var catcell = dataGridView1.Rows[rows].Cells[2].Value;

                if (xcell != DBNull.Value && ycell != DBNull.Value && catcell != DBNull.Value)
                {
                    // Read next data pair.
                    x = Convert.ToDouble(xcell);
                    y = Convert.ToDouble(ycell);
                    category = Convert.ToString(catcell);

                    // Add to chart.
                    chart1.Series["Original Data"].Points.AddXY(x, y);
                    chart1.Series["Original Data"].Points[rows].Color = catColor(category);
                }
                chart1.Invalidate();

            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {

            // Find file to write to.
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Export File";
            fdlg.InitialDirectory = fdir;
            fdlg.Filter = ffilter;
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                this.fname = fdlg.FileName;
            }
            fdlg.Dispose();

            // Create the CSV file to which grid data will be exported.
            StreamWriter sw = new StreamWriter(this.fname, false);

            // Loop through all the rows.
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (!dr.IsNewRow)
                {
                    List<string> columnData = new List<string>();
                    foreach (DataGridViewCell cell in dr.Cells)
                    {
                        columnData.Add(cell.Value.ToString());
                    }
                    sw.WriteLine(string.Join(",", columnData.ToArray()));
                }
            }

            sw.Close();
        }

        private void addNewData_CheckedChanged(object sender, EventArgs e)
        {
            if (addNewData.Checked)
            {
                categoryLabel.Visible = true;
                categorySelector.Visible = true;
            }
        }

        private void guessCategory_CheckedChanged(object sender, EventArgs e)
        {

            if (guessCategory.Checked)
            {
                categoryLabel.Visible = false;
                categorySelector.Visible = false;
            }
        }


        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            clickPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false, ChartElementType.PlottingArea);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.PlottingArea)
                {
                    double xVal = Math.Round(result.ChartArea.AxisX.PixelPositionToValue(pos.X), 1);
                    double yVal = Math.Round(result.ChartArea.AxisY.PixelPositionToValue(pos.Y), 1);

                    if (addNewData.Checked)
                    {
                        this.dataTable.Rows.Add(xVal, yVal, categorySelector.Text);
                        refreshChart(sender, e);
                    }
                    else
                    {
                        int k = Convert.ToInt16(kField.Text);
                        bool weighted = weightedBox.Checked;
                        DataTable dt = new DataTable();
                        dt = (DataTable)this.dataGridView1.DataSource;
                        string categoryGuess = KNN_calculator.guess(dt, xVal, yVal, k, weighted);

                        // Add to chart.
                        chart1.Series["Original Data"].Points.AddXY(xVal, yVal);
                        int point_count = chart1.Series["Original Data"].Points.Count - 1;
                        chart1.Series["Original Data"].Points[point_count].MarkerStyle = MarkerStyle.Square;
                        chart1.Series["Original Data"].Points[point_count].MarkerSize = 10;
                        if (categoryGuess.Length > 1) { chart1.Series["Original Data"].Points[point_count].Color = Color.Gray; }
                        else { chart1.Series["Original Data"].Points[point_count].Color = catColor(categoryGuess); };
                        chart1.Invalidate();
                    }
                }
            }
        }

        private System.Drawing.Color catColor(string category)
        {
            if (category == "A") { return Color.Green; }
            else if (category == "B") { return Color.Blue; }
            else if (category == "C") { return Color.Yellow; }
            else { return Color.Black; };
        }

        private void refreshChartButton_Click(object sender, EventArgs e)
        {
            refreshChart(sender, e);
        }

        private void drawZoneButton_Click(object sender, EventArgs e)
        {
            // Work out data boundaries.
            // (x1,y1) is bottom LH corner.
            // (x2,y2) is top RH corner.
            double x, y, x1=0, y1=0, x2=0, y2=0;

            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                var xcell = dataGridView1.Rows[rows].Cells[0].Value;
                var ycell = dataGridView1.Rows[rows].Cells[1].Value;
                var catcell = dataGridView1.Rows[rows].Cells[2].Value;

                if (xcell != DBNull.Value && ycell != DBNull.Value && catcell != DBNull.Value)
                {
                    // Read next data pair.
                    x = Convert.ToDouble(xcell);
                    y = Convert.ToDouble(ycell);

                    // Update boundaries.
                    if (rows == 0) 
                    {
                        x1 = x; y1 = y; x2 = x; y2 = y;
                    }
                    else
                    {
                        x1 = Math.Min(x1, x); y1 = Math.Min(y1, y); x2 = Math.Max(x2, x); y2 = Math.Max(y2, y);
                    }
                }
            }

            // Guess category at each point in zone.
            int k = Convert.ToInt16(kField.Text);
            bool weighted = weightedBox.Checked;
            double interval = Convert.ToDouble(intervalBox.Text);
            int marker_size = Convert.ToInt16(markerSizeBox.Text);
            DataTable dt = new DataTable();
            dt = (DataTable)this.dataGridView1.DataSource;
            for (double xVal = x1; xVal <= x2; xVal += interval)
            {
                for (double yVal = y1; yVal <= y2; yVal += interval)
                {
                    //  Guess category.
                    string categoryGuess = KNN_calculator.guess(dt, xVal, yVal, k, weighted);

                    // Add to chart.
                    chart1.Series["Original Data"].Points.AddXY(xVal, yVal);
                    int point_count = chart1.Series["Original Data"].Points.Count - 1;
                    chart1.Series["Original Data"].Points[point_count].MarkerStyle = MarkerStyle.Square;
                    chart1.Series["Original Data"].Points[point_count].MarkerSize = marker_size;
                    if (categoryGuess.Length > 1) { chart1.Series["Original Data"].Points[point_count].Color = Color.Gray; }
                    else { chart1.Series["Original Data"].Points[point_count].Color = catColor(categoryGuess); };
                }
            }
            chart1.Invalidate();
        }
    }
}
