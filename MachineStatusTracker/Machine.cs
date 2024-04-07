using System.ComponentModel;
using System.Windows;

namespace MachineStatusTracker
{
    // Enum for machine status
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
