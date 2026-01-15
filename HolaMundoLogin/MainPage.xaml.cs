namespace HolaMundoLogin
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void logginButton_Clicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;
            if (username == "admin" && password == "password")
            {
                DisplayAlertAsync("Login Successful", "Welcome, admin!", "OK");
            }
            else
            {
                DisplayAlertAsync("Login Failed", "Invalid username or password.", "OK");
            }
        }

    }
}
