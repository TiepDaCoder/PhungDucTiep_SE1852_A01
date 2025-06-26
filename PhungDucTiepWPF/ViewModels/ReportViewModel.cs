using System.Collections.ObjectModel;
using System.ComponentModel;
using BusinessObjects;
using Services.Implementation;

public class ReportViewModel : INotifyPropertyChanged
{
    private readonly OrderService _orderService = new();
    public ObservableCollection<OrderReportModel> Reports { get; set; }

    public ReportViewModel()
    {
        Reports = new ObservableCollection<OrderReportModel>(_orderService.GetReportByMonth());
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}