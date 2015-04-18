using System;
using System.Windows;
using System.Windows.Forms; 

namespace ComicReader
{
    /// <summary>
    /// Interaction logic for DirectorySelect.xaml
    /// </summary>
    public partial class DirectorySelect : Window
    {
        public DirectorySelect()
        {
            InitializeComponent();
        }

        private void ButtonOpenFolderDialog_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TextBoxFolderPath.Text = dialog.SelectedPath;

                Properties.Settings.Default["root_dir"] = dialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
    }
}
