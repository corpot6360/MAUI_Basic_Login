namespace MAUI_Basic_Login
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object? sender, EventArgs e)
        {
            var user = UserEntry.Text ?? string.Empty;
            var pass = PasswordEntry.Text ?? string.Empty;

            if (user == "Potts" && pass == "Password1")
            {
                MessageLabel.Text = $"Login successful {user}";
            }
            else
            {
                MessageLabel.Text = $"Login failed {user}";
            }
        }

        private void OnCancelClicked(object? sender, EventArgs e)
        {
            UserEntry.Text = string.Empty;
            PasswordEntry.Text = string.Empty;
            MessageLabel.Text = string.Empty;
        }
    }
}
