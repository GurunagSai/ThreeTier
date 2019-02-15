
namespace DomainLayer
{
    public static class StringLiterals
    {
        public const string ConnectionString = "Data Source=ora1-ggk-remap3;Initial Catalog=gurunag;Integrated Security=True";
        public static string InvalidDetails = "\nInvalid Details Entered";
        public static string RegistrationSucces = "\nRegistration successful";
        public static string AlreadyEmail = "\nEmail AlreadyExists!";
        public static string InvalidPassword = "Wrong Password";
        public static string LoginSuccessful = "\n You are Logged IN Successfully";
        public static string LoginUnsuccessful = "\nInvalid EmailId or Password!";
        public static string LogOutSuccessful = "you have been Logged OUT successfully ";
        public static string UserChoice = "\nOPTIONS:\n 1. LOGIN \n 2. REGISTRATION \n 3. EXIT";
        public static string Login = "LOGIN by entering your Credintals\n";
        public static string EmailId = "Enter EmailID :";
        public static string Password = "Enter Password :";
        public static string Registration = "REGISTRATION\n";
        public static string ValidPassword = "Password(Capital letters + small Letters + numbers) :";
        public static string ConfirmPassword = "Confirm Password :";
        public static string FirstName = "Enter First Name :";
        public static string LastName = "Enter Last Name :";
        public static string IsStudent = "Student(yes or no) :";
        public static string DisplayControl = "\nDisplay\n\t1. Students\n\t2. Other Than Students\n\t3. All \n\t4.LogOut";
        public static string TableData = "\nName\t\t\tName\t\tIsStudent?\n-------------------------------------------------------";
        public static string Exit = "\nPress ENTER to Exit";
        public static string WrongOption = "\n You have entered a Wrong Option";
        public static string SqlQueryYes = "SELECT * FROM EMPLOYEE WHERE IsStudent = 'yes' ;";
        public static string SqlQueryNo = "SELECT * FROM EMPLOYEE WHERE IsStudent = 'no' ;";
        public static string SqlQueryAll = "SELECT * FROM EMPLOYEE;";
        public static string Exception = "Exception occured";
    }
}
