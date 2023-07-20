using Observer.Pattern;

namespace Observer.Displays
{
    public partial class TemperatureDisplay : UserControl, IObserver<WeatherData>
    {
        WeatherStation? _station = null;
        private IDisposable _unsubcriber;

        public TemperatureDisplay(WeatherStation weatherStation)
        {
            InitializeComponent();
            _station = weatherStation;
            _unsubcriber = _station.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            UpdateData(value);
        }

        private void UpdateData(WeatherData value)
        {
            var suffix = showFareniht.Checked ? "F" : "C";
            var temperature = showFareniht.Checked ?
                (value.Temperature * 9 / 5) + 32 : value.Temperature;

            
            this.Invoke(new MethodInvoker(delegate ()
            {
                tempertureData.Text = temperature + " " + suffix;
                dataRecivedAt.Text = DateTime.Now.ToString("yy-MM-dd HH-mm-ss");
            }));
        }

        private void stopUpdating_Click(object sender, EventArgs e)
        {
            var currentState = stopUpdating.Text;
            if (currentState.ToUpperInvariant() == "STOP")
            {
                _unsubcriber.Dispose();
                stopUpdating.Text = "Start";
            }
            else
            {
                _unsubcriber = _station.Subscribe(this);
                stopUpdating.Text = "Stop";
            }
        }
    }
}
