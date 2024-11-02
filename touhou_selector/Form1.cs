using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

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
        
        // Declaring variables.
		private int menuLoc = 1;
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
            // Setting the title so its not blank on launch.
            gameTitle.Text = ("Touhou 1: Highly Responsive to Prayers");
		}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // These are to stop the selector going out of bounds.
            if (menuLoc <= 1)
            {
                menuLoc = 1;
            }
            if (menuLoc >= 16)
            {
                menuLoc = 16;
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



            // This checks the menuLoc variable and launches the matching game.
            if (e.KeyCode == Keys.Z)
            {
                if (menuLoc == 1)
                {
                    fixErrorSoundBug = true;
                    try
                    {
                        Process.Start(Properties.Settings.Default["dosboxexe"].ToString(), "-conf " + Properties.Settings.Default["t1conf"].ToString());
                        Application.Exit();
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
                        Application.Exit();
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
                        Application.Exit();
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
                        Application.Exit();
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
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t6workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t6exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t7workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t7exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t8workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t8exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t9workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t9exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t95workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t95exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t10workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t10exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t105workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t105exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t11workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t11exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t12workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t12exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t123workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t123exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                        startInfo.WorkingDirectory = Properties.Settings.Default["t125workdir"].ToString();
                        startInfo.FileName = Properties.Settings.Default["t125exe"].ToString();
                        Process.Start(startInfo);
                        Application.Exit();
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
                            const string message = "This game has not been added yet.";
                            const string caption = "Error!";
                            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
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
