namespace OOP_2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddCompilation = new Button();
            btnAddAlbum = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtResults = new TextBox();
            label1 = new Label();
            cbSearchCategories = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAddCompilation
            // 
            btnAddCompilation.Location = new Point(8, 70);
            btnAddCompilation.Name = "btnAddCompilation";
            btnAddCompilation.Size = new Size(150, 23);
            btnAddCompilation.TabIndex = 0;
            btnAddCompilation.Text = "Создать сборник";
            btnAddCompilation.UseVisualStyleBackColor = true;
            btnAddCompilation.Click += btnAddCompilation_Click;
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.Location = new Point(8, 41);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(150, 23);
            btnAddAlbum.TabIndex = 1;
            btnAddAlbum.Text = "Добавить альбом";
            btnAddAlbum.UseVisualStyleBackColor = true;
            btnAddAlbum.Click += btnAddAlbum_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(385, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(115, 24);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(195, 71);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Введите ваш запрос...";
            txtSearch.Size = new Size(184, 23);
            txtSearch.TabIndex = 3;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(195, 100);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(305, 157);
            txtResults.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(195, 16);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 5;
            label1.Text = "Поиск по каталогу";
            // 
            // cbSearchCategories
            // 
            cbSearchCategories.FormattingEnabled = true;
            cbSearchCategories.Items.AddRange(new object[] { "по песням", "по исполнителям", "по альбомам", "по сборникам" });
            cbSearchCategories.Location = new Point(385, 41);
            cbSearchCategories.Name = "cbSearchCategories";
            cbSearchCategories.Size = new Size(115, 23);
            cbSearchCategories.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 45);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 7;
            label2.Text = "Выберите категорию поиска:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 226);
            label3.Name = "label3";
            label3.Size = new Size(169, 30);
            label3.TabIndex = 8;
            label3.Text = "ООО \"ИТМО-ООП\"\r\n(c) 2024 Права не защищены.\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(16, 16);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 9;
            label4.Text = "Наполнение каталога";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 265);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbSearchCategories);
            Controls.Add(label1);
            Controls.Add(txtResults);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAddAlbum);
            Controls.Add(btnAddCompilation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Каталог музыки 3000";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCompilation;
        private Button btnAddAlbum;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtResults;
        private Label label1;
        private ComboBox cbSearchCategories;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
