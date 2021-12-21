namespace Gui
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.testButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.apiTestLabel = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.baseUriTextBox = new System.Windows.Forms.TextBox();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apiUrlLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(384, 86);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(384, 111);
            this.toolStripContainer1.TabIndex = 12;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip.CanOverflow = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.testButton,
            this.toolStripSeparator1,
            this.apiTestLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(384, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveButton.Enabled = false;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 22);
            this.saveButton.Text = "Enre&gistrer";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // apiTestButton
            // 
            this.testButton.Image = global::Gui.Properties.Resources.Test;
            this.testButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.testButton.Name = "apiTestButton";
            this.testButton.Size = new System.Drawing.Size(57, 22);
            this.testButton.Text = "Tester";
            this.testButton.Click += new System.EventHandler(this.apiTestButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // apiTestLabel
            // 
            this.apiTestLabel.Image = global::Gui.Properties.Resources.Question;
            this.apiTestLabel.Name = "apiTestLabel";
            this.apiTestLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.keyTextBox);
            this.panel1.Controls.Add(this.apiKeyLabel);
            this.panel1.Controls.Add(this.baseUriTextBox);
            this.panel1.Controls.Add(this.apiUrlLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 86);
            this.panel1.TabIndex = 16;
            // 
            // apiKeyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Location = new System.Drawing.Point(115, 49);
            this.keyTextBox.Name = "apiKeyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(233, 23);
            this.keyTextBox.TabIndex = 14;
            this.keyTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(48, 52);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(61, 15);
            this.apiKeyLabel.TabIndex = 15;
            this.apiKeyLabel.Text = "Clé d\'API :";
            // 
            // apiBaseUriTextBox
            // 
            this.baseUriTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseUriTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "ApiBaseUri", true));
            this.baseUriTextBox.Location = new System.Drawing.Point(115, 14);
            this.baseUriTextBox.Name = "apiBaseUriTextBox";
            this.baseUriTextBox.PlaceholderText = "http://localhost/api/";
            this.baseUriTextBox.Size = new System.Drawing.Size(233, 23);
            this.baseUriTextBox.TabIndex = 12;
            this.baseUriTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.baseUriTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.uriTextBox_Validating);
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(Core.Properties.Settings);
            // 
            // apiUrlLabel
            // 
            this.apiUrlLabel.AutoSize = true;
            this.apiUrlLabel.Location = new System.Drawing.Point(12, 17);
            this.apiUrlLabel.Name = "apiUrlLabel";
            this.apiUrlLabel.Size = new System.Drawing.Size(97, 15);
            this.apiUrlLabel.TabIndex = 13;
            this.apiUrlLabel.Text = "Adresse de l\'API :";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // APISettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.toolStripContainer1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 150);
            this.Name = "APISettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres serveur";
            this.Load += new System.EventHandler(this.APISettingsForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip;
        private ToolStripButton saveButton;
        private ToolStripButton testButton;
        private TextBox keyTextBox;
        private TextBox baseUriTextBox;
        private Label apiUrlLabel;
        private Label apiKeyLabel;
        private Panel panel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel apiTestLabel;
        private ErrorProvider errorProvider;
        public BindingSource settingsBindingSource;
    }
}