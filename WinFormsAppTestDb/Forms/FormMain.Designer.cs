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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorkers
            // 
            this.dataGridViewWorkers.AllowUserToAddRows = false;
            this.dataGridViewWorkers.AllowUserToDeleteRows = false;
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            this.dataGridViewWorkers.ReadOnly = true;
            this.dataGridViewWorkers.RowTemplate.Height = 23;
            this.dataGridViewWorkers.Size = new System.Drawing.Size(412, 212);
            this.dataGridViewWorkers.TabIndex = 0;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoadWorkers);
            this.Controls.Add(this.dataGridViewWorkers);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewWorkers;
        private Button buttonLoadWorkers;
    }
}