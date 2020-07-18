using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text;
using Microsoft.VisualBasic.FileIO;

/*
	Dedicated to Alicia-chan
	Initial release: March 21, 2018
    Updated and improved: July 18, 2020
*/

namespace SPS
{
    public partial class MainForm : Form
    {
        private const int MAX_LENGTH = 45;
        private const int FULL_HEIGHT = 500;
        private const int DEF_HEIGHT = 70;

        private string FOLDERS_FILENAME = "Folders.txt";
        private string FOLDERS_CUTENAME = "Папки.txt";
        private string STR_FILENAME = "Filename: ";
        private string STR_FILE = "File ";
        private string STR_OUT_OF = " out of ";
        private string STR_RESET = "Reset";
        private string STR_EMPTY_FOLDER_LIST = "Please fill out the folder list before launching the program.";
        private string STR_ERROR = "Error!";
        private string STR_EMPTY_FOLDER = "The specified folder is empty!";
        private string STR_INIT_ERROR = "Cannot create one of the folders, check for illegal characters!";
        private string STR_ALL_SORTED = "All files have been sorted!";
        private string STR_DONE = "Done!";

        private FileInfo[] files;
        private string[] folderNames;
        private DirectoryInfo[] folderInfos;
        private int currentFile = -1;
        private bool isInitialized = false;
        private bool cuteMode = false;

        // load folder list from file
        public MainForm()
        {
            InitializeComponent();

            // check the cute mode trigger
            if (File.Exists(FOLDERS_CUTENAME))
            {
                FOLDERS_FILENAME = FOLDERS_CUTENAME;
                cuteMode = true;
                setCuteStrings();
            }

            Encoding Unicode = Encoding.GetEncoding("utf-8");
            bool empty = true;
            if (cuteMode || File.Exists(FOLDERS_FILENAME)) {
                folderNames = File.ReadAllLines(FOLDERS_FILENAME, Unicode);
                empty = folderNames.Length == 0;
            }
            else
            {
                // create the file if it's not there
                File.CreateText(FOLDERS_FILENAME).Close();
            }

            // if the file is empty or doesn't exist
            if (empty)
            {
                MessageBox.Show(STR_EMPTY_FOLDER_LIST, STR_ERROR);
                System.Diagnostics.Process.Start(FOLDERS_FILENAME);
                Environment.Exit(1);
                return;
            }

            // if everything is fine
            listBox.Items.Clear();
            listBox.Items.AddRange(folderNames);
        }

        // interface tweaks on initial form showing
        private void MainForm_Shown(object sender, EventArgs e)
        {
            // hide the main part of the window until everything's initialized
            ActiveForm.Height = DEF_HEIGHT;

            // if the secret cute mode was triggered
            if (cuteMode)
            {
                setCuteStyle();
            }
        }

        // select and open the directory with files
        private void browseBtn_Click(object sender, EventArgs e)
        {
            // reset everything if the sorting is going
            if (isInitialized)
            {
                Application.Restart();
                return;
            }

            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                // check the file count
                files = new DirectoryInfo(FBD.SelectedPath).GetFiles();
                if (files.Length == 0)
                {
                    MessageBox.Show(STR_EMPTY_FOLDER, STR_ERROR);
                    return;
                }
                else
                {
                    folderPathTbox.Text = FBD.SelectedPath;
                    InitiateSorting();
                }
            }
        }
        
        // initialize everything before sorting
        private void InitiateSorting()
        {            
            // create all the necessary folders
            folderInfos = new DirectoryInfo[folderNames.Length];
            for (int i = 0; i<folderNames.Length; i++)
            {
                string folderPath = folderPathTbox.Text + '\\'+folderNames[i];
                try
                {
                    folderInfos[i] = Directory.CreateDirectory(folderPath);
                }
                catch
                {
                    MessageBox.Show(STR_INIT_ERROR, STR_ERROR);
                    Application.Restart();
                    return;
                }
            }

            // switch "Browse" to "Reset"
            browseBtn.Text = STR_RESET;

            // show the rest of the window and load the first file
            ActiveForm.Height = FULL_HEIGHT;
            isInitialized = true;
            loadNextPicture();
        }

        // load and display the next file
        private void loadNextPicture(object sender = null, EventArgs e = null)
        {
            if (!isInitialized) return;


            // if all files have been processed
            if (++currentFile >= files.Length)
            {
                MessageBox.Show(STR_ALL_SORTED, STR_DONE);
                Application.Restart();
                return;
            }

            FileInfo F = files[currentFile];
            string filename = F.Name;
            
            // cut the filename if it's too long
            if (filename.Length > MAX_LENGTH)
            {
                filename = filename.Substring(0, MAX_LENGTH) + "...";
            }
            fileNameLbl.Text = STR_FILENAME + filename;
            fileIndexLbl.Text = STR_FILE + (currentFile + 1) + STR_OUT_OF + files.Length;

            try
            {
                // load the picture from file and display it
                using (var bmpTemp = new Bitmap(F.FullName))
                {
                    pictureBox.Image = new Bitmap(bmpTemp);
                }
            }
            catch
            {
                // display the "preview unavailable" picture
                pictureBox.Image = new Bitmap(Properties.Resources.picture_error);
            }
            listBox.ClearSelected();
            this.ActiveControl = listBox;
        }

        // move the selected file to the selected folder
        private void listBox_Click(object sender = null, EventArgs e = null)
        {       
            if (listBox.SelectedItem == null || !isInitialized) return;
            int i = listBox.SelectedIndex;
            string destination = folderInfos[i].FullName+'\\'+files[currentFile].Name;
            try
            {
                FileSystem.MoveFile(
                    files[currentFile].FullName,
                    destination,
                    UIOption.OnlyErrorDialogs
                );
            }
            catch
            {
                // the dialog was shown by the system, no other actions required
                return;
            }
            loadNextPicture();
        }

        // delete the selected file
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!isInitialized) return;
            try
            {
                // move the file to the recycle bin
                FileSystem.DeleteFile(
                    files[currentFile].FullName,
                    UIOption.OnlyErrorDialogs,
                    RecycleOption.SendToRecycleBin
                );
            }
            catch
            {
                // the dialog was shown by the system, no other actions required
                return;
            }
            loadNextPicture();
        }

        // open the selected file with the associated application
        private void openBtn_Click(object sender, EventArgs e)
        {
            if (!isInitialized) return;
            System.Diagnostics.Process.Start(files[currentFile].FullName);
        }

        // keyboard support: press enter instead of clicking
        private void listBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ENTER_KEY = Convert.ToChar(Keys.Return);
            if (e.KeyChar == ENTER_KEY) listBox_Click();
        }

        // set the text constants to cute mode
        private void setCuteStrings()
        {
            STR_FILENAME = "Имя файла: ";
            STR_FILE = "Файл ";
            STR_OUT_OF = " из ";
            STR_RESET = "Сброс";
            STR_EMPTY_FOLDER_LIST = "Сначала заполни файл со списком папкок ^^";
            STR_ERROR = "Ошибка :c";
            STR_EMPTY_FOLDER = "В заданной папке ничего нет!";
            STR_INIT_ERROR = "Не получилось создать одну из папок, может там есть недопустимые символы?";
            STR_ALL_SORTED = "Всё успешно отсортировано~";
            STR_DONE = "Готово!";
        }

        // set the color and the form text to cute mode
        private void setCuteStyle()
        {
            // change the color scheme
            ActiveForm.BackColor = Color.FromArgb(255, 230, 245);
            browseBtn.BackColor = Color.White;
            openBtn.BackColor = Color.White;
            deleteBtn.BackColor = Color.White;
            skipBtn.BackColor = Color.White;

            // change the form text
            ActiveForm.Text = "Сортировщик картиночек (и всего остального) ^^";
            folderPathTbox.Text = "Путь к папке с файлами...";
            browseBtn.Text = "Выбрать";
            openBtn.Text = "Открыть";
            deleteBtn.Text = "Удалить";
            skipBtn.Text = "Пропустить";
        }
    }
}
