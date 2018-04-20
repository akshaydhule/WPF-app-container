using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;

namespace DemoUI
{
    public class WindowViewModel : BaseViewModel
    {
        #region Private Member
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// Margin around the window to allow for a drop shadow
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// the radius of the edge of the shadow
        /// </summary>
        private int mWindowRadius = 10;

        /// <summary>
        /// The last known dock position
        /// </summary>
        private WindowDockPosition mDockPosition = WindowDockPosition.Undocked;

        #endregion

        #region public Properties

        public double WindowMimumWidth { get; set; } = 800;

        public double WindowMimumHeight { get; set; } = 400;

        /// <summary>
        /// True if the window should be borderless because it is docked or maximized
        /// </summary>
        public bool Borderless { get { return (mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked); } }


        ///<summary>
        ///resize border around the window
        ///</summary>
        public int ResizeBorder { get; set; } = 6;

        ///<summary>
        ///size of the resize border around the window, taking into account the outer margin
        ///</summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        ///<summary>
        ///Padding of the inner content of main window
        ///</summary>
        public Thickness InnerContentPadding { get; set; } = new Thickness(0);


        /// <summary>
        /// Margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }

        /// <summary>
        /// Margin around the window to allow for a drop shadow
        /// </summary>
        public Thickness OuterMarginsizeThickness { get { return new Thickness(OuterMarginSize); } }


        /// <summary>
        /// the radius of the edge of the shadow
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }

        /// <summary>
        /// the radius of the edge of the shadow
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        #endregion

        #region Commands
        public ICommand MinimizeCommand { get; set; }

        public ICommand MaximizeCommand { get; set; }

        public ICommand CloseCommand { get; set; }

        #endregion

        #region Constructor
        ///<summary
        ///Default constructor
        ///</summary
        ///
        public WindowViewModel(Window Window)
        {
            mWindow = Window;

            //listen out for the window resizing
            mWindow.StateChanged += (Sender, e) =>
            {
                // Fire off events for all properties that are affected by a resize
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginsizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };

            //Create commands

            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());

        }
        #endregion
    }
}