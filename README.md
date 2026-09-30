# MSE C# FileAnalyzer

.NET Framework 4.7.2 üzerinde çalışan Windows Forms masaüstü uygulaması.
Ödevdeki ConsoleApp tanımı, kullanıcının masaüstü ve sürükle-bırak isteği doğrultusunda Windows Forms olarak uygulanmıştır.

## Kullanım

1. Visual Studio ile çözümü açıp F5 ile çalıştırın.
2. Uygulama doğrudan ana pencereyle açılır; otomatik dosya seçim penceresi gösterilmez.
3. Daha sonra dosyaları pencereye sürükleyip bırakabilir veya **Dosya seç** düğmesini kullanabilirsiniz.
4. Soldaki listeden dosya seçin. Kelime sıklığını ve noktalama dökümünü ilgili sekmelerde inceleyin.
5. **Listeyi temizle**, ekrandaki sonuçları temizler; kaynak dosyaları silmez.

Birden fazla dosya sırayla, arka planda işlenir. Hatalı dosyalar diğerlerinin analizini engellemez.

## Analiz kuralları

- Toplam farklı kelime: büyük/küçük harften bağımsız farklı sözcüklerin sayısıdır; bağlaçlar dahil, rakamla yazılmış sayılar hariçtir.
- Kelime sıklığı: `TextAnalyzer` içindeki açık bağlaç listesini ve sayıları hariç tutar. Tüm kalan kelimeler, tekrar sayısı azalan sırada gösterilir; eşitlikte kelime sırası kullanılır.
- Türkçe harf dönüşümü, işletim sisteminin dilinden bağımsızdır. Unicode harfleri ve tek harfli sözcükler desteklenir.
- Bağlaç tespiti sözcük listesine dayanır; bağlama göre dilbilgisel çözümleme yapılmaz. Sayıların yazıyla yazılmış halleri normal sözcük olarak değerlendirilir.
- Noktalama: `char.IsPunctuation` kapsamındaki işaretlerin toplamı ve işaret bazında sayıları gösterilir.
- DOCX ana belge metni okunur; biçimlendirme parçaları kelimeleri bölmez. Paragraflar, sekmeler ve satır sonları korunur. Üstbilgi, altbilgi ve dipnotlar kapsam dışındadır.
- TXT için UTF-8 veya BOM içeren Unicode dosyalar kullanılmalıdır.

## Gereksinim karşılıkları

| Ödev maddesi | Uygulama |
| --- | --- |
| 1–2 | Dosya seç düğmesiyle OpenFileDialog; TXT ve DOCX okuyucuları (kullanıcı isteğiyle otomatik açılış kaldırıldı) |
| 3 ve 7 | Dosya bazında hata gösterimi ve işlem/hata kayıtları |
| 4–6 | Toplam farklı kelime, sıralı sıklık, noktalama toplamı ve dökümü |
| 8–10 | IFileService arayüzü, ayrı okuyucu/analiz/log/arayüz sınıfları, İngilizce kod isimleri |
| 11 (isteğe bağlı) | PDF okuma desteği eklenmemiştir |

Yeni dosya türü için `IFileService` uygulayan bir okuyucu yazıp `MainForm` içindeki `readers` listesine ve dosya seçim filtresine ekleyin.
Log konumu: `%LOCALAPPDATA%\MSEFileAnalyzer\app_logs.txt`. Yazma başarısız olursa işlem sonunda durum satırında uyarı gösterilir.

## Derleme ve doğrulama

Visual Studio .NET masaüstü geliştirme araçları, .NET Framework 4.7.2 hedefleme paketi gerekir. Harici NuGet paketi kullanılmaz.

```powershell
dotnet build stajProjesi_29_09/stajProjesi_29_09.csproj --no-restore
powershell -NoProfile -STA -File tests/Verify-Requirements.ps1
```

Çıktı: `stajProjesi_29_09/bin/Debug/stajProjesi_29_09.exe`.
GitHub teslimi için değişiklikler incelenip commit/push yapılmalıdır; bu çalışma otomatik olarak yayımlamaz.
