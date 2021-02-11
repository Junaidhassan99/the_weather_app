
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
            this.coordLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityLable
            // 
            this.cityLable.AutoSize = true;
            this.cityLable.Location = new System.Drawing.Point(311, 63);
            this.cityLable.Name = "cityLable";
            this.cityLable.Size = new System.Drawing.Size(0, 17);
            this.cityLable.TabIndex = 0;
            // 
            // coordLabel
            // 
            this.coordLabel.AutoSize = true;
            this.coordLabel.Location = new System.Drawing.Point(311, 102);
            this.coordLabel.Name = "coordLabel";
            this.coordLabel.Size = new System.Drawing.Size(0, 17);
            this.coordLabel.TabIndex = 1;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(311, 140);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(0, 17);
            this.tempLabel.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.coordLabel);
            this.Controls.Add(this.cityLable);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLable;
        private System.Windows.Forms.Label coordLabel;
        private System.Windows.Forms.Label tempLabel;
    }
}

