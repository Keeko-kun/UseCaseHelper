namespace UseCaseHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsActor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUseCase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLine = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearAllLines = new System.Windows.Forms.Button();
            this.btnUndoActor = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUndoCase = new System.Windows.Forms.Button();
            this.btnExitLineMode = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1584, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "tsTop";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSave,
            this.tsQuit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // tsSave
            // 
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(152, 22);
            this.tsSave.Text = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsQuit
            // 
            this.tsQuit.Name = "tsQuit";
            this.tsQuit.Size = new System.Drawing.Size(152, 22);
            this.tsQuit.Text = "Quit";
            this.tsQuit.Click += new System.EventHandler(this.tsQuit_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsActor,
            this.tsUseCase,
            this.tsLine});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton2.Text = "Create New";
            // 
            // tsActor
            // 
            this.tsActor.Name = "tsActor";
            this.tsActor.Size = new System.Drawing.Size(121, 22);
            this.tsActor.Text = "Actor";
            this.tsActor.Click += new System.EventHandler(this.tsActor_Click);
            // 
            // tsUseCase
            // 
            this.tsUseCase.Name = "tsUseCase";
            this.tsUseCase.Size = new System.Drawing.Size(121, 22);
            this.tsUseCase.Text = "Use Case";
            this.tsUseCase.Click += new System.EventHandler(this.tsUseCase_Click);
            // 
            // tsLine
            // 
            this.tsLine.Name = "tsLine";
            this.tsLine.Size = new System.Drawing.Size(121, 22);
            this.tsLine.Text = "Line";
            this.tsLine.Click += new System.EventHandler(this.tsLine_Click);
            // 
            // btnClearAllLines
            // 
            this.btnClearAllLines.Location = new System.Drawing.Point(12, 28);
            this.btnClearAllLines.Name = "btnClearAllLines";
            this.btnClearAllLines.Size = new System.Drawing.Size(86, 30);
            this.btnClearAllLines.TabIndex = 2;
            this.btnClearAllLines.Text = "Clear All Lines";
            this.btnClearAllLines.UseVisualStyleBackColor = true;
            this.btnClearAllLines.Click += new System.EventHandler(this.btnClearAllLines_Click);
            // 
            // btnUndoActor
            // 
            this.btnUndoActor.Location = new System.Drawing.Point(104, 28);
            this.btnUndoActor.Name = "btnUndoActor";
            this.btnUndoActor.Size = new System.Drawing.Size(86, 30);
            this.btnUndoActor.TabIndex = 3;
            this.btnUndoActor.Text = "Undo Actor";
            this.btnUndoActor.UseVisualStyleBackColor = true;
            this.btnUndoActor.Click += new System.EventHandler(this.btnUndoActor_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(380, 28);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(86, 30);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "Place Element";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 785);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btnUndoCase
            // 
            this.btnUndoCase.Location = new System.Drawing.Point(196, 28);
            this.btnUndoCase.Name = "btnUndoCase";
            this.btnUndoCase.Size = new System.Drawing.Size(86, 30);
            this.btnUndoCase.TabIndex = 5;
            this.btnUndoCase.Text = "Undo Case";
            this.btnUndoCase.UseVisualStyleBackColor = true;
            this.btnUndoCase.Click += new System.EventHandler(this.btnUndoCase_Click);
            // 
            // btnExitLineMode
            // 
            this.btnExitLineMode.Location = new System.Drawing.Point(288, 28);
            this.btnExitLineMode.Name = "btnExitLineMode";
            this.btnExitLineMode.Size = new System.Drawing.Size(86, 30);
            this.btnExitLineMode.TabIndex = 6;
            this.btnExitLineMode.Text = "Exit Line Mode";
            this.btnExitLineMode.UseVisualStyleBackColor = true;
            this.btnExitLineMode.Click += new System.EventHandler(this.btnExitLineMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btnExitLineMode);
            this.Controls.Add(this.btnUndoCase);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnUndoActor);
            this.Controls.Add(this.btnClearAllLines);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use Case Helper";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsSave;
        private System.Windows.Forms.ToolStripMenuItem tsQuit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem tsActor;
        private System.Windows.Forms.ToolStripMenuItem tsUseCase;
        private System.Windows.Forms.ToolStripMenuItem tsLine;
        private System.Windows.Forms.Button btnClearAllLines;
        private System.Windows.Forms.Button btnUndoActor;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUndoCase;
        private System.Windows.Forms.Button btnExitLineMode;
    }
}

