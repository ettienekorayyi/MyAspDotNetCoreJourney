namespace Classes {
    public class Student : Person {
        public Student(string name, int age)
        {
            base.SetName(name);
            base.SetAge(age);
        }
    }
}