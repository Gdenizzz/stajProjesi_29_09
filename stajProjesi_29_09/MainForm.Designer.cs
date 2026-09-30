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
            this.status = new System.Windows.Forms.Label();
            this.wordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punctuationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punctuationCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.words)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctuation)).BeginInit();
            this.layout.SuspendLayout();
            this.buttons.SuspendLayout();
            this.content.SuspendLayout();
            this.results.SuspendLayout();
            this.tabs.SuspendLayout();
            this.wordTab.SuspendLayout();
            this.punctuationTab.SuspendLayout();
            this.SuspendLayout();
            // layout
            this.layout.Name = "layout";
            this.layout.TabIndex = 0;
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            // title
            this.title.Name = "title";
            this.title.TabIndex = 1;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            // drop
            this.drop.Name = "drop";
            this.drop.TabIndex = 2;
            this.drop.Dock = System.Windows.Forms.DockStyle.Fill;
            // buttons
            this.buttons.Name = "buttons";
            this.buttons.TabIndex = 3;
            this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            // browse
            this.browse.Name = "browse";
            this.browse.TabIndex = 4;
            // clear
            this.clear.Name = "clear";
            this.clear.TabIndex = 5;
            // content
            this.content.Name = "content";
            this.content.TabIndex = 6;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            // files
            this.files.Name = "files";
            this.files.TabIndex = 7;
            this.files.Dock = System.Windows.Forms.DockStyle.Fill;
            // results
            this.results.Name = "results";
            this.results.TabIndex = 8;
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            // summary
            this.summary.Name = "summary";
            this.summary.TabIndex = 9;
            this.summary.Dock = System.Windows.Forms.DockStyle.Fill;
            // tabs
            this.tabs.Name = "tabs";
            this.tabs.TabIndex = 10;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            // wordTab
            this.wordTab.Name = "wordTab";
            this.wordTab.TabIndex = 11;
            this.wordTab.Dock = System.Windows.Forms.DockStyle.Fill;
            // words
            this.words.Name = "words";
            this.words.TabIndex = 12;
            this.words.Dock = System.Windows.Forms.DockStyle.Fill;
            // punctuationTab
            this.punctuationTab.Name = "punctuationTab";
            this.punctuationTab.TabIndex = 13;
            this.punctuationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            // punctuation
            this.punctuation.Name = "punctuation";
            this.punctuation.TabIndex = 14;
            this.punctuation.Dock = System.Windows.Forms.DockStyle.Fill;
            // status
            this.status.Name = "status";
            this.status.TabIndex = 15;
            this.status.Dock = System.Windows.Forms.DockStyle.Fill;
            // wordColumn
            this.wordColumn.Name = "wordColumn";
            // countColumn
            this.countColumn.Name = "countColumn";
            // punctuationColumn
            this.punctuationColumn.Name = "punctuationColumn";
            // punctuationCountColumn
            this.punctuationCountColumn.Name = "punctuationCountColumn";
            this.layout.Padding = new System.Windows.Forms.Padding(20);
            this.layout.ColumnCount = 1;
            this.layout.RowCount = 5;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layout.Controls.Add(this.title, 0, 0);
            this.layout.Controls.Add(this.drop, 0, 1);
            this.layout.Controls.Add(this.buttons, 0, 2);
            this.layout.Controls.Add(this.content, 0, 3);
            this.layout.Controls.Add(this.status, 0, 4);
            this.title.Text = "Dosya Analizi";
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.drop.Text = "Dosyalarınızı buraya sürükleyip bırakın\nTXT ve DOCX • Birden fazla dosya ekleyebilirsiniz";
            this.drop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drop.BackColor = System.Drawing.Color.FromArgb(225, 237, 251);
            this.drop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttons.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.buttons.Controls.Add(this.browse);
            this.browse.Text = "Dosya seç…";
            this.browse.AutoSize = true;
            this.browse.UseVisualStyleBackColor = true;
            this.buttons.Controls.Add(this.clear);
            this.clear.Text = "Listeyi temizle";
            this.clear.AutoSize = true;
            this.clear.UseVisualStyleBackColor = true;
            this.content.ColumnCount = 2;
            this.content.RowCount = 1;
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.content.Controls.Add(this.files, 0, 0);
            this.content.Controls.Add(this.results, 1, 0);
            this.files.HorizontalScrollbar = true;
            this.files.IntegralHeight = false;
            this.results.ColumnCount = 1;
            this.results.RowCount = 2;
            this.results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.results.Controls.Add(this.summary, 0, 0);
            this.results.Controls.Add(this.tabs, 0, 1);
            this.summary.AutoEllipsis = true;
            this.summary.Padding = new System.Windows.Forms.Padding(8);
            this.summary.Text = "Analiz sonuçlarını görmek için dosya ekleyin.\nKelime sıklığında bağlaçlar ve sayılar hariçtir.";
            this.tabs.Controls.Add(this.wordTab);
            this.wordTab.Text = "Kelime sıklığı (azalan)";
            this.wordTab.UseVisualStyleBackColor = true;
            this.wordTab.Controls.Add(this.words);
            this.tabs.Controls.Add(this.punctuationTab);
            this.punctuationTab.Text = "Noktalama dökümü";
            this.punctuationTab.UseVisualStyleBackColor = true;
            this.punctuationTab.Controls.Add(this.punctuation);
            this.tabs.SelectedIndex = 0;
            this.words.ReadOnly = true;
            this.words.AllowUserToAddRows = false;
            this.words.AllowUserToDeleteRows = false;
            this.words.AutoGenerateColumns = false;
            this.words.RowHeadersVisible = false;
            this.words.BackgroundColor = System.Drawing.Color.White;
            this.words.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.words.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.punctuation.ReadOnly = true;
            this.punctuation.AllowUserToAddRows = false;
            this.punctuation.AllowUserToDeleteRows = false;
            this.punctuation.AutoGenerateColumns = false;
            this.punctuation.RowHeadersVisible = false;
            this.punctuation.BackgroundColor = System.Drawing.Color.White;
            this.punctuation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.punctuation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wordColumn.HeaderText = "Kelime";
            this.wordColumn.DataPropertyName = "Word";
            this.wordColumn.FillWeight = 75F;
            this.wordColumn.ReadOnly = true;
            this.countColumn.HeaderText = "Tekrar sayısı";
            this.countColumn.DataPropertyName = "Count";
            this.countColumn.FillWeight = 25F;
            this.countColumn.ReadOnly = true;
            this.punctuationColumn.HeaderText = "İşaret";
            this.punctuationColumn.DataPropertyName = "Word";
            this.punctuationColumn.FillWeight = 50F;
            this.punctuationColumn.ReadOnly = true;
            this.punctuationCountColumn.HeaderText = "Sayı";
            this.punctuationCountColumn.DataPropertyName = "Count";
            this.punctuationCountColumn.FillWeight = 50F;
            this.punctuationCountColumn.ReadOnly = true;
            this.words.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.wordColumn, this.countColumn });
            this.punctuation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.punctuationColumn, this.punctuationCountColumn });
            this.status.Text = "Hazır. TXT veya DOCX dosyaları ekleyin.";
            this.status.Padding = new System.Windows.Forms.Padding(8);
            this.browse.Click += new System.EventHandler(this.BrowseClicked);
            this.clear.Click += new System.EventHandler(this.ClearClicked);
            this.files.SelectedIndexChanged += new System.EventHandler(this.FilesSelectedIndexChanged);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(780, 520);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "MainForm";
            this.Text = "MSE • Dosya Analizi";
            this.Controls.Add(this.layout);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.words)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctuation)).EndInit();
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.buttons.ResumeLayout(false);
            this.buttons.PerformLayout();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.results.ResumeLayout(false);
            this.results.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabs.PerformLayout();
            this.wordTab.ResumeLayout(false);
            this.wordTab.PerformLayout();
            this.punctuationTab.ResumeLayout(false);
            this.punctuationTab.PerformLayout();
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
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctuationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctuationCountColumn;
    }
}
