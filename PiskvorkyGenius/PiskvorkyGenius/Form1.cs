using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiskvorkyGenius
{
    public partial class Form1 : Form
    {

        private int _playArea = 0;
        private int _players = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridArena.Columns.Clear();
            GridArena.Rows.Clear();
            string playArenaText = cmbPlayArea.SelectedItem.ToString();
            int playArena = int.Parse(playArenaText.Remove(1));
            for (int i = 0; i < playArena; i++)
            {
                GridArena.Columns.Add("i", $"{i}");
            }
            for (int i = 0; i < playArena; i++)
            {
                GridArena.Rows.Add();
            }
            Logika.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string playArenaText = cmbPlayArea.SelectedItem.ToString();
            _playArea = int.Parse(playArenaText.Remove(1));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PlayersText = cmbPocetHracov.SelectedItem.ToString();
            _players = int.Parse(PlayersText.Remove(1));
            PocetHracovVypis.Text = _players.ToString();
        }

        private void GridArena_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridArena_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void GridArena_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void GridArena_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        public int lastMove = 0; 
        private void GridArena_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (lastMove % _players)
            {
                case 0:
                    { 
                    GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "X";
                    }
                    break;
                case 1:
                    {
                        GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "O";
                    }
                    break;
                case 2:
                    {
                        GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "♥";
                    }
                    break;
                case 3:
                    {
                        GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "☻";
                    }
                    break;
            }
            lastMove++;
        }
    }
}
