using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text;

/*
	I dedicate this program to Alicia-chan, nya~
	March 21, 2018
*/

namespace SPS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Encoding Unicode = Encoding.GetEncoding("utf-8");
            FolderNames = File.ReadAllLines("Folders.txt", Unicode);
            if (FolderNames.Length == 0)
            {
                MessageBox.Show("Please fill out the Folders.txt file before launching the program.", "Error!");
                Environment.Exit(1);
                return;
            }
            listBox.Items.Clear();
            listBox.Items.AddRange(FolderNames);
        }

        private void BrowseBT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                folderPathTB.Text = FBD.SelectedPath;
                InitiateSorting();
            }
        }

        const int FULL_HEIGHT = 480;
        const int SMALL_HEIGHT = 80;
        FileInfo[] Files;
        int currentFile, filesTotal;
        string[] FolderNames;
        DirectoryInfo[] Folders;
        const string DEFAULT_TEXT = "Path to the folder with pictures...";

        private void InitiateSorting()
        {
            String path = folderPathTB.Text;
            DirectoryInfo DI = new DirectoryInfo(path);
            Files = DI.GetFiles();
            if (Files.Length == 0)
            {
                MessageBox.Show("The specified folder is empty!", "Error!");
                folderPathTB.Text = DEFAULT_TEXT;
                return;
            }
            currentFile = -1;
            filesTotal = Files.Length;            

            //folders creation
            Folders = new DirectoryInfo[FolderNames.Length];
            for (int i = 0; i<FolderNames.Length; i++)
            {
                string folderPath = path+'\\'+FolderNames[i];
                Folders[i] = Directory.CreateDirectory(folderPath);
            }

            MainForm.ActiveForm.Height = FULL_HEIGHT;
            nextPicture();
        }

        private void nextPicture()
        {
            const int MAX_LENGTH = 45;
            currentFile++;
            if (currentFile >= filesTotal)
            {
                MessageBox.Show("All pictures have been sorted!","Done!");
                Application.Exit();
                return;
            }
            picture.BackColor = Color.FromName("Window");
            FileInfo F = Files[currentFile];
            string filename = (F.Name.Length <= MAX_LENGTH) ? F.Name : F.Name.Substring(0, MAX_LENGTH) + "...";
            fileNameL.Text = "Filename: "+filename;
            fileIndexL.Text = "File " + (currentFile + 1) + " out of " + filesTotal;
            try
            {
                using (var bmpTemp = new Bitmap(F.FullName))
                {
                    picture.Image = new Bitmap(bmpTemp);
                }
            }
            catch (Exception e) //we don't care about the type of an exception
            {
                picture.BackColor = Color.FromArgb(255, 200, 200, 200);
                picture.Image = new Bitmap(Properties.Resources.picture_error);
            }
        }

        private void listBox_Click(object sender, EventArgs e)
        {       
            if (listBox.SelectedItem == null) return;
            int i = listBox.SelectedIndex;
            string path = Folders[i].FullName+'\\'+Files[currentFile].Name;
            Files[currentFile].MoveTo(path);
            listBox.ClearSelected();
            nextPicture();
        }
    }
}
