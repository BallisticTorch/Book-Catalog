using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Catalog
{
    public partial class SearchCatalogControl : UserControl
    {
        List<Book> book = new List<Book>();

        public SearchCatalogControl()
        {
            InitializeComponent();
        }

        public void UpdateDataGrid()
        {
            dgvSearchCatalog.DataSource = book;

            dgvSearchCatalog.Columns[0].HeaderCell.Value = "ISBN";
            dgvSearchCatalog.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSearchCatalog.Columns[1].HeaderCell.Value = "Book Title";
            dgvSearchCatalog.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSearchCatalog.Columns[2].HeaderCell.Value = "Author First Name";
            dgvSearchCatalog.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSearchCatalog.Columns[3].HeaderCell.Value = "Author Middle Name";
            dgvSearchCatalog.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSearchCatalog.Columns[4].HeaderCell.Value = "Author Last Name";
            dgvSearchCatalog.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSearchCatalog.Columns[5].HeaderCell.Value = "Book Series";
            dgvSearchCatalog.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSearchCatalog.Columns[6].HeaderCell.Value = "Genre";
            dgvSearchCatalog.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvSearchCatalog.Columns.Remove("FullInfo");
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            book = db.GetAuthorLastName(txtAuthorLastName.Text);

            UpdateDataGrid();
            txtAuthorLastName.Text = "";
        }

        private void btnBookTitle_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            book = db.GetBookTitle(txtBookTitle.Text);

            UpdateDataGrid();
            txtBookTitle.Text = "";
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            book = db.GetGenre(comboGenre.Text);

            UpdateDataGrid();
            comboGenre.Text = "";
        }
    }
}
