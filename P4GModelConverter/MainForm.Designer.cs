﻿namespace P4GModelConverter
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Extract = new System.Windows.Forms.Button();
            this.btn_CreateGMO = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.chkBox_ExtractTex = new System.Windows.Forms.CheckBox();
            this.chkBox_Animations = new System.Windows.Forms.CheckBox();
            this.lbl_AnimationsLoaded = new System.Windows.Forms.Label();
            this.btn_ExportAnim = new System.Windows.Forms.Button();
            this.btn_ImportAnim = new System.Windows.Forms.Button();
            this.chkBox_Dummy = new System.Windows.Forms.CheckBox();
            this.lbl_WpnBone = new System.Windows.Forms.Label();
            this.txt_WpnBone = new System.Windows.Forms.TextBox();
            this.chkBox_FBXtoGMO = new System.Windows.Forms.CheckBox();
            this.chkBox_PCFix = new System.Windows.Forms.CheckBox();
            this.chkBox_ViewGMO = new System.Windows.Forms.CheckBox();
            this.chkBox_RenameBones = new System.Windows.Forms.CheckBox();
            this.panel_FBX_GMO = new System.Windows.Forms.Panel();
            this.chkBox_fbxascii = new System.Windows.Forms.CheckBox();
            this.chkBox_fbxoldexport = new System.Windows.Forms.CheckBox();
            this.chkBox_FBXOptimize = new System.Windows.Forms.CheckBox();
            this.chkBox_AutoConvertTex = new System.Windows.Forms.CheckBox();
            this.panel_MDS = new System.Windows.Forms.Panel();
            this.comboBox_Preview = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.comboBox_Preset = new System.Windows.Forms.ComboBox();
            this.dataGridView_AnimationOrder = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_Animations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBox_AutoUpdate = new System.Windows.Forms.CheckBox();
            this.btn_FixMDS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_NoesisOptions = new System.Windows.Forms.TextBox();
            this.toolStripTextBox_Rename = new System.Windows.Forms.ToolStripTextBox();
            this.panel_FBX_GMO.SuspendLayout();
            this.panel_MDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AnimationOrder)).BeginInit();
            this.contextMenuStrip_Animations.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Extract
            // 
            this.btn_Extract.AllowDrop = true;
            this.btn_Extract.Location = new System.Drawing.Point(7, 3);
            this.btn_Extract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Extract.Name = "btn_Extract";
            this.btn_Extract.Size = new System.Drawing.Size(200, 172);
            this.btn_Extract.TabIndex = 0;
            this.btn_Extract.Text = "Generate MDS\r\nfrom Model";
            this.btn_Extract.UseVisualStyleBackColor = true;
            this.btn_Extract.Click += new System.EventHandler(this.btn_Extract_Click);
            this.btn_Extract.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_Extract_DragDrop);
            this.btn_Extract.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_Extract_DragEnter);
            // 
            // btn_CreateGMO
            // 
            this.btn_CreateGMO.AllowDrop = true;
            this.btn_CreateGMO.Location = new System.Drawing.Point(423, 3);
            this.btn_CreateGMO.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CreateGMO.Name = "btn_CreateGMO";
            this.btn_CreateGMO.Size = new System.Drawing.Size(200, 172);
            this.btn_CreateGMO.TabIndex = 1;
            this.btn_CreateGMO.Text = "Generate new GMO\r\nfrom MDS\r\n";
            this.btn_CreateGMO.UseVisualStyleBackColor = true;
            this.btn_CreateGMO.Click += new System.EventHandler(this.btn_Create_Click);
            this.btn_CreateGMO.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_Create_DragDrop);
            this.btn_CreateGMO.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_Create_DragEnter);
            // 
            // btn_Up
            // 
            this.btn_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_Up.Location = new System.Drawing.Point(933, 4);
            this.btn_Up.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(40, 135);
            this.btn_Up.TabIndex = 4;
            this.btn_Up.Text = "↑";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_Down.Location = new System.Drawing.Point(933, 145);
            this.btn_Down.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(40, 135);
            this.btn_Down.TabIndex = 5;
            this.btn_Down.Text = "↓";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // chkBox_ExtractTex
            // 
            this.chkBox_ExtractTex.AutoSize = true;
            this.chkBox_ExtractTex.Checked = true;
            this.chkBox_ExtractTex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_ExtractTex.Location = new System.Drawing.Point(4, 132);
            this.chkBox_ExtractTex.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_ExtractTex.Name = "chkBox_ExtractTex";
            this.chkBox_ExtractTex.Size = new System.Drawing.Size(167, 21);
            this.chkBox_ExtractTex.TabIndex = 11;
            this.chkBox_ExtractTex.Text = "Extract TIM2 Textures";
            this.chkBox_ExtractTex.UseVisualStyleBackColor = true;
            // 
            // chkBox_Animations
            // 
            this.chkBox_Animations.AutoSize = true;
            this.chkBox_Animations.Location = new System.Drawing.Point(4, 66);
            this.chkBox_Animations.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_Animations.Name = "chkBox_Animations";
            this.chkBox_Animations.Size = new System.Drawing.Size(135, 21);
            this.chkBox_Animations.TabIndex = 8;
            this.chkBox_Animations.Text = "Load Animations";
            this.chkBox_Animations.UseVisualStyleBackColor = true;
            this.chkBox_Animations.CheckedChanged += new System.EventHandler(this.chkBox_Animations_CheckedChanged);
            // 
            // lbl_AnimationsLoaded
            // 
            this.lbl_AnimationsLoaded.AutoSize = true;
            this.lbl_AnimationsLoaded.Location = new System.Drawing.Point(822, 315);
            this.lbl_AnimationsLoaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AnimationsLoaded.Name = "lbl_AnimationsLoaded";
            this.lbl_AnimationsLoaded.Size = new System.Drawing.Size(151, 17);
            this.lbl_AnimationsLoaded.TabIndex = 8;
            this.lbl_AnimationsLoaded.Text = "No Animations Loaded";
            // 
            // btn_ExportAnim
            // 
            this.btn_ExportAnim.AllowDrop = true;
            this.btn_ExportAnim.Enabled = false;
            this.btn_ExportAnim.Location = new System.Drawing.Point(822, 284);
            this.btn_ExportAnim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExportAnim.Name = "btn_ExportAnim";
            this.btn_ExportAnim.Size = new System.Drawing.Size(73, 29);
            this.btn_ExportAnim.TabIndex = 6;
            this.btn_ExportAnim.Text = "Export";
            this.btn_ExportAnim.UseVisualStyleBackColor = true;
            this.btn_ExportAnim.Click += new System.EventHandler(this.btn_ExportAnim_Click);
            // 
            // btn_ImportAnim
            // 
            this.btn_ImportAnim.AllowDrop = true;
            this.btn_ImportAnim.Enabled = false;
            this.btn_ImportAnim.Location = new System.Drawing.Point(900, 284);
            this.btn_ImportAnim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ImportAnim.Name = "btn_ImportAnim";
            this.btn_ImportAnim.Size = new System.Drawing.Size(73, 29);
            this.btn_ImportAnim.TabIndex = 7;
            this.btn_ImportAnim.Text = "Import";
            this.btn_ImportAnim.UseVisualStyleBackColor = true;
            this.btn_ImportAnim.Click += new System.EventHandler(this.btn_ImportAnim_Click);
            // 
            // chkBox_Dummy
            // 
            this.chkBox_Dummy.AutoSize = true;
            this.chkBox_Dummy.Location = new System.Drawing.Point(4, 45);
            this.chkBox_Dummy.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_Dummy.Name = "chkBox_Dummy";
            this.chkBox_Dummy.Size = new System.Drawing.Size(167, 21);
            this.chkBox_Dummy.TabIndex = 12;
            this.chkBox_Dummy.Text = "Use Dummy Materials";
            this.chkBox_Dummy.UseVisualStyleBackColor = true;
            this.chkBox_Dummy.CheckedChanged += new System.EventHandler(this.chkBox_Dummy_CheckedChanged);
            // 
            // lbl_WpnBone
            // 
            this.lbl_WpnBone.AutoSize = true;
            this.lbl_WpnBone.Location = new System.Drawing.Point(1, 125);
            this.lbl_WpnBone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_WpnBone.Name = "lbl_WpnBone";
            this.lbl_WpnBone.Size = new System.Drawing.Size(143, 17);
            this.lbl_WpnBone.TabIndex = 14;
            this.lbl_WpnBone.Text = "Weapon Bone Name:";
            // 
            // txt_WpnBone
            // 
            this.txt_WpnBone.Location = new System.Drawing.Point(4, 145);
            this.txt_WpnBone.Name = "txt_WpnBone";
            this.txt_WpnBone.Size = new System.Drawing.Size(149, 22);
            this.txt_WpnBone.TabIndex = 15;
            this.txt_WpnBone.Text = "Bip01_L_Hand_Bone";
            // 
            // chkBox_FBXtoGMO
            // 
            this.chkBox_FBXtoGMO.AutoSize = true;
            this.chkBox_FBXtoGMO.Location = new System.Drawing.Point(4, 112);
            this.chkBox_FBXtoGMO.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_FBXtoGMO.Name = "chkBox_FBXtoGMO";
            this.chkBox_FBXtoGMO.Size = new System.Drawing.Size(162, 21);
            this.chkBox_FBXtoGMO.TabIndex = 10;
            this.chkBox_FBXtoGMO.Text = "Convert FBX to GMO\r\n";
            this.chkBox_FBXtoGMO.UseVisualStyleBackColor = true;
            // 
            // chkBox_PCFix
            // 
            this.chkBox_PCFix.AutoSize = true;
            this.chkBox_PCFix.Checked = true;
            this.chkBox_PCFix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_PCFix.Location = new System.Drawing.Point(4, 5);
            this.chkBox_PCFix.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_PCFix.Name = "chkBox_PCFix";
            this.chkBox_PCFix.Size = new System.Drawing.Size(174, 21);
            this.chkBox_PCFix.TabIndex = 9;
            this.chkBox_PCFix.Text = "Fix Output GMO for PC";
            this.chkBox_PCFix.UseVisualStyleBackColor = true;
            // 
            // chkBox_ViewGMO
            // 
            this.chkBox_ViewGMO.AutoSize = true;
            this.chkBox_ViewGMO.Location = new System.Drawing.Point(4, 25);
            this.chkBox_ViewGMO.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_ViewGMO.Name = "chkBox_ViewGMO";
            this.chkBox_ViewGMO.Size = new System.Drawing.Size(164, 21);
            this.chkBox_ViewGMO.TabIndex = 13;
            this.chkBox_ViewGMO.Text = "Preview New GMO w/";
            this.chkBox_ViewGMO.UseVisualStyleBackColor = true;
            this.chkBox_ViewGMO.CheckedChanged += new System.EventHandler(this.chkBox_ViewGMO_CheckedChanged);
            // 
            // chkBox_RenameBones
            // 
            this.chkBox_RenameBones.AutoSize = true;
            this.chkBox_RenameBones.Location = new System.Drawing.Point(4, 25);
            this.chkBox_RenameBones.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_RenameBones.Name = "chkBox_RenameBones";
            this.chkBox_RenameBones.Size = new System.Drawing.Size(173, 21);
            this.chkBox_RenameBones.TabIndex = 16;
            this.chkBox_RenameBones.Text = "Reformat Bone Names";
            this.chkBox_RenameBones.UseVisualStyleBackColor = true;
            // 
            // panel_FBX_GMO
            // 
            this.panel_FBX_GMO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_FBX_GMO.Controls.Add(this.txtBox_NoesisOptions);
            this.panel_FBX_GMO.Controls.Add(this.label1);
            this.panel_FBX_GMO.Controls.Add(this.chkBox_fbxascii);
            this.panel_FBX_GMO.Controls.Add(this.chkBox_fbxoldexport);
            this.panel_FBX_GMO.Controls.Add(this.chkBox_FBXOptimize);
            this.panel_FBX_GMO.Controls.Add(this.chkBox_FBXtoGMO);
            this.panel_FBX_GMO.Controls.Add(this.chkBox_ExtractTex);
            this.panel_FBX_GMO.Location = new System.Drawing.Point(7, 182);
            this.panel_FBX_GMO.Name = "panel_FBX_GMO";
            this.panel_FBX_GMO.Size = new System.Drawing.Size(200, 183);
            this.panel_FBX_GMO.TabIndex = 17;
            // 
            // chkBox_fbxascii
            // 
            this.chkBox_fbxascii.AutoSize = true;
            this.chkBox_fbxascii.Enabled = false;
            this.chkBox_fbxascii.Location = new System.Drawing.Point(4, 45);
            this.chkBox_fbxascii.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_fbxascii.Name = "chkBox_fbxascii";
            this.chkBox_fbxascii.Size = new System.Drawing.Size(165, 21);
            this.chkBox_fbxascii.TabIndex = 33;
            this.chkBox_fbxascii.Text = "-fbxascii (mds output)";
            this.chkBox_fbxascii.UseVisualStyleBackColor = true;
            // 
            // chkBox_fbxoldexport
            // 
            this.chkBox_fbxoldexport.AutoSize = true;
            this.chkBox_fbxoldexport.Enabled = false;
            this.chkBox_fbxoldexport.Location = new System.Drawing.Point(4, 25);
            this.chkBox_fbxoldexport.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_fbxoldexport.Name = "chkBox_fbxoldexport";
            this.chkBox_fbxoldexport.Size = new System.Drawing.Size(186, 21);
            this.chkBox_fbxoldexport.TabIndex = 31;
            this.chkBox_fbxoldexport.Text = "-fbxoldexport (animation)";
            this.chkBox_fbxoldexport.UseVisualStyleBackColor = true;
            // 
            // chkBox_FBXOptimize
            // 
            this.chkBox_FBXOptimize.AutoSize = true;
            this.chkBox_FBXOptimize.Location = new System.Drawing.Point(4, 5);
            this.chkBox_FBXOptimize.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_FBXOptimize.Name = "chkBox_FBXOptimize";
            this.chkBox_FBXOptimize.Size = new System.Drawing.Size(189, 21);
            this.chkBox_FBXOptimize.TabIndex = 12;
            this.chkBox_FBXOptimize.Text = "Convert to FBX w/ Noesis";
            this.chkBox_FBXOptimize.UseVisualStyleBackColor = true;
            this.chkBox_FBXOptimize.CheckedChanged += new System.EventHandler(this.chkBox_FBXOptimize_CheckedChanged);
            // 
            // chkBox_AutoConvertTex
            // 
            this.chkBox_AutoConvertTex.AutoSize = true;
            this.chkBox_AutoConvertTex.Checked = true;
            this.chkBox_AutoConvertTex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_AutoConvertTex.Location = new System.Drawing.Point(4, 5);
            this.chkBox_AutoConvertTex.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_AutoConvertTex.Name = "chkBox_AutoConvertTex";
            this.chkBox_AutoConvertTex.Size = new System.Drawing.Size(186, 21);
            this.chkBox_AutoConvertTex.TabIndex = 17;
            this.chkBox_AutoConvertTex.Text = "Convert Textures to TM2";
            this.chkBox_AutoConvertTex.UseVisualStyleBackColor = true;
            // 
            // panel_MDS
            // 
            this.panel_MDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_MDS.Controls.Add(this.comboBox_Preview);
            this.panel_MDS.Controls.Add(this.chkBox_ViewGMO);
            this.panel_MDS.Controls.Add(this.chkBox_PCFix);
            this.panel_MDS.Location = new System.Drawing.Point(423, 182);
            this.panel_MDS.Name = "panel_MDS";
            this.panel_MDS.Size = new System.Drawing.Size(200, 182);
            this.panel_MDS.TabIndex = 18;
            // 
            // comboBox_Preview
            // 
            this.comboBox_Preview.AutoCompleteCustomSource.AddRange(new string[] {
            "Noesis",
            "GMOView"});
            this.comboBox_Preview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Preview.Enabled = false;
            this.comboBox_Preview.FormattingEnabled = true;
            this.comboBox_Preview.Items.AddRange(new object[] {
            "Noesis",
            "GMOView"});
            this.comboBox_Preview.Location = new System.Drawing.Point(27, 45);
            this.comboBox_Preview.Name = "comboBox_Preview";
            this.comboBox_Preview.Size = new System.Drawing.Size(124, 24);
            this.comboBox_Preview.TabIndex = 25;
            // 
            // btn_Update
            // 
            this.btn_Update.AllowDrop = true;
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(632, 284);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(182, 49);
            this.btn_Update.TabIndex = 19;
            this.btn_Update.Text = "Update MDS Animations";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // comboBox_Preset
            // 
            this.comboBox_Preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Preset.FormattingEnabled = true;
            this.comboBox_Preset.Items.AddRange(new object[] {
            "Animation Preset",
            "P4G Protag",
            "P4G Party Member",
            "P4G Persona",
            "P4G Culprit",
            "P3P Protag/Protag",
            "P3P Persona",
            "P3P Strega"});
            this.comboBox_Preset.Location = new System.Drawing.Point(632, 340);
            this.comboBox_Preset.Name = "comboBox_Preset";
            this.comboBox_Preset.Size = new System.Drawing.Size(182, 24);
            this.comboBox_Preset.TabIndex = 22;
            this.comboBox_Preset.SelectedIndexChanged += new System.EventHandler(this.comboBox_Preset_SelectedIndexChanged);
            // 
            // dataGridView_AnimationOrder
            // 
            this.dataGridView_AnimationOrder.AllowUserToAddRows = false;
            this.dataGridView_AnimationOrder.AllowUserToDeleteRows = false;
            this.dataGridView_AnimationOrder.AllowUserToResizeColumns = false;
            this.dataGridView_AnimationOrder.AllowUserToResizeRows = false;
            this.dataGridView_AnimationOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_AnimationOrder.ColumnHeadersHeight = 29;
            this.dataGridView_AnimationOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_AnimationOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.AnimationName});
            this.dataGridView_AnimationOrder.Location = new System.Drawing.Point(632, 4);
            this.dataGridView_AnimationOrder.MultiSelect = false;
            this.dataGridView_AnimationOrder.Name = "dataGridView_AnimationOrder";
            this.dataGridView_AnimationOrder.ReadOnly = true;
            this.dataGridView_AnimationOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_AnimationOrder.RowHeadersVisible = false;
            this.dataGridView_AnimationOrder.RowHeadersWidth = 25;
            this.dataGridView_AnimationOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView_AnimationOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_AnimationOrder.RowTemplate.Height = 24;
            this.dataGridView_AnimationOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_AnimationOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AnimationOrder.ShowCellErrors = false;
            this.dataGridView_AnimationOrder.ShowCellToolTips = false;
            this.dataGridView_AnimationOrder.ShowEditingIcon = false;
            this.dataGridView_AnimationOrder.ShowRowErrors = false;
            this.dataGridView_AnimationOrder.Size = new System.Drawing.Size(294, 276);
            this.dataGridView_AnimationOrder.TabIndex = 23;
            this.dataGridView_AnimationOrder.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_AnimationOrder_CellMouseDown);
            // 
            // Number
            // 
            this.Number.HeaderText = "#";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 25;
            // 
            // AnimationName
            // 
            this.AnimationName.HeaderText = "Animation Name";
            this.AnimationName.MinimumWidth = 177;
            this.AnimationName.Name = "AnimationName";
            this.AnimationName.ReadOnly = true;
            this.AnimationName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnimationName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AnimationName.Width = 177;
            // 
            // contextMenuStrip_Animations
            // 
            this.contextMenuStrip_Animations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Animations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Add,
            this.toolStripMenuItem_Remove,
            this.toolStripMenuItem_Rename});
            this.contextMenuStrip_Animations.Name = "contextMenuStrip_Animations";
            this.contextMenuStrip_Animations.Size = new System.Drawing.Size(211, 104);
            this.contextMenuStrip_Animations.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolStripMenuItem_Add
            // 
            this.toolStripMenuItem_Add.Name = "toolStripMenuItem_Add";
            this.toolStripMenuItem_Add.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem_Add.Text = "Add";
            this.toolStripMenuItem_Add.Click += new System.EventHandler(this.toolStripMenuItem_Add_Click);
            // 
            // toolStripMenuItem_Remove
            // 
            this.toolStripMenuItem_Remove.Name = "toolStripMenuItem_Remove";
            this.toolStripMenuItem_Remove.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem_Remove.Text = "Remove";
            this.toolStripMenuItem_Remove.Click += new System.EventHandler(this.toolStripMenuItem_Remove_Click);
            // 
            // toolStripMenuItem_Rename
            // 
            this.toolStripMenuItem_Rename.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_Rename});
            this.toolStripMenuItem_Rename.Name = "toolStripMenuItem_Rename";
            this.toolStripMenuItem_Rename.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem_Rename.Text = "Rename";
            // 
            // chkBox_AutoUpdate
            // 
            this.chkBox_AutoUpdate.AutoSize = true;
            this.chkBox_AutoUpdate.Enabled = false;
            this.chkBox_AutoUpdate.Location = new System.Drawing.Point(825, 344);
            this.chkBox_AutoUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_AutoUpdate.Name = "chkBox_AutoUpdate";
            this.chkBox_AutoUpdate.Size = new System.Drawing.Size(144, 21);
            this.chkBox_AutoUpdate.TabIndex = 18;
            this.chkBox_AutoUpdate.Text = "Auto-Update MDS";
            this.chkBox_AutoUpdate.UseVisualStyleBackColor = true;
            // 
            // btn_FixMDS
            // 
            this.btn_FixMDS.AllowDrop = true;
            this.btn_FixMDS.Location = new System.Drawing.Point(215, 3);
            this.btn_FixMDS.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FixMDS.Name = "btn_FixMDS";
            this.btn_FixMDS.Size = new System.Drawing.Size(200, 172);
            this.btn_FixMDS.TabIndex = 24;
            this.btn_FixMDS.Text = "Fix MDS for P4G\r\n";
            this.btn_FixMDS.UseVisualStyleBackColor = true;
            this.btn_FixMDS.Click += new System.EventHandler(this.btn_Fix_Click);
            this.btn_FixMDS.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_Fix_DragDrop);
            this.btn_FixMDS.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_Fix_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkBox_AutoConvertTex);
            this.panel1.Controls.Add(this.chkBox_Dummy);
            this.panel1.Controls.Add(this.txt_WpnBone);
            this.panel1.Controls.Add(this.chkBox_RenameBones);
            this.panel1.Controls.Add(this.lbl_WpnBone);
            this.panel1.Controls.Add(this.chkBox_Animations);
            this.panel1.Location = new System.Drawing.Point(215, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 182);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Additional Options:";
            // 
            // txtBox_NoesisOptions
            // 
            this.txtBox_NoesisOptions.Enabled = false;
            this.txtBox_NoesisOptions.Location = new System.Drawing.Point(27, 87);
            this.txtBox_NoesisOptions.Name = "txtBox_NoesisOptions";
            this.txtBox_NoesisOptions.Size = new System.Drawing.Size(163, 22);
            this.txtBox_NoesisOptions.TabIndex = 34;
            // 
            // toolStripTextBox_Rename
            // 
            this.toolStripTextBox_Rename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_Rename.Name = "toolStripTextBox_Rename";
            this.toolStripTextBox_Rename.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox_Rename.TextChanged += new System.EventHandler(this.toolStripTextBox_Rename_TextChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_FixMDS);
            this.Controls.Add(this.chkBox_AutoUpdate);
            this.Controls.Add(this.dataGridView_AnimationOrder);
            this.Controls.Add(this.comboBox_Preset);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.panel_MDS);
            this.Controls.Add(this.panel_FBX_GMO);
            this.Controls.Add(this.btn_ImportAnim);
            this.Controls.Add(this.btn_ExportAnim);
            this.Controls.Add(this.lbl_AnimationsLoaded);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_CreateGMO);
            this.Controls.Add(this.btn_Extract);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 420);
            this.MinimumSize = new System.Drawing.Size(1000, 420);
            this.Name = "MainForm";
            this.Text = "P4GMOdelConverter 1.6";
            this.panel_FBX_GMO.ResumeLayout(false);
            this.panel_FBX_GMO.PerformLayout();
            this.panel_MDS.ResumeLayout(false);
            this.panel_MDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AnimationOrder)).EndInit();
            this.contextMenuStrip_Animations.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Extract;
        private System.Windows.Forms.Button btn_CreateGMO;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.CheckBox chkBox_ExtractTex;
        private System.Windows.Forms.CheckBox chkBox_Animations;
        private System.Windows.Forms.Label lbl_AnimationsLoaded;
        private System.Windows.Forms.Button btn_ExportAnim;
        private System.Windows.Forms.Button btn_ImportAnim;
        private System.Windows.Forms.CheckBox chkBox_Dummy;
        private System.Windows.Forms.Label lbl_WpnBone;
        private System.Windows.Forms.TextBox txt_WpnBone;
        private System.Windows.Forms.CheckBox chkBox_FBXtoGMO;
        private System.Windows.Forms.CheckBox chkBox_PCFix;
        private System.Windows.Forms.CheckBox chkBox_ViewGMO;
        private System.Windows.Forms.CheckBox chkBox_RenameBones;
        private System.Windows.Forms.Panel panel_FBX_GMO;
        private System.Windows.Forms.Panel panel_MDS;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.CheckBox chkBox_AutoConvertTex;
        private System.Windows.Forms.ComboBox comboBox_Preset;
        private System.Windows.Forms.DataGridView dataGridView_AnimationOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Animations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Remove;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Rename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimationName;
        private System.Windows.Forms.CheckBox chkBox_AutoUpdate;
        private System.Windows.Forms.Button btn_FixMDS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Preview;
        private System.Windows.Forms.CheckBox chkBox_FBXOptimize;
        private System.Windows.Forms.CheckBox chkBox_fbxascii;
        private System.Windows.Forms.CheckBox chkBox_fbxoldexport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_NoesisOptions;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Rename;
    }
}

