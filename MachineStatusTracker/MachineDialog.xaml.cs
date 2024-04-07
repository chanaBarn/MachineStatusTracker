using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Xml.Linq;

namespace MachineStatusTracker
{
    // EventArgs class for machine-related events
    public partial class MachineDialog : Window
    {
        public string MachineName { get; set; }
        public string Description { get; set; }
        public MachineStatus Status { get; set; }
        public string Notes { get; set; }

        // Collection for machine status values
        public ObservableCollection<MachineStatus> StatusValues { get; set; }

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

        // Event handler for Save button click
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    if (cmbStatus.SelectedIndex != -1)
                    {
                        MachineName = txtName.Text;
                        Description = txtDescription.Text;
                        Status = (MachineStatus)cmbStatus.SelectedIndex;
                        Notes = txtNotes.Text;

                        DialogResult = true; 
                    }
                    else
                    {
                        MessageHelper.ShowErrorMessage("Status must be valid.");
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

        // Event handler for Cancel button click
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; 
            MessageHelper.ShowInformationMessage("Operation canceled.");
        }
    }
}
