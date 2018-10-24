namespace Graphs
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
            this.pctrbxMain = new System.Windows.Forms.PictureBox();
            this.rdbtnAsAgraph = new System.Windows.Forms.RadioButton();
            this.rdbtnAsALeveledGraph = new System.Windows.Forms.RadioButton();
            this.txtbxFirstVertex = new System.Windows.Forms.TextBox();
            this.txtbxSecondVertex = new System.Windows.Forms.TextBox();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnRemoveVertex = new System.Windows.Forms.Button();
            this.btnRemoveEdge = new System.Windows.Forms.Button();
            this.lblFirstVertex = new System.Windows.Forms.Label();
            this.lblSecondVertex = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctrbxMain
            // 
            this.pctrbxMain.Location = new System.Drawing.Point(12, 57);
            this.pctrbxMain.Name = "pctrbxMain";
            this.pctrbxMain.Size = new System.Drawing.Size(719, 512);
            this.pctrbxMain.TabIndex = 0;
            this.pctrbxMain.TabStop = false;
            // 
            // rdbtnAsAgraph
            // 
            this.rdbtnAsAgraph.AutoSize = true;
            this.rdbtnAsAgraph.Checked = true;
            this.rdbtnAsAgraph.Location = new System.Drawing.Point(826, 57);
            this.rdbtnAsAgraph.Name = "rdbtnAsAgraph";
            this.rdbtnAsAgraph.Size = new System.Drawing.Size(167, 20);
            this.rdbtnAsAgraph.TabIndex = 1;
            this.rdbtnAsAgraph.TabStop = true;
            this.rdbtnAsAgraph.Text = "Show as random grpah";
            this.rdbtnAsAgraph.UseVisualStyleBackColor = true;
            // 
            // rdbtnAsALeveledGraph
            // 
            this.rdbtnAsALeveledGraph.AutoSize = true;
            this.rdbtnAsALeveledGraph.Location = new System.Drawing.Point(826, 80);
            this.rdbtnAsALeveledGraph.Name = "rdbtnAsALeveledGraph";
            this.rdbtnAsALeveledGraph.Size = new System.Drawing.Size(166, 20);
            this.rdbtnAsALeveledGraph.TabIndex = 2;
            this.rdbtnAsALeveledGraph.Text = "Show as leveled graph";
            this.rdbtnAsALeveledGraph.UseVisualStyleBackColor = true;
            // 
            // txtbxFirstVertex
            // 
            this.txtbxFirstVertex.Location = new System.Drawing.Point(794, 136);
            this.txtbxFirstVertex.Name = "txtbxFirstVertex";
            this.txtbxFirstVertex.Size = new System.Drawing.Size(100, 22);
            this.txtbxFirstVertex.TabIndex = 3;
            this.txtbxFirstVertex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFirstVertex_KeyPress);
            // 
            // txtbxSecondVertex
            // 
            this.txtbxSecondVertex.Location = new System.Drawing.Point(916, 136);
            this.txtbxSecondVertex.Name = "txtbxSecondVertex";
            this.txtbxSecondVertex.Size = new System.Drawing.Size(100, 22);
            this.txtbxSecondVertex.TabIndex = 4;
            this.txtbxSecondVertex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSecondVertex_KeyPress);
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.Location = new System.Drawing.Point(794, 189);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(100, 41);
            this.btnAddVertex.TabIndex = 5;
            this.btnAddVertex.Text = "Add Vertex";
            this.btnAddVertex.UseVisualStyleBackColor = true;
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(916, 189);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(100, 41);
            this.btnAddEdge.TabIndex = 6;
            this.btnAddEdge.Text = "Add Edge";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // btnRemoveVertex
            // 
            this.btnRemoveVertex.Location = new System.Drawing.Point(794, 242);
            this.btnRemoveVertex.Name = "btnRemoveVertex";
            this.btnRemoveVertex.Size = new System.Drawing.Size(100, 41);
            this.btnRemoveVertex.TabIndex = 7;
            this.btnRemoveVertex.Text = "Remove Vertex";
            this.btnRemoveVertex.UseVisualStyleBackColor = true;
            this.btnRemoveVertex.Click += new System.EventHandler(this.btnRemoveVertex_Click);
            // 
            // btnRemoveEdge
            // 
            this.btnRemoveEdge.Location = new System.Drawing.Point(916, 242);
            this.btnRemoveEdge.Name = "btnRemoveEdge";
            this.btnRemoveEdge.Size = new System.Drawing.Size(100, 41);
            this.btnRemoveEdge.TabIndex = 8;
            this.btnRemoveEdge.Text = "Remove Edge";
            this.btnRemoveEdge.UseVisualStyleBackColor = true;
            // 
            // lblFirstVertex
            // 
            this.lblFirstVertex.AutoSize = true;
            this.lblFirstVertex.Location = new System.Drawing.Point(794, 114);
            this.lblFirstVertex.Name = "lblFirstVertex";
            this.lblFirstVertex.Size = new System.Drawing.Size(74, 16);
            this.lblFirstVertex.TabIndex = 9;
            this.lblFirstVertex.Text = "First Vertex";
            // 
            // lblSecondVertex
            // 
            this.lblSecondVertex.AutoSize = true;
            this.lblSecondVertex.Location = new System.Drawing.Point(913, 117);
            this.lblSecondVertex.Name = "lblSecondVertex";
            this.lblSecondVertex.Size = new System.Drawing.Size(96, 16);
            this.lblSecondVertex.TabIndex = 10;
            this.lblSecondVertex.Text = "Second Vertex";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(946, 561);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 52);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Location = new System.Drawing.Point(794, 301);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(219, 53);
            this.btnShowGraph.TabIndex = 13;
            this.btnShowGraph.Text = "Show graph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 31);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.selectFolderToolStripMenuItem.Text = "Select folder";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 625);
            this.Controls.Add(this.btnShowGraph);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSecondVertex);
            this.Controls.Add(this.lblFirstVertex);
            this.Controls.Add(this.btnRemoveEdge);
            this.Controls.Add(this.btnRemoveVertex);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.btnAddVertex);
            this.Controls.Add(this.txtbxSecondVertex);
            this.Controls.Add(this.txtbxFirstVertex);
            this.Controls.Add(this.rdbtnAsALeveledGraph);
            this.Controls.Add(this.rdbtnAsAgraph);
            this.Controls.Add(this.pctrbxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxMain;
        private System.Windows.Forms.RadioButton rdbtnAsAgraph;
        private System.Windows.Forms.RadioButton rdbtnAsALeveledGraph;
        private System.Windows.Forms.TextBox txtbxFirstVertex;
        private System.Windows.Forms.TextBox txtbxSecondVertex;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button btnRemoveVertex;
        private System.Windows.Forms.Button btnRemoveEdge;
        private System.Windows.Forms.Label lblFirstVertex;
        private System.Windows.Forms.Label lblSecondVertex;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

