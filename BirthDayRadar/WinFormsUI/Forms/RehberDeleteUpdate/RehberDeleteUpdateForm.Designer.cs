
namespace WinFormsUI.Forms.RehberDeleteUpdate
{
    partial class RehberDeleteUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RehberDeleteUpdateForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.duyurulbl = new System.Windows.Forms.Label();
            this.newagetxb = new System.Windows.Forms.TextBox();
            this.datetxb = new System.Windows.Forms.TextBox();
            this.Silbtn = new System.Windows.Forms.Button();
            this.notertxb = new System.Windows.Forms.RichTextBox();
            this.telephonetxb = new System.Windows.Forms.TextBox();
            this.Surnametxb = new System.Windows.Forms.TextBox();
            this.Nametxb = new System.Windows.Forms.TextBox();
            this.panelcontext = new System.Windows.Forms.Panel();
            this.Notxb = new System.Windows.Forms.TextBox();
            this.jobtxb = new System.Windows.Forms.TextBox();
            this.Notelbl = new System.Windows.Forms.Label();
            this.newagelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.telephonelbl = new System.Windows.Forms.Label();
            this.Joblbl = new System.Windows.Forms.Label();
            this.Surnamelbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.panelslider = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelcontext.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 36);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.duyurulbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 36);
            this.panel1.TabIndex = 8;
            // 
            // duyurulbl
            // 
            this.duyurulbl.AutoSize = true;
            this.duyurulbl.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.duyurulbl.Location = new System.Drawing.Point(12, 12);
            this.duyurulbl.Name = "duyurulbl";
            this.duyurulbl.Size = new System.Drawing.Size(13, 19);
            this.duyurulbl.TabIndex = 0;
            this.duyurulbl.Text = "l";
            this.duyurulbl.Visible = false;
            // 
            // newagetxb
            // 
            this.newagetxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.newagetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newagetxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.newagetxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newagetxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newagetxb.Location = new System.Drawing.Point(250, 265);
            this.newagetxb.MaxLength = 20;
            this.newagetxb.Multiline = true;
            this.newagetxb.Name = "newagetxb";
            this.newagetxb.PlaceholderText = "Yaş Giriniz";
            this.newagetxb.ReadOnly = true;
            this.newagetxb.Size = new System.Drawing.Size(336, 23);
            this.newagetxb.TabIndex = 43;
            // 
            // datetxb
            // 
            this.datetxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.datetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datetxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.datetxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.datetxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datetxb.Location = new System.Drawing.Point(250, 223);
            this.datetxb.MaxLength = 20;
            this.datetxb.Multiline = true;
            this.datetxb.Name = "datetxb";
            this.datetxb.PlaceholderText = "Tarih Giriniz";
            this.datetxb.ReadOnly = true;
            this.datetxb.Size = new System.Drawing.Size(336, 23);
            this.datetxb.TabIndex = 42;
            // 
            // Silbtn
            // 
            this.Silbtn.BackColor = System.Drawing.Color.DarkRed;
            this.Silbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Silbtn.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Silbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Silbtn.Location = new System.Drawing.Point(281, 436);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(179, 56);
            this.Silbtn.TabIndex = 41;
            this.Silbtn.Text = "Sil";
            this.Silbtn.UseVisualStyleBackColor = false;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // notertxb
            // 
            this.notertxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notertxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notertxb.Location = new System.Drawing.Point(250, 311);
            this.notertxb.Name = "notertxb";
            this.notertxb.ReadOnly = true;
            this.notertxb.Size = new System.Drawing.Size(494, 96);
            this.notertxb.TabIndex = 40;
            this.notertxb.Text = "";
            // 
            // telephonetxb
            // 
            this.telephonetxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.telephonetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telephonetxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telephonetxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telephonetxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.telephonetxb.Location = new System.Drawing.Point(250, 186);
            this.telephonetxb.MaxLength = 20;
            this.telephonetxb.Multiline = true;
            this.telephonetxb.Name = "telephonetxb";
            this.telephonetxb.PlaceholderText = "Telefon Numarası Belirtiniz.";
            this.telephonetxb.ReadOnly = true;
            this.telephonetxb.Size = new System.Drawing.Size(336, 23);
            this.telephonetxb.TabIndex = 38;
            // 
            // Surnametxb
            // 
            this.Surnametxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Surnametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Surnametxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Surnametxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Surnametxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Surnametxb.Location = new System.Drawing.Point(250, 111);
            this.Surnametxb.MaxLength = 20;
            this.Surnametxb.Multiline = true;
            this.Surnametxb.Name = "Surnametxb";
            this.Surnametxb.PlaceholderText = "Soyisim Giriniz. ";
            this.Surnametxb.ReadOnly = true;
            this.Surnametxb.Size = new System.Drawing.Size(336, 23);
            this.Surnametxb.TabIndex = 36;
            // 
            // Nametxb
            // 
            this.Nametxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Nametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nametxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nametxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nametxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nametxb.Location = new System.Drawing.Point(250, 72);
            this.Nametxb.MaxLength = 20;
            this.Nametxb.Multiline = true;
            this.Nametxb.Name = "Nametxb";
            this.Nametxb.PlaceholderText = "İsim Giriniz. ";
            this.Nametxb.ReadOnly = true;
            this.Nametxb.Size = new System.Drawing.Size(336, 23);
            this.Nametxb.TabIndex = 35;
            // 
            // panelcontext
            // 
            this.panelcontext.BackColor = System.Drawing.Color.White;
            this.panelcontext.Controls.Add(this.Notxb);
            this.panelcontext.Controls.Add(this.newagetxb);
            this.panelcontext.Controls.Add(this.datetxb);
            this.panelcontext.Controls.Add(this.Silbtn);
            this.panelcontext.Controls.Add(this.notertxb);
            this.panelcontext.Controls.Add(this.telephonetxb);
            this.panelcontext.Controls.Add(this.jobtxb);
            this.panelcontext.Controls.Add(this.Surnametxb);
            this.panelcontext.Controls.Add(this.Nametxb);
            this.panelcontext.Controls.Add(this.Notelbl);
            this.panelcontext.Controls.Add(this.newagelbl);
            this.panelcontext.Controls.Add(this.datelbl);
            this.panelcontext.Controls.Add(this.telephonelbl);
            this.panelcontext.Controls.Add(this.Joblbl);
            this.panelcontext.Controls.Add(this.Surnamelbl);
            this.panelcontext.Controls.Add(this.Namelbl);
            this.panelcontext.Controls.Add(this.panelfooter);
            this.panelcontext.Controls.Add(this.panelslider);
            this.panelcontext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontext.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelcontext.Location = new System.Drawing.Point(0, 0);
            this.panelcontext.Name = "panelcontext";
            this.panelcontext.Size = new System.Drawing.Size(937, 551);
            this.panelcontext.TabIndex = 6;
            // 
            // Notxb
            // 
            this.Notxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Notxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Notxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Notxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Notxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Notxb.Location = new System.Drawing.Point(12, 42);
            this.Notxb.MaxLength = 20;
            this.Notxb.Multiline = true;
            this.Notxb.Name = "Notxb";
            this.Notxb.ReadOnly = true;
            this.Notxb.Size = new System.Drawing.Size(119, 23);
            this.Notxb.TabIndex = 44;
            // 
            // jobtxb
            // 
            this.jobtxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.jobtxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobtxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.jobtxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobtxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.jobtxb.Location = new System.Drawing.Point(250, 150);
            this.jobtxb.MaxLength = 20;
            this.jobtxb.Multiline = true;
            this.jobtxb.Name = "jobtxb";
            this.jobtxb.PlaceholderText = "Meslek Belirtiniz.";
            this.jobtxb.ReadOnly = true;
            this.jobtxb.Size = new System.Drawing.Size(336, 23);
            this.jobtxb.TabIndex = 37;
            // 
            // Notelbl
            // 
            this.Notelbl.AutoSize = true;
            this.Notelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Notelbl.Location = new System.Drawing.Point(204, 308);
            this.Notelbl.Name = "Notelbl";
            this.Notelbl.Size = new System.Drawing.Size(53, 21);
            this.Notelbl.TabIndex = 34;
            this.Notelbl.Text = "Not : ";
            // 
            // newagelbl
            // 
            this.newagelbl.AutoSize = true;
            this.newagelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newagelbl.Location = new System.Drawing.Point(204, 265);
            this.newagelbl.Name = "newagelbl";
            this.newagelbl.Size = new System.Drawing.Size(53, 21);
            this.newagelbl.TabIndex = 33;
            this.newagelbl.Text = "Yaş : ";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.datelbl.Location = new System.Drawing.Point(193, 223);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(64, 21);
            this.datelbl.TabIndex = 32;
            this.datelbl.Text = "Tarih : ";
            // 
            // telephonelbl
            // 
            this.telephonelbl.AutoSize = true;
            this.telephonelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telephonelbl.Location = new System.Drawing.Point(175, 183);
            this.telephonelbl.Name = "telephonelbl";
            this.telephonelbl.Size = new System.Drawing.Size(82, 21);
            this.telephonelbl.TabIndex = 31;
            this.telephonelbl.Text = "Telefon : ";
            // 
            // Joblbl
            // 
            this.Joblbl.AutoSize = true;
            this.Joblbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Joblbl.Location = new System.Drawing.Point(171, 147);
            this.Joblbl.Name = "Joblbl";
            this.Joblbl.Size = new System.Drawing.Size(86, 21);
            this.Joblbl.TabIndex = 30;
            this.Joblbl.Text = "Meslek  : ";
            // 
            // Surnamelbl
            // 
            this.Surnamelbl.AutoSize = true;
            this.Surnamelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Surnamelbl.Location = new System.Drawing.Point(169, 108);
            this.Surnamelbl.Name = "Surnamelbl";
            this.Surnamelbl.Size = new System.Drawing.Size(88, 21);
            this.Surnamelbl.TabIndex = 29;
            this.Surnamelbl.Text = "Soyisim : ";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelbl.Location = new System.Drawing.Point(198, 72);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(59, 21);
            this.Namelbl.TabIndex = 28;
            this.Namelbl.Text = "İsim : ";
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.BurlyWood;
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 515);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(937, 36);
            this.panelfooter.TabIndex = 3;
            // 
            // panelslider
            // 
            this.panelslider.BackColor = System.Drawing.Color.BurlyWood;
            this.panelslider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelslider.Location = new System.Drawing.Point(0, 0);
            this.panelslider.Name = "panelslider";
            this.panelslider.Size = new System.Drawing.Size(937, 36);
            this.panelslider.TabIndex = 2;
            // 
            // RehberDeleteUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelcontext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RehberDeleteUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RehberDeleteUpdateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelcontext.ResumeLayout(false);
            this.panelcontext.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox newagetxb;
        public System.Windows.Forms.TextBox datetxb;
        private System.Windows.Forms.Button Silbtn;
        public System.Windows.Forms.RichTextBox notertxb;
        public System.Windows.Forms.TextBox telephonetxb;
        public System.Windows.Forms.TextBox Surnametxb;
        public System.Windows.Forms.TextBox Nametxb;
        private System.Windows.Forms.Panel panelcontext;
        public System.Windows.Forms.TextBox jobtxb;
        public System.Windows.Forms.Label Notelbl;
        public System.Windows.Forms.Label newagelbl;
        public System.Windows.Forms.Label datelbl;
        public System.Windows.Forms.Label telephonelbl;
        public System.Windows.Forms.Label Joblbl;
        public System.Windows.Forms.Label Surnamelbl;
        public System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.Panel panelslider;
        private System.Windows.Forms.Label duyurulbl;
        public System.Windows.Forms.TextBox Notxb;
    }
}