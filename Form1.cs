using System.Threading;
namespace Simon_Says;

public partial class Form1 : Form
{
    int score = 0;
    int highScore;
    Random rand = new Random();
    bool talk = false;
    List<int> list = new List<int>();
    public Form1()
    {
        InitializeComponent();
    }

    private void Simon_Talk()
    {
        talk = true;

        Thread.Sleep(150);
        foreach (int i in list)
        {
            switch (i)
            {
                case 0:
                    pb_0.Image = Properties.Resources.R2;
                    Thread.Sleep(150);
                    pb_0.Image = Properties.Resources.R1;
                    Thread.Sleep(150);
                    break;

                case 1:
                    pb_1.Image = Properties.Resources.Y2;
                    Thread.Sleep(150);
                    pb_1.Image = Properties.Resources.Y1;
                    Thread.Sleep(150);
                    break;

                case 2:
                    pb_2.Image = Properties.Resources.B2;
                    Thread.Sleep(150);
                    pb_2.Image = Properties.Resources.B1;
                    Thread.Sleep(150);
                    break;

                case 3:
                    pb_3.Image = Properties.Resources.G2;
                    Thread.Sleep(150);
                    pb_3.Image = Properties.Resources.G1;
                    Thread.Sleep(150);
                    break;
            }
        }

        talk = false;
    }
    private void verify_Sequence(int btn_pressed)
    {
        if (talk == false && list.Count > 0)
        {
            if (score >= list.Count)
            {
                MessageBox.Show("Game Over! There were not that many sequences");
                score = 0;
                list.Clear();
            }
            else
               if (btn_pressed == list[score])
            {
                score++;
            }
            else
            {
                MessageBox.Show("Game Over! Better Luck Next Time");
                score = 0;
                list.Clear();
            }
        }
    }
    private void btn_Click(object sender, EventArgs e)
    {
        lb_score.Text = "Score: 0";
        list.Clear();
        score = 0;

        list.Add(rand.Next(0, 4));
        new Thread(Simon_Talk).Start();
    }

    private void Submit_Click(object sender, EventArgs e)
    {
        lb_score.Text = "Score: " + score;

        if (score > highScore)
        {
            highScore = score;
            lb_high_score.Text = "High Score: " + highScore;
        }
        list.Add(rand.Next(0, 4));
        new Thread(Simon_Talk).Start();
        score = 0;
    }

    private void pb_0_MouseDown(object sender, MouseEventArgs e)
    {
        pb_0.Image = Properties.Resources.R2;
    }

    private void pb_0_MouseUp(object sender, MouseEventArgs e)
    {
        pb_0.Image = Properties.Resources.R1;
    }
    private void pb_1_MouseDown(object sender, MouseEventArgs e)
    {
        pb_1.Image = Properties.Resources.Y2;
    }

    private void pb_1_MouseUp(object sender, MouseEventArgs e)
    {
        pb_1.Image = Properties.Resources.Y1;
    }

    private void pb_2_MouseDown(object sender, MouseEventArgs e)
    {
        pb_2.Image = Properties.Resources.B2;
    }

    private void pb_2_MouseUp(object sender, MouseEventArgs e)
    {
        pb_2.Image = Properties.Resources.B1;
    }

    private void pb_3_MouseDown(object sender, MouseEventArgs e)
    {
        pb_3.Image = Properties.Resources.G2;
    }

    private void pb_3_MouseUp(object sender, MouseEventArgs e)
    {
        pb_3.Image = Properties.Resources.G1;
    }

    private void pb_Click(object sender, EventArgs e)
    {
        PictureBox pb = (PictureBox)sender;
        //String s = pb.Name.ToString();
        //String[] substring = s.Split('_');
        //int value = int.Parse(substring[1]);
        verify_Sequence(int.Parse(pb.Name.ToString().Split('_')[1]));
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        highScore = int.Parse(lb_high_score.Text.ToString().Split(':')[1]);
        Properties.Settings.Default.saved_value = highScore;
        Properties.Settings.Default.Save();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        highScore = Properties.Settings.Default.saved_value;
        lb_high_score.Text = "High Score: " + highScore;

    }


}