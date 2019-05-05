using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Studio_Wave_Transfer_2019
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        // Init file name strings, used to preserve UI values between sessions.
        const string SourceFolderPath = "source folder";
        const string DestinationFolderPath = "destination folder";
        const string SecondSourceFolderPath = "second source";
        const string SecondDestinationFolderPath = "second destination";
        const string OpenAndRunPath = "open and run";

        // The full path to the init file.
        string initFilePath;

        // A char used to divide the name from the value in the init file.
        const char SettingDivider = '*';

        public Page3()
        {
            InitializeComponent();

            // Store the init file in the same folder as the application.
            initFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "initSWT.txt");

            ReadInitFile();

        }


        private string FolderExplorer()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            else
            {
                return "";
            }
        }

        private void WriteInitFile()
        {
            using (var sw = new StreamWriter(initFilePath))
            {
                sw.WriteLine(SourceFolderPath + SettingDivider + SourceFolderTextBox.Text);
                sw.WriteLine(DestinationFolderPath + SettingDivider + DestinationFolderTextBox.Text);
                sw.WriteLine(SecondSourceFolderPath + SettingDivider + SecondSourceFolderTextBox.Text);
                sw.WriteLine(SecondDestinationFolderPath + SettingDivider + SecondDestinationFolderTextBox.Text);
                sw.WriteLine(OpenAndRunPath + SettingDivider + OpenAndRunCheckBox.IsChecked.ToString());
            }
        }

        private void ReadInitFile()
        {
            // Check that we have an init file.
            if (File.Exists(initFilePath))
            {
                String line = null;
                String[] part;

                using (var sr = new StreamReader(initFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Split the line into the part before the colon (the name), and the part after (the value).
                        part = line.Split(SettingDivider);

                        // Switch on the "name" part, and then process the "value" part.
                        switch (part[0])
                        {
                            case SourceFolderPath:
                                SourceFolderTextBox.Text = part[1];
                                break;

                            case DestinationFolderPath:
                                DestinationFolderTextBox.Text = part[1];
                                break;

                            case SecondSourceFolderPath:
                                SecondSourceFolderTextBox.Text = part[1];
                                break;

                            case SecondDestinationFolderPath:
                                SecondDestinationFolderTextBox.Text = part[1];
                                break;

                            case OpenAndRunPath:
                                if (part[1] == "True")
                                {
                                    OpenAndRunCheckBox.IsChecked = true;
                                }
                                break;

                            default:
                                throw new Exception("Unknown init file entry: " + line);
                        }
                    }
                }
            }
            else
            {
                // No init file exists yet, so set defaults.
                SourceFolderTextBox.Text = "";
                DestinationFolderTextBox.Text = "";
                SecondSourceFolderTextBox.Text = "";
                SecondDestinationFolderTextBox.Text = "";
            }
        }

        

        private void Page_LostFocus(object sender, RoutedEventArgs e)
        {
            WriteInitFile();
        }

        private void SourceFolderButton_Click(object sender, RoutedEventArgs e)
        {
            SourceFolderTextBox.Text = FolderExplorer();
        }

        private void DestinationFolderButton_Click(object sender, RoutedEventArgs e)
        {
            DestinationFolderTextBox.Text = FolderExplorer();
        }

        private void SecondSourceFolderButton_Click(object sender, RoutedEventArgs e)
        {
            SecondSourceFolderTextBox.Text = FolderExplorer();
        }

        private void SecondDestinationFolderButton_Click(object sender, RoutedEventArgs e)
        {
            SecondDestinationFolderTextBox.Text = FolderExplorer();
        }

        private void SavePresetButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.FileName = "Preset";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            List<String> saveLines = new List<String>();

            saveLines.Add(SourceFolderTextBox.Text);
            saveLines.Add(DestinationFolderTextBox.Text);
            saveLines.Add(SecondSourceFolderTextBox.Text);
            saveLines.Add(SecondDestinationFolderTextBox.Text);
            saveLines.Add(OpenAndRunCheckBox.IsChecked.ToString());


            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllLines(saveFileDialog.FileName, saveLines);
            }
        }

        private void LoadPresetButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Preset";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();
            String line = null;
            List<string> lines = new List<string>();

            if (result == true)
            {
                using (var sw = new StreamReader(dlg.FileName))
                {
                    while ((line = sw.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }

                    if (lines.Count == 5)
                    {
                        SourceFolderTextBox.Text = lines[0];
                        DestinationFolderTextBox.Text = lines[1];
                        SecondSourceFolderTextBox.Text = lines[2];
                        SecondDestinationFolderTextBox.Text = lines[3];
                        if (lines[4] == "True")
                        {
                            OpenAndRunCheckBox.IsChecked = true;
                        }
                        else
                        {
                            OpenAndRunCheckBox.IsChecked = false;
                        }
                    }

                }
            }
            else
            {
                SourceFolderTextBox.Text = "Arquivo não lido";
            }

        }
    }
}
