namespace MultilayerArchitecture
{
    partial class Form1
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
            this.comboBoxPredmet = new System.Windows.Forms.ComboBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listViewStudentIspit = new System.Windows.Forms.ListView();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentIspit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentIspit)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPredmet
            // 
            this.comboBoxPredmet.FormattingEnabled = true;
            this.comboBoxPredmet.Location = new System.Drawing.Point(13, 26);
            this.comboBoxPredmet.Name = "comboBoxPredmet";
            this.comboBoxPredmet.Size = new System.Drawing.Size(572, 24);
            this.comboBoxPredmet.TabIndex = 0;
            this.comboBoxPredmet.SelectedIndexChanged += new System.EventHandler(this.comboBoxPredmet_SelectedIndexChanged);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(656, 70);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(139, 48);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(656, 146);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(139, 48);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(656, 222);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 48);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(656, 304);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(139, 48);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listViewStudentIspit
            // 
            this.listViewStudentIspit.Location = new System.Drawing.Point(13, 81);
            this.listViewStudentIspit.Name = "listViewStudentIspit";
            this.listViewStudentIspit.Size = new System.Drawing.Size(572, 537);
            this.listViewStudentIspit.TabIndex = 6;
            this.listViewStudentIspit.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(907, 81);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(713, 271);
            this.dataGridViewStudent.TabIndex = 7;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            // 
            // dataGridViewStudentIspit
            // 
            this.dataGridViewStudentIspit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentIspit.Location = new System.Drawing.Point(907, 378);
            this.dataGridViewStudentIspit.Name = "dataGridViewStudentIspit";
            this.dataGridViewStudentIspit.RowTemplate.Height = 24;
            this.dataGridViewStudentIspit.Size = new System.Drawing.Size(713, 271);
            this.dataGridViewStudentIspit.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 674);
            this.Controls.Add(this.dataGridViewStudentIspit);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.listViewStudentIspit);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.comboBoxPredmet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentIspit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPredmet;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ListView listViewStudentIspit;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudentIspit;
    }
}

