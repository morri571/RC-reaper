using System.Windows.Forms;

namespace Reaper_flight_software
{
    partial class FormFlightTest
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
        /// 

        private TrackBar throttleTrackBar;
        private Label throttleLabel;
        private NumericUpDown pitchNumericUpDown;
        private Label pitchLabel;
        private NumericUpDown yawNumericUpDown;
        private Label yawLabel;
        private NumericUpDown rollNumericUpDown;
        private Label rollLabel;

        private void InitializeComponent()
        {
            this.throttleTrackBar = new System.Windows.Forms.TrackBar();
            this.throttleLabel = new System.Windows.Forms.Label();
            this.pitchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pitchLabel = new System.Windows.Forms.Label();
            this.yawNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yawLabel = new System.Windows.Forms.Label();
            this.rollNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rollLabel = new System.Windows.Forms.Label();
            this.buttonConfigure = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.buttonClosePort = new System.Windows.Forms.Button();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelPortNames = new System.Windows.Forms.Label();
            this.comboBoxPortNames = new System.Windows.Forms.ComboBox();
            this.labelParityBits = new System.Windows.Forms.Label();
            this.comboBoxParityBits = new System.Windows.Forms.ComboBox();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.textBoxMessageSent = new System.Windows.Forms.TextBox();
            this.textBoxMessageReceived = new System.Windows.Forms.TextBox();
            this.labelMessageSent = new System.Windows.Forms.Label();
            this.labelMessageReceived = new System.Windows.Forms.Label();
            this.labelRPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.throttleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // throttleTrackBar
            // 
            this.throttleTrackBar.BackColor = System.Drawing.Color.Indigo;
            this.throttleTrackBar.Enabled = false;
            this.throttleTrackBar.Location = new System.Drawing.Point(640, 70);
            this.throttleTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.throttleTrackBar.Maximum = 10000;
            this.throttleTrackBar.Minimum = 5000;
            this.throttleTrackBar.Name = "throttleTrackBar";
            this.throttleTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.throttleTrackBar.Size = new System.Drawing.Size(56, 437);
            this.throttleTrackBar.TabIndex = 0;
            this.throttleTrackBar.TickFrequency = 100;
            this.throttleTrackBar.Value = 5000;
            this.throttleTrackBar.ValueChanged += new System.EventHandler(this.throttleTrackBar_ValueChanged);
            this.throttleTrackBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.throttleTrackBar_KeyPress);
            // 
            // throttleLabel
            // 
            this.throttleLabel.AutoSize = true;
            this.throttleLabel.Location = new System.Drawing.Point(636, 50);
            this.throttleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(55, 16);
            this.throttleLabel.TabIndex = 1;
            this.throttleLabel.Text = "Throttle:";
            // 
            // pitchNumericUpDown
            // 
            this.pitchNumericUpDown.Location = new System.Drawing.Point(14, 485);
            this.pitchNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.pitchNumericUpDown.Name = "pitchNumericUpDown";
            this.pitchNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.pitchNumericUpDown.TabIndex = 1;
            // 
            // pitchLabel
            // 
            this.pitchLabel.AutoSize = true;
            this.pitchLabel.Location = new System.Drawing.Point(10, 434);
            this.pitchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pitchLabel.Name = "pitchLabel";
            this.pitchLabel.Size = new System.Drawing.Size(39, 16);
            this.pitchLabel.TabIndex = 2;
            this.pitchLabel.Text = "Pitch:";
            // 
            // yawNumericUpDown
            // 
            this.yawNumericUpDown.Location = new System.Drawing.Point(214, 485);
            this.yawNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.yawNumericUpDown.Name = "yawNumericUpDown";
            this.yawNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.yawNumericUpDown.TabIndex = 2;
            // 
            // yawLabel
            // 
            this.yawLabel.AutoSize = true;
            this.yawLabel.Location = new System.Drawing.Point(210, 434);
            this.yawLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yawLabel.Name = "yawLabel";
            this.yawLabel.Size = new System.Drawing.Size(36, 16);
            this.yawLabel.TabIndex = 3;
            this.yawLabel.Text = "Yaw:";
            // 
            // rollNumericUpDown
            // 
            this.rollNumericUpDown.Location = new System.Drawing.Point(414, 485);
            this.rollNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.rollNumericUpDown.Name = "rollNumericUpDown";
            this.rollNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.rollNumericUpDown.TabIndex = 3;
            // 
            // rollLabel
            // 
            this.rollLabel.AutoSize = true;
            this.rollLabel.Location = new System.Drawing.Point(410, 434);
            this.rollLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rollLabel.Name = "rollLabel";
            this.rollLabel.Size = new System.Drawing.Size(34, 16);
            this.rollLabel.TabIndex = 4;
            this.rollLabel.Text = "Roll:";
            // 
            // buttonConfigure
            // 
            this.buttonConfigure.BackColor = System.Drawing.Color.Lime;
            this.buttonConfigure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfigure.Location = new System.Drawing.Point(29, 54);
            this.buttonConfigure.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfigure.Name = "buttonConfigure";
            this.buttonConfigure.Size = new System.Drawing.Size(163, 44);
            this.buttonConfigure.TabIndex = 5;
            this.buttonConfigure.Text = "Configure";
            this.buttonConfigure.UseVisualStyleBackColor = false;
            this.buttonConfigure.Click += new System.EventHandler(this.buttonConfigure_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(217, 85);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(160, 24);
            this.comboBoxBaudRate.TabIndex = 6;
            // 
            // buttonClosePort
            // 
            this.buttonClosePort.BackColor = System.Drawing.Color.Red;
            this.buttonClosePort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClosePort.Location = new System.Drawing.Point(29, 107);
            this.buttonClosePort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClosePort.Name = "buttonClosePort";
            this.buttonClosePort.Size = new System.Drawing.Size(163, 44);
            this.buttonClosePort.TabIndex = 7;
            this.buttonClosePort.Text = "Close Port";
            this.buttonClosePort.UseVisualStyleBackColor = false;
            this.buttonClosePort.Click += new System.EventHandler(this.buttonClosePort_Click);
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.Location = new System.Drawing.Point(399, 89);
            this.labelBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(77, 22);
            this.labelBaudRate.TabIndex = 8;
            this.labelBaudRate.Text = "Baud Rate";
            // 
            // labelPortNames
            // 
            this.labelPortNames.Location = new System.Drawing.Point(399, 57);
            this.labelPortNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPortNames.Name = "labelPortNames";
            this.labelPortNames.Size = new System.Drawing.Size(77, 22);
            this.labelPortNames.TabIndex = 10;
            this.labelPortNames.Text = "Ports";
            // 
            // comboBoxPortNames
            // 
            this.comboBoxPortNames.FormattingEnabled = true;
            this.comboBoxPortNames.Location = new System.Drawing.Point(217, 53);
            this.comboBoxPortNames.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPortNames.Name = "comboBoxPortNames";
            this.comboBoxPortNames.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPortNames.TabIndex = 9;
            // 
            // labelParityBits
            // 
            this.labelParityBits.Location = new System.Drawing.Point(399, 122);
            this.labelParityBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParityBits.Name = "labelParityBits";
            this.labelParityBits.Size = new System.Drawing.Size(77, 22);
            this.labelParityBits.TabIndex = 14;
            this.labelParityBits.Text = "Parity Bits";
            // 
            // comboBoxParityBits
            // 
            this.comboBoxParityBits.FormattingEnabled = true;
            this.comboBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParityBits.Location = new System.Drawing.Point(217, 118);
            this.comboBoxParityBits.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxParityBits.Name = "comboBoxParityBits";
            this.comboBoxParityBits.Size = new System.Drawing.Size(160, 24);
            this.comboBoxParityBits.TabIndex = 13;
            // 
            // labelDataBits
            // 
            this.labelDataBits.Location = new System.Drawing.Point(399, 154);
            this.labelDataBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(77, 22);
            this.labelDataBits.TabIndex = 12;
            this.labelDataBits.Text = "Data Bits";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(217, 150);
            this.comboBoxDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDataBits.TabIndex = 11;
            // 
            // labelStopBits
            // 
            this.labelStopBits.Location = new System.Drawing.Point(399, 187);
            this.labelStopBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(77, 22);
            this.labelStopBits.TabIndex = 18;
            this.labelStopBits.Text = "Stop Bits";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(217, 183);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(160, 24);
            this.comboBoxStopBits.TabIndex = 17;
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPower.BackColor = System.Drawing.Color.Red;
            this.checkBoxPower.Location = new System.Drawing.Point(568, 60);
            this.checkBoxPower.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(64, 74);
            this.checkBoxPower.TabIndex = 19;
            this.checkBoxPower.Text = "On/Off";
            this.checkBoxPower.UseVisualStyleBackColor = false;
            this.checkBoxPower.CheckedChanged += new System.EventHandler(this.checkBoxPower_CheckedChanged);
            // 
            // textBoxMessageSent
            // 
            this.textBoxMessageSent.Location = new System.Drawing.Point(933, 195);
            this.textBoxMessageSent.Multiline = true;
            this.textBoxMessageSent.Name = "textBoxMessageSent";
            this.textBoxMessageSent.Size = new System.Drawing.Size(134, 53);
            this.textBoxMessageSent.TabIndex = 20;
            // 
            // textBoxMessageReceived
            // 
            this.textBoxMessageReceived.Location = new System.Drawing.Point(933, 265);
            this.textBoxMessageReceived.Multiline = true;
            this.textBoxMessageReceived.Name = "textBoxMessageReceived";
            this.textBoxMessageReceived.Size = new System.Drawing.Size(134, 53);
            this.textBoxMessageReceived.TabIndex = 21;
            // 
            // labelMessageSent
            // 
            this.labelMessageSent.Location = new System.Drawing.Point(790, 199);
            this.labelMessageSent.Name = "labelMessageSent";
            this.labelMessageSent.Size = new System.Drawing.Size(137, 23);
            this.labelMessageSent.TabIndex = 22;
            this.labelMessageSent.Text = "Message Sent";
            // 
            // labelMessageReceived
            // 
            this.labelMessageReceived.Location = new System.Drawing.Point(790, 265);
            this.labelMessageReceived.Name = "labelMessageReceived";
            this.labelMessageReceived.Size = new System.Drawing.Size(137, 23);
            this.labelMessageReceived.TabIndex = 23;
            this.labelMessageReceived.Text = "Message Received";
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPM.Location = new System.Drawing.Point(562, 237);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(69, 25);
            this.labelRPM.TabIndex = 24;
            this.labelRPM.Text = "RPM\'s";
            // 
            // FormFlightTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 535);
            this.Controls.Add(this.labelRPM);
            this.Controls.Add(this.labelMessageReceived);
            this.Controls.Add(this.labelMessageSent);
            this.Controls.Add(this.textBoxMessageReceived);
            this.Controls.Add(this.textBoxMessageSent);
            this.Controls.Add(this.checkBoxPower);
            this.Controls.Add(this.labelStopBits);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.labelParityBits);
            this.Controls.Add(this.comboBoxParityBits);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.labelPortNames);
            this.Controls.Add(this.comboBoxPortNames);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.buttonClosePort);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.buttonConfigure);
            this.Controls.Add(this.throttleTrackBar);
            this.Controls.Add(this.throttleLabel);
            this.Controls.Add(this.pitchNumericUpDown);
            this.Controls.Add(this.pitchLabel);
            this.Controls.Add(this.yawNumericUpDown);
            this.Controls.Add(this.yawLabel);
            this.Controls.Add(this.rollNumericUpDown);
            this.Controls.Add(this.rollLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFlightTest";
            this.Text = "Flight Test Software";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.throttleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button buttonConfigure;
        private ComboBox comboBoxBaudRate;
        private Button buttonClosePort;
        private Label labelBaudRate;
        private Label labelPortNames;
        private ComboBox comboBoxPortNames;
        private Label labelParityBits;
        private ComboBox comboBoxParityBits;
        private Label labelDataBits;
        private ComboBox comboBoxDataBits;
        private Label labelStopBits;
        private ComboBox comboBoxStopBits;
        private CheckBox checkBoxPower;
        private TextBox textBoxMessageSent;
        private TextBox textBoxMessageReceived;
        private Label labelMessageSent;
        private Label labelMessageReceived;
        private Label labelRPM;
    }
}

#endregion Windows Form Designer generated code