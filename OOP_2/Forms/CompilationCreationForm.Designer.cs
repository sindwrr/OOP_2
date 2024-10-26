namespace OOP_2
{
    partial class CompilationCreationForm
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
            btnCreateCompilation = new Button();
            txtCompilationTitle = new TextBox();
            label1 = new Label();
            cbAlbums = new ComboBox();
            cbSongs = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnAddSong = new Button();
            btnSaveCompilation = new Button();
            SuspendLayout();
            // 
            // btnCreateCompilation
            // 
            btnCreateCompilation.Location = new Point(319, 27);
            btnCreateCompilation.Name = "btnCreateCompilation";
            btnCreateCompilation.Size = new Size(113, 23);
            btnCreateCompilation.TabIndex = 0;
            btnCreateCompilation.Text = "Создать сборник";
            btnCreateCompilation.UseVisualStyleBackColor = true;
            btnCreateCompilation.Click += btnCreateCompilation_Click;
            // 
            // txtCompilationTitle
            // 
            txtCompilationTitle.Location = new Point(12, 27);
            txtCompilationTitle.Name = "txtCompilationTitle";
            txtCompilationTitle.Size = new Size(301, 23);
            txtCompilationTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 2;
            label1.Text = "Название сборника";
            // 
            // cbAlbums
            // 
            cbAlbums.FormattingEnabled = true;
            cbAlbums.Location = new Point(12, 82);
            cbAlbums.Name = "cbAlbums";
            cbAlbums.Size = new Size(157, 23);
            cbAlbums.TabIndex = 3;
            cbAlbums.SelectedIndexChanged += cbAlbums_SelectedIndexChanged;
            // 
            // cbSongs
            // 
            cbSongs.FormattingEnabled = true;
            cbSongs.Location = new Point(175, 82);
            cbSongs.Name = "cbSongs";
            cbSongs.Size = new Size(157, 23);
            cbSongs.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Альбом";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 64);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Песня";
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new Point(338, 82);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(98, 23);
            btnAddSong.TabIndex = 7;
            btnAddSong.Text = "Добавить";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // btnSaveCompilation
            // 
            btnSaveCompilation.Location = new Point(279, 121);
            btnSaveCompilation.Name = "btnSaveCompilation";
            btnSaveCompilation.Size = new Size(153, 23);
            btnSaveCompilation.TabIndex = 8;
            btnSaveCompilation.Text = "Завершить и сохранить";
            btnSaveCompilation.UseVisualStyleBackColor = true;
            btnSaveCompilation.Click += btnSaveCompilation_Click;
            // 
            // CompilationCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 156);
            Controls.Add(btnSaveCompilation);
            Controls.Add(btnAddSong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbSongs);
            Controls.Add(cbAlbums);
            Controls.Add(label1);
            Controls.Add(txtCompilationTitle);
            Controls.Add(btnCreateCompilation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CompilationCreationForm";
            Text = "Создание сборника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateCompilation;
        private TextBox txtCompilationTitle;
        private Label label1;
        private ComboBox cbAlbums;
        private ComboBox cbSongs;
        private Label label2;
        private Label label3;
        private Button btnAddSong;
        private Button btnSaveCompilation;
    }
}