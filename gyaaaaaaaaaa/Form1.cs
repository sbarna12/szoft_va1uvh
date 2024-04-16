using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace gyaaaaaaaaaa
{
    public partial class Form1 : Form
    {

        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("countries.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var x = csv.GetRecords<CountryData>();
                foreach (var item in x)
                {
                    countryList.Add(item);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.CountryData = countryDataBindingSource.Current as CountryData;
            f2.Show();
        }
    }
}
