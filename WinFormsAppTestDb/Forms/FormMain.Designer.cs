namespace WinFormsAppTestDb.Forms
{
    partial class FormMain
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
            this.dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.buttonLoadWorkers = new System.Windows.Forms.Button();
            this.buttonDeleteSelectedWorker = new System.Windows.Forms.Button();
            this.textBoxWorkerName = new System.Windows.Forms.TextBox();
            this.textBoxWokerExperience = new System.Windows.Forms.TextBox();
            this.buttonAddNewWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdateWorker = new System.Windows.Forms.Button();
            this.textBoxWorkerExperience = new System.Windows.Forms.TextBox();
            this.textBoxWorkerUpdateName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWorkerUpdateId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorkers
            // 
            this.dataGridViewWorkers.AllowUserToAddRows = false;
            this.dataGridViewWorkers.AllowUserToDeleteRows = false;
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewWorkers.MultiSelect = false;
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            this.dataGridViewWorkers.ReadOnly = true;
            this.dataGridViewWorkers.RowTemplate.Height = 23;
            this.dataGridViewWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWorkers.Size = new System.Drawing.Size(412, 212);
            this.dataGridViewWorkers.TabIndex = 0;
            this.dataGridViewWorkers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkers_CellClick);
            // 
            // buttonLoadWorkers
            // 
            this.buttonLoadWorkers.Location = new System.Drawing.Point(12, 230);
            this.buttonLoadWorkers.Name = "buttonLoadWorkers";
            this.buttonLoadWorkers.Size = new System.Drawing.Size(161, 23);
            this.buttonLoadWorkers.TabIndex = 1;
            this.buttonLoadWorkers.Text = "Загрузить сотрудников";
            this.buttonLoadWorkers.UseVisualStyleBackColor = true;
            this.buttonLoadWorkers.Click += new System.EventHandler(this.buttonLoadWorkers_Click);
            // 
            // buttonDeleteSelectedWorker
            // 
            this.buttonDeleteSelectedWorker.Location = new System.Drawing.Point(179, 230);
            this.buttonDeleteSelectedWorker.Name = "buttonDeleteSelectedWorker";
            this.buttonDeleteSelectedWorker.Size = new System.Drawing.Size(245, 23);
            this.buttonDeleteSelectedWorker.TabIndex = 2;
            this.buttonDeleteSelectedWorker.Text = "Удалить выбранного сотрудника";
            this.buttonDeleteSelectedWorker.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedWorker.Click += new System.EventHandler(this.buttonDeleteSelectedWorker_Click);
            // 
            // textBoxWorkerName
            // 
            this.textBoxWorkerName.Location = new System.Drawing.Point(12, 321);
            this.textBoxWorkerName.Name = "textBoxWorkerName";
            this.textBoxWorkerName.Size = new System.Drawing.Size(116, 21);
            this.textBoxWorkerName.TabIndex = 3;
            // 
            // textBoxWokerExperience
            // 
            this.textBoxWokerExperience.Location = new System.Drawing.Point(134, 321);
            this.textBoxWokerExperience.Name = "textBoxWokerExperience";
            this.textBoxWokerExperience.Size = new System.Drawing.Size(116, 21);
            this.textBoxWokerExperience.TabIndex = 4;
            // 
            // buttonAddNewWorker
            // 
            this.buttonAddNewWorker.Location = new System.Drawing.Point(256, 321);
            this.buttonAddNewWorker.Name = "buttonAddNewWorker";
            this.buttonAddNewWorker.Size = new System.Drawing.Size(168, 23);
            this.buttonAddNewWorker.TabIndex = 5;
            this.buttonAddNewWorker.Text = "Добавить нового сотрудника";
            this.buttonAddNewWorker.UseVisualStyleBackColor = true;
            this.buttonAddNewWorker.Click += new System.EventHandler(this.buttonAddNewWorker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Опыт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Опыт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Имя";
            // 
            // buttonUpdateWorker
            // 
            this.buttonUpdateWorker.Location = new System.Drawing.Point(256, 458);
            this.buttonUpdateWorker.Name = "buttonUpdateWorker";
            this.buttonUpdateWorker.Size = new System.Drawing.Size(168, 23);
            this.buttonUpdateWorker.TabIndex = 10;
            this.buttonUpdateWorker.Text = "Обновить сотрудника";
            this.buttonUpdateWorker.UseVisualStyleBackColor = true;
            this.buttonUpdateWorker.Click += new System.EventHandler(this.buttonUpdateWorker_Click);
            // 
            // textBoxWorkerExperience
            // 
            this.textBoxWorkerExperience.Location = new System.Drawing.Point(134, 458);
            this.textBoxWorkerExperience.Name = "textBoxWorkerExperience";
            this.textBoxWorkerExperience.Size = new System.Drawing.Size(116, 21);
            this.textBoxWorkerExperience.TabIndex = 9;
            // 
            // textBoxWorkerUpdateName
            // 
            this.textBoxWorkerUpdateName.Location = new System.Drawing.Point(12, 458);
            this.textBoxWorkerUpdateName.Name = "textBoxWorkerUpdateName";
            this.textBoxWorkerUpdateName.Size = new System.Drawing.Size(116, 21);
            this.textBoxWorkerUpdateName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ид";
            // 
            // textBoxWorkerUpdateId
            // 
            this.textBoxWorkerUpdateId.Location = new System.Drawing.Point(12, 418);
            this.textBoxWorkerUpdateId.Name = "textBoxWorkerUpdateId";
            this.textBoxWorkerUpdateId.ReadOnly = true;
            this.textBoxWorkerUpdateId.Size = new System.Drawing.Size(116, 21);
            this.textBoxWorkerUpdateId.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWorkerUpdateId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonUpdateWorker);
            this.Controls.Add(this.textBoxWorkerExperience);
            this.Controls.Add(this.textBoxWorkerUpdateName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddNewWorker);
            this.Controls.Add(this.textBoxWokerExperience);
            this.Controls.Add(this.textBoxWorkerName);
            this.Controls.Add(this.buttonDeleteSelectedWorker);
            this.Controls.Add(this.buttonLoadWorkers);
            this.Controls.Add(this.dataGridViewWorkers);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewWorkers;
        private Button buttonLoadWorkers;
        private Button buttonDeleteSelectedWorker;
        private TextBox textBoxWorkerName;
        private TextBox textBoxWokerExperience;
        private Button buttonAddNewWorker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonUpdateWorker;
        private TextBox textBoxWorkerExperience;
        private TextBox textBoxWorkerUpdateName;
        private Label label5;
        private TextBox textBoxWorkerUpdateId;
    }
}