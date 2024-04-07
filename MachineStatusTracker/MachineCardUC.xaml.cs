using System;
using System.Windows;
using System.Windows.Controls;

namespace MachineStatusTracker
{
    public partial class MachineCardUC : UserControl
    {
        string StatusIcon;
        public MachineCardUC(Machine machineCard)
        {
            InitializeComponent();
            DataContext = machineCard;
        }

        public event EventHandler<MachineEventArgs> MachineEdit;
        public event EventHandler<MachineEventArgs> MachineDelete;

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var machine = (sender as FrameworkElement)?.DataContext as Machine;
            if (machine != null)
            {
                var editEventArgs = new MachineEventArgs(machine.MachineName, machine.Description, machine.Status, machine.Notes);
                MachineEdit(this, editEventArgs);
                machine.MachineName = editEventArgs.MachineName;
                machine.Description = editEventArgs.Description;
                machine.Status = editEventArgs.Status;
                machine.Notes = editEventArgs.Notes;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var machine = (sender as FrameworkElement)?.DataContext as Machine;
            if (machine != null)
            {
                var DeleteEventArgs = new MachineEventArgs(machine.MachineName, machine.Description, machine.Status, machine.Notes);

                MachineDelete(this, DeleteEventArgs);

            }
        }
    }
}
