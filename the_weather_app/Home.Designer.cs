
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
            this.cityLable = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentWeatherIconImage = new System.Windows.Forms.PictureBox();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.cloudCoverLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherIconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLable
            // 
            this.cityLable.AutoSize = true;
            this.cityLable.Location = new System.Drawing.Point(302, 91);
            this.cityLable.Name = "cityLable";
            this.cityLable.Size = new System.Drawing.Size(13, 17);
            this.cityLable.TabIndex = 0;
            this.cityLable.Text = "-";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(302, 127);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(13, 17);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.Text = "-";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(305, 31);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(206, 22);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::the_weather_app.Properties.Resources.search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(272, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // currentWeatherIconImage
            // 
            this.currentWeatherIconImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.currentWeatherIconImage.Location = new System.Drawing.Point(126, 91);
            this.currentWeatherIconImage.Name = "currentWeatherIconImage";
            this.currentWeatherIconImage.Size = new System.Drawing.Size(124, 94);
            this.currentWeatherIconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentWeatherIconImage.TabIndex = 5;
            this.currentWeatherIconImage.TabStop = false;
            this.currentWeatherIconImage.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.AutoSize = true;
            this.feelsLikeLabel.Location = new System.Drawing.Point(302, 157);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(13, 17);
            this.feelsLikeLabel.TabIndex = 6;
            this.feelsLikeLabel.Text = "-";
            // 
            // cloudCoverLabel
            // 
            this.cloudCoverLabel.AutoSize = true;
            this.cloudCoverLabel.Location = new System.Drawing.Point(498, 157);
            this.cloudCoverLabel.Name = "cloudCoverLabel";
            this.cloudCoverLabel.Size = new System.Drawing.Size(13, 17);
            this.cloudCoverLabel.TabIndex = 9;
            this.cloudCoverLabel.Text = "-";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(498, 127);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(13, 17);
            this.humidityLabel.TabIndex = 8;
            this.humidityLabel.Text = "-";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(498, 91);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(13, 17);
            this.pressureLabel.TabIndex = 7;
            this.pressureLabel.Text = "-";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Location = new System.Drawing.Point(302, 191);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(13, 17);
            this.windLabel.TabIndex = 10;
            this.windLabel.Text = "-";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.cloudCoverLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.feelsLikeLabel);
            this.Controls.Add(this.currentWeatherIconImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.cityLable);
            this.Name = "Home";
            this.Text = "22";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherIconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLable;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox currentWeatherIconImage;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label cloudCoverLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label windLabel;
    }
}

