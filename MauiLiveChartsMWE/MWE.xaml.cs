using MauiLiveChartsMWE.Views;

namespace MauiLiveChartsMWE
{
    public partial class MWE : ContentPage
    {
        public class ChartList
        {
            public Graph[] Charts { get; set; } = [];
        }

        public MWE()
        {
            InitializeComponent();

            ChartList chartList = new()
            {
                Charts = [new Graph(), new Graph(), new Graph()],
            };
            BindingContext = chartList;
        }
    }
}
