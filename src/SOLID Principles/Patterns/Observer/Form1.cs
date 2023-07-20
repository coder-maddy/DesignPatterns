using Observer.Displays;
using Observer.Pattern;

namespace Observer
{
    public partial class Form1 : Form
    {
        WeatherStation weatherStation = new WeatherStation();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form();
            form.Controls.Add(new TemperatureDisplay(weatherStation));
            form.Show();
        }
    }
}