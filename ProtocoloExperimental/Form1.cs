using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProtocoloExperimental
{
    public partial class MainForm : Form
    {


        Random randonNum = new Random();
        List<Bitmap> imageList = new List<Bitmap>();
        List<int> fourMoviments = new List<int>() { 1, 2, 3, 4 };
        int[] dataList = new int[360];
        Dictionary<int, List<int>> data = new Dictionary<int, List<int>>();
        Bitmap img1 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\Neutro.jpg");
        Bitmap img2 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\NeutroSupina.jpg");
        Bitmap img3 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\NeutroProna.jpg");
        Bitmap img4 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\NeutroAbre.jpg");
        Bitmap img5 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\NeutroFecha.jpg");
        Bitmap img6 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\Supina.jpg");
        Bitmap img7 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\Prona.jpg");
        Bitmap img8 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\Abre.jpg");
        Bitmap img9 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\Fecha.jpg");
        Bitmap img10 = new Bitmap(@"D:\Arquivos\Graduaçao Eng. Biomedica\10º Periodo\Trabalho de Conclusão de Curso - TCC\Imagens\Final\Modelo.jpg");

        int flag = 0;

        int x; int y;

        int i = 0; int j = 0;

        int a = 1; int b = 5; int c = 4;

        bool iTwo = false;        bool iThree = false;        bool iFour = false;

        int countOne = 0;        int countTwo = 0;        int countThree = 0;        int countFour = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            TimerTwo.Start();

            btOne.Visible = false;
            btStart.Visible = false;

            tbName.Visible = false;

            lb1.Visible = false;
            lb2.Visible = false;
            lb3.Visible = false;
            lbCount.Visible = false;
            lbCountP.Visible = false;
            lbCountT.Visible = false;
            lbMoviment.Visible = false;
            lbStartMessage.Visible = false;

            pbMain.Visible = false;
            pbTwo.Visible = false;

        }



        private void pnMain_Paint(object sender, PaintEventArgs e)
        {
            x = (pnMain.Size.Width) / 2;
            y = (pnMain.Size.Height - pbMain.Height) / 2;
            pbMain.Location = new Point(x, y);


            x = (pnMain.Size.Width + pbMain.Width - (lbCount.Width)/2 ) / 2;
            y = (pnMain.Size.Height - lbCount.Height);
            lbMoviment.Location = new Point(x, y);


            x = (pnMain.Size.Width + pbMain.Width - (lbCount.Width/2)) / 2;
            y = (lbCount.Size.Height) / 2;
            lbCount.Location = new Point(x, y);
        }


        private void TimerTwo_Tick(object sender, EventArgs e)
        {
            lbStartMessage.Visible = true;
            if (flag == 0)
            {

                lbStartMessage.Text = "Bem vindo ao experimento!!";
                x = (pnMain.Size.Width - lbStartMessage.Width) / 2;
                y = (pnMain.Size.Height - lbStartMessage.Height) / 2;
                lbStartMessage.Location = new Point(x, y);
            }
            if (flag == 1)
            {
                lbStartMessage.Text = "O experimento consiste em coletar sinais EMG de quatro canais, \nsendo cada um com um par de eletrodos ativos equidistantes em \ntorno do antebraço do voluntário com auxílio de um bracelete.";
                x = (pnMain.Size.Width - lbStartMessage.Width) / 2;
                y = (pnMain.Size.Height - lbStartMessage.Height) / 2;
                lbStartMessage.Location = new Point(x, y);
            }
            if (flag == 2)
            {
                pbTwo.Visible = true;
                pbTwo.Width = 191;
                pbTwo.Height = 429;
                x = (pnMain.Size.Width - pbTwo.Width) / 2;
                y = (pnMain.Size.Height - pbTwo.Height) / 2;
                pbTwo.Location = new Point(x, y);

                pbTwo.Image = img10;
                lbStartMessage.Visible = false;
                btOne.Visible = true;
                btOne.Width = 180;
                btOne.Height = 45;
                x = (pnMain.Size.Width - btOne.Width) / 2;
                y = (pnMain.Size.Height + pbTwo.Height) / 2;
                btOne.Location = new Point(x, y);
                TimerTwo.Stop();
            }
            flag++;
        }


        private void btOne_Click(object sender, EventArgs e)
        {
            btOne.Visible = false;
            btStart.Visible = true;

            tbName.Visible = true;

            lb1.Visible = true;
            lb2.Visible = true;
            lb3.Visible = true;
            lbCount.Visible = true;
            lbCountP.Visible = true;
            lbCountT.Visible = true;
            lbMoviment.Visible = true;

            pbMain.Visible = true;
            pbTwo.Visible = false;
        }


        private void ImageShow()
        {                  
            imageList.Add(img1);
            imageList.Add(img2);
            imageList.Add(img3);
            imageList.Add(img4);
            imageList.Add(img5);
            imageList.Add(img6);
            imageList.Add(img7);
            imageList.Add(img8);
            imageList.Add(img9);

            for (int i = 0; i < 10; i++)
            {
                data.Add(i, fourMoviments.OrderBy(s => randonNum.Next()).Take(4).ToList());                
            }        
        }

        
        private void Bt1_Click(object sender, EventArgs e)
        {
            for (int i = data.Count; i >= 0; i--)
            {
                data.Remove(i);
            }

            if (btStart.Text == "Iniciar a coleta")
            {
                btStart.Text = "Parar a coleta";
                ImageShow();
                TimerOne.Start();
            }
            else
            {
                btStart.Text = "Iniciar a coleta";
                TimerOne.Stop();
                iTwo = false;
                iThree = false;
                iFour = false;
                j = 0;
                i = 0;
                c = 3;
                countOne = 0;
                countTwo = 0;
                countThree = 0;
                countFour = 0; 
                lbCountT.Text = "0";
                lbCountP.Text = "0";
            }         
        }


        private void DataList()
        {
            if (pbMain.Image == imageList[0])
                dataList[i] = 0;

            if (pbMain.Image == imageList[1])
                dataList[i] = 1;

            if (pbMain.Image == imageList[2])            
                dataList[i] = 2;
            
            if (pbMain.Image == imageList[3])
                dataList[i] = 3;

            if (pbMain.Image == imageList[4])
                dataList[i] = 4;

            if (pbMain.Image == imageList[5])
                dataList[i] = 5;

            if (pbMain.Image == imageList[6])
                dataList[i] = 6;

            if (pbMain.Image == imageList[7])
                dataList[i] = 7;

            if (pbMain.Image == imageList[8])
                dataList[i] = 8;

            i++;
        }

        private void MovimentText(Image x)
        {
            if (x == img2)
            {
                lbMoviment.Text = "Tempo em repouso";
            }

        }
        private void TimerOne_Tick(object sender, EventArgs e)
        {

            if (j < 10)
            {
                if (countTwo < 4)
                {
                    if (countOne < 3)
                    {
                        c--;
                        lbCount.Text = c.ToString();
                        pbMain.Image = imageList[0];
                        lbMoviment.Text = "Tempo em repouso";
                    }
                    if (countOne >= 3 && countOne < 6)
                    {
                        TimeMovement(3);

                        if (pbMain.Image == imageList[0] && iTwo == false
                               && iThree == false && iFour == false)
                        {
                            pbMain.Image = imageList[data[j][0]];
                        }
                        if (iTwo == true)
                        {
                            pbMain.Image = imageList[data[j][1]];
                            iTwo = false;
                        }
                        if (iThree == true)
                        {
                            pbMain.Image = imageList[data[j][2]];
                            iThree = false;
                        }
                        if (iFour == true)
                        {
                            pbMain.Image = imageList[data[j][3]];
                            iFour = false;
                        }
                    }
                    if (countOne >= 6 && countOne < 8)
                    {
                        TimeMovement(6);

                        if (pbMain.Image == imageList[data[j][0]])
                        {
                            iTwo = true;
                            pbMain.Image = imageList[data[j][0] + 4];
                        }

                        if (pbMain.Image == imageList[data[j][1]])
                        {
                            iThree = true;
                            pbMain.Image = imageList[data[j][1] + 4];
                        }
                        if (pbMain.Image == imageList[data[j][2]])
                        {
                            iFour = true;
                            pbMain.Image = imageList[data[j][2] + 4];
                        }

                        if (pbMain.Image == imageList[data[j][3]])
                        {
                            pbMain.Image = imageList[data[j][3] + 4];
                        }
                    }
                    if (countOne == 8)
                    {
                        lbCount.Text = c.ToString();
                        c = 4;
                        countThree++;
                        countFour++;
                        lbCountT.Text = countThree.ToString();
                        lbCountP.Text = countFour.ToString();
                        countOne = -1;
                        countTwo++;
                    }

                    
                    countOne++;
                    DataList();
                }
                else
                {
                    j++;
                    countTwo = 0;
                }
            }
            else
            {
                i = 0;
                j = 0;
                countFour = 0;
                TimerOne.Stop();
                lbCountP.Text = "0";
                btStart.Text = "Iniciar a coleta";

                DataSave();
                a++;
                b++;
            }


        }

        private void TimeMovement(int x)
        {
            if (countOne == x)
            {
                c = 3;
            }
            lbCount.Text = c.ToString();
            c--;
        }
        private void DataSave()
        {
            var fullPathOne = @"C:\" + tbName.Text + "-Coleta-" + a.ToString() + ".txt";
            using (var write = new StreamWriter(fullPathOne))
            {
                foreach (var n in dataList)
                    write.WriteLine(n);

            }
            var fullPathTwo = @"C:\" + tbName.Text + "-Coleta-" + b.ToString() + ".txt";
            using (var write = new StreamWriter(fullPathTwo))
            {
                foreach (var n in dataList)
                    if (n != dataList[0])
                    {
                        write.WriteLine(n);
                    }
            }
        }
    }
}
