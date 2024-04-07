using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MachineStatusTracker
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Machine> Machines { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Machines = new ObservableCollection<Machine>() { };
            // Sample machines for testing

            Machines.Add(new Machine("Machine 1", "Description 1", MachineStatus.Idle, "Notes 1"));
            Machines.Add(new Machine("Machine 2", "Description 2", MachineStatus.Offline, "Notes 2"));
            for (int i = 3; i < 15; i++)
            {
                Machines.Add(new Machine("Machine "+i, "Description "+i, MachineStatus.Running, "Notes "+i));

            }
            Machines.Add(new Machine("Machine 15", "Description 15", MachineStatus.Idle, "Notes 15"));
            Machines.Add(new Machine("Machine 16", "Description 16", MachineStatus.Offline, "Notes 16"));

            // Add machines to UI
            foreach (Machine machineCard in Machines)
            {
                AddMachineCard(machineCard);
            }
        }

        private void AddMachineCard(Machine machineCard)
        {
            MachineCardUC machineCardUC = new MachineCardUC(machineCard);
            MachineCards.Children.Add(machineCardUC);

            machineCardUC.MachineEdit += MachineEditHandler;
            machineCardUC.MachineDelete += DeleteMachine_Click;
        }

        private void DeleteMachine_Click(object sender, MachineEventArgs e)
        {
            Machine machineToDelete = Machines.FirstOrDefault(m => m.MachineName == e.MachineName);
            if (machineToDelete != null)
            {
                if (MessageHelper.ShowConfirmationMessage($"Are you sure you want to delete {machineToDelete.MachineName}?"))
                {
                    Machines.Remove(machineToDelete);
                    MachineCards.Children.Remove(MachineCards.Children.OfType<MachineCardUC>().FirstOrDefault(card => card.DataContext == machineToDelete));
                    MessageHelper.ShowSuccessMessage("Machine deleted successfully.");
                }
            }
        }

        private void AddMachine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var addDialog = new MachineDialog();
                if (addDialog.ShowDialog() == true)
                {
                    var newMachine = new Machine(addDialog.MachineName, addDialog.Description, addDialog.Status, addDialog.Notes);

                        Machines.Add(newMachine);
                        AddMachineCard(newMachine);
                        MessageHelper.ShowSuccessMessage("Machine added successfully.");
                    
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage("An error occurred: " + ex.Message);
            }
        }

        private void MachineEditHandler(object sender, MachineEventArgs e)
        {
            
                var editDialog = new MachineDialog(e.MachineName, e.Description, e.Status, e.Notes);
                if (editDialog.ShowDialog() == true)
                {
                    e.MachineName = editDialog.MachineName;
                    e.Description = editDialog.Description;
                    e.Status = editDialog.Status;
                    e.Notes = editDialog.Notes;
                    MessageHelper.ShowSuccessMessage("Machine updated successfully.");
                }
           
        }

        private void cmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterMachines();
            //MessageHelper.ShowInformationMessage("Machines filtered successfully.");
        }

        private void FilterMachines()
        {
            string selectedStatus = (cmbStatus.SelectedItem as ComboBoxItem)?.Content as string;

            if (selectedStatus == "All")
            {
                // Show all machines
                foreach (MachineCardUC machineCard in MachineCards.Children)
                {
                    machineCard.Visibility = Visibility.Visible;
                }
            }
            else
            {
                // Filter machines based on status
                foreach (MachineCardUC machineCard in MachineCards.Children)
                {
                    Machine machine = machineCard.DataContext as Machine;
                    if (machine.Status.ToString() == selectedStatus)
                    {
                        machineCard.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        machineCard.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }

    }
}
