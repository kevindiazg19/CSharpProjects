namespace studentsDBC
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.cmbxGen = new System.Windows.Forms.ComboBox();
            this.label_title = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_id_hid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(43, 68);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(43, 102);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(41, 20);
            this.label_age.TabIndex = 0;
            this.label_age.Text = "Age";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_city.Location = new System.Drawing.Point(43, 131);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(39, 20);
            this.label_city.TabIndex = 0;
            this.label_city.Text = "City";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(43, 162);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(69, 20);
            this.label_gender.TabIndex = 0;
            this.label_gender.Text = "Gender";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(157, 68);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(190, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(157, 102);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(190, 20);
            this.textBox_age.TabIndex = 1;
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(157, 131);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(190, 20);
            this.textBox_city.TabIndex = 1;
            // 
            // cmbxGen
            // 
            this.cmbxGen.FormattingEnabled = true;
            this.cmbxGen.Location = new System.Drawing.Point(158, 161);
            this.cmbxGen.Name = "cmbxGen";
            this.cmbxGen.Size = new System.Drawing.Size(188, 21);
            this.cmbxGen.TabIndex = 2;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(21, 18);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(188, 30);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Student Details";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(397, 68);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(69, 34);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(397, 110);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(69, 34);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(397, 152);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(69, 34);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 188);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_id_hid
            // 
            this.label_id_hid.AutoSize = true;
            this.label_id_hid.Location = new System.Drawing.Point(428, 13);
            this.label_id_hid.Name = "label_id_hid";
            this.label_id_hid.Size = new System.Drawing.Size(10, 13);
            this.label_id_hid.TabIndex = 6;
            this.label_id_hid.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 411);
            this.Controls.Add(this.label_id_hid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.cmbxGen);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.ComboBox cmbxGen;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_id_hid;
    }
}

