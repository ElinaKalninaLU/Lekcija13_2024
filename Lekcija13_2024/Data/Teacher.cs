namespace Lekcija13_2024.ModelsDB
{
    public partial class Teacher
    {

        public string FullName { get { return Name + " " + Surname; } }
    }
}
