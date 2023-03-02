namespace Human_resources
{
    partial class AddEditEmployee
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbDateStart = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntConfirm = new System.Windows.Forms.Button();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.lbDateFinish = new System.Windows.Forms.Label();
            this.cmbHired = new System.Windows.Forms.ComboBox();
            this.lbHired = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 20);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(79, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID pracownika:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 46);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(29, 13);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "Imię:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(113, 13);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(218, 20);
            this.tbID.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(113, 39);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(218, 20);
            this.tbFirstName.TabIndex = 5;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(113, 65);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(218, 20);
            this.tbLastName.TabIndex = 7;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 72);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(56, 13);
            this.lbLastName.TabIndex = 6;
            this.lbLastName.Text = "Nazwisko:";
            // 
            // lbDateStart
            // 
            this.lbDateStart.AutoSize = true;
            this.lbDateStart.Location = new System.Drawing.Point(12, 152);
            this.lbDateStart.Name = "lbDateStart";
            this.lbDateStart.Size = new System.Drawing.Size(93, 13);
            this.lbDateStart.TabIndex = 10;
            this.lbDateStart.Text = "Data rozpoczęcia:";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(12, 99);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(35, 13);
            this.lbDepartment.TabIndex = 8;
            this.lbDepartment.Text = "Dział:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 126);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(65, 13);
            this.lbTitle.TabIndex = 19;
            this.lbTitle.Text = "Stanowisko:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(113, 146);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(218, 20);
            this.dtpStart.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntConfirm
            // 
            this.bntConfirm.Location = new System.Drawing.Point(175, 225);
            this.bntConfirm.Name = "bntConfirm";
            this.bntConfirm.Size = new System.Drawing.Size(75, 23);
            this.bntConfirm.TabIndex = 23;
            this.bntConfirm.Text = "Potwierdź";
            this.bntConfirm.UseVisualStyleBackColor = true;
            this.bntConfirm.Click += new System.EventHandler(this.bntConfirm_Click);
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(113, 199);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(218, 20);
            this.dtpFinish.TabIndex = 26;
            // 
            // lbDateFinish
            // 
            this.lbDateFinish.AutoSize = true;
            this.lbDateFinish.Location = new System.Drawing.Point(12, 206);
            this.lbDateFinish.Name = "lbDateFinish";
            this.lbDateFinish.Size = new System.Drawing.Size(96, 13);
            this.lbDateFinish.TabIndex = 27;
            this.lbDateFinish.Text = "Data zakończenia:";
            // 
            // cmbHired
            // 
            this.cmbHired.FormattingEnabled = true;
            this.cmbHired.Location = new System.Drawing.Point(113, 172);
            this.cmbHired.Name = "cmbHired";
            this.cmbHired.Size = new System.Drawing.Size(218, 21);
            this.cmbHired.TabIndex = 29;
            // 
            // lbHired
            // 
            this.lbHired.AutoSize = true;
            this.lbHired.Location = new System.Drawing.Point(12, 180);
            this.lbHired.Name = "lbHired";
            this.lbHired.Size = new System.Drawing.Size(66, 13);
            this.lbHired.TabIndex = 28;
            this.lbHired.Text = "Zatrudniony:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(113, 117);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(218, 20);
            this.tbTitle.TabIndex = 31;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(113, 91);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(218, 20);
            this.tbDepartment.TabIndex = 30;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 260);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.cmbHired);
            this.Controls.Add(this.lbHired);
            this.Controls.Add(this.lbDateFinish);
            this.Controls.Add(this.dtpFinish);
            this.Controls.Add(this.bntConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbDateStart);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbID);
            this.MaximumSize = new System.Drawing.Size(359, 299);
            this.MinimumSize = new System.Drawing.Size(359, 299);
            this.Name = "AddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowego pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbDateStart;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntConfirm;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Label lbDateFinish;
        private System.Windows.Forms.ComboBox cmbHired;
        private System.Windows.Forms.Label lbHired;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDepartment;
    }
}