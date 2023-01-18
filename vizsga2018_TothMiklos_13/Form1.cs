using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizsga2018_TothMiklos_13
{
    public partial class Form1 : Form
    {
        int pageNum = 0;
        string kepekPath = @"..//../Kepek/";
        HappyLiving HL = new HappyLiving(new List<Lakopark>());

        public Form1()
        {
            InitializeComponent();
        }

        private void checkArrows()
        {
            left.ImageLocation = (pageNum > 0) ? (kepekPath+@"balnyil.jpg") : (@"");
            right.ImageLocation = (pageNum < 2) ? (kepekPath+@"jobbnyil.jpg") : (@"");
        }

        private void imgLoad(PictureBox pb, int x, int y)
        {
            string house = kepekPath+@"Haz" +HL.Lakoparkok[0].Hazak[x, y]+".jpg";
            string alternative = kepekPath+@"kereszt.jpg";
            pb.ImageLocation = (File.Exists(house)) ? (house) : (alternative);
        }

        private void fillGrid(Lakopark LP)
        {
            btnContainer.Controls.Clear();
            titleKep.ImageLocation = kepekPath+HL.Lakoparkok[pageNum].Nev+".jpg";
            int size = 50;
            for (int x = 0; x < LP.UtcakSzama; x++)
            {
                for (int y = 0; y < LP.MaxHazSzam; y++)
                {
                    PictureBox PB = new PictureBox();
                    PB.SizeMode = PictureBoxSizeMode.Zoom;
                    PB.BorderStyle = BorderStyle.FixedSingle;
                    PB.SetBounds(x * size, y * size, size, size);
                    PB.Name = $"{x};{y}";
                    imgLoad(PB, x, y);
                    PB.Click += (bo, be) =>
                    {
                        PictureBox bpb = (PictureBox)bo;
                        int[] dim = Array.ConvertAll(bpb.Name.Split(';'), int.Parse);
                        int locX = dim[0];
                        int locY = dim[1];
                        HL.Lakoparkok[pageNum].Hazak[locX, locY] = (HL.Lakoparkok[pageNum].Hazak[locX, locY] + 1 > 3) ? (0) : (HL.Lakoparkok[pageNum].Hazak[locX, locY] += 1);
                        imgLoad(bpb, locX, locY);
                    };
                    btnContainer.Controls.Add(PB);
                }
            }
        }

        private Lakopark loadLakopark(string RD)
        {
            string[] splitted = RD.Split('\n');
            int[] dim = Array.ConvertAll(splitted[1].Split(';'), int.Parse);
            int[,] telkek = new int[dim[1], dim[0]];
            for (int i = 2; i < splitted.Length; i++)
            {
                int[] haz = Array.ConvertAll(splitted[i].Split(';'), int.Parse);
                telkek[haz[1]-1, haz[0]-1] = haz[2];
            }
            return new Lakopark(telkek, dim[0], splitted[0].Replace("\r", ""), dim[1]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] rawData = Regex.Split(File.ReadAllText(@"..//../lakoparkok.txt"), Environment.NewLine + Environment.NewLine);
            for (int i = 0; i < rawData.Length-1; i++)
            {
                HL.Lakoparkok.Add(loadLakopark(rawData[i]));
            }
            fillGrid(HL.Lakoparkok[pageNum]);
            checkArrows();
        }

        private void right_Click(object sender, EventArgs e)
        {
            pageNum++;
            fillGrid(HL.Lakoparkok[pageNum]);
            checkArrows();
        }

        private void left_Click(object sender, EventArgs e)
        {
            pageNum--;
            fillGrid(HL.Lakoparkok[pageNum]);
            checkArrows();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string[] date = Regex.Split(DateTime.Now.ToString(), ". ");
            File.Move(@"..//../lakoparkok.txt", $"..//../lakoparkok_{date[0]}{date[1]}{date[2]}_{date[3].Replace(":", "")}.txt");
            string stringToSave = "";
            foreach (Lakopark lp in HL.Lakoparkok)
            {
                stringToSave += $"{lp.Nev}{Environment.NewLine}{lp.MaxHazSzam};{lp.UtcakSzama}{Environment.NewLine}";
                for (int x = 0; x < lp.Hazak.GetLength(0); x++)
                {
                    for (int y = 0; y < lp.Hazak.GetLength(1); y++)
                    {
                        stringToSave += (lp.Hazak[x, y] == 0) ? ("") : ($"{y+1};{x+1};{lp.Hazak[x, y]}{Environment.NewLine}");
                    }
                }
                stringToSave += Environment.NewLine;
            }
            MessageBox.Show(Regex.Escape(stringToSave));
            File.WriteAllText(@"..//../lakoparkok.txt", stringToSave);
        }
    }
}
