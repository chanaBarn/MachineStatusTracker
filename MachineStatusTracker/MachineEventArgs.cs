using System;

namespace MachineStatusTracker
{
    public class MachineEventArgs : EventArgs
    {
        public string MachineName { get;  set; }
        public string Description { get;  set; }
        public MachineStatus Status { get;  set; }
        public string Notes { get;  set; }

        public MachineEventArgs(string name, string description, MachineStatus status, string notes)
        {
            MachineName = name;
            Description = description;
            Status = status;
            Notes = notes;
        }
    }
}
