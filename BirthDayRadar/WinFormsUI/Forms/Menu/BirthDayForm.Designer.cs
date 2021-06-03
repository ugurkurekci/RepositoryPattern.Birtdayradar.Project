
namespace WinFormsUI
{
    partial class BirthDayForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirthDayForm));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.deletebtn = new System.Windows.Forms.Button();
            this.rehberAddbtn = new System.Windows.Forms.Button();
            this.panelfooterr = new System.Windows.Forms.Panel();
            this.rehberBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontext = new System.Windows.Forms.Panel();
            this.timelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.timetimer = new System.Windows.Forms.Timer(this.components);
            this.panelmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcontext.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.White;
            this.panelmenu.Controls.Add(this.deletebtn);
            this.panelmenu.Controls.Add(this.rehberAddbtn);
            this.panelmenu.Controls.Add(this.panelfooterr);
            this.panelmenu.Controls.Add(this.rehberBtn);
            this.panelmenu.Controls.Add(this.panel1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(170, 692);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Red;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deletebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.ForeColor = System.Drawing.Color.Black;
            this.deletebtn.Location = new System.Drawing.Point(0, 361);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(170, 69);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Veri Sil";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // rehberAddbtn
            // 
            this.rehberAddbtn.BackColor = System.Drawing.Color.PaleGreen;
            this.rehberAddbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rehberAddbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rehberAddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rehberAddbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rehberAddbtn.ForeColor = System.Drawing.Color.Black;
            this.rehberAddbtn.Location = new System.Drawing.Point(0, 292);
            this.rehberAddbtn.Name = "rehberAddbtn";
            this.rehberAddbtn.Size = new System.Drawing.Size(170, 69);
            this.rehberAddbtn.TabIndex = 3;
            this.rehberAddbtn.Text = "Veri Ekle";
            this.rehberAddbtn.UseVisualStyleBackColor = false;
            this.rehberAddbtn.Click += new System.EventHandler(this.rehberAddbtn_Click);
            // 
            // panelfooterr
            // 
            this.panelfooterr.BackColor = System.Drawing.Color.Tomato;
            this.panelfooterr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooterr.Location = new System.Drawing.Point(0, 646);
            this.panelfooterr.Name = "panelfooterr";
            this.panelfooterr.Size = new System.Drawing.Size(170, 46);
            this.panelfooterr.TabIndex = 2;
            this.panelfooterr.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfooterr_Paint);
            // 
            // rehberBtn
            // 
            this.rehberBtn.BackColor = System.Drawing.Color.Yellow;
            this.rehberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rehberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rehberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rehberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rehberBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rehberBtn.Location = new System.Drawing.Point(0, 223);
            this.rehberBtn.Name = "rehberBtn";
            this.rehberBtn.Size = new System.Drawing.Size(170, 69);
            this.rehberBtn.TabIndex = 1;
            this.rehberBtn.Text = "Rehber";
            this.rehberBtn.UseVisualStyleBackColor = false;
            this.rehberBtn.Click += new System.EventHandler(this.rehberBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 223);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelcontext
            // 
            this.panelcontext.BackColor = System.Drawing.SystemColors.Window;
            this.panelcontext.Controls.Add(this.timelbl);
            this.panelcontext.Controls.Add(this.datelbl);
            this.panelcontext.Controls.Add(this.panelfooter);
            this.panelcontext.Controls.Add(this.panelmenu);
            this.panelcontext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontext.Location = new System.Drawing.Point(0, 0);
            this.panelcontext.Name = "panelcontext";
            this.panelcontext.Size = new System.Drawing.Size(1108, 692);
            this.panelcontext.TabIndex = 1;
            this.panelcontext.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontext_Paint);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.ForeColor = System.Drawing.Color.Black;
            this.timelbl.Location = new System.Drawing.Point(187, 12);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(20, 21);
            this.timelbl.TabIndex = 3;
            this.timelbl.Text = "T";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.ForeColor = System.Drawing.Color.Black;
            this.datelbl.Location = new System.Drawing.Point(187, 51);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(22, 21);
            this.datelbl.TabIndex = 2;
            this.datelbl.Text = "D";
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.Tomato;
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(170, 646);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(938, 46);
            this.panelfooter.TabIndex = 1;
            this.panelfooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfooter_Paint);
            // 
            // timetimer
            // 
            this.timetimer.Tick += new System.EventHandler(this.timetimer_Tick);
            // 
            // BirthDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 692);
            this.Controls.Add(this.panelcontext);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BirthDayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BirthDay Application";
            this.Load += new System.EventHandler(this.BirthDayForm_Load);
            this.panelmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcontext.ResumeLayout(false);
            this.panelcontext.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelcontext;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rehberBtn;
        private System.Windows.Forms.Panel panelfooterr;
        private System.Windows.Forms.Button rehberAddbtn;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Timer timetimer;
        private System.Windows.Forms.Button deletebtn;
    }
}