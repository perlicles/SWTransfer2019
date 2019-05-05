using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Studio_Wave_Transfer_2019
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {

        // Tab information
        ObservableCollection<TransferFiles> custdata = new ObservableCollection<TransferFiles>();

        DispatcherTimer dt = new DispatcherTimer();

       

        const string SourceFolderPath = "source folder";
        const string DestinationFolderPath = "destination folder";
        const string SecondSourceFolderPath = "second source";
        const string SecondDestinationFolderPath = "second destination";
        const string OpenAndRunPath = "open and run";

        const string ExtensionPath = "extension";
        const string MainFunctionPath = "main function";
        const string SecondFunctionPath = "second function";

        // The full path to the init file.
        string initFilePath;
        string initFileMainPath;

        // A char used to divide the name from the value in the init file.
        const char SettingDivider = '*';

        public Page2()
        {
            InitializeComponent();

            initFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "initSWT.txt");
            initFileMainPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "initMainSWT.txt");

            

            ReadInitFile();

            //TransferGrid.DataContext = custdata;
        }


        // Use this how a exemple
        private ObservableCollection<TransferFiles> GetData()
        {
            var data = new ObservableCollection<TransferFiles>
            {
                new TransferFiles
                {
                    File = "27-04-2019_Sessao_Plenaria.mp4",
                    TransferDate = "27/04/2019",
                    MainFunction = "Ok",
                    SecundaryFunction = "Ok"
                },
               
            };

            return data;

        }

        public class TransferFiles
        {
            public string File { get; set; }
            public string TransferDate { get; set; }
            public string MainFunction { get; set; }
            public string SecundaryFunction { get; set; }
        }

        private void RunTransferButton_Checked(object sender, RoutedEventArgs e)
        {
            dt.Interval = TimeSpan.FromSeconds(2);
            dt.Tick += dtTicker;
            dt.Start();
        }



        private void RunWatcherFunction()
        {


            // Variables
            string ext = ExtensionTextBox.Text;
            string source = "";
            string destination = "";


            // Loading the variables
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
                                source = part[1];
                                break;

                            case DestinationFolderPath:
                                destination = part[1];
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
                source = "";
                destination = "";
            }


            string extension = "." + ext;

            // Starting the Watcher
            string[] files = Directory.GetFiles(source);
            int checkSameName;

            foreach (string v1 in files)
            {
                checkSameName = 0;
                string fileFullNameI = System.IO.Path.GetFileName(v1);
                int posI = fileFullNameI.LastIndexOf(".");
                string justNameI = posI > 0 ? fileFullNameI.Substring(0, posI) : fileFullNameI;

                foreach (string v in files)
                {
                    string fileFullNameJ = System.IO.Path.GetFileName(v);
                    int posJ = fileFullNameJ.LastIndexOf(".");
                    string justNameJ = posJ > 0 ? fileFullNameJ.Substring(0, posJ) : fileFullNameJ;

                    if (justNameI.Equals(justNameJ))
                    {
                        checkSameName++;
                    }

                }

                if (checkSameName == 1 && (justNameI + extension).Equals(fileFullNameI))
                {
                    try
                    {
                        File.Move(v1, destination + "\\" + fileFullNameI);

                        DateTime today = DateTime.Now;

                        var data = new TransferFiles();
                        data.File = fileFullNameI;
                        data.TransferDate = today.ToString("dd/MM/yyyy") + " " + today.ToString("HH:mm");
                        data.MainFunction = "Ok";

                        
                        custdata.Insert(0, data);
                        
                        TransferGrid.DataContext = custdata;



                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e.Source);
                    }
                }

            }

        }

        private void RunSecondFunction()
        {
            // Variables
            string secondSource = "";
            string secondDestination = "";

            // Loading the variables
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
                            case SecondSourceFolderPath:
                                secondSource = part[1];
                                break;

                            case SecondDestinationFolderPath:
                                secondDestination = part[1];
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
                secondSource = "";
                secondDestination = "";
            }

            // Starting the Watcher
            string[] files = Directory.GetFiles(secondSource);
            int checkSameName;

            foreach (string v1 in files)
            {
                checkSameName = 0;

            }



        }

        private void dtTicker(object sender, EventArgs e)
        {
            RunWatcherFunction();
        }

        private void RunTransferButton_Unchecked(object sender, RoutedEventArgs e)
        {
            dt.Stop();
        }

        private void WriteInitFile()
        {
            using (var sw = new StreamWriter(initFileMainPath))
            {
                sw.WriteLine(ExtensionPath + SettingDivider + ExtensionTextBox.Text);
                sw.WriteLine(MainFunctionPath + SettingDivider + MainFunctionCheckBox.IsChecked.ToString());
                sw.WriteLine(SecondFunctionPath + SettingDivider + SecondFunctionCheckBox.IsChecked.ToString());
            }
        }

        private void ReadInitFile()
        {
            // Check that we have an init file.
            if (File.Exists(initFileMainPath))
            {
                String line = null;
                String[] part;

                using (var sr = new StreamReader(initFileMainPath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Split the line into the part before the colon (the name), and the part after (the value).
                        part = line.Split(SettingDivider);

                        // Switch on the "name" part, and then process the "value" part.
                        switch (part[0])
                        {
                            case ExtensionPath:
                                ExtensionTextBox.Text = part[1];
                                break;

                            case MainFunctionPath:
                                if (part[1] == "True")
                                {
                                    MainFunctionCheckBox.IsChecked = true;
                                }
                                else
                                {
                                    MainFunctionCheckBox.IsChecked = false;
                                }
                                break;

                            case SecondFunctionPath:
                                if (part[1] == "True")
                                {
                                    SecondFunctionCheckBox.IsChecked = true;
                                }
                                else
                                {
                                    SecondFunctionCheckBox.IsChecked = false;
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
                ExtensionTextBox.Text = "";
                MainFunctionCheckBox.IsChecked = true;
                SecondFunctionCheckBox.IsChecked = true;
            }



        }

        private void Page_LostFocus(object sender, RoutedEventArgs e)
        {
            WriteInitFile();
        }

      
    }
}
