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
        private DbSet<T> _dbSet;

        public Catalog(DbSet<T> dbSet, CrmContext context)
        {
            InitializeComponent();
            _context = context;
            _dbSet = dbSet;
            _dbSet.Load();
            dataGridView.DataSource = _dbSet.Local.ToBindingList();
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

            if (typeof(T) == typeof(Product))
            {
                var product = _dbSet.Find(id) as Product;
                if(product != null)
                {
                    var form = new ProductForm();
                }
                
            }
            else if (typeof(T) == typeof(Seller))
            {

            }
            else if (typeof(T) == typeof(Customer))
            {

            }
        }
    }
}
