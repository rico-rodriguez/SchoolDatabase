namespace SchoolOfFineArtsModels
{
    public class Teacher
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public override string ToString()
        {
            return $" ID: {Id}, First Name: {FirstName}, Last Name: {LastName} ";
        }
    }
}