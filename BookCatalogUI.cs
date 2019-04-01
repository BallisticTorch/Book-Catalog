using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Catalog
{
    public partial class BookCatalogUI : Form
    {
        public BookCatalogUI()
        {
            InitializeComponent();

            searchCatalogControl1.Visible = false;
            addNewBookControl1.Visible = false;

            pnlMenuItemSelected.Height = btnHome.Height;
            pnlMenuItemSelected.Top = btnHome.Top;

            RefreshUI();
        }
        
        private void btnSearchCatalog_Click(object sender, EventArgs e)
        {
            //
            // TO DO:
            // clear dgvSearchCatalog DataGridView when user moves on from Search to Add New or Home
            // haven't found a solution to this yet as the DGV is private on the SearchCatalogControl control
            // and is not accessible here in this code
            //

            pnlMenuItemSelected.Height = btnSearchCatalog.Height;
            pnlMenuItemSelected.Top = btnSearchCatalog.Top;

            searchCatalogControl1.Visible = true;
            addNewBookControl1.Visible = false;
            lblNumBooksResult.Visible = false;
            lblNumAuthorsResult.Visible = false;
            lblNumberOfAuthors.Visible = false;
            lblNumberOfBooks.Visible = false;
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            pnlMenuItemSelected.Height = btnAddNewBook.Height;
            pnlMenuItemSelected.Top = btnAddNewBook.Top;

            searchCatalogControl1.Visible = false;
            addNewBookControl1.Visible = true;
            lblNumBooksResult.Visible = false;
            lblNumAuthorsResult.Visible = false;
            lblNumberOfAuthors.Visible = false;
            lblNumberOfBooks.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            searchCatalogControl1.Visible = false;
            addNewBookControl1.Visible = false;
            lblNumBooksResult.Visible = true;
            lblNumAuthorsResult.Visible = true;
            lblNumberOfAuthors.Visible = true;
            lblNumberOfBooks.Visible = true;

            RefreshUI();

            pnlMenuItemSelected.Height = btnHome.Height;
            pnlMenuItemSelected.Top = btnHome.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void RefreshUI()
        {
            DataAccess db = new DataAccess();

            lblNumBooksResult.Text = db.NumBooksUpdate();
            lblNumAuthorsResult.Text = db.NumAuthorsUpdate();
        }
    }
}
