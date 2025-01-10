using System.Windows.Forms;

namespace UAssetGUI
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openContainersToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            mapStructTypeOverridesToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            expandAllToolStripMenuItem = new ToolStripMenuItem();
            collapseAllToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            recalculateNodesToolStripMenuItem = new ToolStripMenuItem();
            utilsToolStripMenuItem = new ToolStripMenuItem();
            importMappingsToolStripMenuItem = new ToolStripMenuItem();
            extractIOStoreToolStripMenuItem = new ToolStripMenuItem();
            patchusmapWithsavVersionInfoToolStripMenuItem = new ToolStripMenuItem();
            listValidPropertiesToolStripMenuItem = new ToolStripMenuItem();
            createBlueprintToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            configDirToolStripMenuItem = new ToolStripMenuItem();
            issuesToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            apiLinkToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            columnHeader1 = new ColumnHeader();
            comboSpecifyVersion = new ComboBox();
            nameMapContext = new ContextMenuStrip(components);
            replaceAllReferencesToolStripMenuItem = new ToolStripMenuItem();
            importBinaryData = new Button();
            exportBinaryData = new Button();
            setBinaryData = new Button();
            comboSpecifyMappings = new ComboBox();
            splitContainer1 = new SplitContainer();
            treeView1 = new ColorfulTreeView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            nameMapContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, utilsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(17, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(20, 6, 0, 6);
            menuStrip1.Size = new System.Drawing.Size(2632, 69);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, openContainersToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(103, 57);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(555, 66);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // openContainersToolStripMenuItem
            // 
            openContainersToolStripMenuItem.Name = "openContainersToolStripMenuItem";
            openContainersToolStripMenuItem.Size = new System.Drawing.Size(555, 66);
            openContainersToolStripMenuItem.Text = "Open containers...";
            openContainersToolStripMenuItem.Click += openContainersToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(555, 66);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(555, 66);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, findToolStripMenuItem, mapStructTypeOverridesToolStripMenuItem, settingsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(108, 57);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new System.Drawing.Size(717, 66);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new System.Drawing.Size(717, 66);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(717, 66);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Enabled = false;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findToolStripMenuItem.Size = new System.Drawing.Size(717, 66);
            findToolStripMenuItem.Text = "Find...";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // mapStructTypeOverridesToolStripMenuItem
            // 
            mapStructTypeOverridesToolStripMenuItem.Name = "mapStructTypeOverridesToolStripMenuItem";
            mapStructTypeOverridesToolStripMenuItem.Size = new System.Drawing.Size(717, 66);
            mapStructTypeOverridesToolStripMenuItem.Text = "Edit map struct type overrides...";
            mapStructTypeOverridesToolStripMenuItem.Click += mapStructTypeOverridesToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(717, 66);
            settingsToolStripMenuItem.Text = "Settings...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { expandAllToolStripMenuItem, collapseAllToolStripMenuItem, refreshToolStripMenuItem, recalculateNodesToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(124, 57);
            viewToolStripMenuItem.Text = "View";
            // 
            // expandAllToolStripMenuItem
            // 
            expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            expandAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M;
            expandAllToolStripMenuItem.Size = new System.Drawing.Size(663, 66);
            expandAllToolStripMenuItem.Text = "Expand All";
            expandAllToolStripMenuItem.Click += expandAllToolStripMenuItem_Click;
            // 
            // collapseAllToolStripMenuItem
            // 
            collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            collapseAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            collapseAllToolStripMenuItem.Size = new System.Drawing.Size(663, 66);
            collapseAllToolStripMenuItem.Text = "Collapse All";
            collapseAllToolStripMenuItem.Click += collapseAllToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshToolStripMenuItem.Size = new System.Drawing.Size(663, 66);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // recalculateNodesToolStripMenuItem
            // 
            recalculateNodesToolStripMenuItem.Name = "recalculateNodesToolStripMenuItem";
            recalculateNodesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            recalculateNodesToolStripMenuItem.Size = new System.Drawing.Size(663, 66);
            recalculateNodesToolStripMenuItem.Text = "Recalculate Nodes";
            recalculateNodesToolStripMenuItem.Click += refreshFullToolStripMenuItem_Click;
            // 
            // utilsToolStripMenuItem
            // 
            utilsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importMappingsToolStripMenuItem, extractIOStoreToolStripMenuItem, patchusmapWithsavVersionInfoToolStripMenuItem, listValidPropertiesToolStripMenuItem, createBlueprintToolStripMenuItem });
            utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            utilsToolStripMenuItem.Size = new System.Drawing.Size(118, 57);
            utilsToolStripMenuItem.Text = "Utils";
            // 
            // importMappingsToolStripMenuItem
            // 
            importMappingsToolStripMenuItem.Name = "importMappingsToolStripMenuItem";
            importMappingsToolStripMenuItem.Size = new System.Drawing.Size(791, 66);
            importMappingsToolStripMenuItem.Text = "Import mappings...";
            importMappingsToolStripMenuItem.Click += importMappingsToolStripMenuItem_Click;
            // 
            // extractIOStoreToolStripMenuItem
            // 
            extractIOStoreToolStripMenuItem.Name = "extractIOStoreToolStripMenuItem";
            extractIOStoreToolStripMenuItem.Size = new System.Drawing.Size(791, 66);
            extractIOStoreToolStripMenuItem.Text = "Extract IO store container...";
            extractIOStoreToolStripMenuItem.Click += extractIOStoreToolStripMenuItem_Click;
            // 
            // patchusmapWithsavVersionInfoToolStripMenuItem
            // 
            patchusmapWithsavVersionInfoToolStripMenuItem.Name = "patchusmapWithsavVersionInfoToolStripMenuItem";
            patchusmapWithsavVersionInfoToolStripMenuItem.Size = new System.Drawing.Size(791, 66);
            patchusmapWithsavVersionInfoToolStripMenuItem.Text = "Patch .usmap with .sav version info...";
            patchusmapWithsavVersionInfoToolStripMenuItem.Click += patchusmapWithsavVersionInfoToolStripMenuItem_Click;
            // 
            // listValidPropertiesToolStripMenuItem
            // 
            listValidPropertiesToolStripMenuItem.Name = "listValidPropertiesToolStripMenuItem";
            listValidPropertiesToolStripMenuItem.Size = new System.Drawing.Size(791, 66);
            listValidPropertiesToolStripMenuItem.Text = "Dump serializable properties...";
            listValidPropertiesToolStripMenuItem.Click += listValidPropertiesToolStripMenuItem_Click;
            // 
            // createBlueprintToolStripMenuItem
            // 
            createBlueprintToolStripMenuItem.Name = "createBlueprintToolStripMenuItem";
            createBlueprintToolStripMenuItem.Size = new System.Drawing.Size(791, 66);
            createBlueprintToolStripMenuItem.Text = "Create Blueprint";
            createBlueprintToolStripMenuItem.Click += createBlueprintToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configDirToolStripMenuItem, issuesToolStripMenuItem, githubToolStripMenuItem, apiLinkToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(123, 57);
            helpToolStripMenuItem.Text = "Help";
            // 
            // configDirToolStripMenuItem
            // 
            configDirToolStripMenuItem.Name = "configDirToolStripMenuItem";
            configDirToolStripMenuItem.Size = new System.Drawing.Size(590, 66);
            configDirToolStripMenuItem.Text = "Open config directory...";
            configDirToolStripMenuItem.Click += configDirToolStripMenuItem_Click;
            // 
            // issuesToolStripMenuItem
            // 
            issuesToolStripMenuItem.Name = "issuesToolStripMenuItem";
            issuesToolStripMenuItem.Size = new System.Drawing.Size(590, 66);
            issuesToolStripMenuItem.Text = "Give feedback";
            issuesToolStripMenuItem.Click += issuesToolStripMenuItem_Click;
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new System.Drawing.Size(590, 66);
            githubToolStripMenuItem.Text = "UAssetGUI on GitHub";
            githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
            // 
            // apiLinkToolStripMenuItem1
            // 
            apiLinkToolStripMenuItem1.Name = "apiLinkToolStripMenuItem1";
            apiLinkToolStripMenuItem1.Size = new System.Drawing.Size(590, 66);
            apiLinkToolStripMenuItem1.Text = "UAssetAPI on GitHub";
            apiLinkToolStripMenuItem1.Click += apiLinkToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(211, 211, 211);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Margin = new Padding(11, 10, 11, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.Size = new System.Drawing.Size(1452, 1554);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridClickCell;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            dataGridView1.CellValueChanged += dataGridEditCell;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 200;
            // 
            // comboSpecifyVersion
            // 
            comboSpecifyVersion.DrawMode = DrawMode.OwnerDrawFixed;
            comboSpecifyVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSpecifyVersion.FlatStyle = FlatStyle.Flat;
            comboSpecifyVersion.FormattingEnabled = true;
            comboSpecifyVersion.Location = new System.Drawing.Point(2411, 10);
            comboSpecifyVersion.Margin = new Padding(11, 10, 11, 10);
            comboSpecifyVersion.Name = "comboSpecifyVersion";
            comboSpecifyVersion.Size = new System.Drawing.Size(247, 56);
            comboSpecifyVersion.TabIndex = 3;
            comboSpecifyVersion.DrawItem += comboSpecifyVersion_DrawItem;
            comboSpecifyVersion.SelectedIndexChanged += comboSpecifyVersion_SelectedIndexChanged;
            // 
            // nameMapContext
            // 
            nameMapContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            nameMapContext.Items.AddRange(new ToolStripItem[] { replaceAllReferencesToolStripMenuItem });
            nameMapContext.Name = "treeNodeContext";
            nameMapContext.Size = new System.Drawing.Size(470, 60);
            // 
            // replaceAllReferencesToolStripMenuItem
            // 
            replaceAllReferencesToolStripMenuItem.Name = "replaceAllReferencesToolStripMenuItem";
            replaceAllReferencesToolStripMenuItem.Size = new System.Drawing.Size(469, 56);
            replaceAllReferencesToolStripMenuItem.Text = "Replace all references...";
            replaceAllReferencesToolStripMenuItem.Click += replaceAllReferencesToolStripMenuItem_Click;
            // 
            // importBinaryData
            // 
            importBinaryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            importBinaryData.Location = new System.Drawing.Point(1269, 3);
            importBinaryData.Margin = new Padding(11, 10, 11, 10);
            importBinaryData.Name = "importBinaryData";
            importBinaryData.Size = new System.Drawing.Size(251, 86);
            importBinaryData.TabIndex = 4;
            importBinaryData.Text = "Import";
            importBinaryData.UseVisualStyleBackColor = true;
            importBinaryData.Click += importBinaryData_Click;
            // 
            // exportBinaryData
            // 
            exportBinaryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            exportBinaryData.Location = new System.Drawing.Point(1540, 3);
            exportBinaryData.Margin = new Padding(11, 10, 11, 10);
            exportBinaryData.Name = "exportBinaryData";
            exportBinaryData.Size = new System.Drawing.Size(251, 86);
            exportBinaryData.TabIndex = 5;
            exportBinaryData.Text = "Export";
            exportBinaryData.UseVisualStyleBackColor = true;
            exportBinaryData.Click += exportBinaryData_Click;
            // 
            // setBinaryData
            // 
            setBinaryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            setBinaryData.Location = new System.Drawing.Point(1811, 3);
            setBinaryData.Margin = new Padding(11, 10, 11, 10);
            setBinaryData.Name = "setBinaryData";
            setBinaryData.Size = new System.Drawing.Size(251, 86);
            setBinaryData.TabIndex = 6;
            setBinaryData.Text = "Set to null...";
            setBinaryData.UseVisualStyleBackColor = true;
            setBinaryData.Click += setBinaryData_Click;
            // 
            // comboSpecifyMappings
            // 
            comboSpecifyMappings.DrawMode = DrawMode.OwnerDrawFixed;
            comboSpecifyMappings.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSpecifyMappings.FlatStyle = FlatStyle.Flat;
            comboSpecifyMappings.FormattingEnabled = true;
            comboSpecifyMappings.Location = new System.Drawing.Point(2080, 10);
            comboSpecifyMappings.Margin = new Padding(11, 10, 11, 10);
            comboSpecifyMappings.Name = "comboSpecifyMappings";
            comboSpecifyMappings.Size = new System.Drawing.Size(301, 56);
            comboSpecifyMappings.TabIndex = 3;
            comboSpecifyMappings.DrawItem += comboSpecifyVersion_DrawItem;
            comboSpecifyMappings.SelectedIndexChanged += comboSpecifyMappings_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new System.Drawing.Point(17, 88);
            splitContainer1.Margin = new Padding(11, 10, 11, 10);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new System.Drawing.Size(2632, 1554);
            splitContainer1.SplitterDistance = 1166;
            splitContainer1.SplitterWidth = 14;
            splitContainer1.TabIndex = 7;
            // 
            // treeView1
            // 
            treeView1.BackColor = System.Drawing.Color.FromArgb(211, 211, 211);
            treeView1.Dock = DockStyle.Fill;
            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView1.HideSelection = false;
            treeView1.Location = new System.Drawing.Point(0, 0);
            treeView1.Margin = new Padding(11, 10, 11, 10);
            treeView1.Name = "treeView1";
            treeView1.ShowLines = false;
            treeView1.ShowNodeToolTips = true;
            treeView1.Size = new System.Drawing.Size(1166, 1554);
            treeView1.TabIndex = 1;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.KeyDown += treeView1_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2666, 1661);
            Controls.Add(comboSpecifyMappings);
            Controls.Add(setBinaryData);
            Controls.Add(exportBinaryData);
            Controls.Add(importBinaryData);
            Controls.Add(comboSpecifyVersion);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(11, 10, 11, 10);
            Name = "Form1";
            Padding = new Padding(17, 19, 17, 19);
            Text = "UAssetGUI";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            nameMapContext.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem; 
        private ColumnHeader columnHeader1;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem recalculateNodesToolStripMenuItem;
        private ToolStripMenuItem apiLinkToolStripMenuItem1;
        private ToolStripMenuItem githubToolStripMenuItem;
        private ToolStripMenuItem replaceAllReferencesToolStripMenuItem;
        public ContextMenuStrip nameMapContext;
        private ToolStripMenuItem issuesToolStripMenuItem;
        private ToolStripMenuItem configDirToolStripMenuItem;
        private ToolStripMenuItem mapStructTypeOverridesToolStripMenuItem;
        public ComboBox comboSpecifyVersion;
        private ToolStripMenuItem settingsToolStripMenuItem;
        public Button importBinaryData;
        public Button exportBinaryData;
        public Button setBinaryData;
        internal ToolStripMenuItem saveToolStripMenuItem;
        public ComboBox comboSpecifyMappings;
        private ToolStripMenuItem listValidPropertiesToolStripMenuItem;
        private ToolStripMenuItem utilsToolStripMenuItem;
        private ToolStripMenuItem extractIOStoreToolStripMenuItem;
        private ToolStripMenuItem patchusmapWithsavVersionInfoToolStripMenuItem;
        private ToolStripMenuItem importMappingsToolStripMenuItem;
        private ToolStripMenuItem openContainersToolStripMenuItem;
        private ToolStripMenuItem createBlueprintToolStripMenuItem;
    }
}

