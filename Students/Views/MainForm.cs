using Students.Data;

namespace Students.Views
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new();
            LoadStudent();
        }

        private void LoadStudent(string filter = "")
        {
            dgvStudents.Rows.Clear();

            var collection = String.IsNullOrEmpty(filter) 
                ? _context.Students 
                : _context.Students.Where(x => x.Settlement.Contains(filter));

            foreach (var s in collection)
            {
                dgvStudents.Rows.Add(new object[]
                {
                    s.OM,
                    s.Name,
                    s.DateOfBirth.ToString("yyyy. MM. dd"),
                    s.Class,
                    $"{s.Zip} {s.Settlement}, {s.Address}"
                });
            }
        }

        private void TsmiNewStudent_Click(object sender, EventArgs e)
        {
            InsertStudentForm form = new(_context);
            form.ShowDialog();
            LoadStudent();
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudent(tbSearch.Text);
        }

    }
}