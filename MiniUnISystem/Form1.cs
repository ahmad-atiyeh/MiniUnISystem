namespace MiniUnISystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Teacher TeacherLogin(string email, string password)
        {
            using (var context = new UniContext())
            {
                return context.Teachers.SingleOrDefault(t => t.Email == email && t.Password == password);
            }
        }

        public Student StuLogin(string email, string password)
        {
            using (var context = new UniContext())
            {
                return context.Students.SingleOrDefault(t => t.Email == email && t.Password == password);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
