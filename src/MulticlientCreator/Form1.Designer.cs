namespace MulticlientCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNostalePath = new Label();
            lblIP = new Label();
            lblPort = new Label();
            txtNostalePath = new TextBox();
            btnBrowse = new Button();
            btnGenerate = new Button();
            txtIP = new TextBox();
            txtPort = new TextBox();
            madeBy = new Label();
            lblFileName = new Label();
            txtFileName = new TextBox();
            SuspendLayout();
            // 
            // lblNostalePath
            // 
            lblNostalePath.AutoSize = true;
            lblNostalePath.BackColor = SystemColors.ButtonHighlight;
            lblNostalePath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNostalePath.ForeColor = Color.Black;
            lblNostalePath.Location = new Point(9, 31);
            lblNostalePath.Name = "lblNostalePath";
            lblNostalePath.Size = new Size(116, 15);
            lblNostalePath.TabIndex = 0;
            lblNostalePath.Text = "NostaleClientX.exe:";
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIP.Location = new Point(53, 58);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(21, 15);
            lblIP.TabIndex = 3;
            lblIP.Text = "IP:";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPort.Location = new Point(40, 85);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(34, 15);
            lblPort.TabIndex = 5;
            lblPort.Text = "Port:";
            // 
            // txtNostalePath
            // 
            txtNostalePath.Location = new Point(131, 26);
            txtNostalePath.Name = "txtNostalePath";
            txtNostalePath.Size = new Size(263, 23);
            txtNostalePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(400, 26);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(70, 24);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(30, 160);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(457, 38);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate Multiclient";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtIP
            // 
            txtIP.ForeColor = SystemColors.GrayText;
            txtIP.Location = new Point(80, 55);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(176, 23);
            txtIP.TabIndex = 4;
            txtIP.Text = "Enter IP address";
            txtIP.Enter += txtIP_Enter;
            txtIP.Leave += txtIP_Leave;
            // 
            // txtPort
            // 
            txtPort.ForeColor = SystemColors.GrayText;
            txtPort.Location = new Point(80, 82);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(88, 23);
            txtPort.TabIndex = 6;
            txtPort.Text = "Enter port";
            txtPort.Enter += txtPort_Enter;
            txtPort.Leave += txtPort_Leave;
            // 
            // madeBy
            // 
            madeBy.BackColor = Color.Transparent;
            madeBy.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            madeBy.ForeColor = SystemColors.ActiveCaptionText;
            madeBy.Location = new Point(444, 306);
            madeBy.Name = "madeBy";
            madeBy.Size = new Size(109, 23);
            madeBy.TabIndex = 8;
            madeBy.Text = "Made by Fizo55.";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFileName.Location = new Point(9, 111);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(65, 15);
            lblFileName.TabIndex = 6;
            lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(80, 108);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(264, 23);
            txtFileName.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(542, 319);
            Controls.Add(btnGenerate);
            Controls.Add(txtPort);
            Controls.Add(lblPort);
            Controls.Add(txtIP);
            Controls.Add(lblIP);
            Controls.Add(btnBrowse);
            Controls.Add(txtNostalePath);
            Controls.Add(lblNostalePath);
            Controls.Add(madeBy);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MulticlientCreator by Fizo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFileName;
        private Label lblFileName;
        private Label lblNostalePath;
        private TextBox txtNostalePath;
        private Button btnBrowse;
        private Label lblIP;
        private TextBox txtIP;
        private Label lblPort;
        private TextBox txtPort;
        private Button btnGenerate;
        private Label madeBy;
    }
}
