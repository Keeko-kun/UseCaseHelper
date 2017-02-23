namespace UseCaseHelper
{
    partial class Element_List
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
            this.lbList = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbActor = new System.Windows.Forms.RadioButton();
            this.rbCase = new System.Windows.Forms.RadioButton();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(13, 65);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(590, 394);
            this.lbList.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSelect.Location = new System.Drawing.Point(13, 465);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(590, 56);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbCase);
            this.gbType.Controls.Add(this.rbActor);
            this.gbType.Location = new System.Drawing.Point(13, 12);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(143, 47);
            this.gbType.TabIndex = 2;
            this.gbType.TabStop = false;
            this.gbType.Text = "Element Type:";
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Location = new System.Drawing.Point(7, 20);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(50, 17);
            this.rbActor.TabIndex = 0;
            this.rbActor.TabStop = true;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            this.rbActor.CheckedChanged += new System.EventHandler(this.rbActor_CheckedChanged);
            // 
            // rbCase
            // 
            this.rbCase.AutoSize = true;
            this.rbCase.Location = new System.Drawing.Point(63, 20);
            this.rbCase.Name = "rbCase";
            this.rbCase.Size = new System.Drawing.Size(71, 17);
            this.rbCase.TabIndex = 1;
            this.rbCase.TabStop = true;
            this.rbCase.Text = "Use Case";
            this.rbCase.UseVisualStyleBackColor = true;
            this.rbCase.CheckedChanged += new System.EventHandler(this.rbCase_CheckedChanged);
            // 
            // Element_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 533);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lbList);
            this.Name = "Element_List";
            this.Text = "Element_List";
            this.Load += new System.EventHandler(this.Element_List_Load);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbCase;
        private System.Windows.Forms.RadioButton rbActor;
    }
}