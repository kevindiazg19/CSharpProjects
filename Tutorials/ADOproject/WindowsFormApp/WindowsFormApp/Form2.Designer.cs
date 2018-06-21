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
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_schools)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_schools
            // 
            this.dataGrid_schools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_schools.Location = new System.Drawing.Point(29, 85);
            this.dataGrid_schools.Name = "dataGrid_schools";
            this.dataGrid_schools.Size = new System.Drawing.Size(579, 192);
            this.dataGrid_schools.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(26, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Post Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Post Address:";
            // 
            // txtBx_Name
            // 
            this.txtBx_Name.Location = new System.Drawing.Point(88, 309);
            this.txtBx_Name.Name = "txtBx_Name";
            this.txtBx_Name.Size = new System.Drawing.Size(206, 20);
            this.txtBx_Name.TabIndex = 3;
            // 
            // txtBx_Address
            // 
            this.txtBx_Address.Location = new System.Drawing.Point(88, 341);
            this.txtBx_Address.Name = "txtBx_Address";
            this.txtBx_Address.Size = new System.Drawing.Size(206, 20);
            this.txtBx_Address.TabIndex = 3;
            // 
            // txtBx_postCode
            // 
            this.txtBx_postCode.Location = new System.Drawing.Point(88, 367);
            this.txtBx_postCode.Name = "txtBx_postCode";
            this.txtBx_postCode.Size = new System.Drawing.Size(206, 20);
            this.txtBx_postCode.TabIndex = 3;
            // 
            // txtBx_Phone
            // 
            this.txtBx_Phone.Location = new System.Drawing.Point(402, 309);
            this.txtBx_Phone.Name = "txtBx_Phone";
            this.txtBx_Phone.Size = new System.Drawing.Size(206, 20);
            this.txtBx_Phone.TabIndex = 3;
            // 
            // txtBx_PostAddress
            // 
            this.txtBx_PostAddress.Location = new System.Drawing.Point(402, 341);
            this.txtBx_PostAddress.Name = "txtBx_PostAddress";
            this.txtBx_PostAddress.Size = new System.Drawing.Size(206, 20);
            this.txtBx_PostAddress.TabIndex = 3;
            // 
            // txtBx_Description
            // 
            this.txtBx_Description.Location = new System.Drawing.Point(402, 367);
            this.txtBx_Description.Name = "txtBx_Description";
            this.txtBx_Description.Size = new System.Drawing.Size(206, 20);
            this.txtBx_Description.TabIndex = 3;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(346, 415);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(441, 415);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(533, 415);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_Schools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txtBx_postCode);
            this.Controls.Add(this.txtBx_Description);
            this.Controls.Add(this.txtBx_PostAddress);
            this.Controls.Add(this.txtBx_Address);
            this.Controls.Add(this.txtBx_Phone);
            this.Controls.Add(this.txtBx_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_schools);
            this.Name = "Form_Schools";
            this.Text = "Schools";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_schools)).EndInit();
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
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
    }
}