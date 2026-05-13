namespace Astronomer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAstronomy = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Distance = new DataGridViewTextBoxColumn();
            Magnitude = new DataGridViewTextBoxColumn();
            colConstellation = new DataGridViewTextBoxColumn();
            colRA = new DataGridViewTextBoxColumn();
            colDec = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            btnStats = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAstronomy).BeginInit();
            SuspendLayout();
            // 
            // dgvAstronomy
            // 
            dgvAstronomy.AllowUserToAddRows = false;
            dgvAstronomy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAstronomy.BackgroundColor = Color.DarkSlateBlue;
            dgvAstronomy.BorderStyle = BorderStyle.None;
            dgvAstronomy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAstronomy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAstronomy.Columns.AddRange(new DataGridViewColumn[] { Name, Type, Distance, Magnitude, colConstellation, colRA, colDec });
            dgvAstronomy.EnableHeadersVisualStyles = false;
            dgvAstronomy.GridColor = SystemColors.GrayText;
            dgvAstronomy.Location = new Point(35, 129);
            dgvAstronomy.Name = "dgvAstronomy";
            dgvAstronomy.RowHeadersWidth = 62;
            dgvAstronomy.Size = new Size(1120, 668);
            dgvAstronomy.TabIndex = 0;
            dgvAstronomy.ColumnHeaderMouseClick += dgvAstronomy_ColumnHeaderMouseClick;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Назва об'єкта";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Тип тіла";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            Type.Width = 150;
            // 
            // Distance
            // 
            Distance.DataPropertyName = "Distance";
            Distance.HeaderText = "Відстань (св. р.)";
            Distance.MinimumWidth = 8;
            Distance.Name = "Distance";
            Distance.Width = 150;
            // 
            // Magnitude
            // 
            Magnitude.DataPropertyName = "Magnitude";
            Magnitude.HeaderText = "Яскравість (m)";
            Magnitude.MinimumWidth = 8;
            Magnitude.Name = "Magnitude";
            Magnitude.Width = 150;
            // 
            // colConstellation
            // 
            colConstellation.DataPropertyName = "Constellation";
            colConstellation.HeaderText = "Сузір'я";
            colConstellation.MinimumWidth = 8;
            colConstellation.Name = "colConstellation";
            colConstellation.Width = 150;
            // 
            // colRA
            // 
            colRA.DataPropertyName = "RightAscension";
            colRA.HeaderText = "Пряме сходження (RA)";
            colRA.MinimumWidth = 8;
            colRA.Name = "colRA";
            colRA.Width = 150;
            // 
            // colDec
            // 
            colDec.DataPropertyName = "Declination";
            colDec.HeaderText = "Схилення (Dec)";
            colDec.MinimumWidth = 8;
            colDec.Name = "colDec";
            colDec.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSpringGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(1201, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(193, 80);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати об'єкт";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Aqua;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEdit.Location = new Point(1201, 402);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(193, 80);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.Location = new Point(1201, 574);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(193, 80);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(410, 43);
            label1.TabIndex = 4;
            label1.Text = "КОСМІЧНИЙ КАТАЛОГ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(35, 81);
            label2.Name = "label2";
            label2.Size = new Size(227, 30);
            label2.TabIndex = 5;
            label2.Text = "Пошук за назвою:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(268, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 32);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnStats
            // 
            btnStats.BackColor = Color.Gold;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnStats.Location = new Point(981, 56);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(165, 57);
            btnStats.TabIndex = 7;
            btnStats.Text = "Статистика";
            btnStats.UseVisualStyleBackColor = false;
            btnStats.Click += btnStats_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1443, 821);
            Controls.Add(btnStats);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvAstronomy);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Text = "Довідник астронома";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvAstronomy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAstronomy;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Button btnStats;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Distance;
        private DataGridViewTextBoxColumn Magnitude;
        private DataGridViewTextBoxColumn colConstellation;
        private DataGridViewTextBoxColumn colRA;
        private DataGridViewTextBoxColumn colDec;
    }
}
