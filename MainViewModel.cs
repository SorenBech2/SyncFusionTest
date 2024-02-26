using CommunityToolkit.Mvvm.ComponentModel;

namespace SyncFusionTest
{
    public partial class MainViewModel : ObservableObject
    {
        private string? selectedExpirationMonth;
        private string? selectedExpirationYear;

        [ObservableProperty]
        List<PaymentTypes> paymentTypesList = [];
        [ObservableProperty]
        public int expirationMonthsPickerIndex = -1;
        [ObservableProperty]
        public int expirationYearsPickerIndex = -1;

        [ObservableProperty]
        public string? cardHolderName;
        [ObservableProperty]
        public string? cardNumber;
        [ObservableProperty]
        public string? expiryMonth;
        [ObservableProperty]
        public string? expiryYear;
        [ObservableProperty]
        public string? securityCode;

        [ObservableProperty]
        public List<DateInformation> expirationMonths = [];
        [ObservableProperty]
        public List<DateInformation> expirationYears = [];

        public MainViewModel()
        {
            // Builds the expiration month list

            // Builds the expiration year list
            DateTime year = DateTime.Now;
            for (int i = 0; i <= 5; i++)
            {
                DateInformation dateInformation = new () 
                { 
                    Days = string.Empty,
                    Months = string.Empty,
                    Years = year.Year.ToString()
                };
                ExpirationYears.Add(dateInformation);
                year = year.AddYears(1);
            }

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
        }

        public void ExpirationMonthsPickerChanged()
        {
            if (ExpirationMonthsPickerIndex < 0)
                return;

            //selectedExpirationMonth = ExpirationMonths[ExpirationMonthsPickerIndex];
        }

        public void ExpirationYearsPickerChanged()
        {
            if (ExpirationYearsPickerIndex < 0)
                return;

            // = ExpirationYears[ExpirationYearsPickerIndex];
        }   
    }
}

