namespace Book_Catalog
{
    partial class SearchCatalogControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnBookTitle = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.dgvSearchCatalog = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.comboGenre);
            this.panel1.Controls.Add(this.txtBookTitle);
            this.panel1.Controls.Add(this.txtAuthorLastName);
            this.panel1.Controls.Add(this.btnGenre);
            this.panel1.Controls.Add(this.btnBookTitle);
            this.panel1.Controls.Add(this.btnSearchAuthor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 133);
            this.panel1.TabIndex = 0;
            // 
            // comboGenre
            // 
            this.comboGenre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Items.AddRange(new object[] {
            "Biography",
            "Business",
            "Databases",
            "eBook",
            "Fantasy",
            "History",
            "Humor",
            "Linux",
            "Macintosh",
            "Memoir",
            "Mystery",
            "Nonfiction",
            "Paranormal",
            "Philosophy",
            "Programming",
            "Science",
            "Science Fiction",
            "Self Help",
            "Technology",
            "Windows"});
            this.comboGenre.Location = new System.Drawing.Point(846, 46);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(190, 29);
            this.comboGenre.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(454, 46);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(190, 27);
            this.txtBookTitle.TabIndex = 2;
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorLastName.Location = new System.Drawing.Point(54, 45);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(190, 27);
            this.txtAuthorLastName.TabIndex = 1;
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btnGenre.FlatAppearance.BorderSize = 0;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenre.Location = new System.Drawing.Point(846, 79);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(190, 27);
            this.btnGenre.TabIndex = 0;
            this.btnGenre.Text = "Genre";
            this.btnGenre.UseVisualStyleBackColor = false;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnBookTitle
            // 
            this.btnBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btnBookTitle.FlatAppearance.BorderSize = 0;
            this.btnBookTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTitle.Location = new System.Drawing.Point(454, 80);
            this.btnBookTitle.Name = "btnBookTitle";
            this.btnBookTitle.Size = new System.Drawing.Size(190, 27);
            this.btnBookTitle.TabIndex = 0;
            this.btnBookTitle.Text = "Book Title";
            this.btnBookTitle.UseVisualStyleBackColor = false;
            this.btnBookTitle.Click += new System.EventHandler(this.btnBookTitle_Click);
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btnSearchAuthor.FlatAppearance.BorderSize = 0;
            this.btnSearchAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAuthor.Location = new System.Drawing.Point(54, 79);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(190, 27);
            this.btnSearchAuthor.TabIndex = 0;
            this.btnSearchAuthor.Text = "Author\'s Last Name";
            this.btnSearchAuthor.UseVisualStyleBackColor = false;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // dgvSearchCatalog
            // 
            this.dgvSearchCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchCatalog.Location = new System.Drawing.Point(4, 140);
            this.dgvSearchCatalog.Name = "dgvSearchCatalog";
            this.dgvSearchCatalog.Size = new System.Drawing.Size(1078, 501);
            this.dgvSearchCatalog.TabIndex = 1;
            // 
            // SearchCatalogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.dgvSearchCatalog);
            this.Controls.Add(this.panel1);
            this.Name = "SearchCatalogControl";
            this.Size = new System.Drawing.Size(1085, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnBookTitle;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.DataGridView dgvSearchCatalog;
    }
}
