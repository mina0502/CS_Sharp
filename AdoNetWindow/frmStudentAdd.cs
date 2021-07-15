using AdoNet;
using AdoNetWindow.Model;
using AppConfiguration;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libs;

namespace AdoNetWindow
{
    public partial class frmStudentAdd : ApplicationRoot
    {
     //   IStudentDsRepository studentRepository;
        IStudentRepository studentRepository;
        public frmStudentAdd()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            studentRepository = new StudentRepository();
            V_ShowStudent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentAdd();
            V_ShowStudent();
        }

        private void V_ShowStudent()
        {
            grdStudent.DataSource = studentRepository.GetAll();
            grdStudent.Columns["StudentId"].HeaderText = "학생Id";
            grdStudent.Columns["StudentId"].ReadOnly = true;
            grdStudent.Columns["StudentName"].HeaderText = "학생성명";
            grdStudent.Columns["Address"].HeaderText = "주소";
        }

        private void StudentAdd()
        {
            StudentModel studentModel = new StudentModel();
            studentModel.StudentName = txtStudentName.Text.Trim();
            studentModel.Address = txtAddress.Text.Trim();
            studentRepository.Add(studentModel);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(grdStudent.SelectedRows.Count==0)
            {
                return;
            }
//            StudentDelete(int.Parse(grdStudent.SelectedRows[0].Cells["StudentId"].Value.ToString()));


            StudentModel studentModel = grdStudent.SelectedRows[0].DataBoundItem as StudentModel;
            StudentDelete(studentModel.StudentId);
        }

        private void StudentDelete(int student_id)
        {
            //studentRepository.Delete(student_id);

            IStudentDeleteHandler studentDeleteHandler = new StudentDeleteHandler();
            try
            {
                studentDeleteHandler.Delete(student_id); 
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(student_id.ToString());
            }
            V_ShowStudent();
        }

        private void grdStudent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdStudent.SelectedRows.Count == 0 || grdStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("학생을 한 명 선택하세요");
                return;
            }
            StudentModel studentModel = grdStudent.SelectedRows[0].DataBoundItem as StudentModel;
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                studentRepository.UpdateName(studentModel.StudentId, studentModel.StudentName);
            }
            V_ShowStudent();
        }


    }
}