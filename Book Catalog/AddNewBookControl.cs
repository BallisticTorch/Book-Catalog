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
    public partial class AddNewBookControl : UserControl
    {
        public AddNewBookControl()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "" || txtTitle.Text != "" || txtFirstName.Text != "" || txtLastName.Text != "" || txtGenre.Text != "")
            {
                DataAccess db = new DataAccess();

                db.SubmitBook(txtISBN.Text, txtTitle.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtBookSeries.Text, txtGenre.Text);

                txtISBN.Text = "";
                txtTitle.Text = "";
                txtFirstName.Text = "";
                txtMiddleName.Text = "";
                txtLastName.Text = "";
                txtBookSeries.Text = "";
                txtGenre.Text = "";
            }
            else
            {
                string message = "One or more required fields have not been provided. Please try again!";
                string messageTitle = "Input Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, messageTitle, button, MessageBoxIcon.Warning);
            }
        }
    }
}
