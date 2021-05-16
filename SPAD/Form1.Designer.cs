
namespace SPAD
{
    partial class SPADProject
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
            this.lblAppLogo = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCleanData = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvSPAD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPAD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppLogo
            // 
            this.lblAppLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAppLogo.BackColor = System.Drawing.Color.Firebrick;
            this.lblAppLogo.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppLogo.Location = new System.Drawing.Point(1, 1);
            this.lblAppLogo.Name = "lblAppLogo";
            this.lblAppLogo.Size = new System.Drawing.Size(1292, 79);
            this.lblAppLogo.TabIndex = 0;
            this.lblAppLogo.Text = "SPAD";
            this.lblAppLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(4, 114);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(144, 41);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // btnCleanData
            // 
            this.btnCleanData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCleanData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCleanData.Location = new System.Drawing.Point(4, 205);
            this.btnCleanData.Name = "btnCleanData";
            this.btnCleanData.Size = new System.Drawing.Size(144, 41);
            this.btnCleanData.TabIndex = 2;
            this.btnCleanData.Text = "Clean Data";
            this.btnCleanData.UseVisualStyleBackColor = false;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDownload.Location = new System.Drawing.Point(4, 303);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(144, 45);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(4, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // dgvSPAD
            // 
            this.dgvSPAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPAD.Location = new System.Drawing.Point(169, 114);
            this.dgvSPAD.Name = "dgvSPAD";
            this.dgvSPAD.RowHeadersWidth = 51;
            this.dgvSPAD.RowTemplate.Height = 24;
            this.dgvSPAD.Size = new System.Drawing.Size(1092, 481);
            this.dgvSPAD.TabIndex = 5;
            // 
            // SPADProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 624);
            this.Controls.Add(this.dgvSPAD);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnCleanData);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblAppLogo);
            this.Name = "SPADProject";
            this.Text = "SPADproj";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAppLogo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCleanData;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvSPAD;
    }
}

