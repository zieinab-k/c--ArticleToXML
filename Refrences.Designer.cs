namespace XmlCreat1
{
    partial class Refrences
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
            this.cmbPublicationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.cmbAck = new System.Windows.Forms.ComboBox();
            this.btnAck = new System.Windows.Forms.Button();
            this.rtxtAck = new System.Windows.Forms.RichTextBox();
            this.cmbJournals = new System.Windows.Forms.ComboBox();
            this.txtJournals = new System.Windows.Forms.TextBox();
            this.btnJournals = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPublicationType
            // 
            this.cmbPublicationType.FormattingEnabled = true;
            this.cmbPublicationType.Items.AddRange(new object[] {
            "journal",
            "book",
            "web"});
            this.cmbPublicationType.Location = new System.Drawing.Point(34, 36);
            this.cmbPublicationType.Name = "cmbPublicationType";
            this.cmbPublicationType.Size = new System.Drawing.Size(121, 21);
            this.cmbPublicationType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Publication-Type :";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(624, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(126, 95);
            this.btnInsert.TabIndex = 123;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 55);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(96, 143);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(32, 13);
            this.label56.TabIndex = 135;
            this.label56.Text = "Ack :";
            // 
            // cmbAck
            // 
            this.cmbAck.FormattingEnabled = true;
            this.cmbAck.Items.AddRange(new object[] {
            "Acknowledgement",
            "Conflict of Interest"});
            this.cmbAck.Location = new System.Drawing.Point(7, 159);
            this.cmbAck.Name = "cmbAck";
            this.cmbAck.Size = new System.Drawing.Size(121, 21);
            this.cmbAck.TabIndex = 134;
            // 
            // btnAck
            // 
            this.btnAck.Location = new System.Drawing.Point(53, 192);
            this.btnAck.Name = "btnAck";
            this.btnAck.Size = new System.Drawing.Size(75, 23);
            this.btnAck.TabIndex = 133;
            this.btnAck.Text = "Add";
            this.btnAck.UseVisualStyleBackColor = true;
            this.btnAck.Click += new System.EventHandler(this.btnAck_Click);
            // 
            // rtxtAck
            // 
            this.rtxtAck.Location = new System.Drawing.Point(134, 138);
            this.rtxtAck.Name = "rtxtAck";
            this.rtxtAck.Size = new System.Drawing.Size(271, 96);
            this.rtxtAck.TabIndex = 132;
            this.rtxtAck.Text = "";
            // 
            // cmbJournals
            // 
            this.cmbJournals.FormattingEnabled = true;
            this.cmbJournals.Items.AddRange(new object[] {
            "Names",
            "Others"});
            this.cmbJournals.Location = new System.Drawing.Point(265, 12);
            this.cmbJournals.Name = "cmbJournals";
            this.cmbJournals.Size = new System.Drawing.Size(121, 21);
            this.cmbJournals.TabIndex = 136;
         
            // 
            // txtJournals
            // 
            this.txtJournals.Location = new System.Drawing.Point(191, 39);
            this.txtJournals.Name = "txtJournals";
            this.txtJournals.Size = new System.Drawing.Size(401, 20);
            this.txtJournals.TabIndex = 137;
            // 
            // btnJournals
            // 
            this.btnJournals.Location = new System.Drawing.Point(230, 65);
            this.btnJournals.Name = "btnJournals";
            this.btnJournals.Size = new System.Drawing.Size(81, 29);
            this.btnJournals.TabIndex = 138;
            this.btnJournals.Text = "Journal";
            this.btnJournals.UseVisualStyleBackColor = true;
            this.btnJournals.Click += new System.EventHandler(this.btnJournals_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 140;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(489, 172);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(52, 13);
            this.label57.TabIndex = 141;
            this.label57.Text = "Numbers:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(195, 15);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(66, 13);
            this.label58.TabIndex = 142;
            this.label58.Text = "Insert-Type :";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(339, 65);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(87, 30);
            this.btnBook.TabIndex = 143;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(460, 65);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(81, 29);
            this.btnWeb.TabIndex = 144;
            this.btnWeb.Text = "Web";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refrences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 292);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnJournals);
            this.Controls.Add(this.txtJournals);
            this.Controls.Add(this.cmbJournals);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.cmbAck);
            this.Controls.Add(this.btnAck);
            this.Controls.Add(this.rtxtAck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPublicationType);
            this.Name = "Refrences";
            this.Text = "Refrences";
            this.Load += new System.EventHandler(this.Refrences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPublicationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox cmbAck;
        private System.Windows.Forms.Button btnAck;
        private System.Windows.Forms.RichTextBox rtxtAck;
        private System.Windows.Forms.ComboBox cmbJournals;
        private System.Windows.Forms.TextBox txtJournals;
        private System.Windows.Forms.Button btnJournals;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnWeb;
    }
}