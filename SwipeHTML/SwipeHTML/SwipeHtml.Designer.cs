namespace SwipeHTML
{
    partial class SwipeHtml
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
            this.txtInputBox = new System.Windows.Forms.TextBox();
            this.btnDoScrap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputBox
            // 
            this.txtInputBox.Location = new System.Drawing.Point(9, 12);
            this.txtInputBox.Name = "txtInputBox";
            this.txtInputBox.Size = new System.Drawing.Size(263, 20);
            this.txtInputBox.TabIndex = 0;
            // 
            // btnDoScrap
            // 
            this.btnDoScrap.Location = new System.Drawing.Point(9, 38);
            this.btnDoScrap.Name = "btnDoScrap";
            this.btnDoScrap.Size = new System.Drawing.Size(263, 88);
            this.btnDoScrap.TabIndex = 1;
            this.btnDoScrap.Text = "SCRAP!";
            this.btnDoScrap.UseVisualStyleBackColor = true;
            this.btnDoScrap.Click += new System.EventHandler(this.btnDoScrap_Click);
            // 
            // SwipeHtml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.btnDoScrap);
            this.Controls.Add(this.txtInputBox);
            this.Name = "SwipeHtml";
            this.Text = "Swipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputBox;
        private System.Windows.Forms.Button btnDoScrap;
    }
}

