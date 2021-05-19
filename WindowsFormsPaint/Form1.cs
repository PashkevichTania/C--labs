using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPaint
{
    public partial class Form1 : Form
    {
        bool drawing;
        GraphicsPath currentPath;
        Point oldLocation;
        Pen currentPen;
        Color historyColor;

        int historyCounter; //Счетчик истории
        List<Image> History;

        public Form1()
        {
            InitializeComponent();
            drawing = false; //Переменная, ответственная за рисование
            currentPen = new Pen(Color.Black);
            currentPen.Width = trackBarPen.Value;
            History = new List<Image>();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка ? ",
                    "Предупреждение", 
                    MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveMenu_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }

            History.Clear();
            historyCounter = 0;

            Bitmap pic = new Bitmap(750, 500);
            picDrawingSurface.Image = pic;

            Graphics g = Graphics.FromImage(picDrawingSurface.Image);
            g.Clear(Color.White);
            g.DrawImage(picDrawingSurface.Image, 0, 0, 750, 500);

            History.Add(new Bitmap(picDrawingSurface.Image));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                historyColor = currentPen.Color;
                currentPath = new GraphicsPath();
            }
            if (e.Button == MouseButtons.Right)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPen.Color = Color.White;
                currentPath = new GraphicsPath();
            }
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif| PNG Image | *.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; 
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "") //Если введено не пустое имя
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*. jpg| Bitmap Image|*. bmp| GIF Image|*. gif| PNG Image | *.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1;

            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);
                picDrawingSurface.AutoSize = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveMenu_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }

            label_XY.Text = e.X + ", " + e.Y;
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            currentPen.Color = historyColor;

            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);

            drawing = false;
            try
            {
                currentPath.Dispose();
                
            }
            catch { };
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBarPen.Value;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidStyleMenu.Checked = true;
            dashDotDotStyleMenu.Checked = false;
            dashDotDotStyleMenu.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            solidStyleMenu.Checked = true;
            dashDotDotStyleMenu.Checked = false;
            dashDotDotStyleMenu.Checked = false;
        }

        private void deshDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidStyleMenu.Checked = true;
            dashDotDotStyleMenu.Checked = false;
            dashDotDotStyleMenu.Checked = false;
        }
    }
}
