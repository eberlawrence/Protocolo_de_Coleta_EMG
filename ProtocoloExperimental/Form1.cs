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
using System.Threading;

namespace ProtocoloExperimental
{
    public partial class MainForm : Form
    {
        // Variavel para embaralhar as classes
        Random randonNum = new Random();
        // Lista de imagens dos movimentos que devem ser executados
        List<Bitmap> imageList = new List<Bitmap>();
        // Classes que serão embaralhadas
        List<int> SixMoviments = new List<int>() { 1, 2, 3, 4, 5, 6};
        //Dicionário para colocar as listas com a ordem de imagens e seu indice de 0 a 39
        Dictionary<int, List<int>> data = new Dictionary<int, List<int>>();
        
        //Carregando todas as imagens usadas
        Bitmap img1 = new Bitmap(@"C:\Users\BioLab\Desktop\GitHub\Protocolo_de_Coleta_EMG\img\Neutro.jpg");  
        Bitmap img2 = new Bitmap(@"C:\Users\BioLab\Desktop\GitHub\Protocolo_de_Coleta_EMG\img\supina.jpg");
        Bitmap img3 = new Bitmap(@"C:\Users\BioLab\Desktop\GitHub\Protocolo_de_Coleta_EMG\img\Prona.jpg");
        Bitmap img4 = new Bitmap(@"C:\Users\BioLab\Desktop\GitHub\Protocolo_de_Coleta_EMG\img\Pince.jpg");
        Bitmap img5 = new Bitmap(@"C:\Users\BioLab\Desktop\GitHub\Protocolo_de_Coleta_EMG\img\Fecha.jpg");
        Bitmap img6 = new Bitmap(@"C:\Users\BioLab\Desktop\GitHub\Protocolo_de_Coleta_EMG\img\Estenda.jpg");
        Bitmap img7 = new Bitmap(@"C:\Users\BioLab\Desktop\GitHub\Protocolo_de_Coleta_EMG\img\Flexiona.jpg");
        Bitmap img8 = new Bitmap(@"C:\Users\BioLab\Desktop\GitHub\Protocolo_de_Coleta_EMG\img\PosiçãoEletrodos.jpg");

        //Salvar o numero da coleta
        int a = 1;

        bool iRest = true;
        // Ajustar a posicição de panels, labels, button...
        int x;        int y;    
        //Contagem da quantidade do numero de movimentos, total e parcial. contiInitial = incrementa as informações iniciais
        int countInitial = 0;        int countT = 0;        int countP = 0;
        // incrementam a lista de imagens e a imagem dentro da lista
        int countTwo = 0;        int countOne = 0;        


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
            lbCountP.Visible = false;
            lbCountT.Visible = false;
            lbMoviment.Visible = false;
            lbStartMessage.Visible = false;

            pbMain.Visible = false;
            pbTwo.Visible = false;
            pbTrigger.Visible = false;

            x = ((pnMain.Size.Width - lbMoviment.Size.Width) / 2) + pbMain.Size.Width ;
            y = (pnMain.Size.Height / 2);
            lbMoviment.Location = new Point(x, y);

            x = (pnMain.Size.Width - pbMain.Size.Width) / 2;
            y = (pnMain.Size.Height - pbMain.Height) / 2;
            pbMain.Location = new Point(x, y);

            pbTrigger.Width = 150;
            pbTrigger.Height = 140;
            x = (pnMain.Size.Width - 20) / 10;
            y = (pnMain.Size.Height) - (pbTrigger.Size.Width) - 20;
            pbTrigger.Location = new Point(x, y);
        }


        private void TimerTwo_Tick(object sender, EventArgs e)
        {
            lbStartMessage.Visible = true;
            if (countInitial == 0)
            {
                lbStartMessage.Text = "Bem vindo ao experimento!!";
                x = (pnMain.Size.Width - lbStartMessage.Width) / 2;
                y = (pnMain.Size.Height - lbStartMessage.Height) / 2;
                lbStartMessage.Location = new Point(x, y);
            }

            if (countInitial == 1)
            {
                pbTwo.Visible = true;
                pbTwo.Width = 964;
                pbTwo.Height = 649;
                x = (pnMain.Size.Width - pbTwo.Width) / 2;
                y = (pnMain.Size.Height - pbTwo.Height) / 2;
                pbTwo.Location = new Point(x, y);

                pbTwo.Image = img8;
                lbStartMessage.Visible = false;
                btOne.Visible = true;
                btOne.Width = 180;
                btOne.Height = 45;
                x = (pnMain.Size.Width - btOne.Width) / 2;
                y = (pnMain.Size.Height + pbTwo.Height) / 2;
                btOne.Location = new Point(x, y);
                TimerTwo.Stop();
            }
            countInitial++;
        }


        private void BtOne_Click(object sender, EventArgs e)
        {
            btOne.Visible = false;
            btStart.Visible = true;

            tbName.Visible = true;

            lb1.Visible = true;
            lb2.Visible = true;
            lb3.Visible = true;
            lbCountP.Visible = true;
            lbCountT.Visible = true;            

            pbMain.Visible = true;
            pbTwo.Visible = false;
            pbTrigger.Visible = true;
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

            for (int i = 0; i < 10; i++)
            {
                data.Add(i, SixMoviments.OrderBy(s => randonNum.Next()).Take(6).ToList());                
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
                lbMoviment.Text = "Repouso";
                lbMoviment.Visible = true;
                btStart.Text = "Parar a coleta";
                ImageShow();
                TimerOne.Start();
                DataSave();

            }
            else if(btStart.Text == "Parar a coleta")
            {
                pbMain.Image = imageList[0];
                lbMoviment.Visible = false;
                btStart.Text = "Iniciar a coleta";
                TimerOne.Stop();
                TimerThree.Stop();
                countTwo = 0;
                countOne = 0;
                countT = 0;
                countP = 0; 
                lbCountT.Text = "0";
                lbCountP.Text = "0";
            }         
        }
        

        private void MovimentText(Image x)
        {
            if (x == img2)
            {
                lbMoviment.Text = " Supine";
            }
            if (x == img3)
            {
                lbMoviment.Text = "  Prone";
            }
            if (x == img4)
            {
                lbMoviment.Text = "  Pince";                                   
            }
            if (x == img5)
            {
                lbMoviment.Text = "  Feche";
            }
            if (x == img6)
            {
                lbMoviment.Text = "Estenda";
            }
            if (x == img7)
            {
                lbMoviment.Text = "Flexione";
            }
        }


        private void TimerOne_Tick(object sender, EventArgs e)
        {
            if (iRest == true)
            {
                TimerOne.Interval = 3000;
                lbMoviment.Text = "Repouso";
                pbTrigger.BackColor = Color.White;
                pbMain.Image = imageList[0];
                iRest = false;
                switch (countTwo)
                {
                    case 10:
                        countP = 0;
                        lbCountP.Text = "0";
                        btStart.Text = "Iniciar a coleta";
                        countTwo = 0;
                        TimerOne.Stop();
                        a++;
                        break;
                }
            }
            else
            {
                TimerOne.Interval = 3000;
                MovimentText(pbMain.Image);
                pbMain.Image = imageList[data[countTwo][countOne++]];
                countT++;
                lbCountT.Text = countT.ToString();
                countP++;
                lbCountP.Text = countP.ToString();
                MovimentText(pbMain.Image);
                pbTrigger.BackColor = Color.Black;
                switch (countOne)
                {
                    case 6:
                        countOne = 0;
                        countTwo++;
                        break;
                }
                iRest = true;
            }

        }

        

        private void DataSave()
        {
            var File = @"C:\Users\BioLab\Desktop\ColetaEMG\EberCoPiloto\Resposta\" + tbName.Text + "-Resposta.txt";
            using (var write = new StreamWriter(File))
                foreach (KeyValuePair<int, List<int>> N in data)
                {
                    write.Write("[{0}]\r\n", N.Key);
                    foreach (var item in N.Value)
                    {
                        write.Write("{0}\r\n", item);
                    }
                }
        }
    }    
 
}