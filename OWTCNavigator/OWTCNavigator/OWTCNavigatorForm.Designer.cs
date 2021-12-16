namespace OWTCNavigator
{
    partial class OWTCNavigatorForm
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
            this.outputTabControl = new System.Windows.Forms.TabControl();
            this.progressTabPage = new System.Windows.Forms.TabPage();
            this.dueDatesTabPage = new System.Windows.Forms.TabPage();
            this.dueDatesListBox = new System.Windows.Forms.ListBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.studentIDSubmitButton = new System.Windows.Forms.Button();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.outputTabControl.SuspendLayout();
            this.dueDatesTabPage.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTabControl
            // 
            this.outputTabControl.Controls.Add(this.dueDatesTabPage);
            this.outputTabControl.Controls.Add(this.progressTabPage);
            this.outputTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTabControl.Location = new System.Drawing.Point(0, 0);
            this.outputTabControl.Name = "outputTabControl";
            this.outputTabControl.SelectedIndex = 0;
            this.outputTabControl.Size = new System.Drawing.Size(484, 311);
            this.outputTabControl.TabIndex = 0;
            // 
            // progressTabPage
            // 
            this.progressTabPage.Location = new System.Drawing.Point(4, 22);
            this.progressTabPage.Name = "progressTabPage";
            this.progressTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.progressTabPage.Size = new System.Drawing.Size(476, 285);
            this.progressTabPage.TabIndex = 0;
            this.progressTabPage.Text = "Progress";
            this.progressTabPage.UseVisualStyleBackColor = true;
            // 
            // dueDatesTabPage
            // 
            this.dueDatesTabPage.Controls.Add(this.dueDatesListBox);
            this.dueDatesTabPage.Location = new System.Drawing.Point(4, 22);
            this.dueDatesTabPage.Name = "dueDatesTabPage";
            this.dueDatesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dueDatesTabPage.Size = new System.Drawing.Size(476, 285);
            this.dueDatesTabPage.TabIndex = 1;
            this.dueDatesTabPage.Text = "Due Dates";
            this.dueDatesTabPage.UseVisualStyleBackColor = true;
            // 
            // dueDatesListBox
            // 
            this.dueDatesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dueDatesListBox.FormattingEnabled = true;
            this.dueDatesListBox.Location = new System.Drawing.Point(3, 3);
            this.dueDatesListBox.Name = "dueDatesListBox";
            this.dueDatesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dueDatesListBox.Size = new System.Drawing.Size(470, 279);
            this.dueDatesListBox.TabIndex = 0;
            // 
            // inputPanel
            // 
            this.inputPanel.AutoSize = true;
            this.inputPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputPanel.Controls.Add(this.courseComboBox);
            this.inputPanel.Controls.Add(this.studentIDSubmitButton);
            this.inputPanel.Controls.Add(this.studentIDTextBox);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputPanel.Location = new System.Drawing.Point(0, 282);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(484, 29);
            this.inputPanel.TabIndex = 1;
            // 
            // studentIDSubmitButton
            // 
            this.studentIDSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentIDSubmitButton.Location = new System.Drawing.Point(201, 3);
            this.studentIDSubmitButton.Name = "studentIDSubmitButton";
            this.studentIDSubmitButton.Size = new System.Drawing.Size(83, 23);
            this.studentIDSubmitButton.TabIndex = 1;
            this.studentIDSubmitButton.Text = "Submit";
            this.studentIDSubmitButton.UseVisualStyleBackColor = true;
            this.studentIDSubmitButton.Click += new System.EventHandler(this.studentIDSubmitButton_Click);
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.studentIDTextBox.Location = new System.Drawing.Point(4, 5);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(191, 20);
            this.studentIDTextBox.TabIndex = 0;
            this.studentIDTextBox.Text = "Enter your student ID# here";
            this.studentIDTextBox.Leave += new System.EventHandler(this.studentIDTextBox_Leave);
            this.studentIDTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.studentIDTextBox_MouseUp);
            // 
            // courseComboBox
            // 
            this.courseComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.courseComboBox.Enabled = false;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(290, 5);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(190, 21);
            this.courseComboBox.TabIndex = 2;
            this.courseComboBox.Text = "Select a course";
            // 
            // OWTCNavigatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.outputTabControl);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "OWTCNavigatorForm";
            this.Text = "OWTC Navigator";
            this.outputTabControl.ResumeLayout(false);
            this.dueDatesTabPage.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl outputTabControl;
        private System.Windows.Forms.TabPage progressTabPage;
        private System.Windows.Forms.TabPage dueDatesTabPage;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button studentIDSubmitButton;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.ListBox dueDatesListBox;
        private System.Windows.Forms.ComboBox courseComboBox;
    }
}

