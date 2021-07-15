using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Libs
{
    public class StudentDeleteHandler: ClassRoot,IStudentDeleteHandler
    {
        public void Delete(int student_id)
        {

            
           IDbTransaction transaction= dbInstance.Connection.BeginTransaction();
           try
           {
                DeleteCourseRegistration(student_id,transaction);
                DeleteStudent(student_id, transaction);
                transaction.Commit();
           }
           catch(Exception e)
           {
               transaction.Rollback();
               throw e; 
           }
        }

        private void DeleteStudent(int student_id, IDbTransaction transaction)
        {
            StringBuilder qry = new StringBuilder();
            qry.Append(" DELETE FROM");
            qry.Append("    TB_Student");
            qry.Append(" WHERE");
            qry.Append("    StudentId="+student_id);
            transaction.Connection.Execute(qry.ToString(), transaction: transaction);
        }

        private void DeleteCourseRegistration(int student_id, IDbTransaction transaction)
        {
            StringBuilder qry = new StringBuilder();
            qry.Append(" DELETE FROM");
            qry.Append("    TB_CourseRegistration");
            qry.Append(" WHERE");
            qry.Append("    StudentId="+student_id);
            transaction.Connection.Execute(qry.ToString(), transaction: transaction);
        }
    }
}
