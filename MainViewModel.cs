
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SyncFusionTest
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<PaymentTypes> paymentTypesList = [];
        [ObservableProperty]
        public string? cardHolderName;
        [ObservableProperty]
        public string? cardNumber;
        [ObservableProperty]
        public List<DateInformation> expirationMonths = [];
        [ObservableProperty]
        public List<DateInformation> expirationYears = [];
        [ObservableProperty]
        public int paymentTypePickerIndex = -1;
        [ObservableProperty]
        public int expirationMonthsPickerIndex = -1;
        [ObservableProperty]
        public int expirationYearsPickerIndex = -1;

        public MainViewModel()
        {
            PaymentTypesList.Add(new PaymentTypes
            {
                PaymentType = "Apple Pay",
                Icon_Light = "apple_pay_icon_light",
                Icon_Dark = "apple_pay_icon_dark"
            });

            PaymentTypesList.Add(new PaymentTypes
            {
                PaymentType = "VISA",
                Icon_Light = "visa_icon_light",
                Icon_Dark = "visa_icon_dark"
            });

            // Builds the expiration month list
            for (int i = 1; i <= 12; i++)
            {
                string month;
                if (i < 10)
                    month = $"0{i}";
                else
                    month = i.ToString();

                DateInformation dateInformation = new()
                {
                    Days = string.Empty,
                    Months = month,
                    Years = string.Empty
                };
                ExpirationMonths.Add(dateInformation);
            }

            // Builds the expiration year list
            DateTime year = DateTime.Now;
            for (int i = 0; i < 5; i++)
            {
                DateInformation dateInformation = new()
                {
                    Days = string.Empty,
                    Months = string.Empty,
                    Years = year.Year.ToString()
                };
                ExpirationYears.Add(dateInformation);
                year = year.AddYears(1);
            }
        }  
    }
}

