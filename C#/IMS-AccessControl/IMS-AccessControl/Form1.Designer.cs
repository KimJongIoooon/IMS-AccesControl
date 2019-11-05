namespace IMS_AccessControl
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCardID = new System.Windows.Forms.TextBox();
            this.nudStartTime = new System.Windows.Forms.NumericUpDown();
            this.nudEndTime = new System.Windows.Forms.NumericUpDown();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndTime)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(249, 377);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(12, 9);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(52, 17);
            this.lblConnectionStatus.TabIndex = 2;
            this.lblConnectionStatus.Text = "Status:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(383, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(539, 292);
            this.listBox1.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(368, 33);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 4;
            // 
            // tbxCardID
            // 
            this.tbxCardID.Location = new System.Drawing.Point(474, 34);
            this.tbxCardID.Name = "tbxCardID";
            this.tbxCardID.Size = new System.Drawing.Size(100, 22);
            this.tbxCardID.TabIndex = 5;
            // 
            // nudStartTime
            // 
            this.nudStartTime.Location = new System.Drawing.Point(580, 35);
            this.nudStartTime.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.nudStartTime.Name = "nudStartTime";
            this.nudStartTime.Size = new System.Drawing.Size(120, 22);
            this.nudStartTime.TabIndex = 6;
            // 
            // nudEndTime
            // 
            this.nudEndTime.Location = new System.Drawing.Point(706, 36);
            this.nudEndTime.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.nudEndTime.Name = "nudEndTime";
            this.nudEndTime.Size = new System.Drawing.Size(120, 22);
            this.nudEndTime.TabIndex = 7;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(832, 12);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(126, 23);
            this.btnAddCard.TabIndex = 8;
            this.btnAddCard.Text = "Pas toevoegen";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.BtnAddCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "pasNr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "starttijd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "eindtijd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(832, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "addCard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(96, 32);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(168, 23);
            this.btnSync.TabIndex = 14;
            this.btnSync.Text = "sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.nudEndTime);
            this.Controls.Add(this.nudStartTime);
            this.Controls.Add(this.tbxCardID);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxCardID;
        private System.Windows.Forms.NumericUpDown nudStartTime;
        private System.Windows.Forms.NumericUpDown nudEndTime;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSync;
    }
}

