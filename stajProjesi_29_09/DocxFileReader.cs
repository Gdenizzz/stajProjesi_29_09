using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace stajProjesi_29_09
{
    public class DocxFileReader : IFileService
    {
        public bool CanRead(string fileExtension)
        {
            return string.Equals(fileExtension, ".docx", StringComparison.OrdinalIgnoreCase);
        }

        public string ReadFile(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("Seçilen DOCX dosyası bulunamadı.", filePath);
            var text = new StringBuilder();
            using (ZipArchive archive = ZipFile.OpenRead(filePath))
            {
                ZipArchiveEntry entry = archive.GetEntry("word/document.xml");
                if (entry == null) throw new InvalidDataException("Geçersiz DOCX: ana belge içeriği bulunamadı.");
                using (Stream stream = entry.Open())
                using (XmlReader reader = XmlReader.Create(stream, new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null }))
                {
                    XDocument document = XDocument.Load(reader);
                    XNamespace word = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
                    XNamespace strictWord = "http://purl.oclc.org/ooxml/wordprocessingml/main";
                    if (document.Root == null || (document.Root.Name != word + "document" && document.Root.Name != strictWord + "document"))
                        throw new InvalidDataException("Geçersiz DOCX: beklenen belge yapısı bulunamadı.");
                    AppendText(document.Root, document.Root.Name.Namespace, text);
                }
            }
            return text.ToString();
        }

        private static void AppendText(XElement element, XNamespace word, StringBuilder text)
        {
            if (element.Name == word + "t") { text.Append(element.Value); return; }
            if (element.Name == word + "tab") { text.Append('\t'); return; }
            if (element.Name == word + "br" || element.Name == word + "cr") { text.AppendLine(); return; }
            foreach (XElement child in element.Elements()) AppendText(child, word, text);
            if (element.Name == word + "p") text.AppendLine();
        }
    }
}
