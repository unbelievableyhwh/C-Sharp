namespace CorporateDistribution
{
    partial class NewMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessage));
            this.contactNav = new System.Windows.Forms.ComboBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnNMBack = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactNav
            // 
            this.contactNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactNav.ForeColor = System.Drawing.Color.Gray;
            this.contactNav.FormattingEnabled = true;
            this.contactNav.Location = new System.Drawing.Point(12, 12);
            this.contactNav.Name = "contactNav";
            this.contactNav.Size = new System.Drawing.Size(435, 28);
            this.contactNav.TabIndex = 0;
            this.contactNav.Text = "Choose or enter contact...";
            this.contactNav.Enter += new System.EventHandler(this.contactNav_Enter);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.ForeColor = System.Drawing.Color.Gray;
            this.tbMessage.Location = new System.Drawing.Point(12, 61);
            this.tbMessage.MaxLength = 4096;
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(435, 184);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.Text = "Enter your message...";
            this.tbMessage.Enter += new System.EventHandler(this.tbMessage_Enter);
            // 
            // btnNMBack
            // 
            this.btnNMBack.Location = new System.Drawing.Point(347, 256);
            this.btnNMBack.Name = "btnNMBack";
            this.btnNMBack.Size = new System.Drawing.Size(100, 31);
            this.btnNMBack.TabIndex = 2;
            this.btnNMBack.Text = "Back";
            this.btnNMBack.UseVisualStyleBackColor = true;
            this.btnNMBack.Click += new System.EventHandler(this.btnNMBack_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(130, 256);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 31);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 31);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 291);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnNMBack);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.contactNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMessage";
            this.Load += new System.EventHandler(this.NewMessage_Load);
            this.Shown += new System.EventHandler(this.NewMessage_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox contactNav;
        public System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnNMBack;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}