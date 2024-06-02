using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json;

namespace IP_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void buttonCheck_Click(object sender, EventArgs e)
        {
            string path = @"C:\tempFile";

            if (CheckString(textBox1.Text))
            {
                string ip = textBox1.Text;
                using (var httpClient = new HttpClient())
                {
                    var requestMessage = new HttpRequestMessage
                    {
                        RequestUri = new Uri(@"http://www.geoplugin.net/json.gp?ip=" + ip),
                        Method = HttpMethod.Get
                    };
                    var response = await httpClient.SendAsync(requestMessage);

                    using (var stream = File.Create(path))
                    {
                        await response.Content.CopyToAsync(stream);
                    }

                    var infoText = File.ReadAllText(path);
                    Information info = JsonSerializer.Deserialize<Information>(infoText);
                    labelContinent.Text = info.geoplugin_continentName;
                    labelCountry.Text = info.geoplugin_countryName;
                    labelRegion.Text = info.geoplugin_region;
                    labelCity.Text = info.geoplugin_city;
                    labelCurrency.Text = info.geoplugin_currencyCode;
                    labelLatitude.Text = info.geoplugin_latitude;
                    labelLongitude.Text = info.geoplugin_longitude;

                    File.Delete(path);
                }

            }
            else
            {
                MessageBox.Show("Введите IP адрес", "Ошибка");
            }
        }

        private static bool CheckString(string str)
        {
            if(!(str == String.Empty) && !(str.Contains(",")))
            {
                return true;
            }
            return false;
        }

        private void labelLatitude_Click(object sender, EventArgs e) => CopyToBuffer(labelLatitude.Text);

        private void labelLongitude_Click(object sender, EventArgs e) => CopyToBuffer(labelLongitude.Text);

        private static void CopyToBuffer(string savingText)
        {
            Clipboard.Clear();
            Clipboard.SetText(savingText);
        }
    }

    public struct Information
    {
        public string geoplugin_city { get; set; }
        public string geoplugin_region { get; set; }
        public string geoplugin_countryName { get; set; }
        public string geoplugin_continentName { get; set; }
        public string geoplugin_latitude { get; set; }
        public string geoplugin_longitude { get; set; }
        public string geoplugin_currencyCode { get; set; }
    }
}