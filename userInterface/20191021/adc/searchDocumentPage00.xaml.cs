﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace adc
{
    /// <summary>
    /// searchDocumentPage00.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class searchDocumentPage00 : Page
    {
        public searchDocumentPage00()
        {
            InitializeComponent();
        }

        private void BtnNextStep(object sender, RoutedEventArgs e)
        {
        }

        private void BtnPreStep(object sender, RoutedEventArgs e)
        {
            searchDocumentPage page = new searchDocumentPage();
            NavigationService.Navigate(page);
        }


    }
}
