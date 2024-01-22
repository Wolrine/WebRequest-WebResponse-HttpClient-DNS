﻿using System.Net.Http;
using System.Windows;

namespace HttpClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new();

        private async void btnViewHTML_Click(object sender, RoutedEventArgs e)
        {
            string uri = txtURL.Text;

            try
            {
                string responseBody = await client.GetStringAsync(uri);
                txtContent.Text = responseBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtContent.Text = string.Empty;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();
    }
}