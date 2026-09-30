namespace stajProjesi_29_09
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.drop = new System.Windows.Forms.Label();
            this.buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.browse = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.TableLayoutPanel();
            this.files = new System.Windows.Forms.ListBox();
            this.results = new System.Windows.Forms.TableLayoutPanel();
            this.summary = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.wordTab = new System.Windows.Forms.TabPage();
            this.words = new System.Windows.Forms.DataGridView();
            this.punctuationTab = new System.Windows.Forms.TabPage();
            this.punctuation = new System.Windows.Forms.DataGridView();
            this.layout.SuspendLayout();
            this.buttons.SuspendLayout();
            this.content.SuspendLayout();
            this.results.SuspendLayout();
            this.tabs.SuspendLayout();
            this.wordTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.words)).BeginInit();
            this.punctuationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punctuation)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.title, 0, 0);
            this.layout.Controls.Add(this.drop, 0, 1);
            this.layout.Controls.Add(this.buttons, 0, 2);
            this.layout.Controls.Add(this.content, 0, 3);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layout.Name = "layout";
            this.layout.Padding = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.layout.RowCount = 5;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layout.Size = new System.Drawing.Size(1250, 812);
            this.layout.TabIndex = 0;
            this.layout.Paint += new System.Windows.Forms.PaintEventHandler(this.layout_Paint);
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(29, 25);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1192, 56);
            this.title.TabIndex = 1;
            this.title.Text = "Dosya Analizi";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // drop
            // 
            this.drop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(251)))));
            this.drop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drop.Location = new System.Drawing.Point(29, 81);
            this.drop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drop.Name = "drop";
            this.drop.Size = new System.Drawing.Size(1192, 125);
            this.drop.TabIndex = 2;
            this.drop.Text = "Dosyalarınızı buraya sürükleyip bırakın\nTXT ve DOCX • Birden fazla dosya ekleyebi" +
    "lirsiniz";
            this.drop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drop.Click += new System.EventHandler(this.drop_Click);
            // 
            // buttons
            // 
            this.buttons.Controls.Add(this.browse);
            this.buttons.Controls.Add(this.clear);
            this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons.Location = new System.Drawing.Point(29, 210);
            this.buttons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttons.Name = "buttons";
            this.buttons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.buttons.Size = new System.Drawing.Size(1192, 48);
            this.buttons.TabIndex = 3;
            // 
            // browse
            // 
            this.browse.AutoSize = true;
            this.browse.Location = new System.Drawing.Point(4, 12);
            this.browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(110, 33);
            this.browse.TabIndex = 4;
            this.browse.Text = "Dosya seç…";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.BrowseClicked);
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Location = new System.Drawing.Point(122, 12);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(126, 33);
            this.clear.TabIndex = 5;
            this.clear.Text = "Listeyi temizle";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.ClearClicked);
            // 
            // content
            // 
            this.content.ColumnCount = 2;
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.content.Controls.Add(this.files, 0, 0);
            this.content.Controls.Add(this.results, 1, 0);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(29, 266);
            this.content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.content.Name = "content";
            this.content.RowCount = 1;
            this.content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.content.Size = new System.Drawing.Size(1192, 467);
            this.content.TabIndex = 6;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // files
            // 
            this.files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.files.HorizontalScrollbar = true;
            this.files.IntegralHeight = false;
            this.files.ItemHeight = 23;
            this.files.Location = new System.Drawing.Point(4, 4);
            this.files.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(373, 459);
            this.files.TabIndex = 7;
            this.files.SelectedIndexChanged += new System.EventHandler(this.FilesSelectedIndexChanged);
            // 
            // results
            // 
            this.results.ColumnCount = 1;
            this.results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.results.Controls.Add(this.summary, 0, 0);
            this.results.Controls.Add(this.tabs, 0, 1);
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results.Location = new System.Drawing.Point(385, 4);
            this.results.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.results.Name = "results";
            this.results.RowCount = 2;
            this.results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.results.Size = new System.Drawing.Size(803, 459);
            this.results.TabIndex = 8;
            // 
            // summary
            // 
            this.summary.AutoEllipsis = true;
            this.summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summary.Location = new System.Drawing.Point(4, 0);
            this.summary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.summary.Name = "summary";
            this.summary.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.summary.Size = new System.Drawing.Size(795, 119);
            this.summary.TabIndex = 9;
            this.summary.Text = "Analiz sonuçlarını görmek için dosya ekleyin.\nKelime sıklığında bağlaçlar ve sayı" +
    "lar hariçtir.";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.wordTab);
            this.tabs.Controls.Add(this.punctuationTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(4, 123);
            this.tabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(795, 332);
            this.tabs.TabIndex = 10;
            // 
            // wordTab
            // 
            this.wordTab.Controls.Add(this.words);
            this.wordTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordTab.Location = new System.Drawing.Point(4, 32);
            this.wordTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordTab.Name = "wordTab";
            this.wordTab.Size = new System.Drawing.Size(787, 296);
            this.wordTab.TabIndex = 11;
            this.wordTab.Text = "Kelime sıklığı (azalan)";
            this.wordTab.UseVisualStyleBackColor = true;
            // 
            // words
            // 
            this.words.AllowUserToAddRows = false;
            this.words.AllowUserToDeleteRows = false;
            this.words.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.words.BackgroundColor = System.Drawing.Color.White;
            this.words.ColumnHeadersHeight = 29;
            this.words.Dock = System.Windows.Forms.DockStyle.Fill;
            this.words.Location = new System.Drawing.Point(0, 0);
            this.words.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.words.Name = "words";
            this.words.ReadOnly = true;
            this.words.RowHeadersVisible = false;
            this.words.RowHeadersWidth = 51;
            this.words.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.words.Size = new System.Drawing.Size(787, 296);
            this.words.TabIndex = 12;
            // 
            // punctuationTab
            // 
            this.punctuationTab.Controls.Add(this.punctuation);
            this.punctuationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.punctuationTab.Location = new System.Drawing.Point(4, 32);
            this.punctuationTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.punctuationTab.Name = "punctuationTab";
            this.punctuationTab.Size = new System.Drawing.Size(108, 0);
            this.punctuationTab.TabIndex = 13;
            this.punctuationTab.Text = "Noktalama dökümü";
            this.punctuationTab.UseVisualStyleBackColor = true;
            // 
            // punctuation
            // 
            this.punctuation.AllowUserToAddRows = false;
            this.punctuation.AllowUserToDeleteRows = false;
            this.punctuation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.punctuation.BackgroundColor = System.Drawing.Color.White;
            this.punctuation.ColumnHeadersHeight = 29;
            this.punctuation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.punctuation.Location = new System.Drawing.Point(0, 0);
            this.punctuation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.punctuation.Name = "punctuation";
            this.punctuation.ReadOnly = true;
            this.punctuation.RowHeadersVisible = false;
            this.punctuation.RowHeadersWidth = 51;
            this.punctuation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.punctuation.Size = new System.Drawing.Size(108, 0);
            this.punctuation.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1250, 812);
            this.Controls.Add(this.layout);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(970, 638);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSE • Dosya Analizi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.layout.ResumeLayout(false);
            this.buttons.ResumeLayout(false);
            this.buttons.PerformLayout();
            this.content.ResumeLayout(false);
            this.results.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.wordTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.words)).EndInit();
            this.punctuationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.punctuation)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label drop;
        private System.Windows.Forms.FlowLayoutPanel buttons;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TableLayoutPanel content;
        private System.Windows.Forms.ListBox files;
        private System.Windows.Forms.TableLayoutPanel results;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage wordTab;
        private System.Windows.Forms.DataGridView words;
        private System.Windows.Forms.TabPage punctuationTab;
        private System.Windows.Forms.DataGridView punctuation;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctuationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctuationCountColumn;
    }
}
