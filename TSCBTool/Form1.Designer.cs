namespace TSCBTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.subsections = new System.Windows.Forms.TabControl();
            this.tiles = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noneRad = new System.Windows.Forms.RadioButton();
            this.setAllBtn = new System.Windows.Forms.Button();
            this.waterRad = new System.Windows.Forms.RadioButton();
            this.bothRad = new System.Windows.Forms.RadioButton();
            this.grassRad = new System.Windows.Forms.RadioButton();
            this.updtileBtn = new System.Windows.Forms.Button();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.watmaxBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.watminBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.terrmaxBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.terrminBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.normaliseBtn = new System.Windows.Forms.Button();
            this.proBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LODcomboBox = new System.Windows.Forms.ComboBox();
            this.kill_LOD = new System.Windows.Forms.Button();
            this.tileTree = new System.Windows.Forms.TreeView();
            this.materials = new System.Windows.Forms.TabPage();
            this.materialTree = new System.Windows.Forms.TreeView();
            this.headerTree = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.vscaleBox = new System.Windows.Forms.TextBox();
            this.hscaleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vscaleUpdate = new System.Windows.Forms.Button();
            this.hscaleUpdate = new System.Windows.Forms.Button();
            this.tscbheaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subsections.SuspendLayout();
            this.tiles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.materials.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tscbheaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // subsections
            // 
            this.subsections.Controls.Add(this.tiles);
            this.subsections.Controls.Add(this.materials);
            this.subsections.Location = new System.Drawing.Point(12, 254);
            this.subsections.Name = "subsections";
            this.subsections.SelectedIndex = 0;
            this.subsections.Size = new System.Drawing.Size(662, 773);
            this.subsections.TabIndex = 0;
            // 
            // tiles
            // 
            this.tiles.Controls.Add(this.groupBox1);
            this.tiles.Controls.Add(this.updtileBtn);
            this.tiles.Controls.Add(this.fnameBox);
            this.tiles.Controls.Add(this.label11);
            this.tiles.Controls.Add(this.watmaxBox);
            this.tiles.Controls.Add(this.label10);
            this.tiles.Controls.Add(this.watminBox);
            this.tiles.Controls.Add(this.label9);
            this.tiles.Controls.Add(this.terrmaxBox);
            this.tiles.Controls.Add(this.label8);
            this.tiles.Controls.Add(this.terrminBox);
            this.tiles.Controls.Add(this.label7);
            this.tiles.Controls.Add(this.areaBox);
            this.tiles.Controls.Add(this.label6);
            this.tiles.Controls.Add(this.yBox);
            this.tiles.Controls.Add(this.label5);
            this.tiles.Controls.Add(this.xBox);
            this.tiles.Controls.Add(this.label2);
            this.tiles.Controls.Add(this.normaliseBtn);
            this.tiles.Controls.Add(this.proBar);
            this.tiles.Controls.Add(this.label1);
            this.tiles.Controls.Add(this.LODcomboBox);
            this.tiles.Controls.Add(this.kill_LOD);
            this.tiles.Controls.Add(this.tileTree);
            this.tiles.Location = new System.Drawing.Point(4, 29);
            this.tiles.Name = "tiles";
            this.tiles.Padding = new System.Windows.Forms.Padding(3);
            this.tiles.Size = new System.Drawing.Size(654, 740);
            this.tiles.TabIndex = 0;
            this.tiles.Text = "Tiles";
            this.tiles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noneRad);
            this.groupBox1.Controls.Add(this.setAllBtn);
            this.groupBox1.Controls.Add(this.waterRad);
            this.groupBox1.Controls.Add(this.bothRad);
            this.groupBox1.Controls.Add(this.grassRad);
            this.groupBox1.Location = new System.Drawing.Point(338, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 140);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Info";
            // 
            // noneRad
            // 
            this.noneRad.AutoSize = true;
            this.noneRad.Location = new System.Drawing.Point(11, 29);
            this.noneRad.Name = "noneRad";
            this.noneRad.Size = new System.Drawing.Size(72, 24);
            this.noneRad.TabIndex = 27;
            this.noneRad.TabStop = true;
            this.noneRad.Text = "None";
            this.noneRad.UseVisualStyleBackColor = true;
            // 
            // setAllBtn
            // 
            this.setAllBtn.Location = new System.Drawing.Point(10, 92);
            this.setAllBtn.Name = "setAllBtn";
            this.setAllBtn.Size = new System.Drawing.Size(132, 36);
            this.setAllBtn.TabIndex = 31;
            this.setAllBtn.Text = "Set All";
            this.setAllBtn.UseVisualStyleBackColor = true;
            this.setAllBtn.Click += new System.EventHandler(this.setAllBtn_Click);
            // 
            // waterRad
            // 
            this.waterRad.AutoSize = true;
            this.waterRad.Location = new System.Drawing.Point(143, 29);
            this.waterRad.Name = "waterRad";
            this.waterRad.Size = new System.Drawing.Size(112, 24);
            this.waterRad.TabIndex = 28;
            this.waterRad.TabStop = true;
            this.waterRad.Text = "Water Only";
            this.waterRad.UseVisualStyleBackColor = true;
            // 
            // bothRad
            // 
            this.bothRad.AutoSize = true;
            this.bothRad.Location = new System.Drawing.Point(143, 59);
            this.bothRad.Name = "bothRad";
            this.bothRad.Size = new System.Drawing.Size(155, 24);
            this.bothRad.TabIndex = 30;
            this.bothRad.TabStop = true;
            this.bothRad.Text = "Water and Grass";
            this.bothRad.UseVisualStyleBackColor = true;
            // 
            // grassRad
            // 
            this.grassRad.AutoSize = true;
            this.grassRad.Location = new System.Drawing.Point(11, 59);
            this.grassRad.Name = "grassRad";
            this.grassRad.Size = new System.Drawing.Size(112, 24);
            this.grassRad.TabIndex = 29;
            this.grassRad.TabStop = true;
            this.grassRad.Text = "Grass Only";
            this.grassRad.UseVisualStyleBackColor = true;
            // 
            // updtileBtn
            // 
            this.updtileBtn.Location = new System.Drawing.Point(365, 455);
            this.updtileBtn.Name = "updtileBtn";
            this.updtileBtn.Size = new System.Drawing.Size(195, 45);
            this.updtileBtn.TabIndex = 26;
            this.updtileBtn.Text = "Update";
            this.updtileBtn.UseVisualStyleBackColor = true;
            this.updtileBtn.Click += new System.EventHandler(this.updtileBtn_Click);
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(441, 238);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(137, 26);
            this.fnameBox.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Filename";
            // 
            // watmaxBox
            // 
            this.watmaxBox.Location = new System.Drawing.Point(441, 206);
            this.watmaxBox.Name = "watmaxBox";
            this.watmaxBox.Size = new System.Drawing.Size(137, 26);
            this.watmaxBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Max Water";
            // 
            // watminBox
            // 
            this.watminBox.Location = new System.Drawing.Point(441, 174);
            this.watminBox.Name = "watminBox";
            this.watminBox.Size = new System.Drawing.Size(137, 26);
            this.watminBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Min Water";
            // 
            // terrmaxBox
            // 
            this.terrmaxBox.Location = new System.Drawing.Point(441, 142);
            this.terrmaxBox.Name = "terrmaxBox";
            this.terrmaxBox.Size = new System.Drawing.Size(137, 26);
            this.terrmaxBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Max Terrain";
            // 
            // terrminBox
            // 
            this.terrminBox.Location = new System.Drawing.Point(441, 110);
            this.terrminBox.Name = "terrminBox";
            this.terrminBox.Size = new System.Drawing.Size(137, 26);
            this.terrminBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Min Terrain";
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(441, 78);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(137, 26);
            this.areaBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Area Size";
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(441, 46);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(137, 26);
            this.yBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y Pos";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(441, 14);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(137, 26);
            this.xBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "X Pos";
            // 
            // normaliseBtn
            // 
            this.normaliseBtn.Location = new System.Drawing.Point(7, 520);
            this.normaliseBtn.Name = "normaliseBtn";
            this.normaliseBtn.Size = new System.Drawing.Size(166, 120);
            this.normaliseBtn.TabIndex = 9;
            this.normaliseBtn.Text = "Max Out Terrain Height Constraints";
            this.normaliseBtn.UseVisualStyleBackColor = true;
            this.normaliseBtn.Click += new System.EventHandler(this.normaliseBtn_Click);
            // 
            // proBar
            // 
            this.proBar.Location = new System.Drawing.Point(6, 692);
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(641, 35);
            this.proBar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remove LOD:";
            // 
            // LODcomboBox
            // 
            this.LODcomboBox.FormattingEnabled = true;
            this.LODcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.LODcomboBox.Location = new System.Drawing.Point(150, 646);
            this.LODcomboBox.Name = "LODcomboBox";
            this.LODcomboBox.Size = new System.Drawing.Size(76, 28);
            this.LODcomboBox.TabIndex = 5;
            this.LODcomboBox.Text = "1";
            // 
            // kill_LOD
            // 
            this.kill_LOD.Location = new System.Drawing.Point(232, 636);
            this.kill_LOD.Name = "kill_LOD";
            this.kill_LOD.Size = new System.Drawing.Size(100, 50);
            this.kill_LOD.TabIndex = 4;
            this.kill_LOD.Text = "Remove";
            this.kill_LOD.UseVisualStyleBackColor = true;
            this.kill_LOD.Click += new System.EventHandler(this.kill_LOD_Click);
            // 
            // tileTree
            // 
            this.tileTree.Location = new System.Drawing.Point(6, 6);
            this.tileTree.Name = "tileTree";
            this.tileTree.Size = new System.Drawing.Size(326, 506);
            this.tileTree.TabIndex = 0;
            this.tileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tileTree_AfterSelect);
            // 
            // materials
            // 
            this.materials.Controls.Add(this.materialTree);
            this.materials.Location = new System.Drawing.Point(4, 29);
            this.materials.Name = "materials";
            this.materials.Padding = new System.Windows.Forms.Padding(3);
            this.materials.Size = new System.Drawing.Size(654, 740);
            this.materials.TabIndex = 1;
            this.materials.Text = "Materials";
            this.materials.UseVisualStyleBackColor = true;
            // 
            // materialTree
            // 
            this.materialTree.Location = new System.Drawing.Point(6, 6);
            this.materialTree.Name = "materialTree";
            this.materialTree.Size = new System.Drawing.Size(326, 506);
            this.materialTree.TabIndex = 1;
            // 
            // headerTree
            // 
            this.headerTree.Location = new System.Drawing.Point(21, 36);
            this.headerTree.Name = "headerTree";
            this.headerTree.Size = new System.Drawing.Size(327, 212);
            this.headerTree.TabIndex = 0;
            this.headerTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.headerTree_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "TerrainSCeneBinaries|*.tscb";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "TerrainSCeneBinaries|*.tscb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "World Vertical Scale";
            // 
            // vscaleBox
            // 
            this.vscaleBox.Location = new System.Drawing.Point(416, 93);
            this.vscaleBox.Name = "vscaleBox";
            this.vscaleBox.Size = new System.Drawing.Size(100, 26);
            this.vscaleBox.TabIndex = 3;
            // 
            // hscaleBox
            // 
            this.hscaleBox.Location = new System.Drawing.Point(416, 163);
            this.hscaleBox.Name = "hscaleBox";
            this.hscaleBox.Size = new System.Drawing.Size(100, 26);
            this.hscaleBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "World Horizontal Scale";
            // 
            // vscaleUpdate
            // 
            this.vscaleUpdate.Location = new System.Drawing.Point(363, 86);
            this.vscaleUpdate.Name = "vscaleUpdate";
            this.vscaleUpdate.Size = new System.Drawing.Size(40, 40);
            this.vscaleUpdate.TabIndex = 6;
            this.vscaleUpdate.Text = "<";
            this.vscaleUpdate.UseVisualStyleBackColor = true;
            this.vscaleUpdate.Click += new System.EventHandler(this.vscaleUpdate_Click);
            // 
            // hscaleUpdate
            // 
            this.hscaleUpdate.Location = new System.Drawing.Point(363, 156);
            this.hscaleUpdate.Name = "hscaleUpdate";
            this.hscaleUpdate.Size = new System.Drawing.Size(40, 40);
            this.hscaleUpdate.TabIndex = 7;
            this.hscaleUpdate.Text = "<";
            this.hscaleUpdate.UseVisualStyleBackColor = true;
            this.hscaleUpdate.Click += new System.EventHandler(this.hscaleUpdate_Click);
            // 
            // tscbheaderBindingSource
            // 
            this.tscbheaderBindingSource.DataSource = typeof(tscbheader);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 1039);
            this.Controls.Add(this.hscaleUpdate);
            this.Controls.Add(this.vscaleUpdate);
            this.Controls.Add(this.hscaleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vscaleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headerTree);
            this.Controls.Add(this.subsections);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 1095);
            this.MinimumSize = new System.Drawing.Size(700, 1095);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TSCBTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.subsections.ResumeLayout(false);
            this.tiles.ResumeLayout(false);
            this.tiles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.materials.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tscbheaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl subsections;
        private System.Windows.Forms.TabPage tiles;
        private System.Windows.Forms.TabPage materials;
        private System.Windows.Forms.TreeView headerTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TreeView tileTree;
        private System.Windows.Forms.TreeView materialTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LODcomboBox;
        private System.Windows.Forms.Button kill_LOD;
        private System.Windows.Forms.ProgressBar proBar;
        private System.Windows.Forms.Button normaliseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vscaleBox;
        private System.Windows.Forms.TextBox hscaleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button vscaleUpdate;
        private System.Windows.Forms.Button hscaleUpdate;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox terrminBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox watmaxBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox watminBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox terrmaxBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button updtileBtn;
        private System.Windows.Forms.RadioButton bothRad;
        private System.Windows.Forms.RadioButton grassRad;
        private System.Windows.Forms.RadioButton waterRad;
        private System.Windows.Forms.RadioButton noneRad;
        private System.Windows.Forms.Button setAllBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tscbheaderBindingSource;
    }
}

