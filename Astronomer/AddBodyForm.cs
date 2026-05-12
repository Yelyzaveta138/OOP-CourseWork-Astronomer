using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Astronomer
{
    public partial class AddBodyForm : Form
    {
        public CelestialBody? NewBody { get; private set; }
        public AddBodyForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву об'єкта!");
                return;
            }

            
            NewBody = new CelestialBody(
                txtName.Text,
                cmbType.Text,
                (double)numDistance.Value,
                (double)numMagnitude.Value
            );

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        
    }
    }
}
