namespace Assignment2
{
    partial class MakeUserAdminDialog
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
            this.makeAdminDialog = new System.Windows.Forms.Label();
            this.makeUserAdminComboBox = new System.Windows.Forms.ComboBox();
            this.MakeUserAdmin_Submit = new System.Windows.Forms.Button();
            this.MakeUserAdmin_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeAdminDialog
            // 
            this.makeAdminDialog.AutoSize = true;
            this.makeAdminDialog.Location = new System.Drawing.Point(19, 35);
            this.makeAdminDialog.Name = "makeAdminDialog";
            this.makeAdminDialog.Size = new System.Drawing.Size(253, 13);
            this.makeAdminDialog.TabIndex = 0;
            this.makeAdminDialog.Text = "What admin levelwould you like tomake this user(s)?";
            // 
            // makeUserAdminComboBox
            // 
            this.makeUserAdminComboBox.Items.AddRange(new object[] {
            "Moderator",
            "SuperAdmin"});
            this.makeUserAdminComboBox.Location = new System.Drawing.Point(71, 61);
            this.makeUserAdminComboBox.Name = "makeUserAdminComboBox";
            this.makeUserAdminComboBox.Size = new System.Drawing.Size(121, 21);
            this.makeUserAdminComboBox.TabIndex = 0;
            this.makeUserAdminComboBox.SelectedIndexChanged += new System.EventHandler(this.makeUserAdminComboBox_click);
            // 
            // MakeUserAdmin_Submit
            // 
            this.MakeUserAdmin_Submit.Location = new System.Drawing.Point(87, 117);
            this.MakeUserAdmin_Submit.Name = "MakeUserAdmin_Submit";
            this.MakeUserAdmin_Submit.Size = new System.Drawing.Size(75, 23);
            this.MakeUserAdmin_Submit.TabIndex = 1;
            this.MakeUserAdmin_Submit.Text = "Submit";
            this.MakeUserAdmin_Submit.UseVisualStyleBackColor = true;
            this.MakeUserAdmin_Submit.Click += new System.EventHandler(this.MakeUserAdmin_Submit_click);
            // 
            // MakeUserAdmin_Cancel
            // 
            this.MakeUserAdmin_Cancel.Location = new System.Drawing.Point(87, 146);
            this.MakeUserAdmin_Cancel.Name = "MakeUserAdmin_Cancel";
            this.MakeUserAdmin_Cancel.Size = new System.Drawing.Size(75, 23);
            this.MakeUserAdmin_Cancel.TabIndex = 2;
            this.MakeUserAdmin_Cancel.Text = "Cancel";
            this.MakeUserAdmin_Cancel.UseVisualStyleBackColor = true;
            this.MakeUserAdmin_Cancel.Click += new System.EventHandler(this.MakeUserAdmin_Cancel_click);
            // 
            // MakeUserAdminDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MakeUserAdmin_Cancel);
            this.Controls.Add(this.MakeUserAdmin_Submit);
            this.Controls.Add(this.makeUserAdminComboBox);
            this.Controls.Add(this.makeAdminDialog);
            this.Name = "MakeUserAdminDialog";
            this.Text = "MakeUserAdminDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label makeAdminDialog;
        private System.Windows.Forms.ComboBox makeUserAdminComboBox;
        private System.Windows.Forms.Button MakeUserAdmin_Submit;
        private System.Windows.Forms.Button MakeUserAdmin_Cancel;
    }
}