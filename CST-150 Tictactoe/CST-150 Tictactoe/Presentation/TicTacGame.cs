using CST_150_Tictactoe.Business;
namespace CST_150_Tictactoe
{
    public partial class TicTacGame : Form
    {
        Logic game = new Logic();

        bool playerXTurn = true;
        bool playerOTurn = true;
        public TicTacGame()
        {
            InitializeComponent();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            playerXTurn = true;

            // clear board 
            game.ResetBoard();

            lblBox1.Text = "";
            lblBox2.Text = "";
            lblBox3.Text = "";
            lblBox4.Text = "";
            lblBox5.Text = "";
            lblBox6.Text = "";
            lblBox7.Text = "";
            lblBox8.Text = "";
            lblBox9.Text = "";

            lblmsg.Text = "Player X Turn";
        }


            private void Playmove(Label box, int r, int c)
        {
            if (box.Text != "")
                return;

            if (playerXTurn)
            {
                box.Text = "X";
                game.board[r, c] = 1;
            }
            else
            {
                box.Text = "O";
                game.board[r, c] = 0;
            }

            // check winner
            int winner = game.CheckWinner();

            if (winner == 1)
            {
                lblmsg.Text = "Player X Wins!";
                MessageBox.Show("Player X Wins!");
                return;
            }
            else if (winner == 0)
            {
                lblmsg.Text = "Player O Wins!";
                MessageBox.Show("Player O Wins!");
                return;
            }

            // switch turns
            playerXTurn = !playerXTurn;

            if (playerXTurn)
                lblmsg.Text = "Player X Turn";
            else
                lblmsg.Text = "Player O Turn";
        }

        

        private void lblBox1_Click(object sender, EventArgs e)
        {
            Playmove(lblBox1, 0, 0);
        }

        private void lblBox2_Click(object sender, EventArgs e)
        {
            Playmove(lblBox2, 0, 1);
        }

        private void lblBox3_Click(object sender, EventArgs e)
        {
            Playmove(lblBox3, 0, 2);
        }

        private void lblBox4_Click(object sender, EventArgs e)
        {
            Playmove(lblBox4, 1, 0);
        }

        private void lblBox5_Click(object sender, EventArgs e)
        {
            Playmove(lblBox5, 1, 1);
        }

        private void lblBox6_Click(object sender, EventArgs e)
        {
            Playmove(lblBox6, 1, 2);
        }

        private void lblBox7_Click(object sender, EventArgs e)
        {
            Playmove(lblBox7, 2, 0);
        }

        private void lblBox8_Click(object sender, EventArgs e)
        {
            Playmove(lblBox8, 2, 1);
        }

        private void lblBox9_Click(object sender, EventArgs e)
        {
            Playmove(lblBox9, 2, 2);
        }
    }
}
