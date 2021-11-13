namespace CorporateDistribution
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnAuOk = new System.Windows.Forms.Button();
            this.btnAuClose = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnCA = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.Black;
            this.tbPass.Location = new System.Drawing.Point(46, 57);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(186, 31);
            this.tbPass.TabIndex = 3;
            // 
            // btnAuOk
            // 
            this.btnAuOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuOk.Location = new System.Drawing.Point(46, 100);
            this.btnAuOk.Name = "btnAuOk";
            this.btnAuOk.Size = new System.Drawing.Size(90, 31);
            this.btnAuOk.TabIndex = 4;
            this.btnAuOk.Text = "Ok";
            this.btnAuOk.UseVisualStyleBackColor = true;
            this.btnAuOk.Click += new System.EventHandler(this.btnAuOk_Click);
            // 
            // btnAuClose
            // 
            this.btnAuClose.Location = new System.Drawing.Point(142, 100);
            this.btnAuClose.Name = "btnAuClose";
            this.btnAuClose.Size = new System.Drawing.Size(90, 31);
            this.btnAuClose.TabIndex = 5;
            this.btnAuClose.Text = "Close";
            this.btnAuClose.UseVisualStyleBackColor = true;
            this.btnAuClose.Click += new System.EventHandler(this.btnAuClose_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.Color.Gray;
            this.tbLogin.Location = new System.Drawing.Point(46, 12);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(186, 31);
            this.tbLogin.TabIndex = 6;
            this.tbLogin.Text = "Please enter login...";
            this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter_1);
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(46, 137);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(186, 31);
            this.btnCA.TabIndex = 7;
            this.btnCA.Text = "Create account";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CorporateDistribution.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(12, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CorporateDistribution.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 178);
            this.Controls.Add(this.btnCA);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnAuClose);
            this.Controls.Add(this.btnAuOk);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAuOk;
        private System.Windows.Forms.Button btnAuClose;
        public System.Windows.Forms.TextBox tbPass;
        public System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnCA;
    }
}