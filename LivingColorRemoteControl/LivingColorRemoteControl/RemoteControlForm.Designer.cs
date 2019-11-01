namespace LivingColorRemoteControl
{
    partial class RemoteControlForm
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
            this.redSlider = new System.Windows.Forms.TrackBar();
            this.greenSlider = new System.Windows.Forms.TrackBar();
            this.blueSlider = new System.Windows.Forms.TrackBar();
            this.redSliderLabel = new System.Windows.Forms.Label();
            this.greenSliderLabel = new System.Windows.Forms.Label();
            this.blueSliderLabel = new System.Windows.Forms.Label();
            this.controlFromPCButton = new System.Windows.Forms.Button();
            this.pcColorPanel = new System.Windows.Forms.Panel();
            this.remoteControlGroupBox = new System.Windows.Forms.GroupBox();
            this.btnAddPreset = new System.Windows.Forms.Button();
            this.tbxNaamPc = new System.Windows.Forms.TextBox();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.whoIsInControlLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.disconnecButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxNaamArduino = new System.Windows.Forms.TextBox();
            this.arduinoBlueTextBox = new System.Windows.Forms.TextBox();
            this.arduinoColorPanel = new System.Windows.Forms.Panel();
            this.arduinoGreenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arduinoRedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).BeginInit();
            this.remoteControlGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // redSlider
            // 
            this.redSlider.Location = new System.Drawing.Point(4, 37);
            this.redSlider.Margin = new System.Windows.Forms.Padding(2);
            this.redSlider.Maximum = 255;
            this.redSlider.Name = "redSlider";
            this.redSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redSlider.Size = new System.Drawing.Size(45, 263);
            this.redSlider.TabIndex = 0;
            this.redSlider.TickFrequency = 5;
            this.redSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.redSlider.Scroll += new System.EventHandler(this.redSlider_Scroll);
            // 
            // greenSlider
            // 
            this.greenSlider.Location = new System.Drawing.Point(51, 37);
            this.greenSlider.Margin = new System.Windows.Forms.Padding(2);
            this.greenSlider.Maximum = 255;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenSlider.Size = new System.Drawing.Size(45, 263);
            this.greenSlider.TabIndex = 0;
            this.greenSlider.TickFrequency = 5;
            this.greenSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.greenSlider.Scroll += new System.EventHandler(this.greenSlider_Scroll);
            // 
            // blueSlider
            // 
            this.blueSlider.Location = new System.Drawing.Point(98, 37);
            this.blueSlider.Margin = new System.Windows.Forms.Padding(2);
            this.blueSlider.Maximum = 255;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueSlider.Size = new System.Drawing.Size(45, 263);
            this.blueSlider.TabIndex = 0;
            this.blueSlider.TickFrequency = 5;
            this.blueSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.blueSlider.Scroll += new System.EventHandler(this.blueSlider_Scroll);
            // 
            // redSliderLabel
            // 
            this.redSliderLabel.AutoSize = true;
            this.redSliderLabel.Location = new System.Drawing.Point(9, 303);
            this.redSliderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redSliderLabel.Name = "redSliderLabel";
            this.redSliderLabel.Size = new System.Drawing.Size(27, 13);
            this.redSliderLabel.TabIndex = 1;
            this.redSliderLabel.Text = "Red";
            // 
            // greenSliderLabel
            // 
            this.greenSliderLabel.AutoSize = true;
            this.greenSliderLabel.Location = new System.Drawing.Point(49, 303);
            this.greenSliderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greenSliderLabel.Name = "greenSliderLabel";
            this.greenSliderLabel.Size = new System.Drawing.Size(36, 13);
            this.greenSliderLabel.TabIndex = 1;
            this.greenSliderLabel.Text = "Green";
            // 
            // blueSliderLabel
            // 
            this.blueSliderLabel.AutoSize = true;
            this.blueSliderLabel.Location = new System.Drawing.Point(102, 303);
            this.blueSliderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueSliderLabel.Name = "blueSliderLabel";
            this.blueSliderLabel.Size = new System.Drawing.Size(28, 13);
            this.blueSliderLabel.TabIndex = 1;
            this.blueSliderLabel.Text = "Blue";
            // 
            // controlFromPCButton
            // 
            this.controlFromPCButton.Location = new System.Drawing.Point(169, 24);
            this.controlFromPCButton.Margin = new System.Windows.Forms.Padding(2);
            this.controlFromPCButton.Name = "controlFromPCButton";
            this.controlFromPCButton.Size = new System.Drawing.Size(101, 28);
            this.controlFromPCButton.TabIndex = 2;
            this.controlFromPCButton.Text = "Control from PC";
            this.controlFromPCButton.UseVisualStyleBackColor = true;
            this.controlFromPCButton.Click += new System.EventHandler(this.controlFromPCButton_Click);
            // 
            // pcColorPanel
            // 
            this.pcColorPanel.BackColor = System.Drawing.Color.Black;
            this.pcColorPanel.Location = new System.Drawing.Point(144, 77);
            this.pcColorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pcColorPanel.Name = "pcColorPanel";
            this.pcColorPanel.Size = new System.Drawing.Size(126, 89);
            this.pcColorPanel.TabIndex = 3;
            // 
            // remoteControlGroupBox
            // 
            this.remoteControlGroupBox.Controls.Add(this.btnAddPreset);
            this.remoteControlGroupBox.Controls.Add(this.tbxNaamPc);
            this.remoteControlGroupBox.Controls.Add(this.blueTextBox);
            this.remoteControlGroupBox.Controls.Add(this.greenTextBox);
            this.remoteControlGroupBox.Controls.Add(this.redTextBox);
            this.remoteControlGroupBox.Controls.Add(this.pcColorPanel);
            this.remoteControlGroupBox.Controls.Add(this.greenSlider);
            this.remoteControlGroupBox.Controls.Add(this.redSlider);
            this.remoteControlGroupBox.Controls.Add(this.blueSlider);
            this.remoteControlGroupBox.Controls.Add(this.blueSliderLabel);
            this.remoteControlGroupBox.Controls.Add(this.redSliderLabel);
            this.remoteControlGroupBox.Controls.Add(this.greenSliderLabel);
            this.remoteControlGroupBox.Location = new System.Drawing.Point(9, 88);
            this.remoteControlGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.remoteControlGroupBox.Name = "remoteControlGroupBox";
            this.remoteControlGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.remoteControlGroupBox.Size = new System.Drawing.Size(280, 349);
            this.remoteControlGroupBox.TabIndex = 4;
            this.remoteControlGroupBox.TabStop = false;
            this.remoteControlGroupBox.Text = "Control the color from the PC";
            // 
            // btnAddPreset
            // 
            this.btnAddPreset.Location = new System.Drawing.Point(158, 215);
            this.btnAddPreset.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPreset.Name = "btnAddPreset";
            this.btnAddPreset.Size = new System.Drawing.Size(101, 28);
            this.btnAddPreset.TabIndex = 5;
            this.btnAddPreset.Text = "AddPresetColor";
            this.btnAddPreset.UseVisualStyleBackColor = true;
            this.btnAddPreset.Click += new System.EventHandler(this.btnAddPreset_Click);
            // 
            // tbxNaamPc
            // 
            this.tbxNaamPc.Location = new System.Drawing.Point(144, 191);
            this.tbxNaamPc.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNaamPc.MaxLength = 10;
            this.tbxNaamPc.Name = "tbxNaamPc";
            this.tbxNaamPc.Size = new System.Drawing.Size(124, 20);
            this.tbxNaamPc.TabIndex = 6;
            // 
            // blueTextBox
            // 
            this.blueTextBox.Enabled = false;
            this.blueTextBox.Location = new System.Drawing.Point(98, 319);
            this.blueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(31, 20);
            this.blueTextBox.TabIndex = 4;
            // 
            // greenTextBox
            // 
            this.greenTextBox.Enabled = false;
            this.greenTextBox.Location = new System.Drawing.Point(51, 319);
            this.greenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(31, 20);
            this.greenTextBox.TabIndex = 4;
            // 
            // redTextBox
            // 
            this.redTextBox.Enabled = false;
            this.redTextBox.Location = new System.Drawing.Point(4, 320);
            this.redTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(31, 20);
            this.redTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.whoIsInControlLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.disconnecButton);
            this.groupBox2.Controls.Add(this.connectButton);
            this.groupBox2.Controls.Add(this.controlFromPCButton);
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(433, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // whoIsInControlLabel
            // 
            this.whoIsInControlLabel.AutoSize = true;
            this.whoIsInControlLabel.Location = new System.Drawing.Point(340, 32);
            this.whoIsInControlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whoIsInControlLabel.Name = "whoIsInControlLabel";
            this.whoIsInControlLabel.Size = new System.Drawing.Size(10, 13);
            this.whoIsInControlLabel.TabIndex = 4;
            this.whoIsInControlLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "In Control:";
            // 
            // disconnecButton
            // 
            this.disconnecButton.Location = new System.Drawing.Point(86, 24);
            this.disconnecButton.Margin = new System.Windows.Forms.Padding(2);
            this.disconnecButton.Name = "disconnecButton";
            this.disconnecButton.Size = new System.Drawing.Size(79, 28);
            this.disconnecButton.TabIndex = 2;
            this.disconnecButton.Text = "Disconnect";
            this.disconnecButton.UseVisualStyleBackColor = true;
            this.disconnecButton.Click += new System.EventHandler(this.disconnecButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(11, 24);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(70, 28);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxNaamArduino);
            this.groupBox3.Controls.Add(this.arduinoBlueTextBox);
            this.groupBox3.Controls.Add(this.arduinoColorPanel);
            this.groupBox3.Controls.Add(this.arduinoGreenTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.arduinoRedTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(293, 88);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(293, 349);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitor color from the Arduino";
            // 
            // tbxNaamArduino
            // 
            this.tbxNaamArduino.Enabled = false;
            this.tbxNaamArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNaamArduino.Location = new System.Drawing.Point(12, 215);
            this.tbxNaamArduino.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNaamArduino.Name = "tbxNaamArduino";
            this.tbxNaamArduino.Size = new System.Drawing.Size(277, 49);
            this.tbxNaamArduino.TabIndex = 5;
            // 
            // arduinoBlueTextBox
            // 
            this.arduinoBlueTextBox.Enabled = false;
            this.arduinoBlueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arduinoBlueTextBox.Location = new System.Drawing.Point(198, 71);
            this.arduinoBlueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.arduinoBlueTextBox.Name = "arduinoBlueTextBox";
            this.arduinoBlueTextBox.Size = new System.Drawing.Size(91, 47);
            this.arduinoBlueTextBox.TabIndex = 4;
            this.arduinoBlueTextBox.Text = "0";
            // 
            // arduinoColorPanel
            // 
            this.arduinoColorPanel.BackColor = System.Drawing.Color.Black;
            this.arduinoColorPanel.Location = new System.Drawing.Point(12, 122);
            this.arduinoColorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.arduinoColorPanel.Name = "arduinoColorPanel";
            this.arduinoColorPanel.Size = new System.Drawing.Size(277, 89);
            this.arduinoColorPanel.TabIndex = 3;
            // 
            // arduinoGreenTextBox
            // 
            this.arduinoGreenTextBox.Enabled = false;
            this.arduinoGreenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.arduinoGreenTextBox.Location = new System.Drawing.Point(107, 71);
            this.arduinoGreenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.arduinoGreenTextBox.Name = "arduinoGreenTextBox";
            this.arduinoGreenTextBox.Size = new System.Drawing.Size(87, 47);
            this.arduinoGreenTextBox.TabIndex = 4;
            this.arduinoGreenTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Green";
            // 
            // arduinoRedTextBox
            // 
            this.arduinoRedTextBox.Enabled = false;
            this.arduinoRedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.arduinoRedTextBox.Location = new System.Drawing.Point(12, 71);
            this.arduinoRedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.arduinoRedTextBox.Name = "arduinoRedTextBox";
            this.arduinoRedTextBox.Size = new System.Drawing.Size(91, 47);
            this.arduinoRedTextBox.TabIndex = 4;
            this.arduinoRedTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blue";
            // 
            // RemoteControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.remoteControlGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoteControlForm";
            this.Text = "Living Color Remote Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoteControlForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).EndInit();
            this.remoteControlGroupBox.ResumeLayout(false);
            this.remoteControlGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar redSlider;
        private System.Windows.Forms.TrackBar greenSlider;
        private System.Windows.Forms.TrackBar blueSlider;
        private System.Windows.Forms.Label redSliderLabel;
        private System.Windows.Forms.Label greenSliderLabel;
        private System.Windows.Forms.Label blueSliderLabel;
        private System.Windows.Forms.Button controlFromPCButton;
        private System.Windows.Forms.Panel pcColorPanel;
        private System.Windows.Forms.GroupBox remoteControlGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel arduinoColorPanel;
        private System.Windows.Forms.Label whoIsInControlLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.TextBox arduinoBlueTextBox;
        private System.Windows.Forms.TextBox arduinoGreenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arduinoRedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button disconnecButton;
        private System.Windows.Forms.TextBox tbxNaamArduino;
        private System.Windows.Forms.TextBox tbxNaamPc;
        private System.Windows.Forms.Button btnAddPreset;
    }
}

