namespace Gui
{
    partial class PreferencesForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.changelogsButton);
            this.tabPage3.Controls.Add(this.lastUpdateLabel);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.lastUpdatePollLabel);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.autoUpdateCheckbox);
            this.tabPage3.Controls.Add(this.apiVersionLabel);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.pollUpdateButton);
            this.tabPage3.Controls.Add(this.versionLabel);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(664, 368);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Mise à jour";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.label10.Location = new System.Drawing.Point(186, 64);
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
            this.label9.Location = new System.Drawing.Point(192, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Dernière recherche :";
            // 
            // autoUpdateCheckbox
            // 
            this.autoUpdateCheckbox.AutoSize = true;
            this.autoUpdateCheckbox.Location = new System.Drawing.Point(266, 111);
            this.autoUpdateCheckbox.Name = "autoUpdateCheckbox";
            this.autoUpdateCheckbox.Size = new System.Drawing.Size(155, 19);
            this.autoUpdateCheckbox.TabIndex = 5;
            this.autoUpdateCheckbox.Text = "Mise à jour automatique";
            this.autoUpdateCheckbox.UseVisualStyleBackColor = true;
            // 
            // apiVersionLabel
            // 
            this.apiVersionLabel.AutoSize = true;
            this.apiVersionLabel.Location = new System.Drawing.Point(113, 42);
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
            this.label6.Location = new System.Drawing.Point(13, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Version de l\'API :";
            // 
            // pollUpdateButton
            // 
            this.pollUpdateButton.Image = global::Gui.Properties.Resources.Synchronize;
            this.pollUpdateButton.Location = new System.Drawing.Point(201, 11);
            this.pollUpdateButton.Name = "pollUpdateButton";
            this.pollUpdateButton.Size = new System.Drawing.Size(217, 23);
            this.pollUpdateButton.TabIndex = 2;
            this.pollUpdateButton.Text = "Rechercher des mises à jour";
            this.pollUpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pollUpdateButton.UseVisualStyleBackColor = true;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(113, 18);
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
            this.label4.Location = new System.Drawing.Point(56, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Version :";
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 396);
            this.Controls.Add(this.tabControl1);
            this.Name = "PreferencesForm";
            this.Text = "PreferencesForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage3;
        private Button changelogsButton;
        private Label lastUpdateLabel;
        private Label label10;
        private Label lastUpdatePollLabel;
        private Label label9;
        private CheckBox autoUpdateCheckbox;
        private Label apiVersionLabel;
        private Label label6;
        private Button pollUpdateButton;
        private Label versionLabel;
        private Label label4;
    }
}