using AdoNetWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWindow.View
{
    public class StudentView
    {
        public void ShowStudentOnGrid(DataGridView control,List<StudentModel>list)
        {
            control.DataSource = list;
        }

        public void ShowStudentOnCombo(ComboBox control, List<StudentModel>list)
        {
            control.DataSource = list;
            control.DisplayMember = "StudentName";
            control.ValueMember = "StudentId";
        }
    }
}
