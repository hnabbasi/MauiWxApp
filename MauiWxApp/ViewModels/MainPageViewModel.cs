using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiWxApp.Models;
using MauiWxApp.Services;

namespace MauiWxApp.ViewModels
{
	public class MainPageViewModel : BaseViewModel
	{
        private readonly IAlertService _alertService;

        public ICommand GetAlertsCommand { get; }

        private string _stateCode;
        public string StateCode
        {
            get => _stateCode;
            set => SetProperty(ref _stateCode, value);
        }

        private string _alertsCount;
        public string AlertsCount
        {
            get => _alertsCount;
            set => SetProperty(ref _alertsCount, value);
        }

        public ObservableCollection<Alert> Alerts { get; } = new();

        public MainPageViewModel(IAlertService alertService)
        {
            Title = "Maui Weather Alerts";
            _alertService = alertService;

            GetAlertsCommand = new Command(OnGetAlertsTapped);
        }

        private async void OnGetAlertsTapped()
        {
            if (Alerts.Count > 0)
                Alerts.Clear();

            var alerts = await _alertService.GetAlerts(StateCode);
            foreach (var alert in alerts)
                Alerts.Add(alert);
            
            AlertsCount = Alerts.Count > 0 ? $"Found {Alerts.Count} active alerts for {StateCode}" : $"No active alerts found for {StateCode}";
        }
    }
}

