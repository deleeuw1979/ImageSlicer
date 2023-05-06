using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class board : Form
    {
        String fileContent = string.Empty;
        String filePath = string.Empty;
        String fileLocation = string.Empty;
        String fileType = string.Empty;
        Int32 picNumber = 1;

        public board()
        {
            InitializeComponent();
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("de-DE");
            TransparencyKey = Color.Black;
            frame1.BackColor = Color.Black;
            frame1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackColor = Color.Black;
            getFolder();
        }

        public void getFolder()
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();

            if (openFolderDialog.ShowDialog() == DialogResult.OK)
                filePath = openFolderDialog.SelectedPath;
        }

        private void takeImage()
        {
            picNumber++;

            //To prevent overwriting
            String dateCode = DateTime.Now.ToUniversalTime().ToString();
            dateCode = dateCode.Replace("/", "-");
            dateCode = dateCode.Replace(" ", "-");
            dateCode = dateCode.Replace(":", "-");
            dateCode = dateCode.Replace("_", "-");
            dateCode = dateCode.Replace(".", "-");
            String picCode = picNumber.ToString() + "_" + dateCode;

            Bitmap capturePiece = new Bitmap(frame1.Width, frame1.Height);
            Rectangle captureSection = new Rectangle(new Point(frame1.Left, frame1.Top), new Size(frame1.Width, frame1.Height));
                    Graphics g = Graphics.FromImage(capturePiece);
            g.CopyFromScreen(captureSection.Left, captureSection.Top, 0, 0, new Size(frame1.Width, frame1.Height));
            capturePiece.Save(filePath + "\\" + picCode + ".jpg", ImageFormat.Jpeg);
        }

        private void nextImage(Int32 newX, Int32 newY)
        {
            takeImage();
            frame1.Left = frame1.Left + (newX * frame1.Width);
            frame1.Top = frame1.Top + (newY * frame1.Height);
        }

        private void frame1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Int32 currHeight = frame1.Height;
            Int32 currWidth = frame1.Width;

            if (e.KeyCode==Keys.Space)
                frame1.BackColor = Color.White;
  
            if (e.KeyCode == Keys.Down)
                frame1.Height = frame1.Height + 3;

            if (e.KeyCode == Keys.NumPad2)
                frame1.Top = frame1.Top + 3;

            if (e.KeyCode == Keys.Up)
                frame1.Height = frame1.Height - 3;

            if (e.KeyCode == Keys.NumPad8)
                frame1.Top = frame1.Top - 3;

            if (e.KeyCode == Keys.Right)
                frame1.Width = frame1.Width + 3;

            if (e.KeyCode == Keys.NumPad6)
                frame1.Left = frame1.Left + 3;

            if (e.KeyCode == Keys.Left)
                frame1.Width = frame1.Width - 3;

            if (e.KeyCode == Keys.NumPad4)
                frame1.Left = frame1.Left - 3;

            if (e.KeyCode == Keys.NumPad3)
                nextImage(1, 0);

            if (e.KeyCode == Keys.NumPad1)
                nextImage(-1, 0);

            if (e.KeyCode == Keys.NumPad9)
                nextImage(0, 1);

            if (e.KeyCode == Keys.NumPad7)
                nextImage(0, -1);

            if (e.KeyCode == Keys.Escape)
            {
                frame1.Top = 25;
                frame1.Left = 25;
                getFolder();
            }
        }

        private void frame1_KeyUp(object sender, KeyEventArgs e)
        {
            frame1.BackColor = Color.Black;
        }
    }
}

/*
 private void CaptureMyScreen()
{
    try
    {
        //Creating a new Bitmap object
        Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
        //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
        //Creating a Rectangle object which will
        //capture our Current Screen
        Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
        //Creating a New Graphics Object
        Graphics captureGraphics = Graphics.FromImage(captureBitmap);
        //Copying Image from The Screen
        captureGraphics.CopyFromScreen(captureRectangle.Left,captureRectangle.Top,0,0,captureRectangle.Size);
        //Saving the Image File (I am here Saving it in My E drive).
        captureBitmap.Save(@"E:\Capture.jpg",ImageFormat.Jpeg);
        //Displaying the Successfull Result
        MessageBox.Show("Screen Captured");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}
 */
