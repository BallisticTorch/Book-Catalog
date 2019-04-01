namespace Book_Catalog
{
    partial class BookCatalogUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCatalogUI));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.pnlMenuItemSelected = new System.Windows.Forms.Panel();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnSearchCatalog = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.lblNumberOfBooks = new System.Windows.Forms.Label();
            this.lblNumberOfAuthors = new System.Windows.Forms.Label();
            this.lblNumBooksResult = new System.Windows.Forms.Label();
            this.lblNumAuthorsResult = new System.Windows.Forms.Label();
            this.addNewBookControl1 = new Book_Catalog.AddNewBookControl();
            this.searchCatalogControl1 = new Book_Catalog.SearchCatalogControl();
            this.navigationPanel.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.navigationPanel.Controls.Add(this.pnlMenuItemSelected);
            this.navigationPanel.Controls.Add(this.btnAddNewBook);
            this.navigationPanel.Controls.Add(this.btnSearchCatalog);
            this.navigationPanel.Controls.Add(this.btnHome);
            this.navigationPanel.Controls.Add(this.btnExit);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(233, 725);
            this.navigationPanel.TabIndex = 0;
            // 
            // pnlMenuItemSelected
            // 
            this.pnlMenuItemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.pnlMenuItemSelected.Location = new System.Drawing.Point(0, 217);
            this.pnlMenuItemSelected.Name = "pnlMenuItemSelected";
            this.pnlMenuItemSelected.Size = new System.Drawing.Size(10, 60);
            this.pnlMenuItemSelected.TabIndex = 1;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.FlatAppearance.BorderSize = 0;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.Location = new System.Drawing.Point(0, 282);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(230, 59);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.TabStop = false;
            this.btnAddNewBook.Text = "Add New Book";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnSearchCatalog
            // 
            this.btnSearchCatalog.FlatAppearance.BorderSize = 0;
            this.btnSearchCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCatalog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCatalog.ForeColor = System.Drawing.Color.White;
            this.btnSearchCatalog.Location = new System.Drawing.Point(0, 217);
            this.btnSearchCatalog.Name = "btnSearchCatalog";
            this.btnSearchCatalog.Size = new System.Drawing.Size(230, 59);
            this.btnSearchCatalog.TabIndex = 0;
            this.btnSearchCatalog.TabStop = false;
            this.btnSearchCatalog.Text = "Search Catalog";
            this.btnSearchCatalog.UseVisualStyleBackColor = true;
            this.btnSearchCatalog.Click += new System.EventHandler(this.btnSearchCatalog_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 152);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(230, 59);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 666);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(230, 59);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlTop.Controls.Add(this.lblApplicationName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(233, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1111, 63);
            this.pnlTop.TabIndex = 1;
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.ForeColor = System.Drawing.Color.White;
            this.lblApplicationName.Location = new System.Drawing.Point(6, 9);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(399, 44);
            this.lblApplicationName.TabIndex = 0;
            this.lblApplicationName.Text = "Bryan\'s Book Catalog";
            // 
            // lblNumberOfBooks
            // 
            this.lblNumberOfBooks.AutoSize = true;
            this.lblNumberOfBooks.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBooks.Location = new System.Drawing.Point(319, 152);
            this.lblNumberOfBooks.Name = "lblNumberOfBooks";
            this.lblNumberOfBooks.Size = new System.Drawing.Size(303, 25);
            this.lblNumberOfBooks.TabIndex = 4;
            this.lblNumberOfBooks.Text = "Number of Books in Catalog:";
            // 
            // lblNumberOfAuthors
            // 
            this.lblNumberOfAuthors.AutoSize = true;
            this.lblNumberOfAuthors.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAuthors.Location = new System.Drawing.Point(301, 234);
            this.lblNumberOfAuthors.Name = "lblNumberOfAuthors";
            this.lblNumberOfAuthors.Size = new System.Drawing.Size(321, 25);
            this.lblNumberOfAuthors.TabIndex = 4;
            this.lblNumberOfAuthors.Text = "Number of Authors in Catalog:";
            // 
            // lblNumBooksResult
            // 
            this.lblNumBooksResult.AutoSize = true;
            this.lblNumBooksResult.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBooksResult.Location = new System.Drawing.Point(628, 152);
            this.lblNumBooksResult.Name = "lblNumBooksResult";
            this.lblNumBooksResult.Size = new System.Drawing.Size(74, 24);
            this.lblNumBooksResult.TabIndex = 5;
            this.lblNumBooksResult.Text = "label1";
            // 
            // lblNumAuthorsResult
            // 
            this.lblNumAuthorsResult.AutoSize = true;
            this.lblNumAuthorsResult.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAuthorsResult.Location = new System.Drawing.Point(628, 234);
            this.lblNumAuthorsResult.Name = "lblNumAuthorsResult";
            this.lblNumAuthorsResult.Size = new System.Drawing.Size(74, 24);
            this.lblNumAuthorsResult.TabIndex = 5;
            this.lblNumAuthorsResult.Text = "label1";
            // 
            // addNewBookControl1
            // 
            this.addNewBookControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.addNewBookControl1.Location = new System.Drawing.Point(247, 69);
            this.addNewBookControl1.Name = "addNewBookControl1";
            this.addNewBookControl1.Size = new System.Drawing.Size(1085, 644);
            this.addNewBookControl1.TabIndex = 3;
            // 
            // searchCatalogControl1
            // 
            this.searchCatalogControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.searchCatalogControl1.Location = new System.Drawing.Point(247, 69);
            this.searchCatalogControl1.Name = "searchCatalogControl1";
            this.searchCatalogControl1.Size = new System.Drawing.Size(1085, 644);
            this.searchCatalogControl1.TabIndex = 2;
            // 
            // BookCatalogUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1344, 725);
            this.Controls.Add(this.addNewBookControl1);
            this.Controls.Add(this.searchCatalogControl1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.lblNumberOfBooks);
            this.Controls.Add(this.lblNumberOfAuthors);
            this.Controls.Add(this.lblNumAuthorsResult);
            this.Controls.Add(this.lblNumBooksResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookCatalogUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Catalog";
            this.navigationPanel.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnSearchCatalog;
        private System.Windows.Forms.Panel pnlMenuItemSelected;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblApplicationName;
        private SearchCatalogControl searchCatalogControl1;
        private AddNewBookControl addNewBookControl1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblNumberOfBooks;
        private System.Windows.Forms.Label lblNumberOfAuthors;
        private System.Windows.Forms.Label lblNumBooksResult;
        private System.Windows.Forms.Label lblNumAuthorsResult;
    }
}

