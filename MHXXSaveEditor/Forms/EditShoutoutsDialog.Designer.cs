namespace MHXXSaveEditor.Forms
{
    partial class EditShoutoutsDialog
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
            this.listViewManualShoutouts = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonManualShoutoutSet = new System.Windows.Forms.Button();
            this.textBoxManualShoutouts = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAutomaticShoutoutSet = new System.Windows.Forms.Button();
            this.textBoxAutomaticShoutouts = new System.Windows.Forms.TextBox();
            this.listViewAutomaticShoutouts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewManualShoutouts
            // 
            this.listViewManualShoutouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewManualShoutouts.FullRowSelect = true;
            this.listViewManualShoutouts.GridLines = true;
            this.listViewManualShoutouts.Location = new System.Drawing.Point(4, 4);
            this.listViewManualShoutouts.Margin = new System.Windows.Forms.Padding(2);
            this.listViewManualShoutouts.MultiSelect = false;
            this.listViewManualShoutouts.Name = "listViewManualShoutouts";
            this.listViewManualShoutouts.Size = new System.Drawing.Size(600, 244);
            this.listViewManualShoutouts.TabIndex = 2;
            this.listViewManualShoutouts.UseCompatibleStateImageBehavior = false;
            this.listViewManualShoutouts.View = System.Windows.Forms.View.Details;
            this.listViewManualShoutouts.SelectedIndexChanged += new System.EventHandler(this.ListViewManualShoutouts_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "格子";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "短语内容";
            this.columnHeader5.Width = 618;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 295);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonManualShoutoutSet);
            this.tabPage1.Controls.Add(this.textBoxManualShoutouts);
            this.tabPage1.Controls.Add(this.listViewManualShoutouts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(606, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "手动短语";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonManualShoutoutSet
            // 
            this.buttonManualShoutoutSet.Location = new System.Drawing.Point(320, 248);
            this.buttonManualShoutoutSet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManualShoutoutSet.Name = "buttonManualShoutoutSet";
            this.buttonManualShoutoutSet.Size = new System.Drawing.Size(56, 21);
            this.buttonManualShoutoutSet.TabIndex = 4;
            this.buttonManualShoutoutSet.Text = "保存";
            this.buttonManualShoutoutSet.UseVisualStyleBackColor = true;
            this.buttonManualShoutoutSet.Click += new System.EventHandler(this.ButtonManualShoutoutSet_Click);
            // 
            // textBoxManualShoutouts
            // 
            this.textBoxManualShoutouts.Location = new System.Drawing.Point(5, 252);
            this.textBoxManualShoutouts.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxManualShoutouts.Name = "textBoxManualShoutouts";
            this.textBoxManualShoutouts.Size = new System.Drawing.Size(301, 21);
            this.textBoxManualShoutouts.TabIndex = 3;
            this.textBoxManualShoutouts.TextChanged += new System.EventHandler(this.TextBoxManualShoutouts_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAutomaticShoutoutSet);
            this.tabPage2.Controls.Add(this.textBoxAutomaticShoutouts);
            this.tabPage2.Controls.Add(this.listViewAutomaticShoutouts);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(606, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "自动短语";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAutomaticShoutoutSet
            // 
            this.buttonAutomaticShoutoutSet.Location = new System.Drawing.Point(322, 248);
            this.buttonAutomaticShoutoutSet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAutomaticShoutoutSet.Name = "buttonAutomaticShoutoutSet";
            this.buttonAutomaticShoutoutSet.Size = new System.Drawing.Size(56, 21);
            this.buttonAutomaticShoutoutSet.TabIndex = 5;
            this.buttonAutomaticShoutoutSet.Text = "保存";
            this.buttonAutomaticShoutoutSet.UseVisualStyleBackColor = true;
            this.buttonAutomaticShoutoutSet.Click += new System.EventHandler(this.ButtonAutomaticShoutoutSet_Click);
            // 
            // textBoxAutomaticShoutouts
            // 
            this.textBoxAutomaticShoutouts.Location = new System.Drawing.Point(4, 252);
            this.textBoxAutomaticShoutouts.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAutomaticShoutouts.Name = "textBoxAutomaticShoutouts";
            this.textBoxAutomaticShoutouts.Size = new System.Drawing.Size(301, 21);
            this.textBoxAutomaticShoutouts.TabIndex = 4;
            this.textBoxAutomaticShoutouts.TextChanged += new System.EventHandler(this.TextBoxAutomaticShoutouts_TextChanged);
            // 
            // listViewAutomaticShoutouts
            // 
            this.listViewAutomaticShoutouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewAutomaticShoutouts.FullRowSelect = true;
            this.listViewAutomaticShoutouts.GridLines = true;
            this.listViewAutomaticShoutouts.Location = new System.Drawing.Point(4, 4);
            this.listViewAutomaticShoutouts.Margin = new System.Windows.Forms.Padding(2);
            this.listViewAutomaticShoutouts.MultiSelect = false;
            this.listViewAutomaticShoutouts.Name = "listViewAutomaticShoutouts";
            this.listViewAutomaticShoutouts.Size = new System.Drawing.Size(600, 244);
            this.listViewAutomaticShoutouts.TabIndex = 3;
            this.listViewAutomaticShoutouts.UseCompatibleStateImageBehavior = false;
            this.listViewAutomaticShoutouts.View = System.Windows.Forms.View.Details;
            this.listViewAutomaticShoutouts.SelectedIndexChanged += new System.EventHandler(this.ListViewAutomaticShoutouts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "格子";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "短语内容";
            this.columnHeader2.Width = 618;
            // 
            // EditShoutoutsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 313);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditShoutoutsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改短语";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewManualShoutouts;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewAutomaticShoutouts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxManualShoutouts;
        private System.Windows.Forms.TextBox textBoxAutomaticShoutouts;
        private System.Windows.Forms.Button buttonManualShoutoutSet;
        private System.Windows.Forms.Button buttonAutomaticShoutoutSet;
    }
}