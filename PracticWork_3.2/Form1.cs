using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;

namespace PracticWork_3._2
{
    public partial class FormPW3 : Form
    {
        private DbforPw2Context _db;

        public FormPW3()
        {
            InitializeComponent();

        }

        // OnLoad - при загрузки формы
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _db = new DbforPw2Context();

            // Метод Load расширения используется для всех пользователей из БД в DbContext БД.
            _db.Partners.Load();
            dataGridPartners.DataSource = _db.Partners.Local.ToBindingList();
        }


        // OnClosing - при закрытии формы.
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _db?.Dispose();
            _db = null;
        }


        private void DataGridPartners_SelectionChanged(object sender, EventArgs e)
        {
            if (_db != null)
            {
                var currentRow = dataGridPartners.CurrentRow;

                if (currentRow == null)
                    return;

                /*var user = (User)dataGridPartners.CurrentRow.DataBoundItem;

                if (user != null)
                {
                    _db.Entry(user).Collection(e => e.Posts).Load();
                    dataGridViewPosts.DataSource = user.Posts;
                }*/
            }
        }
        /*
private void BttnSave_Click(object sender, EventArgs e)
{
   // Этот код вызывает метод SaveChanges(),
   // который сохраняет все изменения в БД
   _db!.SaveChanges();

   dataGridView.Refresh();
}*/
    }
}
