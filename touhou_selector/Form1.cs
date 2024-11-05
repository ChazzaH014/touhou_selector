using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

// A Touhou game selection program aimed at arcade machine applications. Arcade machines for private use of course, because i dont actually know the rules behind that.
// I'm not exactly experienced with C# so the coding methods may be a bit dirty.
// Any images used in the launcher does not belong to me.
//
//
// - Charlie Howlett 2024 :D

namespace touhou_selector {
	public partial class Form1 : Form {

        // I was lazy and couldn't be bothered to figure out how to stop the error sound when launching games. Maybe some formatting error. This is just a dirty fix that works.
        private bool fixErrorSoundBug = false;
        private bool keepOpen = (bool) Properties.Settings.Default["keepopen"];

        // Declaring variables.
        private int menuLoc = 1;
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
            // Setting the title so its not blank on launch.
            gameTitle.Text = ("Touhou 1: Highly Responsive to Prayers");
		}

        public void UpdateSetting()
        {
            keepOpen = (bool)Properties.Settings.Default["keepopen"];
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // These are to stop the selector going out of bounds.
            if (menuLoc <= 1)
            {
                menuLoc = 1;
            }
            if (menuLoc >= 30)
            {
                menuLoc = 30;
            }

            // These are the controls for navigating the menu by decrementing or incrementing the menuLoc variable.
            if (e.KeyCode == Keys.Down)
			{
				menuLoc += 1;
                
            }
            if (e.KeyCode == Keys.Up)
            {
                menuLoc -= 1;
				
            }
            if (e.Alt) 
            {
                if (e.KeyCode == Keys.C)
                {
                    ConfigWindow conf = new ConfigWindow();
                    conf.Visible = true;
                }
            }

            // Exit control
            if (e.KeyCode == Keys.X)
            {
                Application.Exit();  
            }
			
            // This runs a check on the menuLoc variable to see what image needs to be applied.
            if (menuLoc == 1)
            {
                
                pictureBox1.Image = Properties.Resources.TH01;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 1: Highly Responsive to Prayers");
            }
            if (menuLoc == 2)
            {
                
                pictureBox1.Image = Properties.Resources.TH02;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 2: Story of Eastern Wonderland");
            }
            if (menuLoc == 3)
            {
                
               pictureBox1.Image = Properties.Resources.TH03;
               pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 3: Phantasmagoria of Dim.Dream");
            }
            if (menuLoc == 4)
            {
                
               pictureBox1.Image = Properties.Resources.TH04;
               pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 4: Lotus Land Story");
               
            }
            if (menuLoc == 5)
            {
                
               pictureBox1.Image = Properties.Resources.TH05;
               pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 5: Mystic Square");

            }
            if (menuLoc == 6)
            {
                
                pictureBox1.Image = Properties.Resources.TH06;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 6: Embodiment of Scarlet Devil");
                
            }
            if (menuLoc == 7)
            {
                
               pictureBox1.Image = Properties.Resources.TH07;
               pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 7: Perfect Cherry Blossom");
                
            }
            if (menuLoc == 8)
            {

                pictureBox1.Image = Properties.Resources.TH08;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 8: Imperishable Night");

            }
            if (menuLoc == 9)
            {

                pictureBox1.Image = Properties.Resources.TH09;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 9: Phantasmagoria of Flower View");

            }
            if (menuLoc == 10)
            {

                pictureBox1.Image = Properties.Resources.TH09f;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 9.5: Shoot the Bullet");

            }
            if (menuLoc == 11)
            {

                pictureBox1.Image = Properties.Resources.TH10;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 10: Mountain of Faith");

            }
            if (menuLoc == 12)
            {

                pictureBox1.Image = Properties.Resources.TH10f;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 10.5: Scarlet Weather Rhapsody");

            }
            if (menuLoc == 13)
            {

                pictureBox1.Image = Properties.Resources.TH11;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 11: Subterranean Animism");

            }
            if (menuLoc == 14)
            {

                pictureBox1.Image = Properties.Resources.TH12;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 12: Undefined Fantastic Object");

            }
            if (menuLoc == 15)
            {

                pictureBox1.Image = Properties.Resources.TH12t;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 12.3: Touhou Hisoutensoku");

            }
            if (menuLoc == 16)
            {

                pictureBox1.Image = Properties.Resources.TH12f;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 12.5: Double Spoiler");

            }
            if (menuLoc == 17)
            {

                pictureBox1.Image = Properties.Resources.TH13;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 13: Ten Desires");

            }
            if (menuLoc == 18)
            {

                pictureBox1.Image = Properties.Resources.TH135;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 13.5: Hopeless Masquerade");

            }
            if (menuLoc == 19)
            {

                pictureBox1.Image = Properties.Resources.TH14;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 14: Double Dealing Character");

            }
            if (menuLoc == 20)
            {

                pictureBox1.Image = Properties.Resources.TH143;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 14.3: Impossible Spell Card");

            }
            if (menuLoc == 21)
            {

                pictureBox1.Image = Properties.Resources.TH145;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 14.5: Urban Legend in Limbo");

            }
            if (menuLoc == 22)
            {

                pictureBox1.Image = Properties.Resources.TH15;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 15: Legacy of Lunatic Kingdom");

            }
            if (menuLoc == 23)
            {

                pictureBox1.Image = Properties.Resources.TH155;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 15.5: Antinomy of Common Flowers");

            }
            if (menuLoc == 24)
            {

                pictureBox1.Image = Properties.Resources.TH16;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 16: Hidden Star in Four Seasons");

            }
            if (menuLoc == 25)
            {

                pictureBox1.Image = Properties.Resources.TH165;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 16.5: Violet Detector");

            }
            if (menuLoc == 26)
            {

                pictureBox1.Image = Properties.Resources.TH17;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 17: Wily Beast and Weakest Creature");

            }
            if (menuLoc == 27)
            {

                pictureBox1.Image = Properties.Resources.TH175;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 17.5: Sunken Fossil World");

            }
            if (menuLoc == 28)
            {

                pictureBox1.Image = Properties.Resources.TH18;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 18: Unconnected Marketeers");

            }
            if (menuLoc == 29)
            {

                pictureBox1.Image = Properties.Resources.TH185;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 18.5: 100th Black Market");

            }
            if (menuLoc == 30)
            {

                pictureBox1.Image = Properties.Resources.TH19;
                pictureBox1.Refresh();
                gameTitle.Text = ("Touhou 19: Unfinished Dream of All Living Ghost");

            }



            // This checks the menuLoc variable and launches the matching game.
            if (e.KeyCode == Keys.Z)
            {
                keepOpen = (bool)Properties.Settings.Default["keepopen"];
                if (menuLoc == 1)
                {
                    fixErrorSoundBug = true;
                    try
                    {
                        Process.Start(Properties.Settings.Default["dosboxexe"].ToString(), "-conf " + Properties.Settings.Default["t1conf"].ToString());
                        
                    }
                    catch
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 2)
                {
                    fixErrorSoundBug = true;
                    try
                    {
                        Process.Start(Properties.Settings.Default["dosboxexe"].ToString(), "-conf " + Properties.Settings.Default["t2conf"].ToString());
                        
                    }
                    catch
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                if (menuLoc == 3)
                {
                    fixErrorSoundBug = true;
                    try
                    {
                        Process.Start(Properties.Settings.Default["dosboxexe"].ToString(), "-conf " + Properties.Settings.Default["t3conf"].ToString());
                         
                    }
                    catch
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                if (menuLoc == 4)
                {
                    fixErrorSoundBug = true;
                    try
                    {
                        Process.Start(Properties.Settings.Default["dosboxexe"].ToString(), "-conf " + Properties.Settings.Default["t4conf"].ToString());
                         
                    }
                    catch
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                if (menuLoc == 5)
                {
                    fixErrorSoundBug = true;
                    try
                    {
                        Process.Start(Properties.Settings.Default["dosboxexe"].ToString(), "-conf " + Properties.Settings.Default["t5conf"].ToString());
                         
                    }
                    catch
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                if (menuLoc == 6)
				{
                    fixErrorSoundBug = true;
                    //Process ExternalProcess = new Process();
                    //ExternalProcess.StartInfo.FileName = "C:\TH\Touhou06.exe";
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t6exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t6exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    
                }
                if (menuLoc == 7)
                {
                    fixErrorSoundBug = true;
                    //Process ExternalProcess = new Process();
                    //ExternalProcess.StartInfo.FileName = "C:\TH\Touhou06.exe";
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t7exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t7exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    
                    
                }
                if (menuLoc == 8)
                {
                    fixErrorSoundBug = true;
                    //Process ExternalProcess = new Process();
                    //ExternalProcess.StartInfo.FileName = "C:\TH\Touhou06.exe";
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t8exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t8exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }


                }
                if (menuLoc == 9)
                {
                    fixErrorSoundBug = true;
                    //Process ExternalProcess = new Process();
                    //ExternalProcess.StartInfo.FileName = "C:\TH\Touhou06.exe";
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t9exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t9exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }


                }
                if (menuLoc == 10)
                {
                    fixErrorSoundBug = true;
                    //Process ExternalProcess = new Process();
                    //ExternalProcess.StartInfo.FileName = "C:\TH\Touhou06.exe";
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t95exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t95exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }


                }
                if (menuLoc == 11)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t10exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t10exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 12)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t105exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t105exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 13)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t11exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t11exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 14)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t12exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t12exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 15)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t123exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t123exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 16)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t125exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t125exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 17)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t13exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t13exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 18)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t135exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t135exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 19)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t14exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t14exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 20)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t143exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t143exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 21)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t145exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t145exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 22)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t15exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t15exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 23)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t155exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t155exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 24)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t16exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t16exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 25)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t165exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t165exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 26)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t17exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t17exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 27)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t175exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t175exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 28)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t18exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t18exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 29)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t185exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t185exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (menuLoc == 30)
                {
                    fixErrorSoundBug = true;
                    var startInfo = new ProcessStartInfo();
                    try
                    {
                        startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Properties.Settings.Default["t19exe"].ToString());
                        startInfo.FileName = Properties.Settings.Default["t19exe"].ToString();
                        Process.Start(startInfo);
                         
                    }
                    catch (Exception ex)
                    {
                        const string message = "The launcher was unable to find the game. Did you set the paths? Press ALT + C to get to configuration.";
                        const string caption = "Game Launch Failed!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    // Here is that dirty fix from earlier being applied.
                    if (fixErrorSoundBug == false)
                        {
                            // Throw an error message if the game hasnt been installed and coded into the menu yet.
                            const string message = "This game has not implemented properly yet. Please contact developer.";
                            const string caption = "Error!";
                            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }

                if (keepOpen == false)
                {
                    Application.Exit();
                }
            }
            
		}

        // Ignore these. VS has a sook if i remove them.
		void gkh_KeyDown(object sender, KeyEventArgs e) {
			
			e.Handled = true;
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CtrBox_Click(object sender, EventArgs e)
        {

        }

       private void configButton_Click(object sender, EventArgs f)
       {
         
        }
    }
    }
