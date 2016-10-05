using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

using MissionPlanner.Controls;
using System.IO;

namespace MissionPlanner.GCSViews
{
    public partial class Supporto : MyUserControl, IActivate, IDeactivate
    {
        string supportoLink = "http://www.flytop.it/supporto-tecnico";
        bool isAttive = false;
        bool isSplash = true;
        public Supporto()
        {
            InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            this.browserSupporto.Url = new Uri(String.Format("file:///{0}/html/index.html", curDir));
            this.BackColor = Color.White;
            browserSupporto.ProgressChanged += new WebBrowserProgressChangedEventHandler(delegate(object sender, WebBrowserProgressChangedEventArgs events)
            {
                if ((int)events.CurrentProgress > 0)
                {
                    Console.WriteLine(((int)events.MaximumProgress).ToString());
                    Console.WriteLine(((int)events.CurrentProgress).ToString());
                    progressBar.Maximum = (int)events.MaximumProgress;
                    progressBar.Value = (int)events.CurrentProgress;
                }
            });



        }

        public void Activate()
        {
            MainV2.instance.MenuConnect.Visible = true;
            this.isAttive = true;
            supportoload();

        }
        public void Deactivate()
        {
            //this.browserSupporto.Visible = false;
            this.isAttive = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void browserSupporto_ControlAdded(object sender, ControlEventArgs e)
        {
            Console.Write("added");
        }

        private void browserSupporto_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // progressBar.MarqueeAnimationSpeed = 0;
           // progressBar.Style = ProgressBarStyle.Blocks;
            if (browserSupporto.Url.OriginalString != supportoLink && this.isAttive)
            {

                supportoload();


            }
        }
        public void supportoload()
        {
            try
            {
                if (MainV2.CheckForInternetConnection())
                {
                    if (isSplash)
                    {
                        this.browserSupporto.Navigate("http://www.flytop.it/supporto-tecnico");
                        isSplash = false;

                    }
                }
                else
                {
                    Console.Write("No connessione");
                    string message = "Per richiedere il supporto il programma deve essere collegato ad internet. Verificare la connessione e procedere nuovamente alla richiesta.";
                    // Show message box
                    DialogResult dialogResult = MessageBox.Show(message, "Errore di connesione", MessageBoxButtons.OK);
                  
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }

                }


            }
            catch
            {
                Console.Write("Errore durante il caricamento della pagina");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            isSplash = true;
            supportoload();
        }

        private void ItemBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

          //  progressBar.MarqueeAnimationSpeed = 80;
           // progressBar.Style = ProgressBarStyle.Marquee;
        }
         
    }
}
