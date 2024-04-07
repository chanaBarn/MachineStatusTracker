using System;
using System.Windows;
using System.Windows.Controls;

namespace MachineStatusTracker
{
    /// User Control for displaying machine details.
    public partial class MachineCardUC : UserControl
    {
        public MachineCardUC(Machine machineCard)
        {
            InitializeComponent();
            DataContext = machineCard;
        }
        /// Event raised when a machine is edited.
        public event EventHandler<MachineEventArgs> MachineEdit;
        /// Event raised when a machine is deleted.
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
        /// Handles the click event for deleting a machine.
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
