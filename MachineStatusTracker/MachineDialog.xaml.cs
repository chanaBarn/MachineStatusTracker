using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Xml.Linq;

namespace MachineStatusTracker
{
    public partial class MachineDialog : Window
    {
        public string MachineName { get; set; }
        public string Description { get; set; }
        public MachineStatus Status { get; set; }
        public string Notes { get; set; }

        public ObservableCollection<MachineStatus> StatusValues { get; set; }
        //private ObservableCollection<Machine> filteredMachines;

        public MachineDialog()
        {
            InitializeComponent();
        }
        public MachineDialog(string name, string description, MachineStatus status, string notes)
        {
            InitializeComponent();
            DataContext = this;

            MachineName = name;
            Description = description;
            Status = status;
            Notes = notes;
            StatusValues = new ObservableCollection<MachineStatus>
            {
                MachineStatus.Running,
                MachineStatus.Idle,
                MachineStatus.Offline
            };
            cmbStatus.SelectedIndex = (int)status;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) )
                {
                    if (cmbStatus.SelectedIndex != -1)
                    {
                        MachineName = txtName.Text;
                        Description = txtDescription.Text;
                        Status = (MachineStatus)cmbStatus.SelectedIndex;
                        Notes = txtNotes.Text;

                        DialogResult = true; // Save changes and close the dialog
                    }
                    else
                    {
                        MessageHelper.ShowErrorMessage("status must be valid.");

                    }
                }
                else
                {
                    MessageHelper.ShowErrorMessage("Machine name is required.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage("An error occurred: " + ex.Message);
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Cancel the operation and close the dialog
            MessageHelper.ShowInformationMessage("Operation canceled.");
        }
    }
}
