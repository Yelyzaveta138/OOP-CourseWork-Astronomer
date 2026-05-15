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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtConstellation = new TextBox();
            txtRA = new TextBox();
            txtDec = new TextBox();
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
            label3.Location = new Point(619, 199);
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
            label4.Location = new Point(1020, 199);
            label4.Name = "label4";
            label4.Size = new Size(258, 39);
            label4.TabIndex = 3;
            label4.Text = "Яскравість (m):";
            // 
            // txtName
            // 
            txtName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.Location = new Point(72, 265);
            txtName.MaxLength = 1000;
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
            numDistance.Location = new Point(658, 263);
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
            numMagnitude.Location = new Point(1058, 265);
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
            btnSave.Location = new Point(958, 610);
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
            btnCancel.Location = new Point(1187, 610);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 71);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(333, 379);
            label5.Name = "label5";
            label5.Size = new Size(132, 39);
            label5.TabIndex = 6;
            label5.Text = "Сузір'я:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(1001, 379);
            label6.Name = "label6";
            label6.Size = new Size(374, 39);
            label6.TabIndex = 7;
            label6.Text = "Схилення (гр мін сек):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(514, 379);
            label7.Name = "label7";
            label7.Size = new Size(469, 39);
            label7.TabIndex = 8;
            label7.Text = "Пряме сходження (год хв с):";
            // 
            // txtConstellation
            // 
            txtConstellation.Font = new Font("Century Gothic", 12F);
            txtConstellation.Location = new Point(311, 441);
            txtConstellation.MaxLength = 1000;
            txtConstellation.Name = "txtConstellation";
            txtConstellation.Size = new Size(180, 37);
            txtConstellation.TabIndex = 9;
            // 
            // txtRA
            // 
            txtRA.Font = new Font("Century Gothic", 12F);
            txtRA.Location = new Point(658, 441);
            txtRA.MaxLength = 10000;
            txtRA.Name = "txtRA";
            txtRA.Size = new Size(180, 37);
            txtRA.TabIndex = 10;
            // 
            // txtDec
            // 
            txtDec.Font = new Font("Century Gothic", 12F);
            txtDec.Location = new Point(1098, 441);
            txtDec.MaxLength = 10000;
            txtDec.Name = "txtDec";
            txtDec.Size = new Size(180, 37);
            txtDec.TabIndex = 11;
            txtDec.TextChanged += textBox3_TextChanged;
            // 
            // AddBodyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1443, 821);
            Controls.Add(txtDec);
            Controls.Add(txtRA);
            Controls.Add(txtConstellation);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
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
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtConstellation;
        private TextBox txtRA;
        private TextBox txtDec;
    }
}