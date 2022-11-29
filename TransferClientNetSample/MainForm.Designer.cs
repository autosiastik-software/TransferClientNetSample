namespace TransferClientNetSample
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnQrCode = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.vin = new System.Windows.Forms.Label();
            this.tsn = new System.Windows.Forms.Label();
            this.hsn = new System.Windows.Forms.Label();
            this.plate = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.processBar = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // btnQrCode
            // 
            this.btnQrCode.Location = new System.Drawing.Point(111, 318);
            this.btnQrCode.Name = "btnQrCode";
            this.btnQrCode.Size = new System.Drawing.Size(117, 23);
            this.btnQrCode.TabIndex = 4;
            this.btnQrCode.Text = "Show QR Code";
            this.btnQrCode.UseVisualStyleBackColor = true;
            this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panelResult);
            this.groupBox.Location = new System.Drawing.Point(12, 347);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(300, 100);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Fahrzeug";
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.vin);
            this.panelResult.Controls.Add(this.tsn);
            this.panelResult.Controls.Add(this.hsn);
            this.panelResult.Controls.Add(this.plate);
            this.panelResult.Location = new System.Drawing.Point(6, 22);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(288, 72);
            this.panelResult.TabIndex = 0;
            this.panelResult.Visible = false;
            // 
            // vin
            // 
            this.vin.AutoSize = true;
            this.vin.Location = new System.Drawing.Point(3, 40);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(29, 15);
            this.vin.TabIndex = 3;
            this.vin.Text = "VIN:";
            // 
            // tsn
            // 
            this.tsn.AutoSize = true;
            this.tsn.Location = new System.Drawing.Point(123, 25);
            this.tsn.Name = "tsn";
            this.tsn.Size = new System.Drawing.Size(31, 15);
            this.tsn.TabIndex = 2;
            this.tsn.Text = "TSN:";
            // 
            // hsn
            // 
            this.hsn.AutoSize = true;
            this.hsn.Location = new System.Drawing.Point(3, 25);
            this.hsn.Name = "hsn";
            this.hsn.Size = new System.Drawing.Size(37, 15);
            this.hsn.TabIndex = 1;
            this.hsn.Text = "HSN: ";
            // 
            // plate
            // 
            this.plate.AutoSize = true;
            this.plate.Location = new System.Drawing.Point(3, 10);
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(80, 15);
            this.plate.TabIndex = 0;
            this.plate.Text = "Kennzeichen: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processBar,
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(328, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // processBar
            // 
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(100, 16);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 475);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnQrCode);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Button btnQrCode;
        private GroupBox groupBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel status;
        private ToolStripProgressBar processBar;
        private Panel panelResult;
        private Label vin;
        private Label tsn;
        private Label hsn;
        private Label plate;
    }
}