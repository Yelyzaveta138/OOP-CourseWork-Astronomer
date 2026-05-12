namespace Astronomer
{
    partial class Form1
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAstronomy).BeginInit();
            SuspendLayout();
            // 
            // dgvAstronomy
            // 
            dgvAstronomy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAstronomy.BackgroundColor = Color.DarkSlateBlue;
            dgvAstronomy.BorderStyle = BorderStyle.None;
            dgvAstronomy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAstronomy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAstronomy.EnableHeadersVisualStyles = false;
            dgvAstronomy.GridColor = SystemColors.GrayText;
            dgvAstronomy.Location = new Point(46, 89);
            dgvAstronomy.Name = "dgvAstronomy";
            dgvAstronomy.RowHeadersWidth = 62;
            dgvAstronomy.Size = new Size(796, 668);
            dgvAstronomy.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSpringGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(1083, 206);
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
            btnEdit.Location = new Point(1083, 377);
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
            btnDelete.Location = new Point(1083, 549);
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
            label1.Location = new Point(46, 23);
            label1.Name = "label1";
            label1.Size = new Size(410, 43);
            label1.TabIndex = 4;
            label1.Text = "КОСМІЧНИЙ КАТАЛОГ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1443, 821);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvAstronomy);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Довідник астронома";
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
    }
}
