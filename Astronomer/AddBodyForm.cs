using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Astronomer
{
    // Форма для введення та редагування даних космічних об'єктів з перевіркою на коректність
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
            txtConstellation.Text = body.Constellation; 
            txtRA.Text = body.RightAscension;           
            txtDec.Text = body.Declination;
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

        // Обробка збереження даних з перевіркою валідації (порожні поля, формати координат)
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

                if (string.IsNullOrWhiteSpace(txtConstellation.Text))
                {
                    MessageBox.Show("Кожне небесне тіло належить до якогось сузір'я. Будь ласка, вкажіть його!", "Валідація");
                    return;
                }

       
                if (txtConstellation.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Назва сузір'я не може містити цифри!", "Помилка формату");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtRA.Text) || string.IsNullOrWhiteSpace(txtDec.Text))
                {
                    MessageBox.Show("Введіть координати об'єкта (RA та Dec)!", "Валідація");
                    return;
                }

                if (txtRA.Text.Length < 3 || txtDec.Text.Length < 3)
                {
                    MessageBox.Show("Будь ласка, вкажіть координати у більш повному форматі!", "Помилка");
                    return;
                }

                if (txtRA.Text.Length > 15 || txtDec.Text.Length > 15)
                {
                    MessageBox.Show("Координати занадто довгі. Використовуйте стандартний формат (напр. 06год 45хв 39с або -16° 22' 08'' ) .", "Помилка");
                    return;
                }

                if(!txtRA.Text.Any(char.IsDigit) || !txtDec.Text.Any(char.IsDigit))
{
                    MessageBox.Show("Координати обов'язково повинні містити цифри!", "Помилка формату");
                    return;
                }

                NewBody = new CelestialBody(
                txtName.Text,
                cmbType.SelectedItem.ToString(),
                (double)numDistance.Value,
                (double)numMagnitude.Value,
                txtConstellation.Text, 
                txtRA.Text,            
                txtDec.Text            
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

        // Відображення контекстної довідки за натисканням клавіші F1  
        private void AddBodyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string helpText = "--- ПІДКАЗКИ ПО ЗАПОВНЕННЮ ПОЛІВ ---\n\n" +
                                  "• НАЗВА: Текст (напр. Сіріус). Обов'язкове поле.\n\n" +
                                  "• ТИП: Виберіть категорію зі списку (Зірка, Планета тощо).\n\n" +
                                  "• ВІДСТАНЬ: Число у світлових роках. Для дробів пишіть КОМУ (напр. 8,6).\n\n" +
                                  "• ЯСКРАВІСТЬ: Видима зоряна величина (m). Можна з мінусом (напр. -1,46).\n\n" +
                                  "• СУЗІР'Я: Назва без цифр (напр. Оріон). Обов'язкове поле.\n\n" +
                                  "• ПРЯМЕ СХОДЖЕННЯ (RA): Формат 'год хв с' (напр. 06г 45х 08с).\n\n" +
                                  "• СХИЛЕННЯ (Dec): Обов'язково знак + або - та градуси (напр. -16° 42' 56'').";

                MessageBox.Show(helpText, "Детальна довідка");
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
