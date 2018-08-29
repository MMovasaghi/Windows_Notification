/*
@    Created By : MH.Movasaghinia
@    Contact : https://github.com/MMovasaghi
@    8.29.2018  
*/
using Notifications.Wpf;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace WDesktopNotification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NotificationManager notificationManager;
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void ifoButton_Click(object sender, RoutedEventArgs e)
        {
            notificationManager = new NotificationManager();
            notificationManager.Show(new NotificationContent
            {
                Title = "Information Notification",
                Message = "Detail of Information",
                Type = NotificationType.Information
                
            });

            //notificationManager.Show("String notification", onClick: () => Console.WriteLine("Click"),
            //   onClose: () => Console.WriteLine("Closed!"));
            
        }
        
        private void errButton_Click(object sender, RoutedEventArgs e)
        {
            notificationManager = new NotificationManager();
            notificationManager.Show(new NotificationContent
            {
                Title = "Error Notification",
                Message = "Detail of Error",
                Type = NotificationType.Error

            });

        }
        private void suButton_Click(object sender, RoutedEventArgs e)
        {
            notificationManager = new NotificationManager();
            notificationManager.Show(new NotificationContent
            {
                Title = "Success Notification",
                Message = "Detail of Success",
                Type = NotificationType.Success

            });
        }
        private void waButton_Click(object sender, RoutedEventArgs e)
        {
            notificationManager = new NotificationManager();
            notificationManager.Show(new NotificationContent
            {
                Title = "Warning Notification",
                Message = "Detail of Warning",
                Type = NotificationType.Warning

            });
        }
    }
}
