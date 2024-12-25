using System.Windows.Forms;

namespace MiniUnISystem
{
    public partial class Form1 : Form
    {
        UniContext context = new UniContext();
        public Form1()
        {
            InitializeComponent();
        }

        public User LogIn(string email, string password)
        {
           
            var user = context.Users
               .FirstOrDefault(u => u.Email == email && u.Password == password);

            return user;

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void adminRB_CheckedChanged(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string password = passwordTB.Text;


            var user = LogIn(email, password);

            user.Role = "Admin";
            if (user != null)
            {
                AdminForm adminF = new AdminForm();
                adminF.Show();
                this.Hide();
                MessageBox.Show($"Welcome {user.Name}.");
            }
            else
            {
                MessageBox.Show("Invalid email or password for Admin.");
            }
        }

        private void teacherRB_CheckedChanged(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string password = passwordTB.Text;


            var user = LogIn(email, password);

            user.Role = "Teacher";
            if (user != null)
            {
                TeacherForm teacherF = new TeacherForm();
                teacherF.Show();
                this.Hide();
                MessageBox.Show($"Welcome {user.Name}.");
            }
            else
            {
                MessageBox.Show("Invalid email or password for Teacher.");
            }
        }

        private void studentRB_CheckedChanged(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string password = passwordTB.Text;


            var user = LogIn(email, password);

            user.Role = "Student";
            if (user != null)
            {
                StudentForm studentF = new StudentForm();
                studentF.Show();
                this.Hide();
                MessageBox.Show($"Welcome {user.Name}.");
            }
            else
            {
                MessageBox.Show("Invalid email or password for Student.");
            }
        }
    }
}
