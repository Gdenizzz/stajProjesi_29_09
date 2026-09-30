param([string]$Configuration = "Debug")
# Run after building: powershell -NoProfile -STA -File tests/Verify-Requirements.ps1
$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.IO.Compression
Add-Type -AssemblyName System.IO.Compression.FileSystem
$assemblyPath = Join-Path $PSScriptRoot "../stajProjesi_29_09/bin/$Configuration/stajProjesi_29_09.exe"
[void][Reflection.Assembly]::LoadFrom((Resolve-Path $assemblyPath))
function Assert($condition, $message) { if (!$condition) { throw $message } }
$analyzer = New-Object stajProjesi_29_09.TextAnalyzer
$originalCulture = [Threading.Thread]::CurrentThread.CurrentCulture
try {
    foreach ($culture in @('tr-TR', 'en-US')) {
        [Threading.Thread]::CurrentThread.CurrentCulture = [Globalization.CultureInfo]::GetCultureInfo($culture)
        $result = $analyzer.Analyze('ISPARTA ısparta İZMİR izmir hâlâ hâlâ ve veya 123 45!?!')
        Assert ($result.TotalUniqueWordCount -eq 5) 'Unique total must include conjunctions and exclude numbers.'
        Assert ($result.WordFrequencies.Count -eq 3) 'Frequency report must exclude conjunctions and numbers.'
        Assert ($result.WordFrequencies['ısparta'] -eq 2) 'Turkish casing must be independent of OS culture.'
        Assert ($result.WordFrequencies['hâlâ'] -eq 2) 'Unicode letters must be counted.'
        Assert ($result.PunctuationCount -eq 3 -and $result.PunctuationFrequencies['!'] -eq 2) 'Punctuation totals and breakdown must match.'
    }
    Assert ($analyzer.Analyze('').TotalUniqueWordCount -eq 0) 'Empty input must return zero.'
    Assert ($analyzer.Analyze('bir bu o a').WordFrequencies.Count -eq 4) 'Non-conjunction words must not be discarded.'
    $reader = New-Object stajProjesi_29_09.DocxFileReader
    Assert ($reader.CanRead('.DOCX')) 'Extensions must be case insensitive.'
    Assert (!$reader.CanRead($null)) 'Null extension must be safe.'
    $fixture = Join-Path $env:TEMP ('mse-' + [Guid]::NewGuid() + '.docx')
    try {
        $archive = [IO.Compression.ZipFile]::Open($fixture, [IO.Compression.ZipArchiveMode]::Create)
        $entry = $archive.CreateEntry('word/document.xml')
        $writer = New-Object IO.StreamWriter($entry.Open())
        $writer.Write('<w:document xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main"><w:body><w:p><w:r><w:t>mer</w:t></w:r><w:r><w:t>haba</w:t><w:tab/><w:t>dünya</w:t></w:r></w:p><w:p><w:r><w:t>merhaba</w:t></w:r></w:p></w:body></w:document>')
        $writer.Dispose(); $archive.Dispose()
        $result = $analyzer.Analyze($reader.ReadFile($fixture))
        Assert ($result.WordFrequencies['merhaba'] -eq 2 -and $result.TotalUniqueWordCount -eq 2) 'DOCX formatting must not split words; paragraphs/tabs must separate words.'
    } finally { if (Test-Path -LiteralPath $fixture) { Remove-Item -LiteralPath $fixture } }
    $fixture = Join-Path $env:TEMP ('mse-' + [Guid]::NewGuid() + '.docx')
    try {
        $archive = [IO.Compression.ZipFile]::Open($fixture, [IO.Compression.ZipArchiveMode]::Create)
        $archive.Dispose()
        $rejected = $false
        try { $reader.ReadFile($fixture) | Out-Null } catch { $rejected = $true }
        Assert $rejected 'DOCX without document.xml must be rejected.'
    } finally { if (Test-Path -LiteralPath $fixture) { Remove-Item -LiteralPath $fixture } }
    'PASS: Turkish culture, Unicode, totals, exclusions, punctuation, empty input, DOCX runs, separators, invalid DOCX.'
} finally { [Threading.Thread]::CurrentThread.CurrentCulture = $originalCulture }

