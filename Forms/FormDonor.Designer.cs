namespace DBFinalBDS_Ver1.Forms
{
    partial class FormDonor
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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.DonordataGridView = new System.Windows.Forms.DataGridView();
            this.guardianInformationbtn = new System.Windows.Forms.Button();
            this.personalInformationbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BottlesQtyComboBox = new System.Windows.Forms.ComboBox();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonordataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.DonordataGridView);
            this.panelDesktopPane.Controls.Add(this.guardianInformationbtn);
            this.panelDesktopPane.Controls.Add(this.personalInformationbtn);
            this.panelDesktopPane.Controls.Add(this.addbtn);
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Controls.Add(this.label1);
            this.panelDesktopPane.Controls.Add(this.BottlesQtyComboBox);
            this.panelDesktopPane.Controls.Add(this.BloodGroupComboBox);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(928, 489);
            this.panelDesktopPane.TabIndex = 0;
            // 
            // DonordataGridView
            // 
            this.DonordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonordataGridView.Location = new System.Drawing.Point(12, 215);
            this.DonordataGridView.Name = "DonordataGridView";
            this.DonordataGridView.Size = new System.Drawing.Size(904, 263);
            this.DonordataGridView.TabIndex = 23;
            // 
            // guardianInformationbtn
            // 
            this.guardianInformationbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.guardianInformationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardianInformationbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(209)))), ((int)(((byte)(150)))));
            this.guardianInformationbtn.Location = new System.Drawing.Point(655, 140);
            this.guardianInformationbtn.Name = "guardianInformationbtn";
            this.guardianInformationbtn.Size = new System.Drawing.Size(261, 37);
            this.guardianInformationbtn.TabIndex = 22;
            this.guardianInformationbtn.Text = "Guardian Information";
            this.guardianInformationbtn.UseVisualStyleBackColor = false;
            this.guardianInformationbtn.Click += new System.EventHandler(this.guardianInformationbtn_Click);
            // 
            // personalInformationbtn
            // 
            this.personalInformationbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.personalInformationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInformationbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(209)))), ((int)(((byte)(150)))));
            this.personalInformationbtn.Location = new System.Drawing.Point(12, 140);
            this.personalInformationbtn.Name = "personalInformationbtn";
            this.personalInformationbtn.Size = new System.Drawing.Size(261, 37);
            this.personalInformationbtn.TabIndex = 21;
            this.personalInformationbtn.Text = "Personal Information";
            this.personalInformationbtn.UseVisualStyleBackColor = false;
            this.personalInformationbtn.Click += new System.EventHandler(this.personalInformationbtn_Click_1);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(209)))), ((int)(((byte)(150)))));
            this.addbtn.Location = new System.Drawing.Point(386, 140);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(157, 37);
            this.addbtn.TabIndex = 20;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Bottle Quantity: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select Blood Group: ";
            // 
            // BottlesQtyComboBox
            // 
            this.BottlesQtyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BottlesQtyComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottlesQtyComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(209)))), ((int)(((byte)(150)))));
            this.BottlesQtyComboBox.FormattingEnabled = true;
            this.BottlesQtyComboBox.Location = new System.Drawing.Point(655, 56);
            this.BottlesQtyComboBox.Name = "BottlesQtyComboBox";
            this.BottlesQtyComboBox.Size = new System.Drawing.Size(261, 29);
            this.BottlesQtyComboBox.TabIndex = 17;
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BloodGroupComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(209)))), ((int)(((byte)(150)))));
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Location = new System.Drawing.Point(212, 10);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(261, 29);
            this.BloodGroupComboBox.TabIndex = 16;
            // 
            // FormDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(209)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(928, 489);
            this.Controls.Add(this.panelDesktopPane);
            this.Name = "FormDonor";
            this.Text = "FormDonor";
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonordataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.DataGridView DonordataGridView;
        private System.Windows.Forms.Button guardianInformationbtn;
        private System.Windows.Forms.Button personalInformationbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BottlesQtyComboBox;
        private System.Windows.Forms.ComboBox BloodGroupComboBox;
    }
}