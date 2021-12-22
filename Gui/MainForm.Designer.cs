namespace Gui
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerLaBaseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchroniserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDeletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupUsers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GroupCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDeletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::Gui.Properties.Resources.CheckDot;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "Non connecté";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.baseToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem,
            this.fermerLaBaseToolStripMenuItem2,
            this.toolStripSeparator3,
            this.paramètresToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem1});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirLaBaseDeDonnéesToolStripMenuItem
            // 
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.Name = "ouvrirLaBaseDeDonnéesToolStripMenuItem";
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.Text = "Connexion à la base";
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.Click += new System.EventHandler(this.ouvrirLaBaseDeDonnéesToolStripMenuItem_Click);
            // 
            // fermerLaBaseToolStripMenuItem2
            // 
            this.fermerLaBaseToolStripMenuItem2.Enabled = false;
            this.fermerLaBaseToolStripMenuItem2.Name = "fermerLaBaseToolStripMenuItem2";
            this.fermerLaBaseToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.fermerLaBaseToolStripMenuItem2.Text = "Fermer la base";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Image = global::Gui.Properties.Resources.Settings;
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // baseToolStripMenuItem
            // 
            this.baseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.synchroniserToolStripMenuItem});
            this.baseToolStripMenuItem.Enabled = false;
            this.baseToolStripMenuItem.Name = "baseToolStripMenuItem";
            this.baseToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.baseToolStripMenuItem.Text = "Base";
            // 
            // synchroniserToolStripMenuItem
            // 
            this.synchroniserToolStripMenuItem.Image = global::Gui.Properties.Resources.Synchronize;
            this.synchroniserToolStripMenuItem.Name = "synchroniserToolStripMenuItem";
            this.synchroniserToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.synchroniserToolStripMenuItem.Text = "Synchroniser";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 404);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tableau de bord";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ressources";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(786, 370);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 342);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Utilisateurs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserHandle,
            this.UserLastName,
            this.UserFirstName,
            this.UserINE,
            this.UserCreationDate,
            this.UserUpdateDate,
            this.UserDeletionDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(772, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "Id";
            this.UserId.HeaderText = "Identifiant";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 146;
            // 
            // UserHandle
            // 
            this.UserHandle.DataPropertyName = "Handle";
            this.UserHandle.HeaderText = "Nom d\'utilisateur";
            this.UserHandle.Name = "UserHandle";
            this.UserHandle.ReadOnly = true;
            this.UserHandle.Width = 146;
            // 
            // UserLastName
            // 
            this.UserLastName.DataPropertyName = "LastName";
            this.UserLastName.HeaderText = "Nom";
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.Width = 145;
            // 
            // UserFirstName
            // 
            this.UserFirstName.DataPropertyName = "FirstName";
            this.UserFirstName.HeaderText = "Prénom";
            this.UserFirstName.Name = "UserFirstName";
            this.UserFirstName.Width = 146;
            // 
            // UserINE
            // 
            this.UserINE.HeaderText = "INE";
            this.UserINE.Name = "UserINE";
            this.UserINE.ReadOnly = true;
            this.UserINE.Width = 146;
            // 
            // UserCreationDate
            // 
            this.UserCreationDate.DataPropertyName = "CreationDate";
            this.UserCreationDate.HeaderText = "Date de création";
            this.UserCreationDate.Name = "UserCreationDate";
            // 
            // UserUpdateDate
            // 
            this.UserUpdateDate.DataPropertyName = "UpdateDate";
            this.UserUpdateDate.HeaderText = "Date de mise à jour";
            this.UserUpdateDate.Name = "UserUpdateDate";
            // 
            // UserDeletionDate
            // 
            this.UserDeletionDate.DataPropertyName = "DeletionDate";
            this.UserDeletionDate.HeaderText = "Date de suppression";
            this.UserDeletionDate.Name = "UserDeletionDate";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(778, 342);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Groupes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(772, 336);
            this.splitContainer1.SplitterDistance = 513;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.GroupHandle,
            this.GroupUsers,
            this.GroupCreationDate,
            this.GroupUpdateDate,
            this.GroupDeletionDate});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(513, 336);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // GroupId
            // 
            this.GroupId.DataPropertyName = "Id";
            this.GroupId.HeaderText = "Identifiant";
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            // 
            // GroupHandle
            // 
            this.GroupHandle.DataPropertyName = "Handle";
            this.GroupHandle.HeaderText = "Nom";
            this.GroupHandle.Name = "GroupHandle";
            this.GroupHandle.ReadOnly = true;
            // 
            // GroupUsers
            // 
            this.GroupUsers.HeaderText = "Utilisateurs";
            this.GroupUsers.Name = "GroupUsers";
            this.GroupUsers.ReadOnly = true;
            this.GroupUsers.Text = "...";
            // 
            // GroupCreationDate
            // 
            this.GroupCreationDate.DataPropertyName = "CreationDate";
            this.GroupCreationDate.HeaderText = "Date de création";
            this.GroupCreationDate.Name = "GroupCreationDate";
            this.GroupCreationDate.ReadOnly = true;
            // 
            // GroupUpdateDate
            // 
            this.GroupUpdateDate.DataPropertyName = "UpdateDate";
            this.GroupUpdateDate.HeaderText = "Dernière mise à jour";
            this.GroupUpdateDate.Name = "GroupUpdateDate";
            this.GroupUpdateDate.ReadOnly = true;
            // 
            // GroupDeletionDate
            // 
            this.GroupDeletionDate.DataPropertyName = "DeletionDate";
            this.GroupDeletionDate.HeaderText = "Date de suppression";
            this.GroupDeletionDate.Name = "GroupDeletionDate";
            this.GroupDeletionDate.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 314);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(778, 342);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Salles";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(778, 342);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Enseignements";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(792, 376);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Emplois du temps";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blaze Desktop";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem ouvrirLaBaseDeDonnéesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem paramètresToolStripMenuItem;
        private ToolStripMenuItem fermerLaBaseToolStripMenuItem2;
        private ToolStripMenuItem quitterToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private ToolStripMenuItem baseToolStripMenuItem;
        private ToolStripMenuItem synchroniserToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem testToolStripMenuItem;

        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserHandle;
        private DataGridViewTextBoxColumn UserLastName;
        private DataGridViewTextBoxColumn UserFirstName;
        private DataGridViewTextBoxColumn UserINE;
        private DataGridViewTextBoxColumn UserCreationDate;
        private DataGridViewTextBoxColumn UserUpdateDate;
        private DataGridViewTextBoxColumn UserDeletionDate;
        private DataGridViewTextBoxColumn GroupId;
        private DataGridViewTextBoxColumn GroupHandle;
        private DataGridViewButtonColumn GroupUsers;
        private DataGridViewTextBoxColumn GroupCreationDate;
        private DataGridViewTextBoxColumn GroupUpdateDate;
        private DataGridViewTextBoxColumn GroupDeletionDate;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ListBox listBox1;
    }
}