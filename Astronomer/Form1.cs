using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Linq;
namespace Astronomer
{
    // Головне вікно програми для керування каталогом та відображення бази даних
    public partial class MainForm : Form
    {

        private System.ComponentModel.BindingList<CelestialBody> bodies = new System.ComponentModel.BindingList<CelestialBody>();

        public MainForm()
        {
            InitializeComponent();

            dgvAstronomy.AllowUserToAddRows = false;
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

            if (dgvAstronomy.Columns["Constellation"] != null)
                dgvAstronomy.Columns["Constellation"].HeaderText = "Сузір'я";

            if (dgvAstronomy.Columns["RightAscension"] != null)
                dgvAstronomy.Columns["RightAscension"].HeaderText = "Пряме сходження";

            if (dgvAstronomy.Columns["Declination"] != null)
                dgvAstronomy.Columns["Declination"].HeaderText = "Схилення";


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
                    body.Constellation = editForm.NewBody.Constellation;
                    body.RightAscension = editForm.NewBody.RightAscension;
                    body.Declination = editForm.NewBody.Declination;


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
                string helpText = "--- ДОВІДКА: КАТАЛОГ КОСМІЧНИХ ОБ'ЄКТІВ ---\n\n" +
                                  "1. Керування: Кнопки праворуч дозволяють додавати, редагувати та видаляти об'єкти.\n" +
                                  "2. Сортування: Натисніть на заголовок будь-якої колонки, щоб відсортувати базу за цим параметром.\n" +
                                  "3. Пошук: Введіть назву або сузір'я у поле пошуку для миттєвої фільтрації.\n" +
                                  "4. Аналітика: Кнопка 'Статистика' покаже розподіл об'єктів по півкулях неба та типах.\n" +
                                  "5. Збереження: Всі дані автоматично зберігаються у файл data.json.";

                MessageBox.Show(helpText, "Інструкція користувача");
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

        // Завантаження даних із JSON-файлу при старті програми
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


            var filteredList = bodies.Where(b =>
                b.Name.ToLower().Contains(searchText) ||
                (b.Constellation != null && b.Constellation.ToLower().Contains(searchText))
            ).ToList();

            dgvAstronomy.DataSource = new BindingList<CelestialBody>(filteredList);
        }

        // Розрахунок розширеної статистики по об'єктах бази
        private void btnStats_Click(object sender, EventArgs e)
        {

            if (bodies.Count == 0)
            {
                MessageBox.Show("Каталог порожній. Додайте об'єкти для розрахунку статистики.", "Інформація");
                return;
            }

            
            int total = bodies.Count;
            int uniqueConstellations = bodies.Select(b => b.Constellation).Distinct().Count();

            
            var brightest = bodies.OrderBy(b => b.Magnitude).First();
            var farthest = bodies.OrderByDescending(b => b.Distance).First();
            double avgDist = bodies.Average(b => b.Distance);

            
            int northernSky = bodies.Count(b => b.Declination.Trim().StartsWith("+"));
            int southernSky = bodies.Count(b => b.Declination.Trim().StartsWith("-"));

            
            var typeGroups = bodies.GroupBy(b => b.Type)
                                   .Select(g => $"{g.Key}: {g.Count()}")
                                   .ToList();
            string typesSummary = string.Join(", ", typeGroups);

            
            string report = $"--- РОЗШИРЕНИЙ АНАЛІТИЧНИЙ ЗВІТ ---\n\n" +
                            $"Загальна кількість: {total} об'єктів\n" +
                            $"Розподіл за типами: {typesSummary}\n" +
                            $"Географія: {uniqueConstellations} унікальних сузір'їв\n\n" +
                            $"--- ЕКСТРЕМУМИ ---\n" +
                            $"Найяскравіший: {brightest.Name} (m = {brightest.Magnitude})\n" +
                            $"Найвіддаленіший: {farthest.Name} ({farthest.Distance:N0} св. р.)\n" +
                            $"Середня відстань у базі: {avgDist:F2} св. р.\n\n" +
                            $"--- СФЕРИЧНІ КООРДИНАТИ ---\n" +
                            $"Північна півкуля неба (+): {northernSky}\n" +
                            $"Південна півкуля неба (-): {southernSky}\n" +
                            $"(інші: {total - northernSky - southernSky} — екватор або не вказано)";

        MessageBox.Show(report, "Аналітичний звіт");
        }

        // Універсальне сортування об'єктів при натисканні на заголовок колонки
        private void dgvAstronomy_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string propName = dgvAstronomy.Columns[e.ColumnIndex].DataPropertyName;
            if (string.IsNullOrEmpty(propName)) return;

            
            var sorted = bodies.OrderBy(x => x.GetType().GetProperty(propName).GetValue(x, null)).ToList();

            bodies.Clear();
            foreach (var b in sorted) bodies.Add(b);
        }
    

     }

}

