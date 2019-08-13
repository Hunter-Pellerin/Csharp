namespace Arduino_Lightswitch
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
            this.components = new System.ComponentModel.Container();
            this.on_button = new System.Windows.Forms.Button();
            this.off_button = new System.Windows.Forms.Button();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.statusIndicator = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // on_button
            // 
            this.on_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.on_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.on_button.Location = new System.Drawing.Point(56, 35);
            this.on_button.Name = "on_button";
            this.on_button.Size = new System.Drawing.Size(108, 37);
            this.on_button.TabIndex = 0;
            this.on_button.Text = "ON";
            this.on_button.UseVisualStyleBackColor = true;
            this.on_button.Click += new System.EventHandler(this.On_button_Click);
            // 
            // off_button
            // 
            this.off_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.off_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.off_button.Location = new System.Drawing.Point(56, 139);
            this.off_button.Name = "off_button";
            this.off_button.Size = new System.Drawing.Size(108, 37);
            this.off_button.TabIndex = 1;
            this.off_button.Text = "OFF";
            this.off_button.UseVisualStyleBackColor = true;
            this.off_button.Click += new System.EventHandler(this.Off_button_Click);
            // 
            // port
            // 
            this.port.PortName = "COM3";
            // 
            // statusIndicator
            // 
            this.statusIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusIndicator.AutoSize = true;
            this.statusIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusIndicator.Location = new System.Drawing.Point(17, 20);
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(41, 20);
            this.statusIndicator.TabIndex = 3;
            this.statusIndicator.Text = "OFF";
            this.statusIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.statusIndicator);
            this.groupBox1.Location = new System.Drawing.Point(72, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.off_button);
            this.Controls.Add(this.on_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Light Boi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button on_button;
        private System.Windows.Forms.Button off_button;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Label statusIndicator;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

