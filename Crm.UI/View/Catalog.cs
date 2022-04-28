using CrmBuisnessLogic;
using CrmBuisnessLogic.Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;


namespace Crm.UI.View
{
    public partial class Catalog<T> : Form
        where T : class
    {

        private CrmContext _context; 

        public Catalog(DbSet<T> dbSet, CrmContext context)
        {
            InitializeComponent();
            _context = context;
            dbSet.Load();
            dataGridView.DataSource = dbSet.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(typeof(T) == typeof(Product))
            {

            }
            else if (typeof(T) == typeof(Seller))
            {

            }
            else if (typeof(T) == typeof(Customer))
            {

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;
        }
    }
}
