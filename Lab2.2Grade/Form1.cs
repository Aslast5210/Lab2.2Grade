namespace Lab2._2Grade
{
    public partial class Form1 : Form
    {
        int arrayIndex = 0;
        int Max = 0;
        int Min = 0;
        string[] arrName = new string[10000];
        string[] arrID = new string[10000];
        int[] arrScore = new int[10000];
        int SUM = 0;
        int na = 0;
        int nbplus = 0;
        int nb = 0;
        int ncplus = 0;
        int nc = 0;
        int ndplus = 0;
        int nd = 0;
        int nf = 0;
        string Grade;

        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputName = TBnm.Text;
            string inputID = TBid.Text;
            int inputScore = int.Parse(TBsc.Text);

            arrID[arrayIndex] = inputID;
            arrName[arrayIndex] = inputName;
            arrScore[arrayIndex] = inputScore;
            arrayIndex++;

            TBsc.Text = inputScore.ToString();

            if (inputScore > Max)
            {
                Max = inputScore;
                Maxid.Text = inputID;
                Maxnm.Text = inputName;
                Maxsc.Text = inputScore.ToString();
                Min = Max;
            }

            if (inputScore < Min)
            {
                Min = inputScore;
                Minid.Text = inputID;
                Minnm.Text = inputName;
                Minsc.Text = inputScore.ToString();
            }

            int SUM = Max + Min;
            double SUM2 = SUM / 2;
            string SUM3 = SUM2.ToString();
            SCavg.Text = SUM3;

            if (inputScore >= 80 && inputScore <= 100)
            {
                Grade = "A";
                na++;
            }
            else if (inputScore >= 75 && inputScore < 79)
            {
                Grade = "B+";
                nbplus++;
            }
            else if (inputScore >= 70 && inputScore < 74)
            {
                Grade = "B";
                nb++;
            }
            else if (inputScore >= 65 && inputScore < 69)
            {
                Grade = "C+";
                ncplus++;
            }
            else if (inputScore >= 60 && inputScore < 64)
            {
                Grade = "C";
                nc++;
            }
            else if (inputScore >= 55 && inputScore < 59)
            {
                Grade = "D+";
                ndplus++;
            }
            else if (inputScore >= 50 && inputScore < 54)
            {
                Grade = "D";
                nd++;
            }
            else
            {
                Grade = "F";
                nf++;
            }

            double v = (na * 4.0) + (nbplus * 3.5) + (nb * 3.0) + (ncplus * 2.5) + (nc * 2.0) + (ndplus * 1.5) + (nd * 1.0);
            int GPA = (int)v;
            double GPA2 = GPA / arrayIndex;
            string GPA3 = GPA2.ToString();
            GPAavg.Text = GPA3;

            TBA.Text = na.ToString();
            TBBplus.Text = nbplus.ToString();
            TBB.Text = nb.ToString();
            TBCplus.Text = ncplus.ToString();
            TBC.Text = nc.ToString();
            TBDplus.Text = ndplus.ToString();
            TBD.Text = nd.ToString();
            TBF.Text = nf.ToString();
        }

        private void BTcl_Click(object sender, EventArgs e)
        {
            TBid.Clear();
            TBnm.Clear();
            TBsc.Clear();
        }
    }
}