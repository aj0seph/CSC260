namespace WeatherProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCityState = new System.Windows.Forms.TextBox();
            this.WeatherIcon = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtDetails = new System.Windows.Forms.Button();
            this.TxtCondition = new System.Windows.Forms.Button();
            this.sunrise = new System.Windows.Forms.Button();
            this.sunset = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.TxtTemp = new System.Windows.Forms.Button();
            this.SunsetResponse = new System.Windows.Forms.Button();
            this.SunriseResponse = new System.Windows.Forms.Button();
            this.WindSpeedResponse = new System.Windows.Forms.Button();
            this.PressureResponse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(579, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtCityState
            // 
            this.TxtCityState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCityState.Location = new System.Drawing.Point(105, 21);
            this.TxtCityState.Multiline = true;
            this.TxtCityState.Name = "TxtCityState";
            this.TxtCityState.Size = new System.Drawing.Size(455, 38);
            this.TxtCityState.TabIndex = 1;
            this.TxtCityState.Text = "sdfsdf";
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.WeatherIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WeatherIcon.Location = new System.Drawing.Point(188, 85);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(274, 160);
            this.WeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WeatherIcon.TabIndex = 5;
            this.WeatherIcon.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(56, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "City/State:";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TxtDetails
            // 
            this.TxtDetails.BackColor = System.Drawing.Color.Transparent;
            this.TxtDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtDetails.FlatAppearance.BorderSize = 0;
            this.TxtDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDetails.ForeColor = System.Drawing.Color.Black;
            this.TxtDetails.Location = new System.Drawing.Point(258, 264);
            this.TxtDetails.Name = "TxtDetails";
            this.TxtDetails.Size = new System.Drawing.Size(162, 38);
            this.TxtDetails.TabIndex = 7;
            this.TxtDetails.Text = "Details:";
            this.TxtDetails.UseVisualStyleBackColor = false;
            // 
            // TxtCondition
            // 
            this.TxtCondition.BackColor = System.Drawing.Color.Transparent;
            this.TxtCondition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCondition.FlatAppearance.BorderSize = 0;
            this.TxtCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCondition.ForeColor = System.Drawing.Color.Black;
            this.TxtCondition.Location = new System.Drawing.Point(506, 264);
            this.TxtCondition.Name = "TxtCondition";
            this.TxtCondition.Size = new System.Drawing.Size(162, 38);
            this.TxtCondition.TabIndex = 8;
            this.TxtCondition.Text = "Condition:";
            this.TxtCondition.UseVisualStyleBackColor = false;
            // 
            // sunrise
            // 
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sunrise.FlatAppearance.BorderSize = 0;
            this.sunrise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.ForeColor = System.Drawing.Color.Black;
            this.sunrise.Location = new System.Drawing.Point(56, 344);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(162, 38);
            this.sunrise.TabIndex = 9;
            this.sunrise.Text = "Sunrise:";
            this.sunrise.UseVisualStyleBackColor = false;
            // 
            // sunset
            // 
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sunset.FlatAppearance.BorderSize = 0;
            this.sunset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.ForeColor = System.Drawing.Color.Black;
            this.sunset.Location = new System.Drawing.Point(258, 344);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(162, 38);
            this.sunset.TabIndex = 10;
            this.sunset.Text = "Sunset:";
            this.sunset.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(506, 344);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 38);
            this.button7.TabIndex = 11;
            this.button7.Text = "Wind Speed:";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(258, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 38);
            this.button8.TabIndex = 12;
            this.button8.Text = "Pressure:";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // TxtTemp
            // 
            this.TxtTemp.BackColor = System.Drawing.Color.Transparent;
            this.TxtTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtTemp.FlatAppearance.BorderSize = 0;
            this.TxtTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTemp.ForeColor = System.Drawing.Color.Black;
            this.TxtTemp.Location = new System.Drawing.Point(560, 85);
            this.TxtTemp.Name = "TxtTemp";
            this.TxtTemp.Size = new System.Drawing.Size(162, 38);
            this.TxtTemp.TabIndex = 13;
            this.TxtTemp.Text = "Temperature:";
            this.TxtTemp.UseVisualStyleBackColor = false;
            // 
            // SunsetResponse
            // 
            this.SunsetResponse.BackColor = System.Drawing.Color.Transparent;
            this.SunsetResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SunsetResponse.FlatAppearance.BorderSize = 0;
            this.SunsetResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SunsetResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunsetResponse.ForeColor = System.Drawing.Color.Black;
            this.SunsetResponse.Location = new System.Drawing.Point(372, 344);
            this.SunsetResponse.Name = "SunsetResponse";
            this.SunsetResponse.Size = new System.Drawing.Size(90, 38);
            this.SunsetResponse.TabIndex = 14;
            this.SunsetResponse.Text = "N/A";
            this.SunsetResponse.UseVisualStyleBackColor = false;
            // 
            // SunriseResponse
            // 
            this.SunriseResponse.BackColor = System.Drawing.Color.Transparent;
            this.SunriseResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SunriseResponse.FlatAppearance.BorderSize = 0;
            this.SunriseResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SunriseResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunriseResponse.ForeColor = System.Drawing.Color.Black;
            this.SunriseResponse.Location = new System.Drawing.Point(172, 345);
            this.SunriseResponse.Name = "SunriseResponse";
            this.SunriseResponse.Size = new System.Drawing.Size(90, 38);
            this.SunriseResponse.TabIndex = 15;
            this.SunriseResponse.Text = "N/A";
            this.SunriseResponse.UseVisualStyleBackColor = false;
            // 
            // WindSpeedResponse
            // 
            this.WindSpeedResponse.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WindSpeedResponse.FlatAppearance.BorderSize = 0;
            this.WindSpeedResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindSpeedResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedResponse.ForeColor = System.Drawing.Color.Black;
            this.WindSpeedResponse.Location = new System.Drawing.Point(651, 345);
            this.WindSpeedResponse.Name = "WindSpeedResponse";
            this.WindSpeedResponse.Size = new System.Drawing.Size(90, 38);
            this.WindSpeedResponse.TabIndex = 16;
            this.WindSpeedResponse.Text = "N/A";
            this.WindSpeedResponse.UseVisualStyleBackColor = false;
            // 
            // PressureResponse
            // 
            this.PressureResponse.BackColor = System.Drawing.Color.Transparent;
            this.PressureResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PressureResponse.FlatAppearance.BorderSize = 0;
            this.PressureResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PressureResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureResponse.ForeColor = System.Drawing.Color.Black;
            this.PressureResponse.Location = new System.Drawing.Point(391, 400);
            this.PressureResponse.Name = "PressureResponse";
            this.PressureResponse.Size = new System.Drawing.Size(90, 38);
            this.PressureResponse.TabIndex = 17;
            this.PressureResponse.Text = "N/A";
            this.PressureResponse.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(589, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 38);
            this.button3.TabIndex = 18;
            this.button3.Text = "N/A";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PressureResponse);
            this.Controls.Add(this.WindSpeedResponse);
            this.Controls.Add(this.SunriseResponse);
            this.Controls.Add(this.SunsetResponse);
            this.Controls.Add(this.TxtTemp);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.TxtCondition);
            this.Controls.Add(this.TxtDetails);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WeatherIcon);
            this.Controls.Add(this.TxtCityState);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtCityState;
        private System.Windows.Forms.PictureBox WeatherIcon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TxtDetails;
        private System.Windows.Forms.Button TxtCondition;
        private System.Windows.Forms.Button sunrise;
        private System.Windows.Forms.Button sunset;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button TxtTemp;
        private System.Windows.Forms.Button SunsetResponse;
        private System.Windows.Forms.Button SunriseResponse;
        private System.Windows.Forms.Button WindSpeedResponse;
        private System.Windows.Forms.Button PressureResponse;
        private System.Windows.Forms.Button button3;
    }
}

