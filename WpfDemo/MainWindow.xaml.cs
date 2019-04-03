using System;
using System.Windows;
using System.Windows.Controls;
using LS = Logger.LoggingService;


namespace WpfDemo
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LS ls = null;
        public MainWindow()
        {
            InitializeComponent();
            ls = new LS();
            ls.init();

        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
           
            //var contr = sender as Control;
            var btn = sender as Button;
            //elvis operator zum nachschauen von properties
            //zB: var color = btn?.Background;
            //if(sender.getType()==tyeof(Button)
            if (btn != null)
            {
                try
                {
                    var tag = (string)btn.Tag;
                    switch (tag)
                    {
                        case "Log":
                            //var c = (string)btn.Content;          
                            
                            lv.Items.Add(ls.LogLine("test"));
                            break;
                        case "Delete_Log":
                            break;
                        default:
                            break;
                    }
                }
                catch (InvalidCastException exp)
                {
                    //ls.LogIt($"Fehlerhafter Typ\n{exp.Message}");
                    //todo
                }
            }
        }

    

        private void Delete_At_Pos_Click(object sender, RoutedEventArgs e)
        {
            ls.Delete_Log_At_Line(1);
            lv.Items.RemoveAt(1);
        }

        private void Push_Click(object sender, RoutedEventArgs e)
        {
            ls.Push();
            lv.Items.Clear();
        }

        private void Delete_Temp_Log_Click(object sender, RoutedEventArgs e)
        {
            ls.ClearLog();
            lv.Items.Clear();
        }

        private void Delete_Log_File_Click(object sender, RoutedEventArgs e)
        {
            //todo
            ls.Delete_LogFile();
            lv.Items.Clear();
        }
    }
}
