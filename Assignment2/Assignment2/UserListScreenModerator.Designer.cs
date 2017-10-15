using System;
using System.Windows.Forms;

namespace Assignment2
{
    partial class UserListScreenModerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // listView4
            // 
            this.listView4.CheckBoxes = true;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col4,
            this.col5,
            this.col6});
            this.listView4.Location = new System.Drawing.Point(36, 154);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(348, 95);
            this.listView4.TabIndex = 1;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // col4
            // 
            this.col4.Name = "col4";
            this.col4.Text = "FullUserString";
            this.col4.Width = 88;
            // 
            // col5
            // 
            this.col5.Text = "Average star rating";
            this.col5.Width = 101;
            // 
            // col6
            // 
            this.col6.Text = "Number of ratings";
            this.col6.Width = 147;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Provide rating to user(s)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_click);
            //  
            // col1
            // 
            this.col1.Name = "col1";
            this.col1.Text = "ShortUserString";
            this.col1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Average star rating";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number of ratings";
            this.columnHeader3.Width = 147;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Provide rating to user(s)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // UserListScreenModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView4);
            this.Name = "UserListScreenModerator";
            this.Text = "UserListScreenModerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView4;
        private ColumnHeader col4;
        private ColumnHeader col5;
        private ColumnHeader col6;
        private Button button3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button4;
        private ColumnHeader col1;
        private Label label2;
    }
}