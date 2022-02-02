using Students.Data;
using Students.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students.Views
{
    public partial class InsertStudentForm : Form
    {
        private readonly ApplicationDbContext _context;

        public InsertStudentForm(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Student student = new()
            {
                OM = tbOM.Text,
                Name = tbName.Text,
                DateOfBirth = DateTime.Parse(tbDateOfBirth.Text),
                Class = tbClass.Text,
                Zip = tbZip.Text,
                Settlement = tbSettlement.Text,
                Address = tbAddress.Text
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            Close();
        }
    }
}
