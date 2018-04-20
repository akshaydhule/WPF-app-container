using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Threading;

namespace DemoUI
{
    /// <summary>
    /// The View Model
    /// </summary>
    public class DataViewModel : BaseViewModel
    {


        #region XAML declaration

        /// <summary>
        /// Data button
        /// </summary>
        public ICommand DataCommand { get; set; }

        /// <summary>
        /// Settings radio options
        /// </summary>
        public RadioOptions RadioOption { get; set; }

        /// <summary>
        /// Type radio options
        /// </summary>
        public TypeRadioOptions TypeRadioOption { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public DataViewModel()
        {
            DataCommand = new RelayCommand(async () => await DataAsync());
        }

        #endregion

        #region XAML functionality


        private async Task DataAsync()
        {
            //Action
            await Task.Delay(1);
        }

        #endregion

    }
}
