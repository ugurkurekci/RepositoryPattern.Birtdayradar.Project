
namespace WinFormsUI.Forms.RehberAdd.AddErrorIcon
{
    partial class AddErrorIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddErrorIcon));
            this.pictureboxadderror = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxadderror)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxadderror
            // 
            this.pictureboxadderror.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxadderror.Image")));
            this.pictureboxadderror.Location = new System.Drawing.Point(46, 12);
            this.pictureboxadderror.Name = "pictureboxadderror";
            this.pictureboxadderror.Size = new System.Drawing.Size(375, 151);
            this.pictureboxadderror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxadderror.TabIndex = 1;
            this.pictureboxadderror.TabStop = false;
            this.pictureboxadderror.Click += new System.EventHandler(this.pictureboxadderror_Click);
            // 
            // AddErrorIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 175);
            this.Controls.Add(this.pictureboxadderror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddErrorIcon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddErrorIcon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxadderror)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxadderror;
    }
}