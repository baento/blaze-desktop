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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.apiPage = new System.Windows.Forms.TabPage();
            this.testAPIButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.changelogsButton = new System.Windows.Forms.Button();
            this.lastUpdateLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lastUpdatePollLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.autoUpdateCheckbox = new System.Windows.Forms.CheckBox();
            this.apiVersionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pollUpdateButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.apiPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiPage
            // 
            this.apiPage.Controls.Add(this.testAPIButton);
            this.apiPage.Controls.Add(this.textBox2);
            this.apiPage.Controls.Add(this.textBox1);
            this.apiPage.Controls.Add(this.label1);
            this.apiPage.Controls.Add(this.label2);
            this.apiPage.Location = new System.Drawing.Point(4, 24);
            this.apiPage.Name = "apiPage";
            this.apiPage.Padding = new System.Windows.Forms.Padding(3);
            this.apiPage.Size = new System.Drawing.Size(426, 133);
            this.apiPage.TabIndex = 0;
            this.apiPage.Text = "API";
            this.apiPage.UseVisualStyleBackColor = true;
            // 
            // testAPIButton
            // 
            this.testAPIButton.Image = global::Gui.Properties.Resources.Test_16x;
            this.testAPIButton.Location = new System.Drawing.Point(343, 104);
            this.testAPIButton.Name = "testAPIButton";
            this.testAPIButton.Size = new System.Drawing.Size(75, 23);
            this.testAPIButton.TabIndex = 8;
            this.testAPIButton.Text = "Tester";
            this.testAPIButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.testAPIButton.UseVisualStyleBackColor = true;
            this.testAPIButton.Click += new System.EventHandler(this.testAPIButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "http://localhost/api";
            this.textBox1.Size = new System.Drawing.Size(327, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adresse API :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clé d\'API :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalPage);
            this.tabControl1.Controls.Add(this.apiPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 161);
            this.tabControl1.TabIndex = 10;
            // 
            // generalPage
            // 
            this.generalPage.Location = new System.Drawing.Point(4, 24);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(426, 133);
            this.generalPage.TabIndex = 1;
            this.generalPage.Text = "Général";
            this.generalPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.changelogsButton);
            this.tabPage1.Controls.Add(this.lastUpdateLabel);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lastUpdatePollLabel);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.autoUpdateCheckbox);
            this.tabPage1.Controls.Add(this.apiVersionLabel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pollUpdateButton);
            this.tabPage1.Controls.Add(this.versionLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 133);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Mise à jour";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // changelogsButton
            // 
            this.changelogsButton.Location = new System.Drawing.Point(6, 104);
            this.changelogsButton.Name = "changelogsButton";
            this.changelogsButton.Size = new System.Drawing.Size(164, 23);
            this.changelogsButton.TabIndex = 10;
            this.changelogsButton.Text = "Journal des changements";
            this.changelogsButton.UseVisualStyleBackColor = true;
            // 
            // lastUpdateLabel
            // 
            this.lastUpdateLabel.Location = new System.Drawing.Point(307, 61);
            this.lastUpdateLabel.Name = "lastUpdateLabel";
            this.lastUpdateLabel.Size = new System.Drawing.Size(111, 15);
            this.lastUpdateLabel.TabIndex = 9;
            this.lastUpdateLabel.Text = "01/01/1970 00:00:00";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Dernière mise à jour :";
            // 
            // lastUpdatePollLabel
            // 
            this.lastUpdatePollLabel.Location = new System.Drawing.Point(307, 39);
            this.lastUpdatePollLabel.Name = "lastUpdatePollLabel";
            this.lastUpdatePollLabel.Size = new System.Drawing.Size(111, 15);
            this.lastUpdatePollLabel.TabIndex = 7;
            this.lastUpdatePollLabel.Text = "01/01/1970 00:00:00";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Dernière recherche :";
            // 
            // autoUpdateCheckbox
            // 
            this.autoUpdateCheckbox.AutoSize = true;
            this.autoUpdateCheckbox.Location = new System.Drawing.Point(263, 108);
            this.autoUpdateCheckbox.Name = "autoUpdateCheckbox";
            this.autoUpdateCheckbox.Size = new System.Drawing.Size(155, 19);
            this.autoUpdateCheckbox.TabIndex = 5;
            this.autoUpdateCheckbox.Text = "Mise à jour automatique";
            this.autoUpdateCheckbox.UseVisualStyleBackColor = true;
            this.autoUpdateCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // apiVersionLabel
            // 
            this.apiVersionLabel.AutoSize = true;
            this.apiVersionLabel.Location = new System.Drawing.Point(110, 39);
            this.apiVersionLabel.Name = "apiVersionLabel";
            this.apiVersionLabel.Size = new System.Drawing.Size(31, 15);
            this.apiVersionLabel.TabIndex = 4;
            this.apiVersionLabel.Text = "1.0.0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Version de l\'API :";
            // 
            // pollUpdateButton
            // 
            this.pollUpdateButton.Image = global::Gui.Properties.Resources.Synchronize_16x;
            this.pollUpdateButton.Location = new System.Drawing.Point(201, 11);
            this.pollUpdateButton.Name = "pollUpdateButton";
            this.pollUpdateButton.Size = new System.Drawing.Size(217, 23);
            this.pollUpdateButton.TabIndex = 2;
            this.pollUpdateButton.Text = "Rechercher des mises à jour";
            this.pollUpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pollUpdateButton.UseVisualStyleBackColor = true;
            this.pollUpdateButton.Click += new System.EventHandler(this.pollUpdateButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(110, 15);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(31, 15);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "1.0.0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Version :";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(434, 161);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(434, 186);
            this.toolStripContainer1.TabIndex = 12;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(434, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // enregistrerToolStripButton
            // 
            this.enregistrerToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.enregistrerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripButton.Image")));
            this.enregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripButton.Name = "enregistrerToolStripButton";
            this.enregistrerToolStripButton.Size = new System.Drawing.Size(83, 22);
            this.enregistrerToolStripButton.Text = "Enre&gistrer";
            this.enregistrerToolStripButton.Click += new System.EventHandler(this.enregistrerToolStripButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Controls.Add(this.toolStripContainer1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 225);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.apiPage.ResumeLayout(false);
            this.apiPage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage apiPage;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private Button testAPIButton;
        private TabPage generalPage;
        private TabPage tabPage1;
        private Label label4;
        private CheckBox autoUpdateCheckbox;
        private Label apiVersionLabel;
        private Label label6;
        private Button pollUpdateButton;
        private Label versionLabel;
        private Label lastUpdatePollLabel;
        private Label label9;
        private Label lastUpdateLabel;
        private Label label10;
        private Button changelogsButton;
        private ToolStripButton enregistrerToolStripButton;
    }
}