using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Linq;
namespace Astronomer
{
    public partial class Form1 : Form
    {

        private System.ComponentModel.BindingList<CelestialBody> bodies = new System.ComponentModel.BindingList<CelestialBody>();

        public Form1()
        {
            InitializeComponent();


            dgvAstronomy.DataSource = bodies;
            LoadData();

            if (dgvAstronomy.Columns["Name"] != null)
                dgvAstronomy.Columns["Name"].HeaderText = "Назва об'єкта";

            if (dgvAstronomy.Columns["Type"] != null)
                dgvAstronomy.Columns["Type"].HeaderText = "Тип тіла";

            if (dgvAstronomy.Columns["Distance"] != null)
                dgvAstronomy.Columns["Distance"].HeaderText = "Відстань (св. р.)";

            if (dgvAstronomy.Columns["Magnitude"] != null)
                dgvAstronomy.Columns["Magnitude"].HeaderText = "Яскравість (m)";


            dgvAstronomy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBodyForm addForm = new AddBodyForm();


            if (addForm.ShowDialog() == DialogResult.OK)
            {

                bodies.Add(addForm.NewBody);
                SaveData();

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
                    SaveData();
                    txtSearch.Text = "";
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
                    SaveData();
                    txtSearch.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть об'єкт для редагування!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Це каталог космічних об'єктів. Ви можете додавати, редагувати або видаляти записи за допомогою кнопок праворуч.", "Довідка");
            }
        }

        private void SaveData()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(bodies, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("data.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}");
            }
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists("data.json"))
                {
                    string jsonString = File.ReadAllText("data.json");
                    var loaded = JsonSerializer.Deserialize<List<CelestialBody>>(jsonString);
                    if (loaded != null)
                    {
                        bodies.Clear();
                        foreach (var item in loaded) bodies.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні: {ex.Message}");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
      
            string searchText = txtSearch.Text.ToLower();

            var filteredList = bodies.Where(b => b.Name.ToLower().Contains(searchText)).ToList();

            dgvAstronomy.DataSource = new BindingList<CelestialBody>(filteredList);
        }
    }
    
}

