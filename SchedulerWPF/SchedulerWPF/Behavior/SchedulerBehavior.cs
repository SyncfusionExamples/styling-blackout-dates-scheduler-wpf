using System;
using System.Collections.ObjectModel;
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        ObservableCollection<DateTime> blackOutDates = new ObservableCollection<DateTime>();
        protected override void OnAttached()
        {
            this.AssociatedObject.ViewChanged += AssociatedObject_ViewChanged;
        }
        private void AssociatedObject_ViewChanged(object sender, ViewChangedEventArgs e)
        {
            blackOutDates.Clear();
            for (int i = -2; i < 3; i++)
            {
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(2));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(3));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(4));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(5));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(6));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(7));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(8));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(9));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(10));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(11));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(12));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(13));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(14));
                blackOutDates.Add(DateTime.Now.Date.AddMonths(i).AddDays(15));

            }

            this.AssociatedObject.MonthViewSettings.BlackoutDates = blackOutDates;
        }
        protected override void OnDetaching()
        {
            this.AssociatedObject.ViewChanged -= AssociatedObject_ViewChanged;
            if (blackOutDates != null)
                blackOutDates = null;
        }
    }
}

