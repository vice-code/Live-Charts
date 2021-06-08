using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Windows;

namespace Wpf_Net5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CartesianMapper<DateModel> dayConfig = Mappers.Xy<DateModel>()
              .X(dateModel => (double)dateModel.DateTime.Ticks / TimeSpan.FromDays(1).Ticks)
              .Y(dateModel => dateModel.Value);

            DateTime now = DateTime.Now;

            SeriesCollection series = new(dayConfig)
            {
                new LineSeries
                {
                    Title = "Line 1",

                    Values = new ChartValues<DateModel>
                    {
                        new DateModel
                        {
                            DateTime = now,
                            Value = 5
                        },
                        new DateModel
                        {
                            DateTime = now.AddDays(1),
                            Value = 9
                        },
                        new DateModel
                        {
                            DateTime = now.AddDays(2),
                            Value = 4
                        }
                    },
                },

                new LineSeries
                {
                    Title = "Line 2",

                    Values = new ChartValues<DateModel>
                    {
                        new DateModel
                        {
                            DateTime = now.AddHours(12),
                            Value = 8
                        },
                        new DateModel
                        {
                            DateTime = now.AddHours(36),
                            Value = 5
                        },
                        new DateModel
                        {
                            DateTime = now.AddHours(60),
                            Value = 10
                        }
                    }
                },
            };

            Formatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks)).ToString("HH:mm");
            Series = series;

            DataContext = this;
        }

        public SeriesCollection Series { get; set; } = new();

        public Func<double, string> Formatter { get; set; }

        public class DateModel
        {
            public DateTime DateTime { get; set; }
            public double Value { get; set; }
        }
    }
}
