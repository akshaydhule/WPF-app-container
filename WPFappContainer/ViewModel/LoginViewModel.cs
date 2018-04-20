using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DemoUI
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            // Create commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));
        }

        #endregion

        #region Actions
        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {        
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                await Task.Delay(5000);
                Password = (parameter as IHavePassword).SecurePassword.Unsecure();
                string response = LoginRequest();
                if (string.IsNullOrEmpty(response))
                {
                    ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Dashboard;
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show(response, "Notification", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            });
        }
        #endregion

        #region Helpers

        /// <summary>
        ///check login Credentials
        /// </summary>
        /// <returns></returns>
        static string LoginRequest()
        {
            int error = 0;
            if (error != 0)
                return "Login unsuccessful";
            else
                return null;
        }

        #endregion

    }
}
