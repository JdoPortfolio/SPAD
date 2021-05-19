
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
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppLogo
            // 
            this.lblAppLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAppLogo.BackColor = System.Drawing.Color.Firebrick;
            this.lblAppLogo.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppLogo.Location = new System.Drawing.Point(1, 1);
            this.lblAppLogo.Name = "lblAppLogo";
            this.lblAppLogo.Size = new System.Drawing.Size(1295, 133);
            this.lblAppLogo.TabIndex = 0;
            this.lblAppLogo.Text = "SPAD";
            this.lblAppLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(11, 188);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(144, 41);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCleanData
            // 
            this.btnCleanData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCleanData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCleanData.Location = new System.Drawing.Point(11, 359);
            this.btnCleanData.Name = "btnCleanData";
            this.btnCleanData.Size = new System.Drawing.Size(144, 41);
            this.btnCleanData.TabIndex = 2;
            this.btnCleanData.Text = "Clean Data";
            this.btnCleanData.UseVisualStyleBackColor = false;
            this.btnCleanData.Click += new System.EventHandler(this.btnCleanData_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDownload.Location = new System.Drawing.Point(11, 443);
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
            this.btnExit.Location = new System.Drawing.Point(11, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgItems
            // 
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(192, 188);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersWidth = 51;
            this.dgItems.RowTemplate.Height = 24;
            this.dgItems.Size = new System.Drawing.Size(1092, 481);
            this.dgItems.TabIndex = 5;
            this.dgItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(11, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(1018, 152);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(266, 30);
            this.txtFile.TabIndex = 7;
            // 
            // SPADProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 681);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnCleanData);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblAppLogo);
            this.Name = "SPADProject";
            this.Text = "SPADproj";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppLogo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCleanData;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFile;
    }
}

