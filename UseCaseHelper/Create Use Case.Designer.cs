namespace UseCaseHelper
{
    partial class Create_Use_Case
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrecondition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFlow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbException = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPostcondition = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(442, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summary:";
            // 
            // tbSummary
            // 
            this.tbSummary.Location = new System.Drawing.Point(12, 69);
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(442, 20);
            this.tbSummary.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actor(s):";
            // 
            // tbActors
            // 
            this.tbActors.Location = new System.Drawing.Point(12, 108);
            this.tbActors.Multiline = true;
            this.tbActors.Name = "tbActors";
            this.tbActors.Size = new System.Drawing.Size(442, 63);
            this.tbActors.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precondition(s):";
            // 
            // tbPrecondition
            // 
            this.tbPrecondition.Location = new System.Drawing.Point(12, 190);
            this.tbPrecondition.Multiline = true;
            this.tbPrecondition.Name = "tbPrecondition";
            this.tbPrecondition.Size = new System.Drawing.Size(442, 76);
            this.tbPrecondition.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Basic Flow:";
            // 
            // tbFlow
            // 
            this.tbFlow.Location = new System.Drawing.Point(12, 285);
            this.tbFlow.Multiline = true;
            this.tbFlow.Name = "tbFlow";
            this.tbFlow.Size = new System.Drawing.Size(442, 76);
            this.tbFlow.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Exception(s):";
            // 
            // tbException
            // 
            this.tbException.Location = new System.Drawing.Point(12, 380);
            this.tbException.Multiline = true;
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(442, 76);
            this.tbException.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Postcondition";
            // 
            // tbPostcondition
            // 
            this.tbPostcondition.Location = new System.Drawing.Point(12, 475);
            this.tbPostcondition.Name = "tbPostcondition";
            this.tbPostcondition.Size = new System.Drawing.Size(442, 20);
            this.tbPostcondition.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(354, 501);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 35);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Create_Use_Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 548);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbPostcondition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbException);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFlow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrecondition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbActors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Create_Use_Case";
            this.Text = "Use Case - New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrecondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFlow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPostcondition;
        private System.Windows.Forms.Button btnCreate;
    }
}