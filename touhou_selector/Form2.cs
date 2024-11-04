using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace touhou_selector
{
    public partial class ConfigWindow : Form
    {
        
        private string dosStr = Properties.Settings.Default["dosboxexe"].ToString();
        private string t1conf = Properties.Settings.Default["t1conf"].ToString();
        private string t2conf = Properties.Settings.Default["t2conf"].ToString();
        private string t3conf = Properties.Settings.Default["t3conf"].ToString();
        private string t4conf = Properties.Settings.Default["t4conf"].ToString();
        private string t5conf = Properties.Settings.Default["t5conf"].ToString();
        private string t6exeStr = Properties.Settings.Default["t6exe"].ToString();
        private string t7exeStr = Properties.Settings.Default["t7exe"].ToString();
        private string t8exeStr = Properties.Settings.Default["t8exe"].ToString();
        private string t9exeStr = Properties.Settings.Default["t9exe"].ToString();
        private string t95exeStr = Properties.Settings.Default["t95exe"].ToString();
        private string t10exeStr = Properties.Settings.Default["t10exe"].ToString();
        private string t105exeStr = Properties.Settings.Default["t105exe"].ToString();
        private string t11exeStr = Properties.Settings.Default["t11exe"].ToString();
        private string t12exeStr = Properties.Settings.Default["t12exe"].ToString();
        private string t123exeStr = Properties.Settings.Default["t123exe"].ToString();
        private string t125exeStr = Properties.Settings.Default["t125exe"].ToString();
        private string t13exeStr = Properties.Settings.Default["t13exe"].ToString();
        private string t135exeStr = Properties.Settings.Default["t135exe"].ToString();
        private string t14exeStr = Properties.Settings.Default["t14exe"].ToString();
        private string t143exeStr = Properties.Settings.Default["t143exe"].ToString();
        private string t145exeStr = Properties.Settings.Default["t145exe"].ToString();
        private string t15exeStr = Properties.Settings.Default["t15exe"].ToString();
        private string t155exeStr = Properties.Settings.Default["t155exe"].ToString();
        private string t16exeStr = Properties.Settings.Default["t16exe"].ToString();
        private string t165exeStr = Properties.Settings.Default["t165exe"].ToString();
        private string t17exeStr = Properties.Settings.Default["t17exe"].ToString();
        private string t175exeStr = Properties.Settings.Default["t175exe"].ToString();
        private string t18exeStr = Properties.Settings.Default["t18exe"].ToString();
        private string t185exeStr = Properties.Settings.Default["t185exe"].ToString();
        private string t19exeStr = Properties.Settings.Default["t19exe"].ToString();
        public ConfigWindow()
        {
            
            InitializeComponent();
            UpdatePathDisplay();
            if ((bool)Properties.Settings.Default["keepopen"] == true)
            {
                Debug.WriteLine("Keep Open is On!");
                checkBox1.Checked = true;
            }
            else
            {
                Debug.WriteLine("Keep Open is Off!");
                checkBox1.Checked = false;
            }

        }

        private void UpdatePathDisplay()
        {
            dosStr = Properties.Settings.Default["dosboxexe"].ToString();
            t1conf = Properties.Settings.Default["t1conf"].ToString();
            t2conf = Properties.Settings.Default["t2conf"].ToString();
            t3conf = Properties.Settings.Default["t3conf"].ToString();
            t4conf = Properties.Settings.Default["t4conf"].ToString();
            t5conf = Properties.Settings.Default["t5conf"].ToString();
            t6exeStr = Properties.Settings.Default["t6exe"].ToString();
            t7exeStr = Properties.Settings.Default["t7exe"].ToString();
            t8exeStr = Properties.Settings.Default["t8exe"].ToString();
            t9exeStr = Properties.Settings.Default["t9exe"].ToString();
            t10exeStr = Properties.Settings.Default["t10exe"].ToString();
            t11exeStr = Properties.Settings.Default["t11exe"].ToString();
            t12exeStr = Properties.Settings.Default["t12exe"].ToString();
            t123exeStr = Properties.Settings.Default["t123exe"].ToString();
            t125exeStr = Properties.Settings.Default["t125exe"].ToString();
            t13exeStr = Properties.Settings.Default["t13exe"].ToString();
            t135exeStr = Properties.Settings.Default["t135exe"].ToString();
            t14exeStr = Properties.Settings.Default["t14exe"].ToString();
            t143exeStr = Properties.Settings.Default["t143exe"].ToString();
            t145exeStr = Properties.Settings.Default["t145exe"].ToString();
            t15exeStr = Properties.Settings.Default["t15exe"].ToString();
            t155exeStr = Properties.Settings.Default["t155exe"].ToString();
            t16exeStr = Properties.Settings.Default["t16exe"].ToString();
            t165exeStr = Properties.Settings.Default["t165exe"].ToString();
            t17exeStr = Properties.Settings.Default["t17exe"].ToString();
            t175exeStr = Properties.Settings.Default["t175exe"].ToString();
            t18exeStr = Properties.Settings.Default["t18exe"].ToString();
            t185exeStr = Properties.Settings.Default["t185exe"].ToString();
            t19exeStr = Properties.Settings.Default["t19exe"].ToString();
            if (dosStr.Length > 0) { dosboxexe.ForeColor = Color.Green; } else { dosboxexe.ForeColor = Color.Red; }
            if (t1conf.Length > 0) { t1text.ForeColor = Color.Green; } else { t1text.ForeColor = Color.Red; }
            if (t2conf.Length > 0) { t2text.ForeColor = Color.Green; } else { t2text.ForeColor = Color.Red; }
            if (t3conf.Length > 0) { t3text.ForeColor = Color.Green; } else { t3text.ForeColor = Color.Red; }
            if (t4conf.Length > 0) { t4text.ForeColor = Color.Green; } else { t4text.ForeColor = Color.Red; }
            if (t5conf.Length > 0) { t5text.ForeColor = Color.Green; } else { t5text.ForeColor = Color.Red; }
            if (t6exeStr.Length > 0) { t6exe.ForeColor = Color.Green; } else { t6exe.ForeColor = Color.Red; }
            if (t7exeStr.Length > 0) { t7exe.ForeColor = Color.Green; } else { t7exe.ForeColor = Color.Red; }
            if (t8exeStr.Length > 0) { t8exe.ForeColor = Color.Green; } else { t8exe.ForeColor = Color.Red; }
            if (t9exeStr.Length > 0) { t9exe.ForeColor = Color.Green; } else { t9exe.ForeColor = Color.Red; }
            if (t95exeStr.Length > 0) { t95exe.ForeColor = Color.Green; } else { t95exe.ForeColor = Color.Red; }
            if (t10exeStr.Length > 0) { t10exe.ForeColor = Color.Green; } else { t10exe.ForeColor = Color.Red; }
            if (t105exeStr.Length > 0) { t105exe.ForeColor = Color.Green; } else { t105exe.ForeColor = Color.Red; }
            if (t11exeStr.Length > 0) { t11exe.ForeColor = Color.Green; } else { t11exe.ForeColor = Color.Red; }
            if (t12exeStr.Length > 0) { t12exe.ForeColor = Color.Green; } else { t12exe.ForeColor = Color.Red; }
            if (t123exeStr.Length > 0) { t123exe.ForeColor = Color.Green; } else { t123exe.ForeColor = Color.Red; }
            if (t125exeStr.Length > 0) { t125exe.ForeColor = Color.Green; } else { t125exe.ForeColor = Color.Red; }
            if (t13exeStr.Length > 0) { t13exe.ForeColor = Color.Green; } else { t13exe.ForeColor = Color.Red; }
            if (t135exeStr.Length > 0) { t135exe.ForeColor = Color.Green; } else { t135exe.ForeColor = Color.Red; }
            if (t14exeStr.Length > 0) { t14exe.ForeColor = Color.Green; } else { t14exe.ForeColor = Color.Red; }
            if (t143exeStr.Length > 0) { t143exe.ForeColor = Color.Green; } else { t143exe.ForeColor = Color.Red; }
            if (t145exeStr.Length > 0) { t145exe.ForeColor = Color.Green; } else { t145exe.ForeColor = Color.Red; }
            if (t15exeStr.Length > 0) { t15exe.ForeColor = Color.Green; } else { t15exe.ForeColor = Color.Red; }
            if (t155exeStr.Length > 0) { t155exe.ForeColor = Color.Green; } else { t155exe.ForeColor = Color.Red; }
            if (t16exeStr.Length > 0) { t16exe.ForeColor = Color.Green; } else { t16exe.ForeColor = Color.Red; }
            if (t165exeStr.Length > 0) { t165exe.ForeColor = Color.Green; } else { t165exe.ForeColor = Color.Red; }
            if (t17exeStr.Length > 0) { t17exe.ForeColor = Color.Green; } else { t17exe.ForeColor = Color.Red; }
            if (t175exeStr.Length > 0) { t175exe.ForeColor = Color.Green; } else { t175exe.ForeColor = Color.Red; }
            if (t18exeStr.Length > 0) { t18exe.ForeColor = Color.Green; } else { t18exe.ForeColor = Color.Red; }
            if (t185exeStr.Length > 0) { t185exe.ForeColor = Color.Green; } else { t185exe.ForeColor = Color.Red; }
            if (t19exeStr.Length > 0) { t19exe.ForeColor = Color.Green; } else { t19exe.ForeColor = Color.Red; }
            



        }
        
       
    
    
    
    

        private void label1_Click(object sender, EventArgs e)
        {
            //t6dirTextBox.Text = Properties.Settings.Default["t6workdir"].ToString();
           
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
                Properties.Settings.Default["t6exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveConfButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Apply settings incase the user wanted to change things manually.
            
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
                
                Properties.Settings.Default["t7exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
                
                Properties.Settings.Default["t8exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
                
                Properties.Settings.Default["t9exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
                
                Properties.Settings.Default["t95exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
                
                Properties.Settings.Default["t10exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
                
                Properties.Settings.Default["t105exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
               
                Properties.Settings.Default["t11exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
                
                Properties.Settings.Default["t12exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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

                
                Properties.Settings.Default["t123exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
                
                
                Properties.Settings.Default["t125exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }

        private void t13exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t13exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t135exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t135exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t14exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t14exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t143exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t143exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t17exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t17exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t145exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t145exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t15exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t15exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t155exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t155exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t16exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t16exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t165exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t165exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
   
        private void t175exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t175exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t18exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t18exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t185exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t185exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
            }
        }
        private void t19exeButton_Click(object sender, EventArgs e)
        {
            EXEBrowse.Title = "Touhou Executable";
            EXEBrowse.Filter = "Exe Files (.exe)|*.exe";
            DialogResult result = EXEBrowse.ShowDialog();
            if (result == DialogResult.OK)
            {

                
                Properties.Settings.Default["t19exe"] = EXEBrowse.FileName;
                Properties.Settings.Default.Save();
                UpdatePathDisplay();
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
                    
                    Properties.Settings.Default["t5conf"] = EXEBrowse.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void t6exe_MouseHover(object sender, EventArgs e)
        {
            Debug.Write("HOVER");
            toolTip1.Show(Properties.Settings.Default["t6exe"].ToString(), t6exe);
        }

        private void t7exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t7exe"].ToString(), t7exe);
        }

        private void t8exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t8exe"].ToString(), t8exe);
        }

        private void t9exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t9exe"].ToString(), t9exe);
        }

        private void t95exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t95exe"].ToString(), t95exe);
        }

        private void t10exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t10exe"].ToString(), t10exe);
        }

        private void t105exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t105exe"].ToString(), t105exe);
        }

        private void t11exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t11exe"].ToString(), t11exe);
        }

        private void t12exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t12exe"].ToString(), t12exe);
        }

        private void t123exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t123exe"].ToString(), t123exe);
        }

        private void t125exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t125exe"].ToString(), t125exe);
        }

        private void t13exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t13exe"].ToString(), t13exe);
        }

        private void t135exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t135exe"].ToString(), t135exe);
        }

        private void t14exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t14exe"].ToString(), t14exe);
        }

        private void t143exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t143exe"].ToString(), t143exe);
        }

        private void t145exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t145exe"].ToString(), t145exe);
        }

        private void t15exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t15exe"].ToString(), t15exe);
        }

        private void t155exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t15exe"].ToString(), t155exe);
        }

        private void t16exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t16exe"].ToString(), t16exe);
        }

        private void t165exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t165exe"].ToString(), t165exe);
        }

        private void t17exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t17exe"].ToString(), t17exe);
        }

        private void t175exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t175exe"].ToString(), t175exe);
        }

        private void t18exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t18exe"].ToString(), t18exe);
        }

        private void t185exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t185exe"].ToString(), t185exe);
        }

        private void t19exe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t19exe"].ToString(), t19exe);
        }

        private void t1text_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t1conf"].ToString(), t1text);
        }

        private void t2text_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t2conf"].ToString(), t2text);
        }

        private void t3text_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t3conf"].ToString(), t3text);
        }

        private void t4text_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t4conf"].ToString(), t4text);
        }

        private void t5text_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["t5conf"].ToString(), t5text);
        }

        private void dosboxexe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(Properties.Settings.Default["dosboxexe"].ToString(), dosboxexe);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

           
                Properties.Settings.Default["keepopen"] = checkBox1.Checked;
                
                
            
        }
    }
}
