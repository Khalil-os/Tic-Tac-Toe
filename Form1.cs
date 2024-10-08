using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        int[] Col1 = { -1, -1, -1 };
        int[] Col2 = { -1, -1, -1 };
        int[] Col3 = { -1, -1, -1 };

        int NumberOfWinForPlayer1 = 0;
        int NumberOfWinForPlayer2 = 0;
        int NumberOfDraw = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberWins()
        {
            if(lbWiner.Text == "Player 1")
            {
                NumberOfWinForPlayer1++;
                lbNWP1.Text = NumberOfWinForPlayer1.ToString();
            }
            else if(lbWiner.Text == "Player 2")
            {
                NumberOfWinForPlayer2++;
                lbNWP2.Text = NumberOfWinForPlayer2.ToString();
            }
            else if(lbWiner.Text == "Draw")
            {
                NumberOfDraw++;
                lbNDraw.Text = NumberOfDraw.ToString();
            }
        }

        private void CheckWiner()
        {
            if (Col1[0] == 1 && Col1[1] == 1 && Col1[2] == 1)
            {
                Col11.BackColor = Color.Lime;
                Col12.BackColor = Color.Lime;
                Col13.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 1";
                lbTurn.Text = "Game Over";
            }
            else if (Col2[0] == 1 && Col2[1] == 1 && Col2[2] == 1)
            {
                Col21.BackColor = Color.Lime;
                Col22.BackColor = Color.Lime;
                Col23.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 1";
                lbTurn.Text = "Game Over";

            }
            else if (Col3[0] == 1 && Col3[1] == 1 && Col3[2] == 1)
            {
                Col31.BackColor = Color.Lime;
                Col32.BackColor = Color.Lime;
                Col33.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 1";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[0] == 1 && Col2[1] == 1 && Col3[2] == 1)
            {
                Col11.BackColor = Color.Lime;
                Col22.BackColor = Color.Lime;
                Col33.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 1";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[2] == 1 && Col2[1] == 1 && Col3[0] == 1)
            {
                Col13.BackColor = Color.Lime;
                Col22.BackColor = Color.Lime;
                Col31.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 1";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[0] == 1 && Col2[0] == 1 && Col3[0] == 1)
            {
                Col11.BackColor = Color.Lime;
                Col21.BackColor = Color.Lime;
                Col31.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 1";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[1] == 1 && Col2[1] == 1 && Col3[1] == 1)
            {
                Col12.BackColor = Color.Lime;
                Col22.BackColor = Color.Lime;
                Col32.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 1";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[2] == 1 && Col2[2] == 1 && Col3[2] == 1)
            {
                Col13.BackColor = Color.Lime;
                Col13.BackColor = Color.Lime;
                Col33.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 1";
                lbTurn.Text = "Game Over";

            }

            else if (Col1[0] == 2 && Col1[1] == 2 && Col1[2] == 2)
            {
                Col11.BackColor = Color.Lime;
                Col12.BackColor = Color.Lime;
                Col13.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 2";
                lbTurn.Text = "Game Over";

            }
            else if (Col2[0] == 2 && Col2[1] == 2 && Col2[2] == 2)
            {
                Col21.BackColor = Color.Lime;
                Col22.BackColor = Color.Lime;
                Col23.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 2";
                lbTurn.Text = "Game Over";

            }
            else if (Col3[0] == 2 && Col3[1] == 2 && Col3[2] == 2)
            {
                Col31.BackColor = Color.Lime;
                Col32.BackColor = Color.Lime;
                Col33.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 2";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[0] == 2 && Col2[1] == 2 && Col3[2] == 2)
            {
                Col11.BackColor = Color.Lime;
                Col22.BackColor = Color.Lime;
                Col33.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 2";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[2] == 2 && Col2[1] == 2 && Col3[0] == 2)
            {
                Col13.BackColor = Color.Lime;
                Col22.BackColor = Color.Lime;
                Col31.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 2";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[0] == 2 && Col2[0] == 2 && Col3[0] == 2)
            {
                Col11.BackColor = Color.Lime;
                Col21.BackColor = Color.Lime;
                Col31.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 2";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[1] == 2 && Col2[1] == 2 && Col3[1] == 2)
            {
                Col12.BackColor = Color.Lime;
                Col22.BackColor = Color.Lime;
                Col32.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 2";
                lbTurn.Text = "Game Over";

            }
            else if (Col1[2] == 2 && Col2[2] == 2 && Col3[2] == 2)
            {
                Col13.BackColor = Color.Lime;
                Col13.BackColor = Color.Lime;
                Col33.BackColor = Color.Lime;
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Player 2";
                lbTurn.Text = "Game Over";

            }

            else if(
                Col1[0] != -1 && Col1[1] != -1 && Col1[2] != -1 &&
                Col2[0] != -1 && Col2[1] != -1 && Col2[2] != -1 &&
                Col3[0] != -1 && Col3[1] != -1 && Col3[2] != -1 
                )
            {
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWiner.Text = "Draw";
                lbTurn.Text = "Game Over";
            }
            NumberWins();
        }

        private void Restart()
        {
            for (byte i = 0; i <= 2; i++)
            {
                Col1[i] = -1;
                Col2[i] = -1;
                Col3[i] = -1;
            }
            Col11.Image = Resources.question_mark_96;
            Col11.BackColor = Color.Black;
            Col12.Image = Resources.question_mark_96;
            Col12.BackColor = Color.Black;
            Col13.Image = Resources.question_mark_96;
            Col13.BackColor = Color.Black;
            Col21.Image = Resources.question_mark_96;
            Col21.BackColor = Color.Black;
            Col22.Image = Resources.question_mark_96;
            Col22.BackColor = Color.Black;
            Col23.Image = Resources.question_mark_96;
            Col23.BackColor = Color.Black;
            Col31.Image = Resources.question_mark_96;
            Col31.BackColor = Color.Black;
            Col32.Image = Resources.question_mark_96;
            Col32.BackColor = Color.Black;
            Col33.Image = Resources.question_mark_96;
            Col33.BackColor = Color.Black;
            lbTurn.Text = "Player 1";
            lbWiner.Text = "In Progress";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White);

            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 400, 150, 400, 460);
            e.Graphics.DrawLine(Pen, 600, 150, 600, 460);

            e.Graphics.DrawLine(Pen, 250, 250, 750, 250);
            e.Graphics.DrawLine(Pen, 250, 370, 750, 370);

        }

        private void Col11_Click(object sender, EventArgs e)
        {
            if (Col1[0] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col11.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col1[0] = 1;
                }
                else if(lbTurn.Text == "Player 2")
                {
                    Col11.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col1[0] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice" , "Wrong" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Col12_Click(object sender, EventArgs e)
        {
            if (Col1[1] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col12.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col1[1] = 1;
                }
                else if (lbTurn.Text == "Player 2")
                {
                    Col12.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col1[1] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Col13_Click(object sender, EventArgs e)
        {
            if (Col1[2] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col13.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col1[2] = 1;
                }
                else if (lbTurn.Text == "Player 2")
                {
                    Col13.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col1[2] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Col21_Click(object sender, EventArgs e)
        {
            if (Col2[0] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col21.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col2[0] = 1;
                }
                else if (lbTurn.Text == "Player 2")
                {
                    Col21.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col2[0] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Col22_Click(object sender, EventArgs e)
        {
            if (Col2[1] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col22.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col2[1] = 1;
                }
                else if (lbTurn.Text == "Player 2")
                {
                    Col22.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col2[1] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Col23_Click(object sender, EventArgs e)
        {
            if (Col2[2] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col23.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col2[2] = 1;
                }
                else if (lbTurn.Text == "Player 2")
                {
                    Col23.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col2[2] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Col31_Click(object sender, EventArgs e)
        {
            if (Col3[0] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col31.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col3[0] = 1;
                }
                else if (lbTurn.Text == "Player 2")
                {
                    Col31.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col3[0] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Col32_Click(object sender, EventArgs e)
        {
            if (Col3[1] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col32.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col3[1] = 1;
                }
                else if (lbTurn.Text == "Player 2")
                {
                    Col32.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col3[1] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Col33_Click(object sender, EventArgs e)
        {
            if (Col3[2] == -1)
            {
                if (lbTurn.Text == "Player 1")
                {
                    Col33.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    Col3[2] = 1;
                }
                else if (lbTurn.Text == "Player 2")
                {
                    Col33.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    Col3[2] = 2;
                }
                CheckWiner();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restart();
        }

    }
}
