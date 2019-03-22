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
            this.PocetHracovVypis = new System.Windows.Forms.Label();
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
            this.GridArena.ColumnHeadersHeight = 30;
            this.GridArena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridArena.ColumnHeadersVisible = false;
            this.GridArena.Location = new System.Drawing.Point(23, 100);
            this.GridArena.Name = "GridArena";
            this.GridArena.RowHeadersVisible = false;
            this.GridArena.RowTemplate.Height = 30;
            this.GridArena.Size = new System.Drawing.Size(350, 312);
            this.GridArena.TabIndex = 0;
            this.GridArena.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridArena_CellClick);
            this.GridArena.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridArena_CellContentClick);
            this.GridArena.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridArena_CellMouseClick);
            this.GridArena.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridArena_CellMouseUp);
            this.GridArena.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridArena_MouseDoubleClick);
            // 
            // PlayGame
            // 
            this.PlayGame.Location = new System.Drawing.Point(299, 25);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(75, 21);
            this.PlayGame.TabIndex = 1;
            this.PlayGame.Text = "PlayGame";
            this.PlayGame.UseVisualStyleBackColor = true;
            this.PlayGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbPlayArea
            // 
            this.cmbPlayArea.FormattingEnabled = true;
            this.cmbPlayArea.Items.AddRange(new object[] {
            "3 x 3",
            "4 x 4",
            "5 x 5",
            "6 x 6",
            "7 x 7",
            "8 x 8",
            "9 x 9"});
            this.cmbPlayArea.Location = new System.Drawing.Point(23, 25);
            this.cmbPlayArea.Name = "cmbPlayArea";
            this.cmbPlayArea.Size = new System.Drawing.Size(130, 21);
            this.cmbPlayArea.TabIndex = 2;
            this.cmbPlayArea.Text = "Vyber si z ponuky";
            this.cmbPlayArea.SelectedIndexChanged += new System.EventHandler(this.PlayArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veľkosť hracej plochy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbPocetHracov
            // 
            this.cmbPocetHracov.FormattingEnabled = true;
            this.cmbPocetHracov.Items.AddRange(new object[] {
            "2 hráči",
            "3 hráči",
            "4 hráči"});
            this.cmbPocetHracov.Location = new System.Drawing.Point(163, 25);
            this.cmbPocetHracov.Name = "cmbPocetHracov";
            this.cmbPocetHracov.Size = new System.Drawing.Size(130, 21);
            this.cmbPocetHracov.TabIndex = 4;
            this.cmbPocetHracov.Text = "Vyber si z ponuky";
            this.cmbPocetHracov.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Počet hráčov";
            // 
            // PocetHracovVypis
            // 
            this.PocetHracovVypis.AutoSize = true;
            this.PocetHracovVypis.Location = new System.Drawing.Point(163, 53);
            this.PocetHracovVypis.Name = "PocetHracovVypis";
            this.PocetHracovVypis.Size = new System.Drawing.Size(0, 13);
            this.PocetHracovVypis.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PocetHracovVypis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPocetHracov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlayArea);
            this.Controls.Add(this.PlayGame);
            this.Controls.Add(this.GridArena);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label PocetHracovVypis;
    }
}

