
namespace WinFormsUI.Forms.Rehber
{
    partial class RehberForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RehberForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.countlbl = new System.Windows.Forms.Label();
            this.secilibtn = new System.Windows.Forms.Button();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.yenilepctrbx = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelfooter.SuspendLayout();
            this.panelsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yenilepctrbx)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panelfooter);
            this.panel1.Controls.Add(this.panelsearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 634);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tomato;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.NewAge,
            this.Name,
            this.Surname,
            this.Job,
            this.Telephone,
            this.Note});
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(998, 414);
            this.dataGridView1.TabIndex = 45;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.HeaderText = "Sıralama";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Doğum Tarihi";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // NewAge
            // 
            this.NewAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NewAge.DataPropertyName = "NewAge";
            this.NewAge.HeaderText = "Yeni Yaş";
            this.NewAge.Name = "NewAge";
            this.NewAge.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "İsim";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Soyisim";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Job
            // 
            this.Job.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Job.DataPropertyName = "Job";
            this.Job.HeaderText = "Meslek";
            this.Job.Name = "Job";
            this.Job.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Telefon Numarası";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Not";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.Tomato;
            this.panelfooter.Controls.Add(this.countlbl);
            this.panelfooter.Controls.Add(this.secilibtn);
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 480);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(998, 154);
            this.panelfooter.TabIndex = 44;
            // 
            // countlbl
            // 
            this.countlbl.AutoSize = true;
            this.countlbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countlbl.ForeColor = System.Drawing.Color.Black;
            this.countlbl.Location = new System.Drawing.Point(23, 43);
            this.countlbl.Name = "countlbl";
            this.countlbl.Size = new System.Drawing.Size(57, 21);
            this.countlbl.TabIndex = 43;
            this.countlbl.Text = "label1";
            // 
            // secilibtn
            // 
            this.secilibtn.BackColor = System.Drawing.Color.Black;
            this.secilibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secilibtn.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secilibtn.ForeColor = System.Drawing.SystemColors.Window;
            this.secilibtn.Location = new System.Drawing.Point(830, 10);
            this.secilibtn.Name = "secilibtn";
            this.secilibtn.Size = new System.Drawing.Size(133, 54);
            this.secilibtn.TabIndex = 42;
            this.secilibtn.Text = "Seç";
            this.secilibtn.UseVisualStyleBackColor = false;
            this.secilibtn.Click += new System.EventHandler(this.secilibtn_Click);
            // 
            // panelsearch
            // 
            this.panelsearch.BackColor = System.Drawing.Color.Tomato;
            this.panelsearch.Controls.Add(this.yenilepctrbx);
            this.panelsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsearch.Location = new System.Drawing.Point(0, 0);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(998, 108);
            this.panelsearch.TabIndex = 43;
            // 
            // yenilepctrbx
            // 
            this.yenilepctrbx.Image = ((System.Drawing.Image)(resources.GetObject("yenilepctrbx.Image")));
            this.yenilepctrbx.Location = new System.Drawing.Point(886, 14);
            this.yenilepctrbx.Name = "yenilepctrbx";
            this.yenilepctrbx.Size = new System.Drawing.Size(100, 50);
            this.yenilepctrbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yenilepctrbx.TabIndex = 0;
            this.yenilepctrbx.TabStop = false;
            this.yenilepctrbx.Click += new System.EventHandler(this.yenilepctrbx_Click);
            // 
            // RehberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 627);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RehberForm";
            this.Load += new System.EventHandler(this.RehberForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelfooter.ResumeLayout(false);
            this.panelfooter.PerformLayout();
            this.panelsearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yenilepctrbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button secilibtn;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Label countlbl;
        private System.Windows.Forms.PictureBox yenilepctrbx;
    }
}