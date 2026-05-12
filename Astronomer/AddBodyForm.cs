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
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }


        public void EditBody(CelestialBody body)
        {
            this.Text = "Редагування об'єкта";

            txtName.Text = body.Name;
            cmbType.Text = body.Type;
            numDistance.Value = (decimal)body.Distance;
            numMagnitude.Value = (decimal)body.Magnitude;
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

            try
            {

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Назва об'єкта не може бути порожньою!", "Помилка валідації");
                    return;
                }

                if (double.TryParse(txtName.Text, out _))
                {
                    MessageBox.Show("Назва не може складатися лише з цифр!", "Помилка валідації");
                    return;
                }

                if (cmbType.SelectedIndex == -1)
                {
                    MessageBox.Show("Будь ласка, оберіть тип космічного об'єкта!", "Помилка валідації");
                    return;
                }

                if (numDistance.Value <= 0 || numMagnitude.Value < -30)
                {
                    MessageBox.Show("Введено некоректні фізичні параметри!", "Помилка даних");
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
            catch (Exception ex)
            {

                MessageBox.Show($"Виникла непередбачувана помилка: {ex.Message}", "Критична помилка");
                return;
            }
        }

        private void AddBodyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Заповніть всі поля для створення або редагування об'єкта. Відстань вказується в світлових роках.", "Довідка");
            }
        }
    }
}
