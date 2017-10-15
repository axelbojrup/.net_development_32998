namespace Assignment2
{
    partial class UserListScreenAdmin
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
            this.adminLabel = new System.Windows.Forms.Label();
            this.listViewAdmin = new System.Windows.Forms.ListView();
            this.colAdmin1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdmin2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdmin3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdminRating = new System.Windows.Forms.Button();
            this.makeAdmin_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(172, 57);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(61, 13);
            this.adminLabel.TabIndex = 5;
            this.adminLabel.Text = "adminLabel";
            // 
            // listViewAdmin
            // 
            this.listViewAdmin.CheckBoxes = true;
            this.listViewAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAdmin1,
            this.colAdmin2,
            this.colAdmin3});
            this.listViewAdmin.Location = new System.Drawing.Point(48, 158);
            this.listViewAdmin.Name = "listViewAdmin";
            this.listViewAdmin.Size = new System.Drawing.Size(348, 95);
            this.listViewAdmin.TabIndex = 6;
            this.listViewAdmin.UseCompatibleStateImageBehavior = false;
            this.listViewAdmin.View = System.Windows.Forms.View.Details;
            // 
            // colAdmin1
            // 
            this.colAdmin1.Name = "colAdmin1";
            this.colAdmin1.Text = "FullUserString";
            this.colAdmin1.Width = 88;
            // 
            // colAdmin2
            // 
            this.colAdmin2.Text = "Average star rating";
            this.colAdmin2.Width = 101;
            // 
            // colAdmin3
            // 
            this.colAdmin3.Text = "Number of ratings";
            this.colAdmin3.Width = 147;
            // 
            // buttonAdminRating
            // 
            this.buttonAdminRating.Location = new System.Drawing.Point(144, 308);
            this.buttonAdminRating.Name = "buttonAdminRating";
            this.buttonAdminRating.Size = new System.Drawing.Size(137, 23);
            this.buttonAdminRating.TabIndex = 7;
            this.buttonAdminRating.Text = "Provide rating to user(s)";
            this.buttonAdminRating.UseVisualStyleBackColor = true;
            this.buttonAdminRating.Click += new System.EventHandler(this.buttonAdminRating_click);
            // 
            // makeAdmin_button
            // 
            this.makeAdmin_button.Location = new System.Drawing.Point(144, 279);
            this.makeAdmin_button.Name = "makeAdmin_button";
            this.makeAdmin_button.Size = new System.Drawing.Size(137, 23);
            this.makeAdmin_button.TabIndex = 8;
            this.makeAdmin_button.Text = "Make User(s) Admin";
            this.makeAdmin_button.UseVisualStyleBackColor = true;
            this.makeAdmin_button.Click += new System.EventHandler(this.makeAdmin_button_click);
            // 
            // UserListScreenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 524);
            this.Controls.Add(this.makeAdmin_button);
            this.Controls.Add(this.buttonAdminRating);
            this.Controls.Add(this.listViewAdmin);
            this.Controls.Add(this.adminLabel);
            this.Name = "UserListScreenAdmin";
            this.Text = "UserListScreenAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.ListView listViewAdmin;
        private System.Windows.Forms.ColumnHeader colAdmin1;
        private System.Windows.Forms.ColumnHeader colAdmin2;
        private System.Windows.Forms.ColumnHeader colAdmin3;
        private System.Windows.Forms.Button buttonAdminRating;
        private System.Windows.Forms.Button makeAdmin_button;
    }
}