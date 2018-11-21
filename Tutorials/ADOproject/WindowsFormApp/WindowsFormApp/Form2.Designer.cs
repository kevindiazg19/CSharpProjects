namespace WindowsFormApp
{
    partial class Form_Schools
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
            this.dataGrid_schools = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBx_Name = new System.Windows.Forms.TextBox();
            this.txtBx_Address = new System.Windows.Forms.TextBox();
            this.txtBx_postCode = new System.Windows.Forms.TextBox();
            this.txtBx_Phone = new System.Windows.Forms.TextBox();
            this.txtBx_PostAddress = new System.Windows.Forms.TextBox();
            this.txtBx_Description = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBoxNew = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_new = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_schools)).BeginInit();
            this.groupBoxNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_schools
            // 
            this.dataGrid_schools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_schools.Location = new System.Drawing.Point(29, 85);
            this.dataGrid_schools.Name = "dataGrid_schools";
            this.dataGrid_schools.Size = new System.Drawing.Size(579, 192);
            this.dataGrid_schools.TabIndex = 0;
            this.dataGrid_schools.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_schools_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schools Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Post Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Post Address:";
            // 
            // txtBx_Name
            // 
            this.txtBx_Name.Location = new System.Drawing.Point(85, 31);
            this.txtBx_Name.Name = "txtBx_Name";
            this.txtBx_Name.Size = new System.Drawing.Size(206, 20);
            this.txtBx_Name.TabIndex = 3;
            // 
            // txtBx_Address
            // 
            this.txtBx_Address.Location = new System.Drawing.Point(85, 63);
            this.txtBx_Address.Name = "txtBx_Address";
            this.txtBx_Address.Size = new System.Drawing.Size(206, 20);
            this.txtBx_Address.TabIndex = 3;
            // 
            // txtBx_postCode
            // 
            this.txtBx_postCode.Location = new System.Drawing.Point(85, 89);
            this.txtBx_postCode.Name = "txtBx_postCode";
            this.txtBx_postCode.Size = new System.Drawing.Size(206, 20);
            this.txtBx_postCode.TabIndex = 3;
            // 
            // txtBx_Phone
            // 
            this.txtBx_Phone.Location = new System.Drawing.Point(399, 31);
            this.txtBx_Phone.Name = "txtBx_Phone";
            this.txtBx_Phone.Size = new System.Drawing.Size(206, 20);
            this.txtBx_Phone.TabIndex = 3;
            // 
            // txtBx_PostAddress
            // 
            this.txtBx_PostAddress.Location = new System.Drawing.Point(399, 63);
            this.txtBx_PostAddress.Name = "txtBx_PostAddress";
            this.txtBx_PostAddress.Size = new System.Drawing.Size(206, 20);
            this.txtBx_PostAddress.TabIndex = 3;
            // 
            // txtBx_Description
            // 
            this.txtBx_Description.Location = new System.Drawing.Point(399, 89);
            this.txtBx_Description.Name = "txtBx_Description";
            this.txtBx_Description.Size = new System.Drawing.Size(206, 20);
            this.txtBx_Description.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(438, 137);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(530, 137);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBoxNew
            // 
            this.groupBoxNew.Controls.Add(this.labelID);
            this.groupBoxNew.Controls.Add(this.label8);
            this.groupBoxNew.Controls.Add(this.btn_cancel);
            this.groupBoxNew.Controls.Add(this.btn_save);
            this.groupBoxNew.Controls.Add(this.txtBx_postCode);
            this.groupBoxNew.Controls.Add(this.txtBx_Description);
            this.groupBoxNew.Controls.Add(this.txtBx_PostAddress);
            this.groupBoxNew.Controls.Add(this.txtBx_Address);
            this.groupBoxNew.Controls.Add(this.txtBx_Phone);
            this.groupBoxNew.Controls.Add(this.txtBx_Name);
            this.groupBoxNew.Controls.Add(this.label5);
            this.groupBoxNew.Controls.Add(this.label4);
            this.groupBoxNew.Controls.Add(this.label3);
            this.groupBoxNew.Controls.Add(this.label7);
            this.groupBoxNew.Controls.Add(this.label6);
            this.groupBoxNew.Controls.Add(this.label2);
            this.groupBoxNew.Enabled = false;
            this.groupBoxNew.Location = new System.Drawing.Point(29, 299);
            this.groupBoxNew.Name = "groupBoxNew";
            this.groupBoxNew.Size = new System.Drawing.Size(646, 175);
            this.groupBoxNew.TabIndex = 5;
            this.groupBoxNew.TabStop = false;
            this.groupBoxNew.Text = "New/Edit";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(82, 125);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ID:";
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(628, 108);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(75, 44);
            this.button_new.TabIndex = 6;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(628, 175);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 42);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form_Schools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 486);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.groupBoxNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_schools);
            this.Name = "Form_Schools";
            this.Text = "Schools";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_schools)).EndInit();
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_schools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBx_Name;
        private System.Windows.Forms.TextBox txtBx_Address;
        private System.Windows.Forms.TextBox txtBx_postCode;
        private System.Windows.Forms.TextBox txtBx_Phone;
        private System.Windows.Forms.TextBox txtBx_PostAddress;
        private System.Windows.Forms.TextBox txtBx_Description;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBoxNew;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonEdit;
    }
}