namespace Astronomer
{
    public partial class Form1 : Form
    {

        private System.ComponentModel.BindingList<CelestialBody> bodies = new System.ComponentModel.BindingList<CelestialBody>();

        public Form1()
        {
            InitializeComponent();


            dgvAstronomy.DataSource = bodies;


            if (dgvAstronomy.Columns["Name"] != null)
                dgvAstronomy.Columns["Name"].HeaderText = "Назва об'єкта";

            if (dgvAstronomy.Columns["Type"] != null)
                dgvAstronomy.Columns["Type"].HeaderText = "Тип тіла";

            if (dgvAstronomy.Columns["Distance"] != null)
                dgvAstronomy.Columns["Distance"].HeaderText = "Відстань (св. р.)";

            if (dgvAstronomy.Columns["Magnitude"] != null)
                dgvAstronomy.Columns["Magnitude"].HeaderText = "Яскравість (m)";


            dgvAstronomy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            bodies.Add(new CelestialBody("Полярна зоря", "Зірка", 433.0, 1.97));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBodyForm addForm = new AddBodyForm();


            if (addForm.ShowDialog() == DialogResult.OK)
            {

                bodies.Add(addForm.NewBody);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAstronomy.CurrentRow != null)
            {

                var body = (CelestialBody)dgvAstronomy.CurrentRow.DataBoundItem;
                string name = body.Name;


                DialogResult result = MessageBox.Show(
                    $"Ви впевнені, що хочете видалити об'єкт '{name}'?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    bodies.Remove(body);
                }
            }
            else
            {

                MessageBox.Show("Будь ласка, спочатку виберіть об'єкт у таблиці!", "Помилка");
            }
        }

       
            private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAstronomy.CurrentRow != null)
            {
                
                var body = (CelestialBody)dgvAstronomy.CurrentRow.DataBoundItem;

                AddBodyForm editForm = new AddBodyForm();

                
                editForm.EditBody(body);

               
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    
                    body.Name = editForm.NewBody.Name;
                    body.Type = editForm.NewBody.Type;
                    body.Distance = editForm.NewBody.Distance;
                    body.Magnitude = editForm.NewBody.Magnitude;

                    
                    bodies.ResetBindings();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть об'єкт для редагування!");
            }
        }
    }
}
