using System.Security.Cryptography;

namespace System_Programming_File_Transfer_Homework
{
    public partial class Form1 : Form
    {

        // Private Fields

        private string fromPath;
        private string toPath;

        // Constructor

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fromPath = ofd.FileName;
                fromTB.Text = fromPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                toPath = ofd.FileName;
                toTB.Text = toPath;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread thread = new(() =>
            {
                int bufferSize = 1024 * 1024;

                using (FileStream fileStream = new FileStream(toPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
                {
                    FileStream fs = new FileStream(fromPath, FileMode.Open, FileAccess.ReadWrite);
                    fileStream.SetLength(fs.Length);
                    int bytesRead = -1;
                    byte[] bytes = new byte[bufferSize];
                    int count = 1;

                    while ((bytesRead = fs.Read(bytes, 0, bufferSize)) > 0)
                    {
                        progressBar1.Increment(count * 200);
                        fileStream.Write(bytes, 0, bytesRead);
                    }
                    progressBar1.Value = 0;
                }
            });
            thread.Start();
        } 
    }
}