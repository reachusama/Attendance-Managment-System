using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace Vp_Final_Project
{
    class MySql
    {
        MySqlDataAdapter adapter;
        DataTable dt;
        private MySqlConnection connection;
        MySqlCommand cmd;

        private string server;
        private string database;
        private string uid;
        private string password;
        public MySql()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "localhost";
            database = "AdvanceAttendanceManager";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public void AdminInsert(string adminFullName,
            string adminUserName,
            string admin_Password,
            string admin_Email,
            string adminAccessLevel)
        {
            string query = "INSERT INTO `admin` " +
                "(`admin_FullName`, " +
                "`admin_UserName`, " +
                "`admin_Password`, " +
                "`admin_Email`, " +
                "`admin_AccessLevel`) " +
                "VALUES ( \'" + adminFullName +
                "\',\'" + adminUserName +
                "\',\'" + admin_Password +
                "\',\'" + admin_Email +
                "\',\'" + adminAccessLevel +
                "\');";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public bool isAdminValid(string adminUserName, string adminPassword)
        {
            if (CountAdmin(adminUserName, adminPassword) == 0)
            {
                return false;
            }
            return true;
        }
        public int CountAdmin(string userName, string password)
        {
            string query = "SELECT Count(*) FROM ADMIN where admin_UserName=\'" +
                userName + "\' AND admin_Password = \'" + password + "\';";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
                return Count;
            }
            else
            {
                return Count;
            }
        }
        public int getAdminId(string userName, string password)
        {
            string query = "SELECT admin_id FROM `admin` WHERE admin_UserName =\'" +
                userName + "\' AND admin_Password = \'" + password + "\';";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();
                return Count;
            }
            return Count;
        }
        public DataTable getAdminUser(int id)
        {
            string query = "SELECT * FROM ADMIN where admin_id = " + Convert.ToString(id) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query,connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public bool isAdminPasswordPresent(string pass)
        {
            string query = "SELECT Count(*) FROM ADMIN where admin_Password=\'" + pass + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();    
            }
            return !(Count == -1 || Count == 0);
        }
        public bool changeAdminPassword(int id, string newPassword, string oldPassword)
        {

            if (isAdminPasswordPresent(oldPassword))
            {
                string query = "UPDATE ADMIN SET admin_password = @admin_Password  WHERE admin_id = " + Convert.ToString(id) + " ;";
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@admin_Password", newPassword );
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool isAdminUserNamePresent(string pass)
        {
            string query = "SELECT Count(*) FROM ADMIN where admin_UserName=\'" + pass + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
            }
            return !(Count == -1 || Count == 0);
        }
        public bool changeAdminUserName(int id, string newUser, string oldUser)
        {

            if (isAdminUserNamePresent(oldUser))
            {
                string query = "UPDATE ADMIN SET admin_UserName = @admin_UserName  WHERE admin_id = " + Convert.ToString(id) + " ;";
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@admin_UserName", newUser);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }


        public void StudentInsert(string studentEnrollment,
            string studentPassword,
            string studentFullName,
            string studentEmailAddress,
            string studentAddress,
            string studentContactNumber,
            string studentSemester,
            string studentJoinYear,
            string studentDepartment)
        {
            string query = "INSERT INTO `student`( " +
                "`student_Enrollment`, " +
                "`student_Password`, " +
                "`student_Name`, " +
                "`student_EmailAddress`, " +
                "`student_Address`, " +
                "`student_ContactNumber`, " +
                "`student_Semester`, " +
                "`student_JoinYear`, " +
                "`student_Department`) VALUES (\'" +
                studentEnrollment + "\',\'" +
                studentPassword + "\',\'" +
                studentFullName + "\',\'" +
                studentEmailAddress + "\',\'" +
                studentAddress + "\',\'" +
                studentContactNumber + "\',\'" +
                studentSemester + "\',\'" +
                studentJoinYear + "\',\'" +
                studentDepartment + "\')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public bool isStudentValid(string studentEnrollment, string studentPassword)
        {
            if (CountStudent(studentEnrollment, studentPassword) == 0)
            {
                return false;
            }
            return true;
        }
        public int CountStudent(string userName, string password)
        {
            string query = "SELECT Count(*) FROM STUDENT where student_Enrollment=\'" +
                userName + "\' AND student_Password = \'" + password + "\';";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
                return Count;
            }
            else
            {
                return Count;
            }
        }
        public DataTable getStudentUser(int id)
        {
            string query = "SELECT * FROM `student` WHERE `student_Id` = " + Convert.ToString(id) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getStudentUsers()
        {
            string query = "SELECT * FROM STUDENT;";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public bool isStudentPasswordPresent(string pass)
        {
            string query = "SELECT Count(*) FROM student where student_Password=\'" + pass + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
            }
            return !(Count == -1 || Count == 0);
        }
        public bool changeStudentPassword(int id, string newPassword, string oldPassword)
        {

            if (isStudentPasswordPresent(oldPassword))
            {
                string query = "UPDATE student SET student_password = @student_Password  WHERE student_id = " + Convert.ToString(id) + " ;";
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@student_Password", newPassword);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool isStudentUserNamePresent(string pass)
        {
            string query = "SELECT Count(*) FROM student where student_Enrollment=\'" + pass + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
            }
            return !(Count == -1 || Count == 0);
        }
        public bool changeStudentUserName(int id, string newUser, string oldUser)
        {

            if (isStudentUserNamePresent(oldUser))
            {
                string query = "UPDATE student SET student_Enrollment = @student_Enrollment  WHERE student_id = " + Convert.ToString(id) + " ;";
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@student_Enrollment", newUser);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public int getStudentId(string userName, string password)
        {
            string query = "SELECT `student_Id` FROM `student` WHERE `student_Enrollment` =\'" +
                userName + "\' AND `student_Password` = \'" + password + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();
            }
            return Count;
        }
        public string getStudentNameById(int id)
        {
            string query = "SELECT student_Name FROM `student` WHERE `student_Id` = " + Convert.ToString(id) + ";";
            string name = "";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                name = cmd.ExecuteScalar() + "";
                this.CloseConnection();
            }
            return name;
        }




        public void TeacherInsert(string teacherUserName,
            string teacherPassword,
            string teacherName,
            string teacherEmailAddress,
            string teacherAddress,
            string teacherContactNumber,
            string teacherDepartment)
        {
            string query = "INSERT INTO `teacher`(" +
                " `teacher_UserName`," +
                " `teacher_Password`," +
                " `teacher_Name`," +
                " `teacher_EmailAddress`," +
                " `teacher_Address`," +
                " `teacher_ContactNumber`," +
                " `teacher_Department`) VALUES (\'" +
                teacherUserName + "\',\'" +
                teacherPassword + "\',\'" +
                teacherName + "\',\'" +
                teacherEmailAddress + "\',\'" +
                teacherAddress + "\',\'" +
                teacherContactNumber + "\',\'" +
                teacherDepartment + "\')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public bool isTeacherValid(string teacherUserName, string teacherPassword)
        {
            if (CountTeacher(teacherUserName, teacherPassword) == 0)
            {
                return false;
            }
            return true;
        }
        public int CountTeacher(string userName, string password)
        {
            string query = "SELECT Count(*) FROM TEACHER where teacher_UserName=\'" +
                userName + "\' AND teacher_Password = \'" + password + "\';";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
                return Count;
            }
            else
            {
                return Count;
            }
        }
        public int getTeacherIdByName(string name)
        {
            string query = "SELECT teacher_id FROM `teacher` WHERE teacher_Name =\'" + name + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();
                return Count;
            }
            return Count;
        }
        public DataTable getAllTeachersName()
        {
            string query = "SELECT teacher_Name FROM TEACHER ;";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getTeacherUser(int id)
        {
            string query = "SELECT * FROM teacher where teacher_Id = " + Convert.ToString(id) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getTeacherUsers()
        {
            string query = "SELECT * FROM TEACHER;";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public bool isTeacherPasswordPresent(string pass)
        {
            string query = "SELECT Count(*) FROM teacher where teacher_Password=\'" + pass + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
            }
            return !(Count == -1 || Count == 0);
        }
        public bool changeTeacherPassword(int id, string newPassword, string oldPassword)
        {

            if (isTeacherPasswordPresent(oldPassword))
            {
                string query = "UPDATE teacher SET teacher_password = @teacher_Password  WHERE teacher_id = " + Convert.ToString(id) + " ;";
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@teacher_Password", newPassword);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool isTeacherUserNamePresent(string pass)
        {
            string query = "SELECT Count(*) FROM teacher where teacher_UserName=\'" + pass + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
            }
            return !(Count == -1 || Count == 0);
        }
        public bool changeTeacherUserName(int id, string newUser, string oldUser)
        {

            if (isTeacherUserNamePresent(oldUser))
            {
                string query = "UPDATE teacher SET teacher_UserName = @teacher_UserName  WHERE teacher_id = " + Convert.ToString(id) + " ;";
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@teacher_UserName", newUser);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public int getTeacherId(string userName, string password)
        {
            string query = "SELECT teacher_id FROM `teacher` WHERE teacher_UserName =\'" +
                userName + "\' AND teacher_Password = \'" + password + "\';";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();
                return Count;
            }
            return Count;
        }




        public void CourseInsert(string name, string hours)
        {
            string query = "INSERT INTO `course`(`course_Name`, `course_CreditHour`) VALUES ( \'" +
                name + "\' , \'" + hours + "\' );";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public int getCourseIdByName(string name)
        {
            string query = "SELECT course_id FROM `course` WHERE course_Name =\'" + name + "\' ;";
            int Count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();
                return Count;
            }
            return Count;
        }
        public DataTable getAllCoursesName()
        {
            string query = "SELECT course_Name FROM Course ;";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getAllCourses()
        {
            string query = "SELECT * FROM COURSE;";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        



        public void AssignedCourseInsert(int cr_id,int tea_id, string cr_name, string tea_name)
        {
            string query = "INSERT INTO `assigned_courses`(`course_id`, `teacher_id`, `course_Name`, `teacher_Name`) VALUES (" +
                Convert.ToString(cr_id) + "," + Convert.ToString(tea_id) +
                ",\'" + cr_name + "\' , \'" + tea_name + "\' );"; 
                ;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public DataTable getAllAssignedCourses()
        {
            string query = "SELECT * FROM assigned_courses;";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public string getTeacherNameByCourse(string name)
        {
            string query = "SELECT teacher_Name FROM `assigned_courses` WHERE course_Name =\'" + name + "\' ;";
            string teacher = "";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                teacher = cmd.ExecuteScalar() + "";
                this.CloseConnection();
            }
            return teacher;
        }
        public DataTable getAllAssigedCoursesByTeacherId(int id)
        {
            string query = "SELECT course_Name FROM assigned_courses WHERE teacher_id = " + Convert.ToString(id) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }





        public void RegisteredCoursesInsert(int stuId,int tid, int cId, string stuName, string tName, string cName)
        {

            cmd = new MySqlCommand("INSERT INTO `registerd_courses`(`student_Id`, `teacher_Id`, `course_id`, `student_Name`, `teacher_Name`, `course_Name`) " +
                " values(@student_Id,@teacher_Id,@course_id,@student_Name,@teacher_Name,@course_Name)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@student_Id", stuId);
            cmd.Parameters.AddWithValue("@teacher_Id", tid);
            cmd.Parameters.AddWithValue("@course_id", cId);
            cmd.Parameters.AddWithValue("@student_Name", stuName);
            cmd.Parameters.AddWithValue("@teacher_Name", tName);
            cmd.Parameters.AddWithValue("@course_Name", cName);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable getRegisteredCoursesForStudent(int id)
        {
            string query = "SELECT * FROM registerd_courses WHERE student_Id = " + Convert.ToString(id) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getRegisteredStudentsByCourseName(string cname)
        {
            string query = "SELECT * FROM registerd_courses WHERE course_Name = \'" +
                cname + "\' ;";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getRegisteredStudentsByTeacherIdAndCourseName(int tId, string courseName)
        {
            string query = "SELECT * FROM registerd_courses WHERE course_Name = \'" +
                courseName + "\' AND teacher_Id = " + Convert.ToString(tId) + " ;";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }



        public void AttendanceUpdate(int attendanceId, string attendance_Status)
        {

            cmd = new MySqlCommand("UPDATE `attendance` set `attendance_Status` = @attendance_Status WHERE " +
                "attendance_Id = @attendance_Id", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@attendance_Status", attendance_Status);
            cmd.Parameters.AddWithValue("@attendance_Id", attendanceId);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void AttendanceInsert(int stuId, int tid, int cId, string stuName, string tName, string cName, string date, string attendance_Status)
        {

            cmd = new MySqlCommand("INSERT INTO `attendance`(`student_Id`, `teacher_Id`, `course_Id`, `student_Name`, `teacher_Name`, `course_Name`, `date_Name`, `attendance_Status`) VALUES " +
                "(@student_Id,@teacher_Id,@course_id,@student_Name,@teacher_Name,@course_Name,@date_Name,@attendance_Status)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@student_Id", stuId);
            cmd.Parameters.AddWithValue("@teacher_Id", tid);
            cmd.Parameters.AddWithValue("@course_id", cId);
            cmd.Parameters.AddWithValue("@student_Name", stuName);
            cmd.Parameters.AddWithValue("@teacher_Name", tName);
            cmd.Parameters.AddWithValue("@course_Name", cName);
            cmd.Parameters.AddWithValue("@date_Name", date);
            cmd.Parameters.AddWithValue("@attendance_Status", attendance_Status);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable getAttendanceCoursesForTeacher(int teacherId)
        {
            string query = "SELECT DISTINCT course_Name FROM attendance WHERE teacher_Id = " + Convert.ToString(teacherId) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getAttendanceDatesForTeacher(int teacherId)
        {
            string query = "SELECT DISTINCT date_Name FROM attendance WHERE teacher_Id = " + Convert.ToString(teacherId) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getAttendanceByCourseAndDateForTeacher(int teacherId, string crName, string date)
        {
            string query = "SELECT * FROM attendance WHERE course_Name = " +
                "\'" + crName + "\' " +
                "AND date_Name = \'" + date + "\'" +
               "AND teacher_Id = " + Convert.ToString(teacherId);
               ;
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable getAttendanceCoursesForStudent(int teacherId)
        {
            string query = "SELECT DISTINCT course_Name FROM attendance WHERE student_Id = " + Convert.ToString(teacherId) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getAttendanceDatesForStudent(int teacherId)
        {
            string query = "SELECT DISTINCT date_Name FROM attendance WHERE student_Id = " + Convert.ToString(teacherId) + ";";
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable getAttendanceByCourseAndDateForStudent(int teacherId, string crName, string date)
        {
            string query = "SELECT * FROM attendance WHERE course_Name = " +
                "\'" + crName + "\' " +
                "AND date_Name = \'" + date + "\'" +
               "AND student_Id = " + Convert.ToString(teacherId);
            ;
            connection.Open();
            dt = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }



        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
      
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
    
    
    }
}