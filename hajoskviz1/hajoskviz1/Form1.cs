using System.Windows.Forms;

namespace hajoskviz1
{
    public partial class Form1 : Form
    {
        List<Kerdes> �sszesKerdes;
        List<Kerdes> AktualisKerdesek;
        int AktualisKerdes = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesKerdes = K�rd�sBet�lt�s();
            AktualisKerdesek = new List<Kerdes>();
            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(�sszesKerdes[0]);
                �sszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;
            K�rd�sMegjelen�t�s(AktualisKerdesek[AktualisKerdes]);
        }


        void K�rd�sMegjelen�t�s(Kerdes k�rd�s)
        {
            label1.Text = k�rd�s.K�rd�sSz�veg;
            v�laszGomb1.Text = k�rd�s.V�lasz1;
            v�laszGomb2.Text = k�rd�s.V�lasz2;
            v�laszGomb3.Text = k�rd�s.V�lasz3;

            if (!string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        List<Kerdes> K�rd�sBet�lt�s()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();

            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "a/";
                string[] t�mb = sor.Split("\t");
                if (t�mb.Length != 7) continue;
                Kerdes k = new Kerdes();
                k.K�rd�sSz�veg = t�mb[1];
                k.V�lasz1 = t�mb[2];
                k.V�lasz2 = t�mb[3];
                k.V�lasz3 = t�mb[4];
                k.URL = t�mb[5];

                int x = 0;
                int.TryParse(t�mb[6], out x);
                k.HelyesV�lasz = x;
                kerdesek.Add(k);
            }

            return kerdesek;
        }


    }
}