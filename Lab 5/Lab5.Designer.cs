﻿
namespace Lab_5
{
    partial class Lab5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab5));
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.AcceptsTab = true;
            this.textBoxEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEditor.Location = new System.Drawing.Point(0, 24);
            this.textBoxEditor.Multiline = true;
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEditor.Size = new System.Drawing.Size(800, 426);
            this.textBoxEditor.TabIndex = 0;
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(800, 24);
            this.menuTop.TabIndex = 1;
            this.menuTop.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.MenuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Options related to file management";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(146, 22);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Create a new file";
            this.menuFileNew.Click += new System.EventHandler(this.FileNew);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(146, 22);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Click to open a file";
            this.menuFileOpen.Click += new System.EventHandler(this.FileOpen);

            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(146, 22);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Click to save the current document ";
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(146, 22);
            this.menuFileSaveAs.Text = "Save &As...";
            this.menuFileSaveAs.ToolTipText = "Click to select a file location to save the file to.\r\n";
            this.menuFileSaveAs.Click += new System.EventHandler(this.FileSaveAs);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(146, 22);
            this.MenuFileExit.Text = "E&xit";
            this.MenuFileExit.ToolTipText = "Click to exit the application";
            this.MenuFileExit.Click += new System.EventHandler(this.ExitForm);

            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.toolStripSeparator4,
            this.menuEditSelectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(144, 22);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Click to remove the current selection and keep it in the clipboard\r\n";
            this.menuEditCut.Click += new System.EventHandler(this.EditCut);

            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(144, 22);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Click to copy the current selection";
            this.menuEditCopy.Click += new System.EventHandler(this.EditCopy);

            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(144, 22);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Click to insert the current contents of the clipboard\r\n";
            this.menuEditPaste.Click += new System.EventHandler(this.EditPaste);

            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.Size = new System.Drawing.Size(144, 22);
            this.menuEditSelectAll.Text = "Select &All";
            this.menuEditSelectAll.ToolTipText = "Click to select all text";
            this.menuEditSelectAll.Click += new System.EventHandler(this.SelectAll);


            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.menuHelpAbout.Text = "&About...";
            this.menuHelpAbout.ToolTipText = "Click to learn about this application";
            this.menuHelpAbout.Click += new System.EventHandler(this.AboutClick);
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEditor);
            this.Controls.Add(this.menuTop);
            this.MainMenuStrip = this.menuTop;
            this.Name = "Lab5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angaran\'s Text Editor";
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditor;
        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

