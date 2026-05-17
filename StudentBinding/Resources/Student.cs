using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.Models
{
    public class Student:ObservableObject
    {
        private string name;
        private string image;
        private int age;
        private DateTime birthDate;
        private string email;
        private string phone;

        public string Name
        {
            get => name;
            set { if (name != value) { name = value; OnPropertyChanged(); } }
        }

        public string Image
        {
            get => image;
            set { if (image != value) { image = value; OnPropertyChanged(); } }
        }

        public int Age
        {
            get => age;
            set { if (age != value) { age = value; OnPropertyChanged(); } }
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set { if (birthDate != value) { birthDate = value; OnPropertyChanged(); } }
        }

        public string Email
        {
            get => email;
            set { if (email != value) { email = value; OnPropertyChanged(); } }
        }

        public string Phone
        {
            get => phone;
            set { if (phone != value) { phone = value; OnPropertyChanged(); } }
        }
    }
}
