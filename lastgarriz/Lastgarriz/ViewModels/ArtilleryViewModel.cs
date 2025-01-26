using Run.Models;
using Run.Util;
using Run.ViewModels.Command;

namespace Run.ViewModels
{
    public sealed class ArtilleryViewModel : BaseViewModel
    {
        internal ArtiMetrics Metrics { get; set; }

        private string title = string.Empty;
        private int milliradian;
        private int meter;

        public string Title { get => title; set => SetProperty(ref title, value); }
        public int Milliradian { get => milliradian; set => SetProperty(ref milliradian, value); }
        public int Meter { get => meter; set => SetProperty(ref meter, value); }

        public ArtilleryCommand Commands { get; private set; }

        public ArtilleryViewModel(int metricsType)
        {
            Commands = new(this);
            Metrics = new(metricsType);
            Title = metricsType switch
            {
                1 => "RU metric converter",
                2 => "UK metric converter",
                _ => "US/GER metric converter"
            };

            TaskManager.StartKeystrokeCatcherTask(this);
        }
    }
}
