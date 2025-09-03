
namespace WAX_converter
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            panel2 = new System.Windows.Forms.Panel();
            btnAnimate = new System.Windows.Forms.Button();
            comboBoxImageCategory = new System.Windows.Forms.ComboBox();
            comboBoxTransparencyOptions = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            RadioGroup = new System.Windows.Forms.GroupBox();
            radioCell = new System.Windows.Forms.RadioButton();
            radioFrame = new System.Windows.Forms.RadioButton();
            radioSequence = new System.Windows.Forms.RadioButton();
            radioAction = new System.Windows.Forms.RadioButton();
            LabelPal = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelWax = new System.Windows.Forms.Label();
            WaxDetails = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            MenuLoadPal = new System.Windows.Forms.ToolStripMenuItem();
            MenuRemasterDirectory = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            MenuOpenWax = new System.Windows.Forms.ToolStripMenuItem();
            MenuOpenFme = new System.Windows.Forms.ToolStripMenuItem();
            MenuCloseWax = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            MenuSaveBMP = new System.Windows.Forms.ToolStripMenuItem();
            MenuExportWXX = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            MenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            MenuBuildWax = new System.Windows.Forms.ToolStripMenuItem();
            MenuBuild = new System.Windows.Forms.ToolStripMenuItem();
            MenuEnemyWizard = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            MenuCreateFme = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            MenuBuildWxx = new System.Windows.Forms.ToolStripMenuItem();
            MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            MenuHelphelp = new System.Windows.Forms.ToolStripMenuItem();
            MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            openWaxDialog = new System.Windows.Forms.OpenFileDialog();
            panel1 = new System.Windows.Forms.Panel();
            labelSeqFrame = new System.Windows.Forms.Label();
            SeqNextFrame = new System.Windows.Forms.Button();
            SeqPrevFrame = new System.Windows.Forms.Button();
            SeqNumber = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            ActionInfo = new System.Windows.Forms.TextBox();
            ActionNumber = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            ViewNumber = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            SeqInfo = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            checkBoxZoom = new System.Windows.Forms.CheckBox();
            CellNumber = new System.Windows.Forms.NumericUpDown();
            CellInfo = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            displayBox = new System.Windows.Forms.PictureBox();
            FrameInfo = new System.Windows.Forms.TextBox();
            FrameNumber = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            openPalDialog = new System.Windows.Forms.OpenFileDialog();
            exportDialog = new System.Windows.Forms.SaveFileDialog();
            openFmeDialog = new System.Windows.Forms.OpenFileDialog();
            openRemasterDirectoryDialog = new System.Windows.Forms.OpenFileDialog();
            panel2.SuspendLayout();
            RadioGroup.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SeqNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActionNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewNumber).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CellNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)displayBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrameNumber).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAnimate);
            panel2.Controls.Add(comboBoxImageCategory);
            panel2.Controls.Add(comboBoxTransparencyOptions);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(RadioGroup);
            panel2.Controls.Add(LabelPal);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(labelWax);
            panel2.Controls.Add(WaxDetails);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1184, 171);
            panel2.TabIndex = 1;
            // 
            // btnAnimate
            // 
            btnAnimate.Location = new System.Drawing.Point(785, 81);
            btnAnimate.Name = "btnAnimate";
            btnAnimate.Size = new System.Drawing.Size(248, 31);
            btnAnimate.TabIndex = 12;
            btnAnimate.Text = "Animate selected action";
            btnAnimate.UseVisualStyleBackColor = true;
            btnAnimate.Click += btnAnimate_Click;
            // 
            // comboBoxImageCategory
            // 
            comboBoxImageCategory.Enabled = false;
            comboBoxImageCategory.FormattingEnabled = true;
            comboBoxImageCategory.Items.AddRange(new object[] { "Original sprite", "Remastered sprite", "Remastered - no alpha", "Remastered - alpha channel" });
            comboBoxImageCategory.Location = new System.Drawing.Point(845, 27);
            comboBoxImageCategory.Name = "comboBoxImageCategory";
            comboBoxImageCategory.Size = new System.Drawing.Size(203, 23);
            comboBoxImageCategory.TabIndex = 11;
            comboBoxImageCategory.SelectedIndexChanged += comboBoxImageCategory_SelectedIndexChanged;
            // 
            // comboBoxTransparencyOptions
            // 
            comboBoxTransparencyOptions.FormattingEnabled = true;
            comboBoxTransparencyOptions.Items.AddRange(new object[] { "Transparent (alpha 0)", "Black", "White", "Magenta" });
            comboBoxTransparencyOptions.Location = new System.Drawing.Point(571, 27);
            comboBoxTransparencyOptions.Name = "comboBoxTransparencyOptions";
            comboBoxTransparencyOptions.Size = new System.Drawing.Size(179, 23);
            comboBoxTransparencyOptions.TabIndex = 10;
            comboBoxTransparencyOptions.SelectedIndexChanged += comboBoxTransparencyOptions_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(410, 30);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(136, 15);
            label7.TabIndex = 9;
            label7.Text = "Set transparent pixels to:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(12, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 15);
            label6.TabIndex = 8;
            label6.Text = "Palette:";
            // 
            // RadioGroup
            // 
            RadioGroup.Controls.Add(radioCell);
            RadioGroup.Controls.Add(radioFrame);
            RadioGroup.Controls.Add(radioSequence);
            RadioGroup.Controls.Add(radioAction);
            RadioGroup.Enabled = false;
            RadioGroup.Location = new System.Drawing.Point(409, 59);
            RadioGroup.Name = "RadioGroup";
            RadioGroup.Size = new System.Drawing.Size(331, 78);
            RadioGroup.TabIndex = 7;
            RadioGroup.TabStop = false;
            // 
            // radioCell
            // 
            radioCell.AutoSize = true;
            radioCell.Location = new System.Drawing.Point(180, 47);
            radioCell.Name = "radioCell";
            radioCell.Size = new System.Drawing.Size(87, 19);
            radioCell.TabIndex = 3;
            radioCell.TabStop = true;
            radioCell.Text = "View by cell";
            radioCell.UseVisualStyleBackColor = true;
            radioCell.CheckedChanged += radioCell_CheckedChanged;
            // 
            // radioFrame
            // 
            radioFrame.AutoSize = true;
            radioFrame.Location = new System.Drawing.Point(180, 22);
            radioFrame.Name = "radioFrame";
            radioFrame.Size = new System.Drawing.Size(100, 19);
            radioFrame.TabIndex = 2;
            radioFrame.TabStop = true;
            radioFrame.Text = "View by frame";
            radioFrame.UseVisualStyleBackColor = true;
            radioFrame.CheckedChanged += radioFrame_CheckedChanged;
            // 
            // radioSequence
            // 
            radioSequence.AutoSize = true;
            radioSequence.Location = new System.Drawing.Point(19, 47);
            radioSequence.Name = "radioSequence";
            radioSequence.Size = new System.Drawing.Size(119, 19);
            radioSequence.TabIndex = 1;
            radioSequence.TabStop = true;
            radioSequence.Text = "View by sequence";
            radioSequence.UseVisualStyleBackColor = true;
            radioSequence.CheckedChanged += radioSequence_CheckedChanged;
            // 
            // radioAction
            // 
            radioAction.AutoSize = true;
            radioAction.Checked = true;
            radioAction.Location = new System.Drawing.Point(19, 22);
            radioAction.Name = "radioAction";
            radioAction.Size = new System.Drawing.Size(102, 19);
            radioAction.TabIndex = 0;
            radioAction.TabStop = true;
            radioAction.Text = "View by action";
            radioAction.UseVisualStyleBackColor = true;
            radioAction.CheckedChanged += radioAction_CheckedChanged;
            // 
            // LabelPal
            // 
            LabelPal.AutoSize = true;
            LabelPal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelPal.Location = new System.Drawing.Point(85, 30);
            LabelPal.Name = "LabelPal";
            LabelPal.Size = new System.Drawing.Size(120, 15);
            LabelPal.TabIndex = 5;
            LabelPal.Text = "Secbase.PAL (default)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "WAX file:";
            // 
            // labelWax
            // 
            labelWax.AutoSize = true;
            labelWax.Location = new System.Drawing.Point(85, 10);
            labelWax.Name = "labelWax";
            labelWax.Size = new System.Drawing.Size(27, 15);
            labelWax.TabIndex = 3;
            labelWax.Text = "----";
            // 
            // WaxDetails
            // 
            WaxDetails.AcceptsReturn = true;
            WaxDetails.BackColor = System.Drawing.SystemColors.Control;
            WaxDetails.Location = new System.Drawing.Point(12, 59);
            WaxDetails.Multiline = true;
            WaxDetails.Name = "WaxDetails";
            WaxDetails.ReadOnly = true;
            WaxDetails.Size = new System.Drawing.Size(359, 96);
            WaxDetails.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuFile, MenuBuildWax, MenuHelp });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1184, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuLoadPal, MenuRemasterDirectory, toolStripSeparator3, MenuOpenWax, MenuOpenFme, MenuCloseWax, toolStripSeparator6, MenuSaveBMP, MenuExportWXX, toolStripSeparator2, MenuQuit });
            MenuFile.Name = "MenuFile";
            MenuFile.Size = new System.Drawing.Size(37, 20);
            MenuFile.Text = "File";
            // 
            // MenuLoadPal
            // 
            MenuLoadPal.Name = "MenuLoadPal";
            MenuLoadPal.Size = new System.Drawing.Size(223, 22);
            MenuLoadPal.Text = "Load PAL";
            MenuLoadPal.Click += MenuLoadPal_Click;
            // 
            // MenuRemasterDirectory
            // 
            MenuRemasterDirectory.Name = "MenuRemasterDirectory";
            MenuRemasterDirectory.Size = new System.Drawing.Size(223, 22);
            MenuRemasterDirectory.Text = "Remaster files location";
            MenuRemasterDirectory.Click += MenuRemasterDirectory_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // MenuOpenWax
            // 
            MenuOpenWax.Name = "MenuOpenWax";
            MenuOpenWax.Size = new System.Drawing.Size(223, 22);
            MenuOpenWax.Text = "Open WAX";
            MenuOpenWax.Click += MenuOpenWax_Click;
            // 
            // MenuOpenFme
            // 
            MenuOpenFme.Name = "MenuOpenFme";
            MenuOpenFme.Size = new System.Drawing.Size(223, 22);
            MenuOpenFme.Text = "Open FME";
            MenuOpenFme.Click += MenuOpenFme_Click;
            // 
            // MenuCloseWax
            // 
            MenuCloseWax.Enabled = false;
            MenuCloseWax.Name = "MenuCloseWax";
            MenuCloseWax.Size = new System.Drawing.Size(223, 22);
            MenuCloseWax.Text = "Close WAX";
            MenuCloseWax.Click += MenuCloseWax_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(220, 6);
            // 
            // MenuSaveBMP
            // 
            MenuSaveBMP.Enabled = false;
            MenuSaveBMP.Name = "MenuSaveBMP";
            MenuSaveBMP.Size = new System.Drawing.Size(223, 22);
            MenuSaveBMP.Text = "Export images to PNG";
            MenuSaveBMP.Click += MenuExportWax_Click;
            // 
            // MenuExportWXX
            // 
            MenuExportWXX.Enabled = false;
            MenuExportWXX.Name = "MenuExportWXX";
            MenuExportWXX.Size = new System.Drawing.Size(223, 22);
            MenuExportWXX.Text = "Export hi-res images to PNG";
            MenuExportWXX.Click += MenuExportWXX_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // MenuQuit
            // 
            MenuQuit.Name = "MenuQuit";
            MenuQuit.Size = new System.Drawing.Size(223, 22);
            MenuQuit.Text = "Quit";
            MenuQuit.Click += MenuQuit_Click;
            // 
            // MenuBuildWax
            // 
            MenuBuildWax.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuBuild, MenuEnemyWizard, toolStripSeparator1, MenuCreateFme, toolStripSeparator4, MenuBuildWxx });
            MenuBuildWax.Name = "MenuBuildWax";
            MenuBuildWax.Size = new System.Drawing.Size(53, 20);
            MenuBuildWax.Text = "Create";
            // 
            // MenuBuild
            // 
            MenuBuild.Name = "MenuBuild";
            MenuBuild.Size = new System.Drawing.Size(182, 22);
            MenuBuild.Text = "Build WAX manually";
            MenuBuild.Click += MenuBuild_Click;
            // 
            // MenuEnemyWizard
            // 
            MenuEnemyWizard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MenuEnemyWizard.Name = "MenuEnemyWizard";
            MenuEnemyWizard.Size = new System.Drawing.Size(182, 22);
            MenuEnemyWizard.Text = "Enemy Wizard";
            MenuEnemyWizard.Click += MenuEnemyWizard_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // MenuCreateFme
            // 
            MenuCreateFme.Name = "MenuCreateFme";
            MenuCreateFme.Size = new System.Drawing.Size(182, 22);
            MenuCreateFme.Text = "Create FME";
            MenuCreateFme.Click += MenuCreateFme_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // MenuBuildWxx
            // 
            MenuBuildWxx.Name = "MenuBuildWxx";
            MenuBuildWxx.Size = new System.Drawing.Size(182, 22);
            MenuBuildWxx.Text = "Create WXX";
            MenuBuildWxx.Click += MenuBuildWxx_Click;
            // 
            // MenuHelp
            // 
            MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuHelphelp, MenuAbout });
            MenuHelp.Name = "MenuHelp";
            MenuHelp.Size = new System.Drawing.Size(44, 20);
            MenuHelp.Text = "Help";
            MenuHelp.DropDownItemClicked += menuHelp_ItemClicked;
            // 
            // MenuHelphelp
            // 
            MenuHelphelp.Name = "MenuHelphelp";
            MenuHelphelp.Size = new System.Drawing.Size(107, 22);
            MenuHelphelp.Text = "Help";
            // 
            // MenuAbout
            // 
            MenuAbout.Name = "MenuAbout";
            MenuAbout.Size = new System.Drawing.Size(107, 22);
            MenuAbout.Text = "About";
            // 
            // openWaxDialog
            // 
            openWaxDialog.DefaultExt = "wax";
            openWaxDialog.Filter = "Dark Forces WAX files|*.wax";
            openWaxDialog.Title = "Open WAX file";
            openWaxDialog.FileOk += openWaxDialog_FileOk;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelSeqFrame);
            panel1.Controls.Add(SeqNextFrame);
            panel1.Controls.Add(SeqPrevFrame);
            panel1.Controls.Add(SeqNumber);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(ActionInfo);
            panel1.Controls.Add(ActionNumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ViewNumber);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SeqInfo);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 195);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(193, 686);
            panel1.TabIndex = 3;
            // 
            // labelSeqFrame
            // 
            labelSeqFrame.AutoSize = true;
            labelSeqFrame.Location = new System.Drawing.Point(80, 323);
            labelSeqFrame.Name = "labelSeqFrame";
            labelSeqFrame.Size = new System.Drawing.Size(17, 15);
            labelSeqFrame.TabIndex = 11;
            labelSeqFrame.Text = "--";
            // 
            // SeqNextFrame
            // 
            SeqNextFrame.Location = new System.Drawing.Point(117, 317);
            SeqNextFrame.Name = "SeqNextFrame";
            SeqNextFrame.Size = new System.Drawing.Size(31, 26);
            SeqNextFrame.TabIndex = 10;
            SeqNextFrame.Text = ">";
            SeqNextFrame.UseVisualStyleBackColor = true;
            SeqNextFrame.Click += SeqNextFrame_Click;
            // 
            // SeqPrevFrame
            // 
            SeqPrevFrame.Location = new System.Drawing.Point(28, 317);
            SeqPrevFrame.Name = "SeqPrevFrame";
            SeqPrevFrame.Size = new System.Drawing.Size(31, 26);
            SeqPrevFrame.TabIndex = 9;
            SeqPrevFrame.Text = "<";
            SeqPrevFrame.UseVisualStyleBackColor = true;
            SeqPrevFrame.Click += SeqPrevFrame_Click;
            // 
            // SeqNumber
            // 
            SeqNumber.Enabled = false;
            SeqNumber.Location = new System.Drawing.Point(84, 200);
            SeqNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SeqNumber.Name = "SeqNumber";
            SeqNumber.Size = new System.Drawing.Size(64, 23);
            SeqNumber.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 202);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(58, 15);
            label8.TabIndex = 7;
            label8.Text = "Sequence";
            // 
            // ActionInfo
            // 
            ActionInfo.Location = new System.Drawing.Point(12, 73);
            ActionInfo.Multiline = true;
            ActionInfo.Name = "ActionInfo";
            ActionInfo.ReadOnly = true;
            ActionInfo.Size = new System.Drawing.Size(154, 104);
            ActionInfo.TabIndex = 2;
            // 
            // ActionNumber
            // 
            ActionNumber.BackColor = System.Drawing.SystemColors.Window;
            ActionNumber.Enabled = false;
            ActionNumber.Location = new System.Drawing.Point(84, 9);
            ActionNumber.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            ActionNumber.Name = "ActionNumber";
            ActionNumber.ReadOnly = true;
            ActionNumber.Size = new System.Drawing.Size(64, 23);
            ActionNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Action";
            // 
            // ViewNumber
            // 
            ViewNumber.Enabled = false;
            ViewNumber.Location = new System.Drawing.Point(84, 35);
            ViewNumber.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            ViewNumber.Name = "ViewNumber";
            ViewNumber.Size = new System.Drawing.Size(64, 23);
            ViewNumber.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "View";
            // 
            // SeqInfo
            // 
            SeqInfo.Location = new System.Drawing.Point(12, 229);
            SeqInfo.Multiline = true;
            SeqInfo.Name = "SeqInfo";
            SeqInfo.ReadOnly = true;
            SeqInfo.Size = new System.Drawing.Size(154, 65);
            SeqInfo.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(checkBoxZoom);
            panel3.Controls.Add(CellNumber);
            panel3.Controls.Add(CellInfo);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(displayBox);
            panel3.Controls.Add(FrameInfo);
            panel3.Controls.Add(FrameNumber);
            panel3.Controls.Add(label4);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(193, 195);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(991, 686);
            panel3.TabIndex = 4;
            // 
            // checkBoxZoom
            // 
            checkBoxZoom.AutoSize = true;
            checkBoxZoom.Location = new System.Drawing.Point(92, 421);
            checkBoxZoom.Name = "checkBoxZoom";
            checkBoxZoom.Size = new System.Drawing.Size(86, 19);
            checkBoxZoom.TabIndex = 10;
            checkBoxZoom.Text = "Zoom to fit";
            checkBoxZoom.UseVisualStyleBackColor = true;
            checkBoxZoom.CheckedChanged += checkBoxZoom_CheckedChanged;
            // 
            // CellNumber
            // 
            CellNumber.Enabled = false;
            CellNumber.Location = new System.Drawing.Point(94, 193);
            CellNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CellNumber.Name = "CellNumber";
            CellNumber.Size = new System.Drawing.Size(58, 23);
            CellNumber.TabIndex = 9;
            CellNumber.ValueChanged += CellNumber_ValueChanged;
            // 
            // CellInfo
            // 
            CellInfo.Location = new System.Drawing.Point(17, 222);
            CellInfo.Multiline = true;
            CellInfo.Name = "CellInfo";
            CellInfo.ReadOnly = true;
            CellInfo.Size = new System.Drawing.Size(161, 133);
            CellInfo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(17, 195);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(27, 15);
            label5.TabIndex = 7;
            label5.Text = "Cell";
            // 
            // displayBox
            // 
            displayBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            displayBox.BackColor = System.Drawing.Color.Gray;
            displayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            displayBox.Location = new System.Drawing.Point(216, 6);
            displayBox.Name = "displayBox";
            displayBox.Size = new System.Drawing.Size(763, 663);
            displayBox.TabIndex = 6;
            displayBox.TabStop = false;
            // 
            // FrameInfo
            // 
            FrameInfo.Location = new System.Drawing.Point(17, 37);
            FrameInfo.Multiline = true;
            FrameInfo.Name = "FrameInfo";
            FrameInfo.ReadOnly = true;
            FrameInfo.Size = new System.Drawing.Size(161, 122);
            FrameInfo.TabIndex = 5;
            // 
            // FrameNumber
            // 
            FrameNumber.Enabled = false;
            FrameNumber.Location = new System.Drawing.Point(94, 8);
            FrameNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            FrameNumber.Name = "FrameNumber";
            FrameNumber.Size = new System.Drawing.Size(58, 23);
            FrameNumber.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Frame";
            // 
            // openPalDialog
            // 
            openPalDialog.DefaultExt = "pal";
            openPalDialog.Filter = "Dark Forces Palette Files|*.pal";
            openPalDialog.Title = "Open PAL";
            openPalDialog.FileOk += openPalDialog_FileOk;
            // 
            // exportDialog
            // 
            exportDialog.AddExtension = false;
            exportDialog.Title = "Export name";
            exportDialog.FileOk += exportDialog_FileOk;
            // 
            // openFmeDialog
            // 
            openFmeDialog.DefaultExt = "wax";
            openFmeDialog.Filter = "Dark Forces FME files|*.fme";
            openFmeDialog.Title = "Open FME file";
            openFmeDialog.FileOk += openFmeDialog_FileOk;
            // 
            // openRemasterDirectoryDialog
            // 
            openRemasterDirectoryDialog.Filter = "GOB, WXX, FXX|*.GOB; *.WXX; *.FXX";
            openRemasterDirectoryDialog.Title = "Select folder or GOB containing remaster files";
            openRemasterDirectoryDialog.FileOk += openRemasterDirectoryDialog_FileOk;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1184, 881);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(1200, 920);
            Name = "MainWindow";
            Text = "WAX Converter (version 3.5)";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            RadioGroup.ResumeLayout(false);
            RadioGroup.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SeqNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActionNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewNumber).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CellNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)displayBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrameNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenWax;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.Label labelWax;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveBMP;
        private System.Windows.Forms.ToolStripMenuItem MenuQuit;
        private System.Windows.Forms.OpenFileDialog openWaxDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TextBox WaxDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ActionNumber;
        private System.Windows.Forms.TextBox ActionInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown ViewNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SeqInfo;
        private System.Windows.Forms.NumericUpDown FrameNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FrameInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuLoadPal;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseWax;
        private System.Windows.Forms.OpenFileDialog openPalDialog;
        private System.Windows.Forms.Label LabelPal;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CellNumber;
        private System.Windows.Forms.TextBox CellInfo;
        private System.Windows.Forms.GroupBox RadioGroup;
        private System.Windows.Forms.RadioButton radioCell;
        private System.Windows.Forms.RadioButton radioFrame;
        private System.Windows.Forms.RadioButton radioSequence;
        private System.Windows.Forms.RadioButton radioAction;
        private System.Windows.Forms.NumericUpDown SeqNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.Button SeqNextFrame;
        private System.Windows.Forms.Button SeqPrevFrame;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildWax;
        private System.Windows.Forms.ToolStripMenuItem MenuBuild;
        private System.Windows.Forms.CheckBox checkBoxZoom;
        private System.Windows.Forms.ToolStripMenuItem MenuHelphelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.Label labelSeqFrame;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenFme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFmeDialog;
        private System.Windows.Forms.ToolStripMenuItem MenuEnemyWizard;
        private System.Windows.Forms.ComboBox comboBoxTransparencyOptions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem MenuRemasterDirectory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog openRemasterDirectoryDialog;
        private System.Windows.Forms.ComboBox comboBoxImageCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuExportWXX;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildWxx;
        private System.Windows.Forms.ToolStripMenuItem MenuCreateFme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

