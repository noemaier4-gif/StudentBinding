using StudentBinding.Models;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }
        private Student currentStudent;
        public Student CurrentStudent
        {
            get => currentStudent;
            set
            {
                currentStudent = value;
                OnPropertyChanged(nameof(CurrentStudent));
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Student1 = new Student
            {
                Name = "מוחמד אבו נאסר",
                Age = 99,
                BirthDate = new DateTime(1927, 3, 18),
                Image = "daniel.png",
                Email = "abunasser@gmail.com",
                Phone = "054-6767679"
            };
            Student2 = new Student
            {
                Name = "נוח מאיר",
                Age = 52,
                BirthDate = new DateTime(1974, 7, 19),
                Image = "noa.png",
                Email = "noemaier@gmail.com",
                Phone = "054-9998567"
            };
            CurrentStudent = Student1;
            this.BindingContext = this;
        }
        private void OnChangeStudentClicked(object sender, EventArgs e)
        {
            if (CurrentStudent == Student1)
                CurrentStudent = Student2;
            else
                CurrentStudent = Student1;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
