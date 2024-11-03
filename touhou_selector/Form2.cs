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
            dosdirTextBox.Text = Properties.Settings.Default["dosboxexe"].ToString();
            t1confTextBox.Text = Properties.Settings.Default["t1conf"].ToString();
            t2confTextBox.Text = Properties.Settings.Default["t2conf"].ToString();
            t3confTextBox.Text = Properties.Settings.Default["t3conf"].ToString();
            t4confTextBox.Text = Properties.Settings.Default["t4conf"].ToString();
            t5confTextBox.Text = Properties.Settings.Default["t5conf"].ToString();
            t6exeTextBox.Text = Properties.Settings.Default["t6exe"].ToString();
            t7exeTextBox.Text = Properties.Settings.Default["t7exe"].ToString();
            t8exeTextBox.Text = Properties.Settings.Default["t8exe"].ToString();
            t9exeTextBox.Text = Properties.Settings.Default["t9exe"].ToString();
            t95exeTextBox.Text = Properties.Settings.Default["t95exe"].ToString(); 
            t10exeTextBox.Text = Properties.Settings.Default["t10exe"].ToString();
            t105exeTextBox.Text = Properties.Settings.Default["t105exe"].ToString();
            t11exeTextBox.Text = Properties.Settings.Default["t11exe"].ToString();
            t12exeTextBox.Text = Properties.Settings.Default["t12exe"].ToString();
            t123exeTextBox.Text = Properties.Settings.Default["t123exe"].ToString();
            t125exeTextBox.Text = Properties.Settings.Default["t125exe"].ToString();
            t13exeTextBox.Text = Properties.Settings.Default["t13exe"].ToString();
            t135exeTextBox.Text = Properties.Settings.Default["t135exe"].ToString();
            t14exeTextBox.Text = Properties.Settings.Default["t14exe"].ToString();
            t143exeTextBox.Text = Properties.Settings.Default["t143exe"].ToString();
            t145exeTextBox.Text = Properties.Settings.Default["t145exe"].ToString();
            t15exeTextBox.Text = Properties.Settings.Default["t15exe"].ToString();
            t155exeTextBox.Text = Properties.Settings.Default["t155exe"].ToString();
            t16exeTextBox.Text = Properties.Settings.Default["t16exe"].ToString();
            t165exeTextBox.Text = Properties.Settings.Default["t165exe"].ToString();
            t17exeTextBox.Text = Properties.Settings.Default["t17exe"].ToString();
            t175exeTextBox.Text = Properties.Settings.Default["t175exe"].ToString();
            t18exeTextBox.Text = Properties.Settings.Default["t18exe"].ToString();
            t185exeTextBox.Text = Properties.Settings.Default["t185exe"].ToString();
            t19exeTextBox.Text = Properties.Settings.Default["t19exe"].ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //t6dirTextBox.Text = Properties.Settings.Default["t6workdir"].ToString();
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
               // t6dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t6workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

       

        private void t6exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
            Properties.Settings.Default["dosboxexe"] = dosdirTextBox.Text;
            Properties.Settings.Default["t1conf"] = t1confTextBox.Text;
            Properties.Settings.Default["t2conf"] = t2confTextBox.Text;
            Properties.Settings.Default["t3conf"] = t3confTextBox.Text;
            Properties.Settings.Default["t4conf"] = t4confTextBox.Text;
            Properties.Settings.Default["t5conf"] = t5confTextBox.Text;
            Properties.Settings.Default["t6exe"] = t6exeTextBox.Text;
            Properties.Settings.Default["t7exe"] = t7exeTextBox.Text;
            Properties.Settings.Default["t8exe"] = t8exeTextBox.Text;
            Properties.Settings.Default["t9exe"] = t9exeTextBox.Text;
            Properties.Settings.Default["t95exe"] = t95exeTextBox.Text;
            Properties.Settings.Default["t10exe"] = t10exeTextBox.Text;
            Properties.Settings.Default["t105exe"] = t105exeTextBox.Text;
            Properties.Settings.Default["t11exe"] = t11exeTextBox.Text;
            Properties.Settings.Default["t12exe"] = t12exeTextBox.Text;
            Properties.Settings.Default["t123exe"] = t123exeTextBox.Text;
            Properties.Settings.Default["t125exe"] = t125exeTextBox.Text;
            Properties.Settings.Default["t13exe"] = t13exeTextBox.Text;
            Properties.Settings.Default["t135exe"] = t135exeTextBox.Text;
            Properties.Settings.Default["t14exe"] = t14exeTextBox.Text;
            Properties.Settings.Default["t143exe"] = t143exeTextBox.Text;
            Properties.Settings.Default["t145exe"] = t145exeTextBox.Text;
            Properties.Settings.Default["t15exe"] = t15exeTextBox.Text;
            Properties.Settings.Default["t155exe"] = t155exeTextBox.Text;
            Properties.Settings.Default["t16exe"] = t16exeTextBox.Text;
            Properties.Settings.Default["t165exe"] = t165exeTextBox.Text;
            Properties.Settings.Default["t17exe"] = t17exeTextBox.Text;
            Properties.Settings.Default["t175exe"] = t175exeTextBox.Text;
            Properties.Settings.Default["t18exe"] = t18exeTextBox.Text;
            Properties.Settings.Default["t185exe"] = t185exeTextBox.Text;
            Properties.Settings.Default["t19exe"] = t19exeTextBox.Text;
            Properties.Settings.Default.Save();
        }


        // Open Dialogs for assigning files and saving settings.
        private void t7dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DirBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
               // t7dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t7workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t7exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
               // t8dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t8workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t8exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
               // t9dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t9workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t9exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
              //  t95dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t95workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t95exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
               // t10dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t10workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t10exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
              //  t105dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t10workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t105exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
              //  t11dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t11workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t11exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
              //  t12dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t12workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t12exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
               // t123dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t123workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t123exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
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
               // t125dirTextBox.Text = DirBrowse.SelectedPath;
                Properties.Settings.Default["t125workdir"] = DirBrowse.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void t125exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                t125exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t125exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void t13exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t13exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t13exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t135exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t135exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t135exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t14exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t14exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t14exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t143exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t143exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t143exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t17exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t17exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t17exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t145exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t145exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t145exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t15exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t15exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t15exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t155exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t155exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t155exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t16exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t16exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t16exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t165exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t165exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t165exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
   
        private void t175exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t175exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t175exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t18exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t18exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t18exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t185exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t185exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t185exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void t19exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                t19exeTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["t19exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dosboxexeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "DOSBox-X Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                dosdirTextBox.Text = EXEBrowse.FileName;
                Properties.Settings.Default["dosboxexe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void t1confButton_Click(object sender, EventArgs e)
        {
            {
                EXEBrowse.Title = "Touhou 1 DOSBox-X conf File";
                EXEBrowse.Filter = "DOSBox-X Config Files|*.conf";
                DialogResult result = EXEBrowse.ShowDialog();
                if (result == DialogResult.OK)
                {
                    t1confTextBox.Text = EXEBrowse.FileName;
                    Properties.Settings.Default["t1conf"] = EXEBrowse.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }
        private void t2confButton_Click(object sender, EventArgs e)
        {
            {
                EXEBrowse.Title = "Touhou 2 DOSBox-X conf File";
                EXEBrowse.Filter = "DOSBox-X Config Files|*.conf";
                DialogResult result = EXEBrowse.ShowDialog();
                if (result == DialogResult.OK)
                {
                    t2confTextBox.Text = EXEBrowse.FileName;
                    Properties.Settings.Default["t2conf"] = EXEBrowse.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }
        private void t3confButton_Click(object sender, EventArgs e)
        {
            {
                EXEBrowse.Title = "Touhou 3 DOSBox-X conf File";
                EXEBrowse.Filter = "DOSBox-X Config Files|*.conf";
                DialogResult result = EXEBrowse.ShowDialog();
                if (result == DialogResult.OK)
                {
                    t3confTextBox.Text = EXEBrowse.FileName;
                    Properties.Settings.Default["t3conf"] = EXEBrowse.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }
        private void t4confButton_Click(object sender, EventArgs e)
        {
            {
                EXEBrowse.Title = "Touhou 4 DOSBox-X conf File";
                EXEBrowse.Filter = "DOSBox-X Config Files|*.conf";
                DialogResult result = EXEBrowse.ShowDialog();
                if (result == DialogResult.OK)
                {
                    t4confTextBox.Text = EXEBrowse.FileName;
                    Properties.Settings.Default["t4conf"] = EXEBrowse.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }
        private void t5confButton_Click(object sender, EventArgs e)
        {
            {
                EXEBrowse.Title = "Touhou 5 DOSBox-X conf File";
                EXEBrowse.Filter = "DOSBox-X Config Files|*.conf";
                DialogResult result = EXEBrowse.ShowDialog();
                if (result == DialogResult.OK)
                {
                    t5confTextBox.Text = EXEBrowse.FileName;
                    Properties.Settings.Default["t5conf"] = EXEBrowse.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }

       
    }
}
