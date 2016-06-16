namespace ALP_Desktop_2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintQRCode = new System.Windows.Forms.Button();
            this.imgQRImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrintNo = new System.Windows.Forms.Label();
            this.txtServiceProviderContact = new System.Windows.Forms.TextBox();
            this.txtProjectCode = new System.Windows.Forms.TextBox();
            this.lblServiceProviderContact = new System.Windows.Forms.Label();
            this.lblProjectCode = new System.Windows.Forms.Label();
            this.lblServiceProvider = new System.Windows.Forms.Label();
            this.txtServiceProvider = new System.Windows.Forms.TextBox();
            this.numPrintNo = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateQRCode = new System.Windows.Forms.Button();
            this.pnlMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQRImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrintNo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainLayout
            // 
            this.pnlMainLayout.ColumnCount = 2;
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMainLayout.Controls.Add(this.btnPrintQRCode, 1, 2);
            this.pnlMainLayout.Controls.Add(this.imgQRImage, 0, 0);
            this.pnlMainLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.pnlMainLayout.Controls.Add(this.btnGenerateQRCode, 0, 2);
            this.pnlMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLayout.Name = "pnlMainLayout";
            this.pnlMainLayout.RowCount = 3;
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlMainLayout.Size = new System.Drawing.Size(564, 341);
            this.pnlMainLayout.TabIndex = 0;
            // 
            // btnPrintQRCode
            // 
            this.btnPrintQRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintQRCode.Location = new System.Drawing.Point(285, 309);
            this.btnPrintQRCode.Name = "btnPrintQRCode";
            this.btnPrintQRCode.Size = new System.Drawing.Size(276, 29);
            this.btnPrintQRCode.TabIndex = 3;
            this.btnPrintQRCode.Text = "Print QR Code";
            this.btnPrintQRCode.UseVisualStyleBackColor = true;
            this.btnPrintQRCode.Click += new System.EventHandler(this.btnPrintQRCode_Click);
            // 
            // imgQRImage
            // 
            this.pnlMainLayout.SetColumnSpan(this.imgQRImage, 2);
            this.imgQRImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgQRImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgQRImage.InitialImage")));
            this.imgQRImage.Location = new System.Drawing.Point(3, 3);
            this.imgQRImage.Name = "imgQRImage";
            this.imgQRImage.Size = new System.Drawing.Size(558, 198);
            this.imgQRImage.TabIndex = 0;
            this.imgQRImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.pnlMainLayout.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.Controls.Add(this.lblPrintNo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtServiceProviderContact, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtProjectCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblServiceProviderContact, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblProjectCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblServiceProvider, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtServiceProvider, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numPrintNo, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 96);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblPrintNo
            // 
            this.lblPrintNo.AutoSize = true;
            this.lblPrintNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrintNo.Location = new System.Drawing.Point(3, 72);
            this.lblPrintNo.Name = "lblPrintNo";
            this.lblPrintNo.Size = new System.Drawing.Size(146, 24);
            this.lblPrintNo.TabIndex = 6;
            this.lblPrintNo.Text = "Print Number";
            this.lblPrintNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServiceProviderContact
            // 
            this.txtServiceProviderContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServiceProviderContact.Location = new System.Drawing.Point(155, 51);
            this.txtServiceProviderContact.Name = "txtServiceProviderContact";
            this.txtServiceProviderContact.Size = new System.Drawing.Size(400, 20);
            this.txtServiceProviderContact.TabIndex = 5;
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProjectCode.Location = new System.Drawing.Point(155, 27);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(400, 20);
            this.txtProjectCode.TabIndex = 4;
            // 
            // lblServiceProviderContact
            // 
            this.lblServiceProviderContact.AutoSize = true;
            this.lblServiceProviderContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceProviderContact.Location = new System.Drawing.Point(3, 48);
            this.lblServiceProviderContact.Name = "lblServiceProviderContact";
            this.lblServiceProviderContact.Size = new System.Drawing.Size(146, 24);
            this.lblServiceProviderContact.TabIndex = 2;
            this.lblServiceProviderContact.Text = "Service Provider Contact";
            this.lblServiceProviderContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectCode
            // 
            this.lblProjectCode.AutoSize = true;
            this.lblProjectCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectCode.Location = new System.Drawing.Point(3, 24);
            this.lblProjectCode.Name = "lblProjectCode";
            this.lblProjectCode.Size = new System.Drawing.Size(146, 24);
            this.lblProjectCode.TabIndex = 1;
            this.lblProjectCode.Text = "Project Code";
            this.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServiceProvider
            // 
            this.lblServiceProvider.AutoSize = true;
            this.lblServiceProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceProvider.Location = new System.Drawing.Point(3, 0);
            this.lblServiceProvider.Name = "lblServiceProvider";
            this.lblServiceProvider.Size = new System.Drawing.Size(146, 24);
            this.lblServiceProvider.TabIndex = 0;
            this.lblServiceProvider.Text = "Service Provider Name";
            this.lblServiceProvider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServiceProvider
            // 
            this.txtServiceProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServiceProvider.Location = new System.Drawing.Point(155, 3);
            this.txtServiceProvider.Name = "txtServiceProvider";
            this.txtServiceProvider.Size = new System.Drawing.Size(400, 20);
            this.txtServiceProvider.TabIndex = 3;
            // 
            // numPrintNo
            // 
            this.numPrintNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.numPrintNo.Location = new System.Drawing.Point(155, 75);
            this.numPrintNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrintNo.Name = "numPrintNo";
            this.numPrintNo.Size = new System.Drawing.Size(120, 20);
            this.numPrintNo.TabIndex = 7;
            this.numPrintNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGenerateQRCode
            // 
            this.btnGenerateQRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateQRCode.Location = new System.Drawing.Point(3, 309);
            this.btnGenerateQRCode.Name = "btnGenerateQRCode";
            this.btnGenerateQRCode.Size = new System.Drawing.Size(276, 29);
            this.btnGenerateQRCode.TabIndex = 2;
            this.btnGenerateQRCode.Text = "Generate QR Code";
            this.btnGenerateQRCode.UseVisualStyleBackColor = true;
            this.btnGenerateQRCode.Click += new System.EventHandler(this.btnGenerateQRCode_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 341);
            this.Controls.Add(this.pnlMainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(580, 380);
            this.MinimumSize = new System.Drawing.Size(580, 380);
            this.Name = "MainWindow";
            this.Text = "ALP Desktop v2.0";
            this.pnlMainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgQRImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrintNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMainLayout;
        private System.Windows.Forms.Button btnPrintQRCode;
        private System.Windows.Forms.PictureBox imgQRImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtServiceProviderContact;
        private System.Windows.Forms.TextBox txtProjectCode;
        private System.Windows.Forms.Label lblServiceProviderContact;
        private System.Windows.Forms.Label lblProjectCode;
        private System.Windows.Forms.Label lblServiceProvider;
        private System.Windows.Forms.TextBox txtServiceProvider;
        private System.Windows.Forms.Button btnGenerateQRCode;
        private System.Windows.Forms.Label lblPrintNo;
        private System.Windows.Forms.NumericUpDown numPrintNo;
    }
}

