namespace OOP_2
{
    partial class AlbumCreationForm
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
            txtAlbumTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtArtistName = new TextBox();
            cbAlbumGenre = new ComboBox();
            label3 = new Label();
            btnCreateAlbum = new Button();
            label4 = new Label();
            btnAddSong = new Button();
            txtSongTitle = new TextBox();
            btnSaveAlbum = new Button();
            SuspendLayout();
            // 
            // txtAlbumTitle
            // 
            txtAlbumTitle.Location = new Point(12, 27);
            txtAlbumTitle.Name = "txtAlbumTitle";
            txtAlbumTitle.Size = new Size(128, 23);
            txtAlbumTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Название альбома";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Исполнитель";
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(146, 27);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(128, 23);
            txtArtistName.TabIndex = 3;
            // 
            // cbAlbumGenre
            // 
            cbAlbumGenre.FormattingEnabled = true;
            cbAlbumGenre.Location = new Point(280, 27);
            cbAlbumGenre.Name = "cbAlbumGenre";
            cbAlbumGenre.Size = new Size(121, 23);
            cbAlbumGenre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 9);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Жанр";
            // 
            // btnCreateAlbum
            // 
            btnCreateAlbum.Location = new Point(252, 56);
            btnCreateAlbum.Name = "btnCreateAlbum";
            btnCreateAlbum.Size = new Size(149, 23);
            btnCreateAlbum.TabIndex = 6;
            btnCreateAlbum.Text = "Создать альбом";
            btnCreateAlbum.UseVisualStyleBackColor = true;
            btnCreateAlbum.Click += btnCreateAlbum_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 99);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 7;
            label4.Text = "Название песни";
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new Point(326, 95);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(75, 23);
            btnAddSong.TabIndex = 8;
            btnAddSong.Text = "Добавить";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // txtSongTitle
            // 
            txtSongTitle.Location = new Point(146, 95);
            txtSongTitle.Name = "txtSongTitle";
            txtSongTitle.Size = new Size(174, 23);
            txtSongTitle.TabIndex = 9;
            // 
            // btnSaveAlbum
            // 
            btnSaveAlbum.Location = new Point(252, 128);
            btnSaveAlbum.Name = "btnSaveAlbum";
            btnSaveAlbum.Size = new Size(149, 23);
            btnSaveAlbum.TabIndex = 10;
            btnSaveAlbum.Text = "Завершить и сохранить";
            btnSaveAlbum.UseVisualStyleBackColor = true;
            btnSaveAlbum.Click += btnSaveAlbum_Click;
            // 
            // AlbumCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 160);
            Controls.Add(btnSaveAlbum);
            Controls.Add(txtSongTitle);
            Controls.Add(btnAddSong);
            Controls.Add(label4);
            Controls.Add(btnCreateAlbum);
            Controls.Add(label3);
            Controls.Add(cbAlbumGenre);
            Controls.Add(txtArtistName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAlbumTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AlbumCreationForm";
            Text = "Добавление альбома";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAlbumTitle;
        private Label label1;
        private Label label2;
        private TextBox txtArtistName;
        private ComboBox cbAlbumGenre;
        private Label label3;
        private Button btnCreateAlbum;
        private Label label4;
        private Button btnAddSong;
        private TextBox txtSongTitle;
        private Button btnSaveAlbum;
    }
}