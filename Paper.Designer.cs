namespace XmlCreat1
{
    partial class Paper
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
            this.btnHeader = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.bynBody = new System.Windows.Forms.Button();
            this.btnRefrence = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHeader
            // 
            this.btnHeader.Location = new System.Drawing.Point(41, 50);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(75, 23);
            this.btnHeader.TabIndex = 0;
            this.btnHeader.Text = "Header";
            this.btnHeader.UseVisualStyleBackColor = true;
            this.btnHeader.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(179, 95);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(87, 55);
            this.btnMerge.TabIndex = 2;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // bynBody
            // 
            this.bynBody.Location = new System.Drawing.Point(41, 95);
            this.bynBody.Name = "bynBody";
            this.bynBody.Size = new System.Drawing.Size(75, 23);
            this.bynBody.TabIndex = 3;
            this.bynBody.Text = "Body";
            this.bynBody.UseVisualStyleBackColor = true;
            this.bynBody.Click += new System.EventHandler(this.bynBody_Click);
            // 
            // btnRefrence
            // 
            this.btnRefrence.Location = new System.Drawing.Point(41, 137);
            this.btnRefrence.Name = "btnRefrence";
            this.btnRefrence.Size = new System.Drawing.Size(75, 23);
            this.btnRefrence.TabIndex = 4;
            this.btnRefrence.Text = "Refrence";
            this.btnRefrence.UseVisualStyleBackColor = true;
            this.btnRefrence.Click += new System.EventHandler(this.btnRefrence_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(179, 63);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Name :";
            // 
            // Paper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnRefrence);
            this.Controls.Add(this.bynBody);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnHeader);
            this.Name = "Paper";
            this.Text = "Paper";
            this.Load += new System.EventHandler(this.Paper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHeader;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button bynBody;
        private System.Windows.Forms.Button btnRefrence;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;


    }
}