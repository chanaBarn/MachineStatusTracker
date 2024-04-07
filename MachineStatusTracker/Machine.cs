using System.ComponentModel;
using System.Windows;

namespace MachineStatusTracker
{
    public enum MachineStatus
    {
        Running,
        Idle,
        Offline
    }

    public class Machine : INotifyPropertyChanged
    {
        private string _name;
        private string _description;
        private MachineStatus _status;
        private string _notes;

        public string MachineName
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(MachineName)); }
        }
       
        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(nameof(Description)); }
        }
        public MachineStatus Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
                OnPropertyChanged(nameof(StatusIcon));
            }
        }

        public string StatusIcon
        {
            get
            {
                switch (Status)
                {
                    case MachineStatus.Running:
                        return "Icons/run.png"; 
                    case MachineStatus.Idle:
                        return "Icons/run.png";
                    case MachineStatus.Offline:
                        return "Icons/run.png";
                    default:
                        return "";
                }
            }
        }

      

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; OnPropertyChanged(nameof(Notes)); }
        }

        public Machine(string name, string description, MachineStatus status, string notes)
        {
            MachineName = name;
            Description = description;
            Status = status;
            Notes = notes;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
