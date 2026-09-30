using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajProjesi_29_09
{
    public partial class MainForm : Form
    {
        private readonly IFileService[] readers = { new TxtFileReader(), new DocxFileReader() };
        private readonly TextAnalyzer analyzer = new TextAnalyzer();
        private readonly Logger logger = new Logger();
        private bool busy;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs args)
        {
            if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;
            EnableDrop(this);
            logger.LogInfo("Uygulama başlatıldı.");
        }

        private void MainFormClosed(object sender, FormClosedEventArgs args)
        {
            logger.LogInfo("Uygulama kapatıldı.");
        }

        private void ClearClicked(object sender, EventArgs args)
        {
            files.Items.Clear();
            ShowSelection();
            status.Text = "Liste temizlendi.";
        }

        private void FilesSelectedIndexChanged(object sender, EventArgs args)
        {
            ShowSelection();
        }

        private void EnableDrop(Control control)
        {
            control.AllowDrop = true;
            control.DragEnter += (sender, args) =>
            {
                args.Effect = !busy && args.Data.GetDataPresent(DataFormats.FileDrop)
                    ? DragDropEffects.Copy : DragDropEffects.None;
            };
            control.DragDrop += async (sender, args) =>
            {
                var paths = args.Data.GetData(DataFormats.FileDrop) as string[];
                if (paths != null) await AnalyzeFilesAsync(paths);
            };
            foreach (Control child in control.Controls) EnableDrop(child);
        }

        private async void BrowseClicked(object sender, EventArgs args)
        {
            using (var dialog = new OpenFileDialog
            {
                Title = "Analiz edilecek dosyaları seçin", Multiselect = true,
                Filter = "Desteklenen dosyalar (*.txt;*.docx)|*.txt;*.docx|Metin (*.txt)|*.txt|Word (*.docx)|*.docx"
            })
            {
                if (dialog.ShowDialog(this) == DialogResult.OK) await AnalyzeFilesAsync(dialog.FileNames);
            }
        }

        private async Task AnalyzeFilesAsync(string[] paths)
        {
            if (busy) return;
            busy = true;
            browse.Enabled = clear.Enabled = false;
            int succeeded = 0;
            int failed = 0;
            try
            {
                foreach (string path in paths)
                {
                    status.Text = "Analiz ediliyor: " + Path.GetFileName(path);
                    FileReport report = await Task.Run(() => AnalyzeFile(path));
                    if (IsDisposed || Disposing) return;
                    files.Items.Add(report);
                    files.SelectedIndex = files.Items.Count - 1;
                    if (report.Error == null) succeeded++; else failed++;
                }
                status.Text = $"Tamamlandı: {succeeded} başarılı, {failed} hatalı. Ayrıntılar için bir dosya seçin.";
                if (logger.LastError != null) status.Text += " Kayıt dosyasına yazılamadı: " + logger.LastError;
            }
            finally
            {
                busy = false;
                if (!IsDisposed && !Disposing) browse.Enabled = clear.Enabled = true;
            }
        }

        private FileReport AnalyzeFile(string path)
        {
            var report = new FileReport { Path = path };
            try
            {
                if (!File.Exists(path)) throw new IOException("Dosya bulunamadı veya seçilen öğe bir klasör.");
                var reader = readers.FirstOrDefault(item => item.CanRead(System.IO.Path.GetExtension(path)));
                if (reader == null) throw new NotSupportedException("Bu dosya türü desteklenmiyor. TXT veya DOCX seçin.");
                report.Result = analyzer.Analyze(reader.ReadFile(path));
                logger.LogInfo("Dosya başarıyla analiz edildi: " + path);
            }
            catch (Exception ex)
            {
                report.Error = ex.Message;
                logger.LogError("Dosya işleme hatası: " + path, ex);
            }
            return report;
        }

        private void ShowSelection()
        {
            var report = files.SelectedItem as FileReport;
            words.DataSource = null;
            punctuation.DataSource = null;
            if (report == null)
            {
                summary.Text = "Analiz sonuçlarını görmek için dosya ekleyin.\nKelime sıklığında bağlaçlar ve sayılar hariçtir.";
                return;
            }
            if (report.Error != null)
            {
                summary.Text = report.Path + "\nHata: " + report.Error;
                return;
            }
            summary.Text = report.Path + $"\nToplam farklı kelime: {report.Result.TotalUniqueWordCount}   •   Noktalama: {report.Result.PunctuationCount}\nToplam: bağlaçlar dahil, sayılar hariç. Sıklık: bağlaçlar ve sayılar hariç.";
            punctuation.DataSource = report.Result.PunctuationFrequencies.OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key).Select(pair => new WordRow { Word = pair.Key, Count = pair.Value }).ToList();
            words.DataSource = report.Result.WordFrequencies.OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key).Select(pair => new WordRow { Word = pair.Key, Count = pair.Value }).ToList();
        }

        private sealed class FileReport
        {
            public string Path { get; set; }
            public AnalysisResult Result { get; set; }
            public string Error { get; set; }
            public override string ToString() => (Error == null ? "✓ " : "! ") + System.IO.Path.GetFileName(Path);
        }

        public sealed class WordRow
        {
            public string Word { get; set; }
            public int Count { get; set; }
        }

        private void drop_Click(object sender, EventArgs e)
        {

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void layout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}
