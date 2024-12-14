namespace notes
{
    partial class Change
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
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.minuetsTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notifyAheadComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 370);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(138, 40);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(156, 370);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(138, 40);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(280, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(13, 63);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(278, 207);
            this.textTextBox.TabIndex = 3;
            // 
            // hourTextBox
            // 
            this.hourTextBox.Location = new System.Drawing.Point(56, 291);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(24, 26);
            this.hourTextBox.TabIndex = 4;
            // 
            // minuetsTextBox
            // 
            this.minuetsTextBox.Location = new System.Drawing.Point(86, 291);
            this.minuetsTextBox.Name = "minuetsTextBox";
            this.minuetsTextBox.Size = new System.Drawing.Size(24, 26);
            this.minuetsTextBox.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(116, 291);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(175, 26);
            this.dateTimePicker.TabIndex = 6;
            // 
            // notifyAheadComboBox
            // 
            this.notifyAheadComboBox.FormattingEnabled = true;
            this.notifyAheadComboBox.Items.AddRange(new object[] {
            1,
            5,
            10,
            15,
            30});
            this.notifyAheadComboBox.Location = new System.Drawing.Point(224, 323);
            this.notifyAheadComboBox.Name = "notifyAheadComboBox";
            this.notifyAheadComboBox.Size = new System.Drawing.Size(67, 28);
            this.notifyAheadComboBox.TabIndex = 7;
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 422);
            this.Controls.Add(this.notifyAheadComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.minuetsTextBox);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Change";
            this.Text = "change";
            this.Load += new System.EventHandler(this.Change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox minuetsTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox notifyAheadComboBox;
    }
}