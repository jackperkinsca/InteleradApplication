
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
namespace InteleradApp
{
    public partial class programForm : Form
    {
        public programForm()
        {
            InitializeComponent();
        }
        
        private void startButton_Click_1(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            CSVOutput.readCSV();
            progressBar.Value = 25;
            progressBar.Value = 25 - 1;
            progressBar.Value = 25;
            startButton.Text = "CSV's Loaded!";
            CSVOutput.initDataCleanup();
            progressBar.Value = 50;
            progressBar.Value = 50 - 1;
            progressBar.Value = 50;
            startButton.Text = "Data Cleaned!";
            CSVOutput.initDataLinking();
            progressBar.Value = 75;
            progressBar.Value = 75 - 1;
            progressBar.Value = 75;
            startButton.Text = "Data Ready!";
            CSVOutput.writeCSV();
            progressBar.Value = 100;
            progressBar.Value = 100 - 1;
            progressBar.Value = 100;
            startButton.Text = "Output Ready!";

        }
    }
}
