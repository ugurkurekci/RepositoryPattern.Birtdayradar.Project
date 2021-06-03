
namespace WinFormsUI.Forms.RehberAdd
{
    partial class RehberAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RehberAddForm));
            this.panelslider = new System.Windows.Forms.Panel();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.panelcontext = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.duyurulbl = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.notertxb = new System.Windows.Forms.RichTextBox();
            this.newagecbbx = new System.Windows.Forms.ComboBox();
            this.telephonetxb = new System.Windows.Forms.TextBox();
            this.jobtxb = new System.Windows.Forms.TextBox();
            this.Surnametxb = new System.Windows.Forms.TextBox();
            this.Nametxb = new System.Windows.Forms.TextBox();
            this.panelcizgi7 = new System.Windows.Forms.Panel();
            this.panelcizgi6 = new System.Windows.Forms.Panel();
            this.panelcizgi5 = new System.Windows.Forms.Panel();
            this.panelcizgi4 = new System.Windows.Forms.Panel();
            this.panelcizgi3 = new System.Windows.Forms.Panel();
            this.panelcizgi2 = new System.Windows.Forms.Panel();
            this.panelcizgi1 = new System.Windows.Forms.Panel();
            this.Notelbl = new System.Windows.Forms.Label();
            this.newagelbl = new System.Windows.Forms.Label();
            this.oldagelbl = new System.Windows.Forms.Label();
            this.telephonelbl = new System.Windows.Forms.Label();
            this.Joblbl = new System.Windows.Forms.Label();
            this.Surnamelbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.panelcontext.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelslider
            // 
            this.panelslider.BackColor = System.Drawing.Color.BurlyWood;
            this.panelslider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelslider.Location = new System.Drawing.Point(0, 0);
            this.panelslider.Name = "panelslider";
            this.panelslider.Size = new System.Drawing.Size(942, 36);
            this.panelslider.TabIndex = 0;
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.BurlyWood;
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 539);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(942, 36);
            this.panelfooter.TabIndex = 1;
            // 
            // panelcontext
            // 
            this.panelcontext.BackColor = System.Drawing.Color.White;
            this.panelcontext.Controls.Add(this.panel3);
            this.panelcontext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontext.Location = new System.Drawing.Point(0, 36);
            this.panelcontext.Name = "panelcontext";
            this.panelcontext.Size = new System.Drawing.Size(942, 503);
            this.panelcontext.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.datepicker);
            this.panel3.Controls.Add(this.duyurulbl);
            this.panel3.Controls.Add(this.Addbtn);
            this.panel3.Controls.Add(this.notertxb);
            this.panel3.Controls.Add(this.newagecbbx);
            this.panel3.Controls.Add(this.telephonetxb);
            this.panel3.Controls.Add(this.jobtxb);
            this.panel3.Controls.Add(this.Surnametxb);
            this.panel3.Controls.Add(this.Nametxb);
            this.panel3.Controls.Add(this.panelcizgi7);
            this.panel3.Controls.Add(this.panelcizgi6);
            this.panel3.Controls.Add(this.panelcizgi5);
            this.panel3.Controls.Add(this.panelcizgi4);
            this.panel3.Controls.Add(this.panelcizgi3);
            this.panel3.Controls.Add(this.panelcizgi2);
            this.panel3.Controls.Add(this.panelcizgi1);
            this.panel3.Controls.Add(this.Notelbl);
            this.panel3.Controls.Add(this.newagelbl);
            this.panel3.Controls.Add(this.oldagelbl);
            this.panel3.Controls.Add(this.telephonelbl);
            this.panel3.Controls.Add(this.Joblbl);
            this.panel3.Controls.Add(this.Surnamelbl);
            this.panel3.Controls.Add(this.Namelbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 503);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // datepicker
            // 
            this.datepicker.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.datepicker.CalendarMonthBackground = System.Drawing.Color.LightSalmon;
            this.datepicker.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(244, 231);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(336, 28);
            this.datepicker.TabIndex = 27;
            this.datepicker.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            // 
            // duyurulbl
            // 
            this.duyurulbl.AutoSize = true;
            this.duyurulbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.duyurulbl.Location = new System.Drawing.Point(355, 16);
            this.duyurulbl.Name = "duyurulbl";
            this.duyurulbl.Size = new System.Drawing.Size(0, 21);
            this.duyurulbl.TabIndex = 25;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.SeaGreen;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Addbtn.Location = new System.Drawing.Point(389, 428);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(179, 56);
            this.Addbtn.TabIndex = 23;
            this.Addbtn.Text = "Kaydet";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // notertxb
            // 
            this.notertxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notertxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notertxb.Location = new System.Drawing.Point(244, 316);
            this.notertxb.Name = "notertxb";
            this.notertxb.Size = new System.Drawing.Size(494, 96);
            this.notertxb.TabIndex = 22;
            this.notertxb.Text = "";
            this.notertxb.TextChanged += new System.EventHandler(this.notertxb_TextChanged);
            // 
            // newagecbbx
            // 
            this.newagecbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newagecbbx.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newagecbbx.FormattingEnabled = true;
            this.newagecbbx.Location = new System.Drawing.Point(244, 273);
            this.newagecbbx.Name = "newagecbbx";
            this.newagecbbx.Size = new System.Drawing.Size(155, 27);
            this.newagecbbx.TabIndex = 21;
            this.newagecbbx.SelectedIndexChanged += new System.EventHandler(this.newagecbbx_SelectedIndexChanged);
            // 
            // telephonetxb
            // 
            this.telephonetxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.telephonetxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telephonetxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telephonetxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telephonetxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.telephonetxb.Location = new System.Drawing.Point(244, 191);
            this.telephonetxb.MaxLength = 20;
            this.telephonetxb.Multiline = true;
            this.telephonetxb.Name = "telephonetxb";
            this.telephonetxb.PlaceholderText = "Telefon Numarası Belirtiniz.";
            this.telephonetxb.Size = new System.Drawing.Size(336, 23);
            this.telephonetxb.TabIndex = 19;
            this.telephonetxb.TextChanged += new System.EventHandler(this.telephonetxb_TextChanged);
            // 
            // jobtxb
            // 
            this.jobtxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.jobtxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobtxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.jobtxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobtxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.jobtxb.Location = new System.Drawing.Point(244, 155);
            this.jobtxb.MaxLength = 20;
            this.jobtxb.Multiline = true;
            this.jobtxb.Name = "jobtxb";
            this.jobtxb.PlaceholderText = "Meslek Belirtiniz.";
            this.jobtxb.Size = new System.Drawing.Size(336, 23);
            this.jobtxb.TabIndex = 18;
            this.jobtxb.TextChanged += new System.EventHandler(this.jobtxb_TextChanged);
            // 
            // Surnametxb
            // 
            this.Surnametxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Surnametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Surnametxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Surnametxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Surnametxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Surnametxb.Location = new System.Drawing.Point(244, 116);
            this.Surnametxb.MaxLength = 20;
            this.Surnametxb.Multiline = true;
            this.Surnametxb.Name = "Surnametxb";
            this.Surnametxb.PlaceholderText = "Soyisim Giriniz. ";
            this.Surnametxb.Size = new System.Drawing.Size(336, 23);
            this.Surnametxb.TabIndex = 17;
            this.Surnametxb.TextChanged += new System.EventHandler(this.Surnametxb_TextChanged);
            // 
            // Nametxb
            // 
            this.Nametxb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Nametxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nametxb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nametxb.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nametxb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nametxb.Location = new System.Drawing.Point(244, 77);
            this.Nametxb.MaxLength = 20;
            this.Nametxb.Multiline = true;
            this.Nametxb.Name = "Nametxb";
            this.Nametxb.PlaceholderText = "İsim Giriniz. ";
            this.Nametxb.Size = new System.Drawing.Size(336, 23);
            this.Nametxb.TabIndex = 16;
            this.Nametxb.TextChanged += new System.EventHandler(this.Nametxb_TextChanged);
            this.Nametxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nametxb_KeyPress);
            // 
            // panelcizgi7
            // 
            this.panelcizgi7.BackColor = System.Drawing.Color.White;
            this.panelcizgi7.Location = new System.Drawing.Point(244, 418);
            this.panelcizgi7.Name = "panelcizgi7";
            this.panelcizgi7.Size = new System.Drawing.Size(494, 4);
            this.panelcizgi7.TabIndex = 14;
            // 
            // panelcizgi6
            // 
            this.panelcizgi6.BackColor = System.Drawing.Color.White;
            this.panelcizgi6.Location = new System.Drawing.Point(244, 306);
            this.panelcizgi6.Name = "panelcizgi6";
            this.panelcizgi6.Size = new System.Drawing.Size(494, 4);
            this.panelcizgi6.TabIndex = 13;
            // 
            // panelcizgi5
            // 
            this.panelcizgi5.BackColor = System.Drawing.Color.White;
            this.panelcizgi5.Location = new System.Drawing.Point(244, 263);
            this.panelcizgi5.Name = "panelcizgi5";
            this.panelcizgi5.Size = new System.Drawing.Size(494, 4);
            this.panelcizgi5.TabIndex = 12;
            // 
            // panelcizgi4
            // 
            this.panelcizgi4.BackColor = System.Drawing.Color.White;
            this.panelcizgi4.Location = new System.Drawing.Point(244, 220);
            this.panelcizgi4.Name = "panelcizgi4";
            this.panelcizgi4.Size = new System.Drawing.Size(494, 4);
            this.panelcizgi4.TabIndex = 11;
            // 
            // panelcizgi3
            // 
            this.panelcizgi3.BackColor = System.Drawing.Color.White;
            this.panelcizgi3.Location = new System.Drawing.Point(244, 181);
            this.panelcizgi3.Name = "panelcizgi3";
            this.panelcizgi3.Size = new System.Drawing.Size(494, 4);
            this.panelcizgi3.TabIndex = 10;
            // 
            // panelcizgi2
            // 
            this.panelcizgi2.BackColor = System.Drawing.Color.White;
            this.panelcizgi2.Location = new System.Drawing.Point(244, 145);
            this.panelcizgi2.Name = "panelcizgi2";
            this.panelcizgi2.Size = new System.Drawing.Size(494, 4);
            this.panelcizgi2.TabIndex = 9;
            // 
            // panelcizgi1
            // 
            this.panelcizgi1.BackColor = System.Drawing.Color.White;
            this.panelcizgi1.Location = new System.Drawing.Point(244, 106);
            this.panelcizgi1.Name = "panelcizgi1";
            this.panelcizgi1.Size = new System.Drawing.Size(494, 4);
            this.panelcizgi1.TabIndex = 8;
            // 
            // Notelbl
            // 
            this.Notelbl.AutoSize = true;
            this.Notelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Notelbl.Location = new System.Drawing.Point(198, 313);
            this.Notelbl.Name = "Notelbl";
            this.Notelbl.Size = new System.Drawing.Size(53, 21);
            this.Notelbl.TabIndex = 7;
            this.Notelbl.Text = "Not : ";
            // 
            // newagelbl
            // 
            this.newagelbl.AutoSize = true;
            this.newagelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newagelbl.Location = new System.Drawing.Point(159, 270);
            this.newagelbl.Name = "newagelbl";
            this.newagelbl.Size = new System.Drawing.Size(92, 21);
            this.newagelbl.TabIndex = 6;
            this.newagelbl.Text = "Yeni Yaş : ";
            // 
            // oldagelbl
            // 
            this.oldagelbl.AutoSize = true;
            this.oldagelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oldagelbl.Location = new System.Drawing.Point(187, 236);
            this.oldagelbl.Name = "oldagelbl";
            this.oldagelbl.Size = new System.Drawing.Size(64, 21);
            this.oldagelbl.TabIndex = 5;
            this.oldagelbl.Text = "Tarih : ";
            // 
            // telephonelbl
            // 
            this.telephonelbl.AutoSize = true;
            this.telephonelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telephonelbl.Location = new System.Drawing.Point(169, 188);
            this.telephonelbl.Name = "telephonelbl";
            this.telephonelbl.Size = new System.Drawing.Size(82, 21);
            this.telephonelbl.TabIndex = 4;
            this.telephonelbl.Text = "Telefon : ";
            // 
            // Joblbl
            // 
            this.Joblbl.AutoSize = true;
            this.Joblbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Joblbl.Location = new System.Drawing.Point(165, 152);
            this.Joblbl.Name = "Joblbl";
            this.Joblbl.Size = new System.Drawing.Size(86, 21);
            this.Joblbl.TabIndex = 3;
            this.Joblbl.Text = "Meslek  : ";
            // 
            // Surnamelbl
            // 
            this.Surnamelbl.AutoSize = true;
            this.Surnamelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Surnamelbl.Location = new System.Drawing.Point(163, 113);
            this.Surnamelbl.Name = "Surnamelbl";
            this.Surnamelbl.Size = new System.Drawing.Size(88, 21);
            this.Surnamelbl.TabIndex = 2;
            this.Surnamelbl.Text = "Soyisim : ";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelbl.Location = new System.Drawing.Point(192, 77);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(59, 21);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "İsim : ";
            // 
            // RehberAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 575);
            this.Controls.Add(this.panelcontext);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.panelslider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RehberAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RehberAddForm";
            this.Load += new System.EventHandler(this.RehberAddForm_Load);
            this.panelcontext.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelslider;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.Panel panelcontext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label oldagelbl;
        private System.Windows.Forms.Label telephonelbl;
        private System.Windows.Forms.Label Joblbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label newagelbl;
        private System.Windows.Forms.Label Notelbl;
        private System.Windows.Forms.Label Surnamelbl;
        private System.Windows.Forms.Panel panelcizgi2;
        private System.Windows.Forms.Panel panelcizgi1;
        private System.Windows.Forms.Panel panelcizgi3;
        private System.Windows.Forms.Panel panelcizgi4;
        private System.Windows.Forms.Panel panelcizgi5;
        private System.Windows.Forms.Panel panelcizgi6;
        private System.Windows.Forms.Panel panelcizgi7;
        private System.Windows.Forms.TextBox Nametxb;
        private System.Windows.Forms.TextBox Surnametxb;
        private System.Windows.Forms.TextBox jobtxb;
        private System.Windows.Forms.TextBox telephonetxb;
        private System.Windows.Forms.ComboBox newagecbbx;
        private System.Windows.Forms.RichTextBox notertxb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label duyurulbl;
        private System.Windows.Forms.DateTimePicker datepicker;
    }
}