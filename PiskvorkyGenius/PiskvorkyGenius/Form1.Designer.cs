namespace PiskvorkyGenius
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridArena = new System.Windows.Forms.DataGridView();
            this.PlayGame = new System.Windows.Forms.Button();
            this.cmbPlayArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPocetHracov = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLenght = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPlayer1 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer2 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer3 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer4 = new System.Windows.Forms.ComboBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridArena)).BeginInit();
            this.SuspendLayout();
            // 
            // GridArena
            // 
            this.GridArena.AllowUserToAddRows = false;
            this.GridArena.AllowUserToDeleteRows = false;
            this.GridArena.AllowUserToResizeColumns = false;
            this.GridArena.AllowUserToResizeRows = false;
            this.GridArena.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridArena.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridArena.ColumnHeadersHeight = 40;
            this.GridArena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridArena.ColumnHeadersVisible = false;
            this.GridArena.Location = new System.Drawing.Point(31, 178);
            this.GridArena.Margin = new System.Windows.Forms.Padding(4);
            this.GridArena.Name = "GridArena";
            this.GridArena.RowHeadersVisible = false;
            this.GridArena.RowTemplate.Height = 40;
            this.GridArena.Size = new System.Drawing.Size(467, 384);
            this.GridArena.TabIndex = 0;
            this.GridArena.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridArena_CellClick);
            this.GridArena.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridArena_CellContentClick);
            this.GridArena.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridArena_CellMouseClick);
            this.GridArena.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridArena_CellMouseUp);
            this.GridArena.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridArena_MouseDoubleClick);
            // 
            // PlayGame
            // 
            this.PlayGame.Location = new System.Drawing.Point(31, 144);
            this.PlayGame.Margin = new System.Windows.Forms.Padding(4);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(468, 26);
            this.PlayGame.TabIndex = 1;
            this.PlayGame.Text = "PlayGame";
            this.PlayGame.UseVisualStyleBackColor = true;
            this.PlayGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbPlayArea
            // 
            this.cmbPlayArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayArea.FormattingEnabled = true;
            this.cmbPlayArea.Items.AddRange(new object[] {
            "3 x 3",
            "4 x 4",
            "5 x 5",
            "6 x 6",
            "7 x 7",
            "8 x 8",
            "9 x 9"});
            this.cmbPlayArea.Location = new System.Drawing.Point(30, 30);
            this.cmbPlayArea.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlayArea.Name = "cmbPlayArea";
            this.cmbPlayArea.Size = new System.Drawing.Size(150, 24);
            this.cmbPlayArea.TabIndex = 2;
            this.cmbPlayArea.SelectedIndexChanged += new System.EventHandler(this.PlayArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veľkosť hracej plochy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbPocetHracov
            // 
            this.cmbPocetHracov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPocetHracov.FormattingEnabled = true;
            this.cmbPocetHracov.Items.AddRange(new object[] {
            "2 hráči",
            "3 hráči",
            "4 hráči"});
            this.cmbPocetHracov.Location = new System.Drawing.Point(185, 30);
            this.cmbPocetHracov.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPocetHracov.Name = "cmbPocetHracov";
            this.cmbPocetHracov.Size = new System.Drawing.Size(150, 24);
            this.cmbPocetHracov.TabIndex = 4;
            this.cmbPocetHracov.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Počet hráčov";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbLenght
            // 
            this.cmbLenght.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLenght.FormattingEnabled = true;
            this.cmbLenght.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbLenght.Location = new System.Drawing.Point(340, 30);
            this.cmbLenght.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLenght.Name = "cmbLenght";
            this.cmbLenght.Size = new System.Drawing.Size(150, 24);
            this.cmbLenght.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Počet zaškrtnutí";
            // 
            // cmbPlayer1
            // 
            this.cmbPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1.FormattingEnabled = true;
            this.cmbPlayer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbPlayer1.Items.AddRange(new object[] {
            "X",
            "○",
            "♥",
            "■"});
            this.cmbPlayer1.Location = new System.Drawing.Point(30, 100);
            this.cmbPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlayer1.Name = "cmbPlayer1";
            this.cmbPlayer1.Size = new System.Drawing.Size(100, 24);
            this.cmbPlayer1.TabIndex = 11;
            this.cmbPlayer1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbPlayer2
            // 
            this.cmbPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2.FormattingEnabled = true;
            this.cmbPlayer2.Items.AddRange(new object[] {
            "X",
            "○",
            "♥",
            "■"});
            this.cmbPlayer2.Location = new System.Drawing.Point(150, 100);
            this.cmbPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlayer2.Name = "cmbPlayer2";
            this.cmbPlayer2.Size = new System.Drawing.Size(100, 24);
            this.cmbPlayer2.TabIndex = 12;
            this.cmbPlayer2.Visible = false;
            // 
            // cmbPlayer3
            // 
            this.cmbPlayer3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer3.FormattingEnabled = true;
            this.cmbPlayer3.Items.AddRange(new object[] {
            "X",
            "○",
            "♥",
            "■"});
            this.cmbPlayer3.Location = new System.Drawing.Point(270, 100);
            this.cmbPlayer3.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlayer3.Name = "cmbPlayer3";
            this.cmbPlayer3.Size = new System.Drawing.Size(100, 24);
            this.cmbPlayer3.TabIndex = 13;
            this.cmbPlayer3.Visible = false;
            // 
            // cmbPlayer4
            // 
            this.cmbPlayer4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer4.FormattingEnabled = true;
            this.cmbPlayer4.Items.AddRange(new object[] {
            "X",
            "○",
            "♥",
            "■"});
            this.cmbPlayer4.Location = new System.Drawing.Point(390, 100);
            this.cmbPlayer4.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlayer4.Name = "cmbPlayer4";
            this.cmbPlayer4.Size = new System.Drawing.Size(100, 24);
            this.cmbPlayer4.TabIndex = 14;
            this.cmbPlayer4.Visible = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(28, 79);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(50, 17);
            this.lblPlayer1.TabIndex = 15;
            this.lblPlayer1.Text = "Hráč 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(147, 79);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(50, 17);
            this.lblPlayer2.TabIndex = 16;
            this.lblPlayer2.Text = "Hráč 2";
            this.lblPlayer2.Visible = false;
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Location = new System.Drawing.Point(267, 79);
            this.lblPlayer3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(50, 17);
            this.lblPlayer3.TabIndex = 17;
            this.lblPlayer3.Text = "Hráč 3";
            this.lblPlayer3.Visible = false;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Location = new System.Drawing.Point(387, 79);
            this.lblPlayer4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(50, 17);
            this.lblPlayer4.TabIndex = 18;
            this.lblPlayer4.Text = "Hráč 4";
            this.lblPlayer4.Visible = false;
            this.lblPlayer4.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDebug.Location = new System.Drawing.Point(28, 587);
            this.lblDebug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(20, 29);
            this.lblDebug.TabIndex = 19;
            this.lblDebug.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 648);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.cmbPlayer4);
            this.Controls.Add(this.cmbPlayer3);
            this.Controls.Add(this.cmbPlayer2);
            this.Controls.Add(this.cmbPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLenght);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPocetHracov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlayArea);
            this.Controls.Add(this.PlayGame);
            this.Controls.Add(this.GridArena);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piškvorky Genius";
            ((System.ComponentModel.ISupportInitialize)(this.GridArena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridArena;
        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.ComboBox cmbPlayArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPocetHracov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLenght;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPlayer1;
        private System.Windows.Forms.ComboBox cmbPlayer2;
        private System.Windows.Forms.ComboBox cmbPlayer3;
        private System.Windows.Forms.ComboBox cmbPlayer4;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Label lblDebug;
    }
}

