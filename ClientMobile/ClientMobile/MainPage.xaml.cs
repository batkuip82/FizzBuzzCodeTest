using Refit;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClientMobile
{
    public partial class MainPage : ContentPage
    {
        private string _input;
        public string Input
        {
            get => _input;
            set
            {
                if (_input != value)
                {
                    _input = value;
                    OnPropertyChanged(nameof(Input));
                }
            }
        }

        private string _output;
        public string Output
        {
            get => _output;
            set
            {
                if (_output != value)
                {
                    _output = value;
                    OnPropertyChanged(nameof(Output));
                }
            }
        }

        private Command _outputCommand;
        public Command OutpuCommand
        {
            get
            {
                return _outputCommand ?? (_outputCommand = new Command(async () =>
                {
                    var isInt = int.TryParse(Input, out int input);

                    if (isInt)
                    {
                        Output = await GetOutput(input);
                    }
                    else
                    {
                        ShowAlert("Error", "Input has to be a number", "OK");
                        Input = string.Empty;
                    }
                }));
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async Task<string> GetOutput(int number)
        {
            try
            {
                var client = RestService.For<IFizzBuzzApi>(Constants.ApiUrl);
                return await client.Get(number);
            }
            catch (ApiException apiEx)
            {
                ShowAlert("Error", apiEx.Message, "OK");
            }
            catch (Exception ex)
            {
                ShowAlert("Error", ex.Message, "OK");
            }
            return string.Empty;
        }

        private void ShowAlert(string title, string message, string button)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert(title, message, button);
            });
        }
    }
}
