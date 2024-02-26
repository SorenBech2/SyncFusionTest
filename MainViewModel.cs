using CommunityToolkit.Mvvm.ComponentModel;

namespace SyncFusionTest
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        List<PaymentTypes> paymentTypesList = [];
        [ObservableProperty]
        public string? cardHolderName;
        [ObservableProperty]
        public string? cardNumber;

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
        }  
    }
}

