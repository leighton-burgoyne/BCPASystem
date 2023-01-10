using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.SfSkinManager;

namespace BCPASystem
{
    /// <summary>
    /// Interaction logic for NewShow.xaml
    /// </summary>
    public partial class NewShow : Page
    {
        #region Fields
        private string currentVisualStyle;
		private string currentSizeMode;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the current visual style.
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string CurrentVisualStyle
        {
            get
            {
                return currentVisualStyle;
            }
            set
            {
                currentVisualStyle = value;
                OnVisualStyleChanged();
            }
        }
		
		/// <summary>
        /// Gets or sets the current Size mode.
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string CurrentSizeMode
        {
            get
            {
                return currentSizeMode;
            }
            set
            {
                currentSizeMode = value;
                OnSizeModeChanged();
            }
        }
        #endregion
        public NewShow()
        {
            InitializeComponent();
			this.Loaded += OnLoaded;
        }
		/// <summary>
        /// Called when [loaded].
        /// </summary>
        /// <param Name="sender">The sender.</param>
        /// <param Name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            CurrentVisualStyle = "Windows11Light";
	        CurrentSizeMode = "Default";
        }
		/// <summary>
        /// On Visual Style Changed.
        /// </summary>
        /// <remarks></remarks>
        private void OnVisualStyleChanged()
        {
            VisualStyles visualStyle = VisualStyles.Default;
            Enum.TryParse(CurrentVisualStyle, out visualStyle);            
            if (visualStyle != VisualStyles.Default)
            {
                SfSkinManager.ApplyStylesOnApplication = true;
                SfSkinManager.SetVisualStyle(this, visualStyle);
                SfSkinManager.ApplyStylesOnApplication = false;
            }
        }
		
		/// <summary>
        /// On Size Mode Changed event.
        /// </summary>
        /// <remarks></remarks>
        private void OnSizeModeChanged()
        {
            SizeMode sizeMode = SizeMode.Default;
            Enum.TryParse(CurrentSizeMode, out sizeMode);
            if (sizeMode != SizeMode.Default)
            {
                SfSkinManager.ApplyStylesOnApplication = true;
                SfSkinManager.SetSizeMode(this, sizeMode);
                SfSkinManager.ApplyStylesOnApplication = false;
            }
        }
        public void OnCreateShowButtonClick(object sender, RoutedEventArgs e)
        {
            ShowInfo.Shows.Add(new Show()
            {
                Name = ShowNameField.Text,
                Description = InfoField.Text,
                ShowDate = StartDateField.Value.ToString(),
                ShowTime = StartTimeField.Value.ToString(),
                Venue = VenueField.Text,
                Organiser = OrganiserField.Text,
                Promotion = PromotionField.Text,
                Duration = int.Parse(DurationField.Text),
                Capacity = int.Parse(CapacityField.Text),
            });
            SelectShow page = new SelectShow();
            NavigationService.Navigate(page);
        }
    }
}
