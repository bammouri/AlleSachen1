using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace YouTubeDownloaderTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addUrl_Click(object sender, EventArgs e)
        {
            // ToDo: Text von Textboxen (tbxAddUrl und rtbUrls in varaiblen speichern)

            // ToDo: Textbox tbxAddUrl auslesen und zur Textbox rtbUrls hinzufuegen
            // tbxAddUrl.Text nehmen und zur rtbUrls.Text hinzufuegen 
            //
            //rtbUrls.Text
            // rtbUrls.Text.


            rtbUrls.Text = tbxAddUrl.Text + "\n" + rtbUrls.Text;
            tbxAddUrl.Text = "";
           
         }
       private void btnDownload_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hallo");
            string[] urls = { "1", "2", "3", "4"};
           
            foreach (string elem in urls)
            {

                MessageBox.Show(" " + elem);

            }
            ExecuteCommandAsync("C:\\Users\\bammouri\\Downloads\\youtube\\youtube-dl --extract-audio --audio-format mp3 " + rtbUrls.Text + urls);
            
       }
        private void CleanBtn_Click(object sender, EventArgs e)
        {
            Ordnertxb.Text = " ";
            rtbUrls.Text = " ";

        }

        private void rtbUrls_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Ordnerbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
        /// <span class="code-SummaryComment"><summary></span>
        /// Executes a shell command synchronously.
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="command">string command</param></span>
        /// <span class="code-SummaryComment"><returns>string, as output of the command.</returns></span>
        public static void ExecuteCommandSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                Console.WriteLine(result);
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }
        /// <span class="code-SummaryComment"><summary></span>
        /// Execute the command Asynchronously.
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="command">string command.</param></span>
        public static void ExecuteCommandAsync(string command)
        {
            try
            {
                //Asynchronously start the Thread to process the Execute command request.
                Thread objThread = new Thread(new ParameterizedThreadStart(ExecuteCommandSync));
                //Make the thread as background thread.
                objThread.IsBackground = true;
                //Set the Priority of the thread.
                objThread.Priority = ThreadPriority.AboveNormal;
                //Start the thread.
                objThread.Start(command);
            }
            catch (ThreadStartException objException)
            {
                // Log the exception
            }
            catch (ThreadAbortException objException)
            {
                // Log the exception
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }
        

               
   }
    } 
                         
            
       



        
           
            
     
                
                
                
                
                
                
            
                          
                
         




    

       


        
        
        
        




        








