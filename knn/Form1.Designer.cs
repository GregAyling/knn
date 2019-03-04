namespace knn
{
    partial class KNN
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.refreshChartButton = new System.Windows.Forms.Button();
            this.categorySelector = new System.Windows.Forms.ComboBox();
            this.weightedBox = new System.Windows.Forms.CheckBox();
            this.kField = new System.Windows.Forms.TextBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.guessCategory = new System.Windows.Forms.RadioButton();
            this.addNewData = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clickBox = new System.Windows.Forms.GroupBox();
            this.drawZoneButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.markerSizeLabel = new System.Windows.Forms.Label();
            this.markerSizeBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.clickBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.375F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1232, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.importButton);
            this.dataPanel.Controls.Add(this.exportButton);
            this.dataPanel.Controls.Add(this.refreshChartButton);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 429);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(358, 88);
            this.dataPanel.TabIndex = 1;
            // 
            // importButton
            // 
            this.importButton.AutoSize = true;
            this.importButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importButton.Location = new System.Drawing.Point(3, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(70, 23);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "Import data";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.AutoSize = true;
            this.exportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportButton.Location = new System.Drawing.Point(79, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(71, 23);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export data";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // refreshChartButton
            // 
            this.refreshChartButton.AutoSize = true;
            this.refreshChartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshChartButton.Location = new System.Drawing.Point(156, 3);
            this.refreshChartButton.Name = "refreshChartButton";
            this.refreshChartButton.Size = new System.Drawing.Size(81, 23);
            this.refreshChartButton.TabIndex = 2;
            this.refreshChartButton.Text = "Refresh chart";
            this.refreshChartButton.UseVisualStyleBackColor = true;
            this.refreshChartButton.Click += new System.EventHandler(this.refreshChartButton_Click);
            // 
            // categorySelector
            // 
            this.categorySelector.FormattingEnabled = true;
            this.categorySelector.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.categorySelector.Location = new System.Drawing.Point(208, 26);
            this.categorySelector.Name = "categorySelector";
            this.categorySelector.Size = new System.Drawing.Size(42, 21);
            this.categorySelector.TabIndex = 9;
            this.categorySelector.Text = "A";
            // 
            // weightedBox
            // 
            this.weightedBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightedBox.AutoSize = true;
            this.weightedBox.Location = new System.Drawing.Point(493, 37);
            this.weightedBox.Name = "weightedBox";
            this.weightedBox.Size = new System.Drawing.Size(78, 17);
            this.weightedBox.TabIndex = 7;
            this.weightedBox.Text = "Weighted?";
            this.weightedBox.UseVisualStyleBackColor = true;
            // 
            // kField
            // 
            this.kField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kField.Location = new System.Drawing.Point(459, 35);
            this.kField.Name = "kField";
            this.kField.Size = new System.Drawing.Size(28, 20);
            this.kField.TabIndex = 5;
            this.kField.Text = "1";
            this.kField.Validating += new System.ComponentModel.CancelEventHandler(this.kField_Validating);
            // 
            // kLabel
            // 
            this.kLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(434, 39);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(19, 13);
            this.kLabel.TabIndex = 4;
            this.kLabel.Text = "k=";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(147, 30);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(55, 13);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category=";
            // 
            // guessCategory
            // 
            this.guessCategory.AutoSize = true;
            this.guessCategory.Location = new System.Drawing.Point(6, 49);
            this.guessCategory.Name = "guessCategory";
            this.guessCategory.Size = new System.Drawing.Size(151, 17);
            this.guessCategory.TabIndex = 1;
            this.guessCategory.Text = "Guess category at location";
            this.guessCategory.UseVisualStyleBackColor = true;
            this.guessCategory.CheckedChanged += new System.EventHandler(this.guessCategory_CheckedChanged);
            // 
            // addNewData
            // 
            this.addNewData.AutoSize = true;
            this.addNewData.Checked = true;
            this.addNewData.Location = new System.Drawing.Point(6, 26);
            this.addNewData.Name = "addNewData";
            this.addNewData.Size = new System.Drawing.Size(117, 17);
            this.addNewData.TabIndex = 0;
            this.addNewData.TabStop = true;
            this.addNewData.Text = "Add new data point";
            this.addNewData.UseVisualStyleBackColor = true;
            this.addNewData.CheckedChanged += new System.EventHandler(this.addNewData_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(367, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(862, 420);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.clickBox);
            this.flowLayoutPanel1.Controls.Add(this.drawZoneButton);
            this.flowLayoutPanel1.Controls.Add(this.kLabel);
            this.flowLayoutPanel1.Controls.Add(this.kField);
            this.flowLayoutPanel1.Controls.Add(this.weightedBox);
            this.flowLayoutPanel1.Controls.Add(this.intervalLabel);
            this.flowLayoutPanel1.Controls.Add(this.intervalBox);
            this.flowLayoutPanel1.Controls.Add(this.markerSizeLabel);
            this.flowLayoutPanel1.Controls.Add(this.markerSizeBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(367, 429);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(862, 88);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // clickBox
            // 
            this.clickBox.Controls.Add(this.addNewData);
            this.clickBox.Controls.Add(this.categorySelector);
            this.clickBox.Controls.Add(this.categoryLabel);
            this.clickBox.Controls.Add(this.guessCategory);
            this.clickBox.Location = new System.Drawing.Point(3, 3);
            this.clickBox.Name = "clickBox";
            this.clickBox.Size = new System.Drawing.Size(346, 85);
            this.clickBox.TabIndex = 0;
            this.clickBox.TabStop = false;
            this.clickBox.Text = "On mouse click...";
            // 
            // drawZoneButton
            // 
            this.drawZoneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drawZoneButton.AutoSize = true;
            this.drawZoneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawZoneButton.Location = new System.Drawing.Point(355, 34);
            this.drawZoneButton.Name = "drawZoneButton";
            this.drawZoneButton.Size = new System.Drawing.Size(73, 23);
            this.drawZoneButton.TabIndex = 1;
            this.drawZoneButton.Text = "Draw zones";
            this.drawZoneButton.UseVisualStyleBackColor = true;
            this.drawZoneButton.Click += new System.EventHandler(this.drawZoneButton_Click);
            // 
            // intervalLabel
            // 
            this.intervalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(577, 39);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(48, 13);
            this.intervalLabel.TabIndex = 8;
            this.intervalLabel.Text = "Interval=";
            // 
            // intervalBox
            // 
            this.intervalBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.intervalBox.Location = new System.Drawing.Point(631, 35);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(28, 20);
            this.intervalBox.TabIndex = 9;
            this.intervalBox.Text = ".1";
            // 
            // markerSizeLabel
            // 
            this.markerSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.markerSizeLabel.AutoSize = true;
            this.markerSizeLabel.Location = new System.Drawing.Point(665, 39);
            this.markerSizeLabel.Name = "markerSizeLabel";
            this.markerSizeLabel.Size = new System.Drawing.Size(67, 13);
            this.markerSizeLabel.TabIndex = 10;
            this.markerSizeLabel.Text = "Marker size=";
            // 
            // markerSizeBox
            // 
            this.markerSizeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.markerSizeBox.Location = new System.Drawing.Point(738, 35);
            this.markerSizeBox.Name = "markerSizeBox";
            this.markerSizeBox.Size = new System.Drawing.Size(28, 20);
            this.markerSizeBox.TabIndex = 11;
            this.markerSizeBox.Text = "2";
            // 
            // KNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1232, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KNN";
            this.Text = "K - Nearest Neighbours";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.clickBox.ResumeLayout(false);
            this.clickBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel dataPanel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton guessCategory;
        private System.Windows.Forms.RadioButton addNewData;
        private System.Windows.Forms.CheckBox weightedBox;
        private System.Windows.Forms.TextBox kField;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button refreshChartButton;
        private System.Windows.Forms.ComboBox categorySelector;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox clickBox;
        private System.Windows.Forms.Button drawZoneButton;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.Label markerSizeLabel;
        private System.Windows.Forms.TextBox markerSizeBox;
    }
}

