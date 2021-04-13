//Name:Angaran Yogeswaran
//Date:April.12th.2021
//File Name: Lab 5
//Course Name: NETD2202
//Description: This is a file for my Lab 5 assignment.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Lab5 : Form
    {
        //This is the filepath of the active file.
        string filePath = String.Empty;
        public Lab5()
        {
            InitializeComponent();
        }

        #region "Event Handlers"
        /// <summary>
        /// Clears the textbox voids the current filePath and updates the title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileNew(object sender, EventArgs e)
        {
            textBoxEditor.Clear();
            filePath = String.Empty;
            UpdateTitle();

        }
        /// <summary>
        /// This function allows us to open new Open file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileOpen(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openDialog.FileName;
            }
        }
        /// <summary>
        /// This function gives us cut functionalitu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCut(object sender, EventArgs e) 
        {
            Clipboard.SetText(textBoxEditor.Text);
            textBoxEditor.Clear();
        }
        /// <summary>
        /// This function is used for the Paste functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPaste(object sender, EventArgs e) 
        {
            //if the Clipboard contains text get the text.
            if (Clipboard.ContainsText()) 
            {
                textBoxEditor.Text = Clipboard.GetText();
            }
        }
        /// <summary>
        /// This function is used for Copy functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCopy(object sender, EventArgs e) 
        {
            //if clipboard contains text then add the text to the clipboard
            if (Clipboard.ContainsText()) 
            {
                Clipboard.SetText(textBoxEditor.Text);
            }
            
        }
        /// <summary>
        /// This function is used to select all the text in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectAll(object sender, EventArgs e) 
        {
            //IF the clipboard has text then select all
            if (Clipboard.ContainsText()) 
            {
                textBoxEditor.SelectAll();
            }
            
        }

        /// <summary>
        /// Saves the file if the path is known or calls "Save As" if it isn't known
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveClick(object sender, EventArgs e) 
        {

            //If there is not already a filepath...
            if (filePath == String.Empty)
            {
                //Then call the Save as event handler
                FileSaveAs(sender, e);
                //menuFileSaveAs.PerformClick(); This is another way to perform the same action
            }
            //If there is a file path
            else 
            {
                //Then we save it
                SaveTextFile(filePath);
            }
        }

        
        /// <summary>
        /// Open a save dialog and save the file to the location chosen by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSaveAs(object sender, EventArgs e)
        {
            //Create a new save dialog and open Save Dialog
            SaveFileDialog saveDialog = new SaveFileDialog();

            //Filter Save Dialog so that its only text files
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Ignore further processing if the user clicks cancel
            if (saveDialog.ShowDialog() == DialogResult.OK) 
            {
                //Set Filepath to saveDialog.filename
                filePath = saveDialog.FileName;

                //Save Text File with the filepath
                SaveTextFile(filePath);
                //Updates title using UpdateTitle function
                UpdateTitle();
            }
        }


        /// <summary>
        /// Displays about message for this application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("This application was made by Angaran Yogeswaran for NETD2202 in March 2021", "About this Application");
        }
        //Closes the form
        private void ExitForm(object sender, EventArgs e) 
        {
            Close();
        }

        #endregion

        #region "Other Functions"
        /// <summary>
        /// This is the Update Title function which updates the title with the filepath
        /// </summary>
        public void UpdateTitle() 
        {

            this.Text = "Angaran's Text Editor";
            if(filePath != String.Empty) 
            {
                this.Text += " - " + filePath;
            }
        }

        /// <summary>
        /// Save the current contents of the textbox to a text file
        /// </summary>
        /// <param name="path">The path of the file to write to.</param>
        public void SaveTextFile(string path) 
        {
            FileStream myFile = new FileStream(path, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(myFile);

            writer.Write(textBoxEditor.Text);

            writer.Close();
        }

        #endregion
    }
}
