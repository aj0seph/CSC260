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
            this.Date = new System.Windows.Forms.Button();
            this.TxtDetails = new System.Windows.Forms.Button();
            this.TxtCondition = new System.Windows.Forms.Button();
            this.sunrise = new System.Windows.Forms.Button();
            this.sunset = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.TxtTemp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.DetailsResponse = new WeatherProject.DetailsDisplayButton();
            this.ConditionResponse = new WeatherProject.ConditionDisplayButton();
            this.TempResponse = new WeatherProject.TemperatureDisplayButton();
            this.PressureResponse = new WeatherProject.PressureDisplayButton();
            this.WindSpeedResponse = new WeatherProject.WindSpeedButton();
            this.SunriseResponse = new WeatherProject.SunriseDisplayButton();
            this.SunsetResponse = new WeatherProject.SunsetDisplayButton();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(598, 21);
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
            this.TxtCityState.Location = new System.Drawing.Point(116, 21);
            this.TxtCityState.Multiline = true;
            this.TxtCityState.Name = "TxtCityState";
            this.TxtCityState.Size = new System.Drawing.Size(455, 38);
            this.TxtCityState.TabIndex = 1;
            this.TxtCityState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCityState_KeyPress);
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.WeatherIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WeatherIcon.Location = new System.Drawing.Point(210, 104);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(295, 138);
            this.WeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WeatherIcon.TabIndex = 5;
            this.WeatherIcon.TabStop = false;
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Date.FlatAppearance.BorderSize = 0;
            this.Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.Indigo;
            this.Date.Location = new System.Drawing.Point(116, 60);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(445, 38);
            this.Date.TabIndex = 6;
            this.Date.Text = "N/A";
            this.Date.UseVisualStyleBackColor = false;
            // 
            // TxtDetails
            // 
            this.TxtDetails.BackColor = System.Drawing.Color.Transparent;
            this.TxtDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtDetails.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.TxtDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDetails.ForeColor = System.Drawing.Color.Black;
            this.TxtDetails.Location = new System.Drawing.Point(12, 251);
            this.TxtDetails.Name = "TxtDetails";
            this.TxtDetails.Size = new System.Drawing.Size(160, 119);
            this.TxtDetails.TabIndex = 7;
            this.TxtDetails.Text = "Details:";
            this.TxtDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TxtDetails.UseVisualStyleBackColor = false;
            // 
            // TxtCondition
            // 
            this.TxtCondition.BackColor = System.Drawing.Color.Transparent;
            this.TxtCondition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCondition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TxtCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCondition.ForeColor = System.Drawing.Color.Black;
            this.TxtCondition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TxtCondition.Location = new System.Drawing.Point(201, 251);
            this.TxtCondition.Name = "TxtCondition";
            this.TxtCondition.Size = new System.Drawing.Size(162, 122);
            this.TxtCondition.TabIndex = 8;
            this.TxtCondition.Text = "Condition:";
            this.TxtCondition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TxtCondition.UseVisualStyleBackColor = false;
            // 
            // sunrise
            // 
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sunrise.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.sunrise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.ForeColor = System.Drawing.Color.Black;
            this.sunrise.Location = new System.Drawing.Point(409, 248);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(162, 122);
            this.sunrise.TabIndex = 9;
            this.sunrise.Text = "Sunrise:";
            this.sunrise.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sunrise.UseVisualStyleBackColor = false;
            // 
            // sunset
            // 
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sunset.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.sunset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.ForeColor = System.Drawing.Color.Black;
            this.sunset.Location = new System.Drawing.Point(615, 245);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(162, 125);
            this.sunset.TabIndex = 10;
            this.sunset.Text = "Sunset:";
            this.sunset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sunset.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button7.Location = new System.Drawing.Point(57, 399);
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
            this.button8.ForeColor = System.Drawing.Color.Fuchsia;
            this.button8.Location = new System.Drawing.Point(474, 400);
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
            this.TxtTemp.Location = new System.Drawing.Point(551, 85);
            this.TxtTemp.Name = "TxtTemp";
            this.TxtTemp.Size = new System.Drawing.Size(162, 38);
            this.TxtTemp.TabIndex = 13;
            this.TxtTemp.Text = "Temperature:";
            this.TxtTemp.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(268, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "mph";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(669, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 38);
            this.button4.TabIndex = 22;
            this.button4.Text = "atm";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.HotPink;
            this.button5.Location = new System.Drawing.Point(649, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 40);
            this.button5.TabIndex = 23;
            this.button5.Text = "o";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(638, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(686, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(40, 280);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(237, 280);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(16, 399);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(448, 399);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(56, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // DetailsResponse
            // 
            this.DetailsResponse.BackColor = System.Drawing.Color.Transparent;
            this.DetailsResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DetailsResponse.FlatAppearance.BorderSize = 0;
            this.DetailsResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsResponse.ForeColor = System.Drawing.Color.IndianRed;
            this.DetailsResponse.Location = new System.Drawing.Point(28, 323);
            this.DetailsResponse.Name = "DetailsResponse";
            this.DetailsResponse.Size = new System.Drawing.Size(127, 47);
            this.DetailsResponse.TabIndex = 20;
            this.DetailsResponse.Text = "N/A";
            this.DetailsResponse.UseVisualStyleBackColor = false;
            // 
            // ConditionResponse
            // 
            this.ConditionResponse.BackColor = System.Drawing.Color.Transparent;
            this.ConditionResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConditionResponse.FlatAppearance.BorderSize = 0;
            this.ConditionResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConditionResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ConditionResponse.Location = new System.Drawing.Point(237, 326);
            this.ConditionResponse.Name = "ConditionResponse";
            this.ConditionResponse.Size = new System.Drawing.Size(90, 38);
            this.ConditionResponse.TabIndex = 19;
            this.ConditionResponse.Text = "N/A";
            this.ConditionResponse.UseVisualStyleBackColor = false;
            // 
            // TempResponse
            // 
            this.TempResponse.BackColor = System.Drawing.Color.Transparent;
            this.TempResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TempResponse.FlatAppearance.BorderSize = 0;
            this.TempResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TempResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempResponse.ForeColor = System.Drawing.Color.HotPink;
            this.TempResponse.Location = new System.Drawing.Point(532, 117);
            this.TempResponse.Name = "TempResponse";
            this.TempResponse.Size = new System.Drawing.Size(148, 106);
            this.TempResponse.TabIndex = 18;
            this.TempResponse.Text = "N/A";
            this.TempResponse.UseVisualStyleBackColor = false;
            // 
            // PressureResponse
            // 
            this.PressureResponse.BackColor = System.Drawing.Color.Transparent;
            this.PressureResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PressureResponse.FlatAppearance.BorderSize = 0;
            this.PressureResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PressureResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureResponse.ForeColor = System.Drawing.Color.Black;
            this.PressureResponse.Location = new System.Drawing.Point(598, 399);
            this.PressureResponse.Name = "PressureResponse";
            this.PressureResponse.Size = new System.Drawing.Size(82, 38);
            this.PressureResponse.TabIndex = 17;
            this.PressureResponse.Text = "N/A";
            this.PressureResponse.UseVisualStyleBackColor = false;
            // 
            // WindSpeedResponse
            // 
            this.WindSpeedResponse.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WindSpeedResponse.FlatAppearance.BorderSize = 0;
            this.WindSpeedResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindSpeedResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedResponse.ForeColor = System.Drawing.Color.Black;
            this.WindSpeedResponse.Location = new System.Drawing.Point(201, 399);
            this.WindSpeedResponse.Name = "WindSpeedResponse";
            this.WindSpeedResponse.Size = new System.Drawing.Size(97, 38);
            this.WindSpeedResponse.TabIndex = 16;
            this.WindSpeedResponse.Text = "N/A";
            this.WindSpeedResponse.UseVisualStyleBackColor = false;
            // 
            // SunriseResponse
            // 
            this.SunriseResponse.BackColor = System.Drawing.Color.Transparent;
            this.SunriseResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SunriseResponse.FlatAppearance.BorderSize = 0;
            this.SunriseResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SunriseResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunriseResponse.ForeColor = System.Drawing.Color.Yellow;
            this.SunriseResponse.Location = new System.Drawing.Point(436, 326);
            this.SunriseResponse.Name = "SunriseResponse";
            this.SunriseResponse.Size = new System.Drawing.Size(102, 38);
            this.SunriseResponse.TabIndex = 15;
            this.SunriseResponse.Text = "N/A";
            this.SunriseResponse.UseVisualStyleBackColor = false;
            // 
            // SunsetResponse
            // 
            this.SunsetResponse.BackColor = System.Drawing.Color.Transparent;
            this.SunsetResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SunsetResponse.FlatAppearance.BorderSize = 0;
            this.SunsetResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SunsetResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunsetResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SunsetResponse.Location = new System.Drawing.Point(638, 327);
            this.SunsetResponse.Name = "SunsetResponse";
            this.SunsetResponse.Size = new System.Drawing.Size(122, 38);
            this.SunsetResponse.TabIndex = 14;
            this.SunsetResponse.Text = "N/A";
            this.SunsetResponse.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DetailsResponse);
            this.Controls.Add(this.ConditionResponse);
            this.Controls.Add(this.TempResponse);
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
            this.Controls.Add(this.Date);
            this.Controls.Add(this.WeatherIcon);
            this.Controls.Add(this.TxtCityState);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtCityState;
        private System.Windows.Forms.PictureBox WeatherIcon;
        private System.Windows.Forms.Button Date;
        private System.Windows.Forms.Button TxtDetails;
        private System.Windows.Forms.Button TxtCondition;
        private System.Windows.Forms.Button sunrise;
        private System.Windows.Forms.Button sunset;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button TxtTemp;
        private TemperatureDisplayButton TempResponse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private SunsetDisplayButton SunsetResponse;
        private SunriseDisplayButton SunriseResponse;
        private WindSpeedButton WindSpeedResponse;
        private PressureDisplayButton PressureResponse;
        private ConditionDisplayButton ConditionResponse;
        private DetailsDisplayButton DetailsResponse;
    }
}

