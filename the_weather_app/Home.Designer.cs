﻿
namespace the_weather_app
{
    partial class Home
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFeelsLike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHumidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCloudCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.cityLable = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.windLabel = new System.Windows.Forms.Label();
            this.currentWeatherIconImage = new System.Windows.Forms.PictureBox();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tempLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.cloudCoverLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDateText,
            this.ColumnTemp,
            this.ColumnFeelsLike,
            this.ColumnHumidity,
            this.ColumnPressure,
            this.ColumnWind,
            this.ColumnCloudCover});
            this.dataGridView1.Location = new System.Drawing.Point(90, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 396);
            this.dataGridView1.TabIndex = 11;
            // 
            // ColumnDateText
            // 
            this.ColumnDateText.HeaderText = "Date and Time";
            this.ColumnDateText.MinimumWidth = 6;
            this.ColumnDateText.Name = "ColumnDateText";
            this.ColumnDateText.Width = 150;
            // 
            // ColumnTemp
            // 
            this.ColumnTemp.HeaderText = "Temperature";
            this.ColumnTemp.MinimumWidth = 6;
            this.ColumnTemp.Name = "ColumnTemp";
            this.ColumnTemp.Width = 125;
            // 
            // ColumnFeelsLike
            // 
            this.ColumnFeelsLike.HeaderText = "Feels Like";
            this.ColumnFeelsLike.MinimumWidth = 6;
            this.ColumnFeelsLike.Name = "ColumnFeelsLike";
            this.ColumnFeelsLike.Width = 125;
            // 
            // ColumnHumidity
            // 
            this.ColumnHumidity.HeaderText = "Humidity";
            this.ColumnHumidity.MinimumWidth = 6;
            this.ColumnHumidity.Name = "ColumnHumidity";
            this.ColumnHumidity.Width = 125;
            // 
            // ColumnPressure
            // 
            this.ColumnPressure.HeaderText = "Pressure";
            this.ColumnPressure.MinimumWidth = 6;
            this.ColumnPressure.Name = "ColumnPressure";
            this.ColumnPressure.Width = 125;
            // 
            // ColumnWind
            // 
            this.ColumnWind.HeaderText = "Wind";
            this.ColumnWind.MinimumWidth = 6;
            this.ColumnWind.Name = "ColumnWind";
            this.ColumnWind.Width = 125;
            // 
            // ColumnCloudCover
            // 
            this.ColumnCloudCover.HeaderText = "Cloud Cover";
            this.ColumnCloudCover.MinimumWidth = 6;
            this.ColumnCloudCover.Name = "ColumnCloudCover";
            this.ColumnCloudCover.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(103, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1152, 709);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather Forecaste";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.labelDateTime);
            this.groupBox2.Controls.Add(this.cityLable);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.windLabel);
            this.groupBox2.Controls.Add(this.currentWeatherIconImage);
            this.groupBox2.Controls.Add(this.humidityLabel);
            this.groupBox2.Controls.Add(this.feelsLikeLabel);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.tempLabel);
            this.groupBox2.Controls.Add(this.pressureLabel);
            this.groupBox2.Controls.Add(this.cloudCoverLabel);
            this.groupBox2.Location = new System.Drawing.Point(90, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 227);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Weather";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(235, 66);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(13, 17);
            this.labelDateTime.TabIndex = 11;
            this.labelDateTime.Text = "-";
            // 
            // cityLable
            // 
            this.cityLable.AutoSize = true;
            this.cityLable.Location = new System.Drawing.Point(235, 98);
            this.cityLable.Name = "cityLable";
            this.cityLable.Size = new System.Drawing.Size(13, 17);
            this.cityLable.TabIndex = 0;
            this.cityLable.Text = "-";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(238, 21);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(206, 22);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Location = new System.Drawing.Point(235, 198);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(13, 17);
            this.windLabel.TabIndex = 10;
            this.windLabel.Text = "-";
            // 
            // currentWeatherIconImage
            // 
            this.currentWeatherIconImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.currentWeatherIconImage.Location = new System.Drawing.Point(59, 98);
            this.currentWeatherIconImage.Name = "currentWeatherIconImage";
            this.currentWeatherIconImage.Size = new System.Drawing.Size(124, 94);
            this.currentWeatherIconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentWeatherIconImage.TabIndex = 5;
            this.currentWeatherIconImage.TabStop = false;
            this.currentWeatherIconImage.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(431, 134);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(13, 17);
            this.humidityLabel.TabIndex = 8;
            this.humidityLabel.Text = "-";
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.AutoSize = true;
            this.feelsLikeLabel.Location = new System.Drawing.Point(235, 164);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(13, 17);
            this.feelsLikeLabel.TabIndex = 6;
            this.feelsLikeLabel.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::the_weather_app.Properties.Resources.search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(205, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(235, 134);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(13, 17);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.Text = "-";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(431, 98);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(13, 17);
            this.pressureLabel.TabIndex = 7;
            this.pressureLabel.Text = "-";
            // 
            // cloudCoverLabel
            // 
            this.cloudCoverLabel.AutoSize = true;
            this.cloudCoverLabel.Location = new System.Drawing.Point(431, 164);
            this.cloudCoverLabel.Name = "cloudCoverLabel";
            this.cloudCoverLabel.Size = new System.Drawing.Size(13, 17);
            this.cloudCoverLabel.TabIndex = 9;
            this.cloudCoverLabel.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(791, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "About Us";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 733);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "22";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFeelsLike;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHumidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCloudCover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox currentWeatherIconImage;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label cloudCoverLabel;
        private System.Windows.Forms.Label cityLable;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

