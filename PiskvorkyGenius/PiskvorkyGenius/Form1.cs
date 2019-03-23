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

        public int _playArea = 0;
        public int _players = 0;
        public int _body = 5;

        public Form1()
        {
            InitializeComponent();
            //počiatočné stavy
            cmbPlayer1.SelectedIndex = 0;
            cmbPlayer2.SelectedIndex = 1;
            cmbPlayer3.SelectedIndex = 2;
            cmbPlayer4.SelectedIndex = 3;
            cmbLenght.SelectedIndex = 1;
            cmbPlayArea.SelectedIndex = 0;
            cmbPocetHracov.SelectedIndex = 0;

        }

        public int GetArenaAray()
        {
            string playArenaText = cmbPlayArea.SelectedItem.ToString();
            return int.Parse(playArenaText.Remove(1));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //vyčistím si plochu
            GridArena.Columns.Clear();
            GridArena.Rows.Clear();

            //vytiahnem si veľkosť plochy
            string playArenaText = cmbPlayArea.SelectedItem.ToString();
            int _playArea = int.Parse(playArenaText.Remove(1));

            //vytvorím si hraciu plochu v datagridview
            for (int i = 0; i < _playArea; i++)
            {
                GridArena.Columns.Add("i", $"{i}");
            }
            for (int i = 0; i < _playArea; i++)
            {
                GridArena.Rows.Add();
            }

            //vytvorím si plochu v logike
            Logika.CreateGameboard(_playArea);

            //vytiahnem si na koľko sa má vyhrať
            // int body = int.Parse(cmbLenght.SelectedItem.ToString());  // nefunguje - spýtat sa
            string tickToWint = cmbLenght.SelectedItem.ToString();
            _body = int.Parse(tickToWint);

            //pre istotu si to zapíšem
            lblDebug.Text = _playArea.ToString();
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

            switch (_players)
            {

                case 2:
                    lblPlayer2.Visible = true;
                    lblPlayer3.Visible = false;
                    lblPlayer4.Visible = false;
                    cmbPlayer2.Visible = true;
                    cmbPlayer3.Visible = false;
                    cmbPlayer4.Visible = false;
                    break;
                case 3:
                    lblPlayer2.Visible = true;
                    lblPlayer3.Visible = true;
                    lblPlayer4.Visible = false;
                    cmbPlayer2.Visible = true;
                    cmbPlayer3.Visible = true;
                    cmbPlayer4.Visible = false;
                    break;
                case 4:
                    lblPlayer2.Visible = true;
                    lblPlayer3.Visible = true;
                    lblPlayer4.Visible = true;
                    cmbPlayer2.Visible = true;
                    cmbPlayer3.Visible = true;
                    cmbPlayer4.Visible = true;
                    break;
            }
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

        string tick;
        public int lastMove = 0;
        public int RowIndex = 0;
        public int ColIndex = 0;
        private void GridArena_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (lastMove % _players)
            {
                case 0:
                    { 
                    GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cmbPlayer1.SelectedItem;
                        tick = cmbPlayer1.SelectedItem.ToString();
                    }
                    break;
                case 1:
                    {
                        GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cmbPlayer2.SelectedItem;
                        tick = cmbPlayer2.SelectedItem.ToString();
                    }
                    break;
                case 2:
                    {
                        GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cmbPlayer3.SelectedItem;
                        tick = cmbPlayer3.SelectedItem.ToString();
                    }
                    break;
                case 3:
                    {
                        GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cmbPlayer4.SelectedItem;
                        tick = cmbPlayer4.SelectedItem.ToString();
                    }
                    break;
            }
            lastMove++;
            int RowIndex = e.RowIndex;
            int ColIndex = e.ColumnIndex;
            Logika.AddTick(_playArea, RowIndex, ColIndex, tick);
            lblDebug.Text = Logika.CheckWin(_playArea,tick, _body).ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
