
namespace WinFormsUI.Forms.RehberAdd.AddIcon
{
    partial class AddIconForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIconForm));
            this.pictureboxadd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxadd)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxadd
            // 
            this.pictureboxadd.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxadd.Image")));
            this.pictureboxadd.Location = new System.Drawing.Point(49, 12);
            this.pictureboxadd.Name = "pictureboxadd";
            this.pictureboxadd.Size = new System.Drawing.Size(375, 151);
            this.pictureboxadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxadd.TabIndex = 0;
            this.pictureboxadd.TabStop = false;
            this.pictureboxadd.Click += new System.EventHandler(this.pictureboxadd_Click);
            // 
            // AddIconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 175);
            this.Controls.Add(this.pictureboxadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddIconForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIconForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxadd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxadd;
    }
}