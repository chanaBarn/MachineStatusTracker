using System;
using System.Windows.Data;
using MaterialDesignThemes.Wpf;

namespace MachineStatusTracker
{
    public class StatusToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null && value is MachineStatus)
            {
                MachineStatus status = (MachineStatus)value;
                switch (status)
                {
                    case MachineStatus.Running:
                        return PackIconKind.PlayCircleOutline;
                    case MachineStatus.Idle:
                        return PackIconKind.PauseCircleOutline;
                    case MachineStatus.Offline:
                        return PackIconKind.StopCircleOutline;
                    default:
                        return PackIconKind.None; // If no matching status, return None icon
                }
            }
            return PackIconKind.None; // Default to None icon if value is null or not of type Status
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
