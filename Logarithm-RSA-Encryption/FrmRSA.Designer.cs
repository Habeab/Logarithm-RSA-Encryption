namespace Logarithm_RSA_Encryption
{
    partial class FrmRSA
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
            this.TbxData = new System.Windows.Forms.TextBox();
            this.TbxEncryptin = new System.Windows.Forms.TextBox();
            this.TbxDecryptin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEncryption = new System.Windows.Forms.Button();
            this.BtnDecryption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxData
            // 
            this.TbxData.Location = new System.Drawing.Point(146, 72);
            this.TbxData.Name = "TbxData";
            this.TbxData.Size = new System.Drawing.Size(438, 20);
            this.TbxData.TabIndex = 0;
            // 
            // TbxEncryptin
            // 
            this.TbxEncryptin.BackColor = System.Drawing.Color.White;
            this.TbxEncryptin.Location = new System.Drawing.Point(146, 98);
            this.TbxEncryptin.Multiline = true;
            this.TbxEncryptin.Name = "TbxEncryptin";
            this.TbxEncryptin.ReadOnly = true;
            this.TbxEncryptin.Size = new System.Drawing.Size(438, 171);
            this.TbxEncryptin.TabIndex = 0;
            // 
            // TbxDecryptin
            // 
            this.TbxDecryptin.Location = new System.Drawing.Point(146, 275);
            this.TbxDecryptin.Name = "TbxDecryptin";
            this.TbxDecryptin.Size = new System.Drawing.Size(438, 20);
            this.TbxDecryptin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encryption Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Decryption Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label4.Location = new System.Drawing.Point(150, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Logarithm RSA";
            // 
            // BtnEncryption
            // 
            this.BtnEncryption.Location = new System.Drawing.Point(157, 301);
            this.BtnEncryption.Name = "BtnEncryption";
            this.BtnEncryption.Size = new System.Drawing.Size(169, 23);
            this.BtnEncryption.TabIndex = 3;
            this.BtnEncryption.Text = "Encryption";
            this.BtnEncryption.UseVisualStyleBackColor = true;
            this.BtnEncryption.Click += new System.EventHandler(this.BtnEncryption_Click);
            // 
            // BtnDecryption
            // 
            this.BtnDecryption.Location = new System.Drawing.Point(396, 301);
            this.BtnDecryption.Name = "BtnDecryption";
            this.BtnDecryption.Size = new System.Drawing.Size(169, 23);
            this.BtnDecryption.TabIndex = 3;
            this.BtnDecryption.Text = "Decryption";
            this.BtnDecryption.UseVisualStyleBackColor = true;
            this.BtnDecryption.Click += new System.EventHandler(this.BtnDecryption_Click);
            // 
            // FrmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 334);
            this.Controls.Add(this.BtnDecryption);
            this.Controls.Add(this.BtnEncryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxDecryptin);
            this.Controls.Add(this.TbxEncryptin);
            this.Controls.Add(this.TbxData);
            this.Name = "FrmRSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logarithm RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxData;
        private System.Windows.Forms.TextBox TbxEncryptin;
        private System.Windows.Forms.TextBox TbxDecryptin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEncryption;
        private System.Windows.Forms.Button BtnDecryption;
    }
}

