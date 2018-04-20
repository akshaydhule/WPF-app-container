using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Windows.Markup;

namespace DemoUI
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class SettingViewModel : BaseViewModel
    {

        #region Public Properties
        /// <summary>
        /// Initialize Current setting page to Default settings
        /// </summary>
        public SettingPage CurrentSettingPage { get; set; } = SettingPage.First;
        #endregion

        #region XAML commands
        /// <summary>
        /// Submit commands
        /// </summary>
        public ICommand SubmitCommand { get; set; }

        /// <summary>
        /// Custom settings command
        /// </summary>
        public ICommand SecondSettingCommand { get; set; }

        /// <summary>
        /// Minimum settings command
        /// </summary>
        public ICommand FirstSettingCommand { get; set; }

        /// <summary>
        /// Maximum settings command
        /// </summary>
        public ICommand ThirdSettingCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingViewModel()
        {
            SubmitCommand = new RelayCommand(async () => await SubmitAsync());
            SecondSettingCommand = new RelayCommand(async () => await SecondSettingAsync());
            FirstSettingCommand = new RelayCommand(async () => await FirstSettingAsync());
            ThirdSettingCommand = new RelayCommand(async () => await ThirdSettingAsync());
        }
        #endregion

        #region XAML Functionality

        /// <summary>
        /// second setting
        /// </summary>
        /// <returns></returns>
        private async Task SecondSettingAsync()
        {
            //Action
            await Task.Delay(1);
        }
        
        /// <summary>
        /// First setting
        /// </summary>
        /// <returns></returns>
        private async Task FirstSettingAsync()
        {
            //Action
            await Task.Delay(1);

        }

        /// <summary>
        /// Third setting
        /// </summary>
        /// <returns></returns>
        private async Task ThirdSettingAsync()
        {
            //Action
            await Task.Delay(1);

        }


        /// <summary>
        /// Submit
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task SubmitAsync()
        {
            await Task.Delay(1);
            //action
        }

        #endregion

    }
}
