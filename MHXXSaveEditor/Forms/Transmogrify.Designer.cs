namespace MHXXSaveEditor.Forms
{
    partial class Transmogrify
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
            this.comboBoxTransmogrify = new System.Windows.Forms.ComboBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改为";
            // 
            // comboBoxTransmogrify
            // 
            this.comboBoxTransmogrify.FormattingEnabled = true;
            this.comboBoxTransmogrify.Location = new System.Drawing.Point(90, 8);
            this.comboBoxTransmogrify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTransmogrify.Name = "comboBoxTransmogrify";
            this.comboBoxTransmogrify.Size = new System.Drawing.Size(188, 20);
            this.comboBoxTransmogrify.TabIndex = 1;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(90, 38);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 22);
            this.buttonSet.TabIndex = 2;
            this.buttonSet.Text = "确定";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.ButtonSet_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(203, 38);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 22);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Transmogrify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 77);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.comboBoxTransmogrify);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transmogrify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改装备";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTransmogrify;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonCancel;
    }
}