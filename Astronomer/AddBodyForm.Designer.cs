namespace Astronomer
{
    partial class AddBodyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            cmbType = new ComboBox();
            numDistance = new NumericUpDown();
            numMagnitude = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMagnitude).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageIndex = 1;
            label1.Location = new Point(90, 199);
            label1.Name = "label1";
            label1.Size = new Size(121, 39);
            label1.TabIndex = 0;
            label1.Text = "Назва:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.ImageIndex = 2;
            label2.Location = new Point(362, 199);
            label2.Name = "label2";
            label2.Size = new Size(78, 39);
            label2.TabIndex = 1;
            label2.Text = "Тип:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.ImageIndex = 3;
            label3.Location = new Point(595, 199);
            label3.Name = "label3";
            label3.Size = new Size(276, 39);
            label3.TabIndex = 2;
            label3.Text = "Відстань (св. р.):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.ImageIndex = 4;
            label4.Location = new Point(982, 199);
            label4.Name = "label4";
            label4.Size = new Size(258, 39);
            label4.TabIndex = 3;
            label4.Text = "Яскравість (m):";
            // 
            // txtName
            // 
            txtName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.Location = new Point(72, 265);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 37);
            txtName.TabIndex = 0;
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Зірка", "Планета", "Туманність", "Галактика" });
            cmbType.Location = new Point(309, 263);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(182, 38);
            cmbType.TabIndex = 1;
            // 
            // numDistance
            // 
            numDistance.DecimalPlaces = 2;
            numDistance.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numDistance.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numDistance.Location = new Point(634, 263);
            numDistance.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(180, 37);
            numDistance.TabIndex = 2;
            // 
            // numMagnitude
            // 
            numMagnitude.DecimalPlaces = 2;
            numMagnitude.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numMagnitude.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numMagnitude.Location = new Point(1020, 265);
            numMagnitude.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numMagnitude.Name = "numMagnitude";
            numMagnitude.Size = new Size(180, 37);
            numMagnitude.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSpringGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnSave.Location = new Point(908, 511);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 71);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Tomato;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(1137, 511);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 71);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddBodyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1443, 821);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numMagnitude);
            Controls.Add(numDistance);
            Controls.Add(cmbType);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "AddBodyForm";
            Text = "Додати новий об'єкт";
            KeyDown += AddBodyForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMagnitude).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private ComboBox cmbType;
        private NumericUpDown numDistance;
        private NumericUpDown numMagnitude;
        private Button btnSave;
        private Button btnCancel;
    }
}