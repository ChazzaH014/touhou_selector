using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace touhou_selector
{
    public partial class ConfigWindow : Form
    {
        public ConfigWindow()
        {
            
            InitializeComponent();
            t6dirTextBox.Text = Properties.Settings.Default["t6workdir"].ToString();
            t6exeTextBox.Text = Properties.Settings.Default["t6exe"].ToString();
            t7dirTextBox.Text = Properties.Settings.Default["t7workdir"].ToString();
            t7exeTextBox.Text = Properties.Settings.Default["t7exe"].ToString();
            t8dirTextBox.Text = Properties.Settings.Default["t8workdir"].ToString();
            t8exeTextBox.Text = Properties.Settings.Default["t8exe"].ToString();
            t9dirTextBox.Text = Properties.Settings.Default["t9workdir"].ToString();
            t9exeTextBox.Text = Properties.Settings.Default["t9exe"].ToString();
            t95dirTextBox.Text = Properties.Settings.Default["t95workdir"].ToString();
            t95exeTextBox.Text = Properties.Settings.Default["t95exe"].ToString();
            t10dirTextBox.Text = Properties.Settings.Default["t10workdir"].ToString();
            t10exeTextBox.Text = Properties.Settings.Default["t10exe"].ToString();
            t105dirTextBox.Text = Properties.Settings.Default["t105workdir"].ToString();
            t105exeTextBox.Text = Properties.Settings.Default["t105exe"].ToString();
            t11dirTextBox.Text = Properties.Settings.Default["t11workdir"].ToString();
            t11exeTextBox.Text = Properties.Settings.Default["t11exe"].ToString();
            t12dirTextBox.Text = Properties.Settings.Default["t12workdir"].ToString();
            t12exeTextBox.Text = Properties.Settings.Default["t12exe"].ToString();
            t123dirTextBox.Text = Properties.Settings.Default["t123workdir"].ToString();
            t123exeTextBox.Text = Properties.Settings.Default["t123exe"].ToString();
            t125dirTextBox.Text = Properties.Settings.Default["t125workdir"].ToString();
            t125exeTextBox.Text = Properties.Settings.Default["t125exe"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            t6dirTextBox.Text = Properties.Settings.Default["t6workdir"].ToString();
            t6exeTextBox.Text = Properties.Settings.Default["t6exe"].ToString();
        }
        private void ConfigWindow_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t6dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t6workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

       

        private void t6exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t6exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t6exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveConfButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Apply settings incase the user wanted to change things manually.
            Properties.Settings.Default["t6workdir"] = t6dirTextBox.Text;
            Properties.Settings.Default["t6exe"] = t6exeTextBox.Text;
            Properties.Settings.Default["t7workdir"] = t7dirTextBox.Text;
            Properties.Settings.Default["t7exe"] = t7exeTextBox.Text;
            Properties.Settings.Default["t8workdir"] = t8dirTextBox.Text;
            Properties.Settings.Default["t8exe"] = t8exeTextBox.Text;
            Properties.Settings.Default["t9workdir"] = t9dirTextBox.Text;
            Properties.Settings.Default["t9exe"] = t9exeTextBox.Text;
            Properties.Settings.Default["t95workdir"] = t95dirTextBox.Text;
            Properties.Settings.Default["t95exe"] = t95exeTextBox.Text;
            Properties.Settings.Default["t10workdir"] = t10dirTextBox.Text;
            Properties.Settings.Default["t10exe"] = t10exeTextBox.Text;
            Properties.Settings.Default["t105workdir"] = t105dirTextBox.Text;
            Properties.Settings.Default["t105exe"] = t105exeTextBox.Text;
            Properties.Settings.Default["t11workdir"] = t11dirTextBox.Text;
            Properties.Settings.Default["t11exe"] = t11exeTextBox.Text;
            Properties.Settings.Default["t12workdir"] = t12dirTextBox.Text;
            Properties.Settings.Default["t12exe"] = t12exeTextBox.Text;
            Properties.Settings.Default["t123workdir"] = t123dirTextBox.Text;
            Properties.Settings.Default["t123exe"] = t123exeTextBox.Text;
            Properties.Settings.Default["t125workdir"] = t125dirTextBox.Text;
            Properties.Settings.Default["t125exe"] = t125exeTextBox.Text;

            Properties.Settings.Default.Save();
        }


        // Open Dialogs for assigning files and saving settings.
        private void t7dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t7dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t7workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t7exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t7exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t7exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t8dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t8dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t8workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t8exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t8exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t8exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t9dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t9dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t9workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t9exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t9exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t9exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t95dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t95dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t95workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t95exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t95exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t95exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t10dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t10dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t10workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t10exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t10exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t10exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t105dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t105dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t10workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t105exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t105exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t105exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t11dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t11dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t11workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t11exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t11exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t11exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t12dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t12dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t12workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t12exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t12exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t12exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t123dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t123dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t123workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t123exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t123exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t123exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t125dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t125dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t125workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t125exeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                t125exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t125exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
        }
    }
}
