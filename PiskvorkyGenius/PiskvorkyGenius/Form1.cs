using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PiskvorkyGenius
{
    public partial class Form1 : Form
    {

        public int _playArea = 0;
        public int _players = 0;
        public int _body = 5;
        public string _playerName = "";

        public Form1()
        {
            InitializeComponent();
            //počiatočné stavy
            cmbPlayer1.SelectedIndex = 0;
            cmbPlayer2.SelectedIndex = 1;
            cmbPlayer3.SelectedIndex = 2;
            cmbPlayer4.SelectedIndex = 3;
            cmbLenght.SelectedIndex = 1;
            cmbPlayArea.SelectedIndex = 2;
            cmbPocetHracov.SelectedIndex = 0;

        }

        public int GetArenaAray()
        {
            string playArenaText = cmbPlayArea.SelectedItem.ToString();
            return int.Parse(playArenaText.Remove(1));
        }

        public int GetPointsToWin()
        {
            string pointsToWin = cmbLenght.SelectedItem.ToString();
            return int.Parse(pointsToWin);
        }

        public int Players()
        {
            string players = cmbPocetHracov.SelectedItem.ToString();
            return int.Parse(players.Remove(1));
        }

        public int Player1()
        {
            return cmbPlayer1.SelectedIndex;
        }

        public int Player2()
        {
            return cmbPlayer2.SelectedIndex;
        }

        public int Player3()
        {
            return cmbPlayer3.SelectedIndex;
        }

        public int Player4()
        {
            return cmbPlayer4.SelectedIndex;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //vyčistím si plochu
            GridArena.Columns.Clear();
            GridArena.Rows.Clear();
            lblDebug.Text = "";
            lblTick.Text = "";

            //lastmove nastavím na nula
            lastMove = 0;

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
            string tickToWint = cmbLenght.SelectedItem.ToString();
            _body = int.Parse(tickToWint);
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
            //Vynulujem si debug lbl pre ďalšie informácie
            lblDebug.Text ="";

            //nastavím správne body
            string tickToWint = cmbLenght.SelectedItem.ToString();
            _body = int.Parse(tickToWint);


            //Pozerám sa, či políčko je už obsadené
            if (GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                //Ak políčko nie je obsadené, idem ho obsadiť
                switch (lastMove % _players)
                {
                    case 0:
                        {
                            GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cmbPlayer1.SelectedItem;
                            tick = cmbPlayer1.SelectedItem.ToString();
                            _playerName = "1";
                        }
                        break;
                    case 1:
                        {
                            GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cmbPlayer2.SelectedItem;
                            tick = cmbPlayer2.SelectedItem.ToString();
                            _playerName = "2";
                        }
                        break;
                    case 2:
                        {
                            GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cmbPlayer3.SelectedItem;
                            tick = cmbPlayer3.SelectedItem.ToString();
                            _playerName = "3";
                        }
                        break;
                    case 3:
                        {
                            GridArena.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cmbPlayer4.SelectedItem;
                            tick = cmbPlayer4.SelectedItem.ToString();
                            _playerName = "4";
                        }
                        break;
                }

                //obsadenie políčka do logiky
                int RowIndex = e.RowIndex;
                int ColIndex = e.ColumnIndex;
                Logika.AddTick(_playArea, RowIndex, ColIndex, tick);

             //Pozriem sa, či už hráč vyhral
            if (Logika.CheckWin(_playArea, tick, _body))
            {
                lblDebug.ForeColor = Color.Black;
                lblDebug.Text = $"Vyhráva hráč č.{_playerName} so znakom {tick}";
            }

                //posuniem na ďalšieho hráča
                lastMove++;
                lblTick.Text = lastMove.ToString();
            }

            //ošetrenie že dané políčko je už obsadené
            else
            {
                lblDebug.ForeColor = Color.Red;
                lblDebug.Text = "Toto políčko je už obsadené";
            }
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

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            int players = Players();
            int player1 = Player1();
            int player2 = Player2();
            int player3 = Player3();
            int player4 = Player4();
            int lastPlayer = lastMove;
            Export.WriteToTxt(_playArea, _body, players, player1, player2, player3, player4, lastPlayer);
        }

        private void btnLoadFrom_Click(object sender, EventArgs e)
        {
            //Export.ReadFromTxt();

            //vytiahnem si velkost areny z txt
            int velkostAreny = Export.ReadFromTxtLenght();


            //vyčistím si plochu
            GridArena.Columns.Clear();
            GridArena.Rows.Clear();


            //vytvorím si hraciu plochu v datagridview - riadky a stĺpce
            for (int i = 0; i < velkostAreny; i++)
            {
                GridArena.Columns.Add("i", $"{i}");
            }
            for (int i = 0; i < velkostAreny; i++)
            {
                GridArena.Rows.Add();
            }



            //Vytvorím si hraciu plochu do logiky
            Logika.CreateGameboard(Export.ReadFromTxtLenght());


            //naplním si hraciu plochu znakmi vizualne
            for (int i = 0; i < velkostAreny; i++)
            {
                for (int j = 0; j < velkostAreny; j++)
                {
                    //vkladám jednotlivé hodnoty do vizuálneho režimu
                    GridArena.Rows[i].Cells[j].Value = Export.ReadFromTxtTicks(i, j);

                    //vkladám jednotlivé hodnoty do logického režimu
                    Logika.AddTick(i, j, Export.ReadFromTxtTicks(i, j));
                    if (GridArena.Rows[i].Cells[j].Value.ToString() == " ")
                    {
                        GridArena.Rows[i].Cells[j].Value = null;
                        string c = null;
                        Logika.AddTick(i, j, c);
                    }
                }

            }

            //pozriem, ako vyzerá naplnený grid
            Debug.WriteLine("\nNaplnil som vizualne formulár z txt\n");
            for (int i = 0; i < velkostAreny; i++)
            {
                for (int j = 0; j < velkostAreny; j++)
                {
                    Debug.Write($"{i},{j}:{GridArena.Rows[i].Cells[j].Value} ");
                }
                Debug.WriteLine("\n");
            }
            Debug.WriteLine($"Počet riadkov{GridArena.RowCount}\n");

            //predvyplním správne hodnoty na frm
            cmbPlayArea.SelectedIndex = Export.ReadFromTxtLenght()-3;
            cmbLenght.SelectedIndex = Export.ReadFromTxtPoints()-2;
            cmbPocetHracov.SelectedIndex = Export.ReadFromTxtPlayers()-2;
            cmbPlayer1.SelectedIndex = Export.ReadFromTxtPlayer1tick();
            cmbPlayer2.SelectedIndex = Export.ReadFromTxtPlayer2tick();
            cmbPlayer3.SelectedIndex = Export.ReadFromTxtPlayer3tick();
            cmbPlayer4.SelectedIndex = Export.ReadFromTxtPlayer4tick();
            lastMove = Export.ReadFromTxtLastPlayerTick();
            lblTick.Text = Export.ReadFromTxtLastPlayerTick().ToString();




        }
    }
}
