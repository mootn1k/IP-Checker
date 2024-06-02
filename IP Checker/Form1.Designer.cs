namespace IP_Checker
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
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.labelCountryN = new System.Windows.Forms.Label();
            this.labelRegionN = new System.Windows.Forms.Label();
            this.labelCityN = new System.Windows.Forms.Label();
            this.labelContinentN = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.internetLabel = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelContinent = new System.Windows.Forms.Label();
            this.labelCurrencyN = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelLatitudeN = new System.Windows.Forms.Label();
            this.labelLongitudeN = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Location = new System.Drawing.Point(125, 270);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(193, 54);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(142, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 31);
            this.name.TabIndex = 2;
            this.name.Text = "IP Checker";
            // 
            // labelCountryN
            // 
            this.labelCountryN.AutoSize = true;
            this.labelCountryN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountryN.Location = new System.Drawing.Point(9, 144);
            this.labelCountryN.Name = "labelCountryN";
            this.labelCountryN.Size = new System.Drawing.Size(72, 20);
            this.labelCountryN.TabIndex = 3;
            this.labelCountryN.Text = "Country: ";
            // 
            // labelRegionN
            // 
            this.labelRegionN.AutoSize = true;
            this.labelRegionN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegionN.Location = new System.Drawing.Point(9, 184);
            this.labelRegionN.Name = "labelRegionN";
            this.labelRegionN.Size = new System.Drawing.Size(68, 20);
            this.labelRegionN.TabIndex = 4;
            this.labelRegionN.Text = "Region: ";
            // 
            // labelCityN
            // 
            this.labelCityN.AutoSize = true;
            this.labelCityN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCityN.Location = new System.Drawing.Point(9, 224);
            this.labelCityN.Name = "labelCityN";
            this.labelCityN.Size = new System.Drawing.Size(43, 20);
            this.labelCityN.TabIndex = 5;
            this.labelCityN.Text = "City: ";
            // 
            // labelContinentN
            // 
            this.labelContinentN.AutoSize = true;
            this.labelContinentN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContinentN.Location = new System.Drawing.Point(11, 108);
            this.labelContinentN.Name = "labelContinentN";
            this.labelContinentN.Size = new System.Drawing.Size(86, 20);
            this.labelContinentN.TabIndex = 6;
            this.labelContinentN.Text = "Continent: ";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.ForeColor = System.Drawing.Color.Lime;
            this.labelCountry.Location = new System.Drawing.Point(87, 144);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(20, 20);
            this.labelCountry.TabIndex = 7;
            this.labelCountry.Text = "C";
            // 
            // internetLabel
            // 
            this.internetLabel.AutoSize = true;
            this.internetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.internetLabel.Location = new System.Drawing.Point(160, 247);
            this.internetLabel.Name = "internetLabel";
            this.internetLabel.Size = new System.Drawing.Size(0, 20);
            this.internetLabel.TabIndex = 8;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.ForeColor = System.Drawing.Color.Lime;
            this.labelCity.Location = new System.Drawing.Point(58, 224);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(20, 20);
            this.labelCity.TabIndex = 9;
            this.labelCity.Text = "C";
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegion.ForeColor = System.Drawing.Color.Lime;
            this.labelRegion.Location = new System.Drawing.Point(83, 184);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(21, 20);
            this.labelRegion.TabIndex = 10;
            this.labelRegion.Text = "R";
            // 
            // labelContinent
            // 
            this.labelContinent.AutoSize = true;
            this.labelContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContinent.ForeColor = System.Drawing.Color.Lime;
            this.labelContinent.Location = new System.Drawing.Point(103, 108);
            this.labelContinent.Name = "labelContinent";
            this.labelContinent.Size = new System.Drawing.Size(20, 20);
            this.labelContinent.TabIndex = 11;
            this.labelContinent.Text = "C";
            // 
            // labelCurrencyN
            // 
            this.labelCurrencyN.AutoSize = true;
            this.labelCurrencyN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrencyN.Location = new System.Drawing.Point(242, 108);
            this.labelCurrencyN.Name = "labelCurrencyN";
            this.labelCurrencyN.Size = new System.Drawing.Size(80, 20);
            this.labelCurrencyN.TabIndex = 12;
            this.labelCurrencyN.Text = "Currency: ";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency.ForeColor = System.Drawing.Color.Lime;
            this.labelCurrency.Location = new System.Drawing.Point(334, 108);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(20, 20);
            this.labelCurrency.TabIndex = 13;
            this.labelCurrency.Text = "C";
            // 
            // labelLatitudeN
            // 
            this.labelLatitudeN.AutoSize = true;
            this.labelLatitudeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLatitudeN.Location = new System.Drawing.Point(242, 146);
            this.labelLatitudeN.Name = "labelLatitudeN";
            this.labelLatitudeN.Size = new System.Drawing.Size(75, 20);
            this.labelLatitudeN.TabIndex = 14;
            this.labelLatitudeN.Text = "Latitude: ";
            // 
            // labelLongitudeN
            // 
            this.labelLongitudeN.AutoSize = true;
            this.labelLongitudeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLongitudeN.Location = new System.Drawing.Point(242, 185);
            this.labelLongitudeN.Name = "labelLongitudeN";
            this.labelLongitudeN.Size = new System.Drawing.Size(88, 20);
            this.labelLongitudeN.TabIndex = 15;
            this.labelLongitudeN.Text = "Longitude: ";
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLatitude.ForeColor = System.Drawing.Color.Lime;
            this.labelLatitude.Location = new System.Drawing.Point(325, 146);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(58, 20);
            this.labelLatitude.TabIndex = 16;
            this.labelLatitude.Text = "0.0000";
            this.labelLatitude.Click += new System.EventHandler(this.labelLatitude_Click);
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLongitude.ForeColor = System.Drawing.Color.Lime;
            this.labelLongitude.Location = new System.Drawing.Point(334, 185);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(58, 20);
            this.labelLongitude.TabIndex = 17;
            this.labelLongitude.Text = "0.0000";
            this.labelLongitude.Click += new System.EventHandler(this.labelLongitude_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(424, 339);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.labelLongitudeN);
            this.Controls.Add(this.labelLatitudeN);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.labelCurrencyN);
            this.Controls.Add(this.labelContinent);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.internetLabel);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelContinentN);
            this.Controls.Add(this.labelCityN);
            this.Controls.Add(this.labelRegionN);
            this.Controls.Add(this.labelCountryN);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCheck);
            this.Name = "Form1";
            this.Text = "IP Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label labelCountryN;
        private System.Windows.Forms.Label labelRegionN;
        private System.Windows.Forms.Label labelCityN;
        private System.Windows.Forms.Label labelContinentN;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label internetLabel;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelContinent;
        private System.Windows.Forms.Label labelCurrencyN;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelLatitudeN;
        private System.Windows.Forms.Label labelLongitudeN;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Label labelLongitude;
    }
}

