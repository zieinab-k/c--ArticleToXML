namespace XmlCreat1
{
    partial class Body1
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.rtxtSec = new System.Windows.Forms.RichTextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNSec = new System.Windows.Forms.TextBox();
            this.btnNSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(534, 15);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // rtxtSec
            // 
            this.rtxtSec.Location = new System.Drawing.Point(31, 52);
            this.rtxtSec.Name = "rtxtSec";
            this.rtxtSec.Size = new System.Drawing.Size(739, 279);
            this.rtxtSec.TabIndex = 1;
            this.rtxtSec.Text = "";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(665, 12);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "Sec";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNSec
            // 
            this.txtNSec.Location = new System.Drawing.Point(110, 18);
            this.txtNSec.Name = "txtNSec";
            this.txtNSec.Size = new System.Drawing.Size(100, 20);
            this.txtNSec.TabIndex = 5;
            // 
            // btnNSec
            // 
            this.btnNSec.Location = new System.Drawing.Point(216, 15);
            this.btnNSec.Name = "btnNSec";
            this.btnNSec.Size = new System.Drawing.Size(75, 23);
            this.btnNSec.TabIndex = 6;
            this.btnNSec.Text = "Num/Sec";
            this.btnNSec.UseVisualStyleBackColor = true;
            this.btnNSec.Click += new System.EventHandler(this.btnNSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Sec :";
            // 
            // Body1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNSec);
            this.Controls.Add(this.txtNSec);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.rtxtSec);
            this.Controls.Add(this.txtTitle);
            this.Name = "Body1";
            this.Text = "Body1";
            this.Load += new System.EventHandler(this.Body1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox rtxtSec;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNSec;
        private System.Windows.Forms.Button btnNSec;
        private System.Windows.Forms.Label label2;

        public System.EventHandler Body1_Load { get; set; }
    }
}