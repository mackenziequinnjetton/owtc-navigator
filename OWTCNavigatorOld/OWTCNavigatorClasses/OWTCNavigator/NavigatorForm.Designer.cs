namespace OWTCNavigator
{
    partial class NavigatorForm
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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.outputTabControl = new System.Windows.Forms.TabControl();
            this.progressTabPage = new System.Windows.Forms.TabPage();
            this.dueDatesTabPage = new System.Windows.Forms.TabPage();
            this.dueDatesListBox = new System.Windows.Forms.ListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.outputTabControl.SuspendLayout();
            this.dueDatesTabPage.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Location = new System.Drawing.Point(4, 3);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(476, 20);
            this.IDTextBox.TabIndex = 0;
            this.IDTextBox.Text = "Student ID#";
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // outputTabControl
            // 
            this.outputTabControl.Controls.Add(this.progressTabPage);
            this.outputTabControl.Controls.Add(this.dueDatesTabPage);
            this.outputTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTabControl.Location = new System.Drawing.Point(0, 0);
            this.outputTabControl.Name = "outputTabControl";
            this.outputTabControl.SelectedIndex = 0;
            this.outputTabControl.Size = new System.Drawing.Size(591, 368);
            this.outputTabControl.TabIndex = 2;
            // 
            // progressTabPage
            // 
            this.progressTabPage.Location = new System.Drawing.Point(4, 22);
            this.progressTabPage.Name = "progressTabPage";
            this.progressTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.progressTabPage.Size = new System.Drawing.Size(583, 342);
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
            this.dueDatesTabPage.Size = new System.Drawing.Size(583, 342);
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
            this.dueDatesListBox.Size = new System.Drawing.Size(577, 336);
            this.dueDatesListBox.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(486, 1);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.AutoSize = true;
            this.inputPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputPanel.Controls.Add(this.IDTextBox);
            this.inputPanel.Controls.Add(this.submitButton);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputPanel.Location = new System.Drawing.Point(0, 341);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(591, 27);
            this.inputPanel.TabIndex = 4;
            // 
            // NavigatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 368);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.outputTabControl);
            this.MinimumSize = new System.Drawing.Size(351, 264);
            this.Name = "NavigatorForm";
            this.Text = "OWTC Navigator";
            this.outputTabControl.ResumeLayout(false);
            this.dueDatesTabPage.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TabControl outputTabControl;
        private System.Windows.Forms.TabPage progressTabPage;
        private System.Windows.Forms.TabPage dueDatesTabPage;
        private System.Windows.Forms.ListBox dueDatesListBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel inputPanel;
    }
}

