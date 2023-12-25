namespace cipher
{
    partial class PolyalphabeticCipher
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
            this.about_LB = new System.Windows.Forms.Label();
            this.decryptedText_LB = new System.Windows.Forms.Label();
            this.decryptedText_TB = new System.Windows.Forms.TextBox();
            this.encryptedText_LB = new System.Windows.Forms.Label();
            this.encryptedText_TB = new System.Windows.Forms.TextBox();
            this.originalText_LB = new System.Windows.Forms.Label();
            this.decrypt_BTN = new System.Windows.Forms.Button();
            this.encrypt_BTN = new System.Windows.Forms.Button();
            this.inputText_TB = new System.Windows.Forms.TextBox();
            this.name_LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // about_LB
            // 
            this.about_LB.AutoSize = true;
            this.about_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.about_LB.Location = new System.Drawing.Point(9, 567);
            this.about_LB.Name = "about_LB";
            this.about_LB.Size = new System.Drawing.Size(292, 17);
            this.about_LB.TabIndex = 20;
            this.about_LB.Text = "Designed By Muhammad Asadullah EP1649044";
            // 
            // decryptedText_LB
            // 
            this.decryptedText_LB.AutoSize = true;
            this.decryptedText_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedText_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.decryptedText_LB.Location = new System.Drawing.Point(9, 390);
            this.decryptedText_LB.Name = "decryptedText_LB";
            this.decryptedText_LB.Size = new System.Drawing.Size(100, 17);
            this.decryptedText_LB.TabIndex = 19;
            this.decryptedText_LB.Text = "Decrypted Text";
            // 
            // decryptedText_TB
            // 
            this.decryptedText_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptedText_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.decryptedText_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decryptedText_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedText_TB.ForeColor = System.Drawing.Color.Gainsboro;
            this.decryptedText_TB.Location = new System.Drawing.Point(12, 410);
            this.decryptedText_TB.Multiline = true;
            this.decryptedText_TB.Name = "decryptedText_TB";
            this.decryptedText_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptedText_TB.Size = new System.Drawing.Size(760, 146);
            this.decryptedText_TB.TabIndex = 14;
            // 
            // encryptedText_LB
            // 
            this.encryptedText_LB.AutoSize = true;
            this.encryptedText_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedText_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.encryptedText_LB.Location = new System.Drawing.Point(9, 216);
            this.encryptedText_LB.Name = "encryptedText_LB";
            this.encryptedText_LB.Size = new System.Drawing.Size(99, 17);
            this.encryptedText_LB.TabIndex = 17;
            this.encryptedText_LB.Text = "Encrypted Text";
            // 
            // encryptedText_TB
            // 
            this.encryptedText_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptedText_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.encryptedText_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptedText_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedText_TB.ForeColor = System.Drawing.Color.Gainsboro;
            this.encryptedText_TB.Location = new System.Drawing.Point(12, 236);
            this.encryptedText_TB.Multiline = true;
            this.encryptedText_TB.Name = "encryptedText_TB";
            this.encryptedText_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptedText_TB.Size = new System.Drawing.Size(760, 146);
            this.encryptedText_TB.TabIndex = 13;
            // 
            // originalText_LB
            // 
            this.originalText_LB.AutoSize = true;
            this.originalText_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalText_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.originalText_LB.Location = new System.Drawing.Point(9, 41);
            this.originalText_LB.Name = "originalText_LB";
            this.originalText_LB.Size = new System.Drawing.Size(85, 17);
            this.originalText_LB.TabIndex = 15;
            this.originalText_LB.Text = "Original Text";
            // 
            // decrypt_BTN
            // 
            this.decrypt_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decrypt_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt_BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.decrypt_BTN.ForeColor = System.Drawing.Color.Silver;
            this.decrypt_BTN.Location = new System.Drawing.Point(617, 565);
            this.decrypt_BTN.Name = "decrypt_BTN";
            this.decrypt_BTN.Size = new System.Drawing.Size(75, 23);
            this.decrypt_BTN.TabIndex = 18;
            this.decrypt_BTN.Text = "Decrypt";
            this.decrypt_BTN.UseVisualStyleBackColor = true;
            this.decrypt_BTN.Click += new System.EventHandler(this.decrypt_BTN_Click);
            // 
            // encrypt_BTN
            // 
            this.encrypt_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.encrypt_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt_BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.encrypt_BTN.ForeColor = System.Drawing.Color.Silver;
            this.encrypt_BTN.Location = new System.Drawing.Point(698, 565);
            this.encrypt_BTN.Name = "encrypt_BTN";
            this.encrypt_BTN.Size = new System.Drawing.Size(75, 23);
            this.encrypt_BTN.TabIndex = 16;
            this.encrypt_BTN.Text = "Encrypt";
            this.encrypt_BTN.UseVisualStyleBackColor = true;
            this.encrypt_BTN.Click += new System.EventHandler(this.encrypt_BTN_Click);
            // 
            // inputText_TB
            // 
            this.inputText_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputText_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputText_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText_TB.ForeColor = System.Drawing.Color.Gainsboro;
            this.inputText_TB.Location = new System.Drawing.Point(12, 61);
            this.inputText_TB.Multiline = true;
            this.inputText_TB.Name = "inputText_TB";
            this.inputText_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputText_TB.Size = new System.Drawing.Size(760, 146);
            this.inputText_TB.TabIndex = 12;
            this.inputText_TB.TextChanged += new System.EventHandler(this.inputText_TB_TextChanged);
            // 
            // name_LB
            // 
            this.name_LB.AutoSize = true;
            this.name_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.name_LB.Location = new System.Drawing.Point(279, 18);
            this.name_LB.Name = "name_LB";
            this.name_LB.Size = new System.Drawing.Size(224, 25);
            this.name_LB.TabIndex = 21;
            this.name_LB.Text = "POLYALPHABETIC CIPHER";
            // 
            // PolyalphabeticCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.name_LB);
            this.Controls.Add(this.about_LB);
            this.Controls.Add(this.decryptedText_LB);
            this.Controls.Add(this.decryptedText_TB);
            this.Controls.Add(this.encryptedText_LB);
            this.Controls.Add(this.encryptedText_TB);
            this.Controls.Add(this.originalText_LB);
            this.Controls.Add(this.decrypt_BTN);
            this.Controls.Add(this.encrypt_BTN);
            this.Controls.Add(this.inputText_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PolyalphabeticCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polyalphabetic Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label about_LB;
        private System.Windows.Forms.Label decryptedText_LB;
        private System.Windows.Forms.TextBox decryptedText_TB;
        private System.Windows.Forms.Label encryptedText_LB;
        private System.Windows.Forms.TextBox encryptedText_TB;
        private System.Windows.Forms.Label originalText_LB;
        private System.Windows.Forms.Button decrypt_BTN;
        private System.Windows.Forms.Button encrypt_BTN;
        private System.Windows.Forms.TextBox inputText_TB;
        private System.Windows.Forms.Label name_LB;

    }
}

