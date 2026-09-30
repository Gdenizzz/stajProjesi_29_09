using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace stajProjesi_29_09
{
    public class TextAnalyzer
    {
        private static readonly CultureInfo TurkishCulture = CultureInfo.GetCultureInfo("tr-TR");
        private readonly HashSet<string> ignoredWords = new HashSet<string>(StringComparer.Ordinal)
        {
            "ve", "veya", "yahut", "veyahut", "ya", "ile", "ama", "fakat", "lakin",
            "ancak", "çünkü", "de", "da", "ki", "ne", "hem", "oysa", "oysaki",
            "halbuki", "hâlbuki", "madem", "mademki", "zira", "eğer", "şayet"
        };

        public AnalysisResult Analyze(string rawText)
        {
            var result = new AnalysisResult();
            if (string.IsNullOrWhiteSpace(rawText)) return result;

            foreach (char character in rawText.Where(char.IsPunctuation))
            {
                int count;
                result.PunctuationFrequencies.TryGetValue(character.ToString(), out count);
                result.PunctuationFrequencies[character.ToString()] = count + 1;
                result.PunctuationCount++;
            }

            string normalizedText = rawText.Normalize(NormalizationForm.FormC).ToLower(TurkishCulture);
            var uniqueWords = new HashSet<string>(StringComparer.Ordinal);
            // Unicode letters and combining marks; do not extract fragments from alphanumeric tokens.
            foreach (Match match in Regex.Matches(normalizedText, @"\b\p{L}[\p{L}\p{M}]*\b"))
            {
                string word = match.Value;
                uniqueWords.Add(word);
                if (ignoredWords.Contains(word)) continue;
                int count;
                result.WordFrequencies.TryGetValue(word, out count);
                result.WordFrequencies[word] = count + 1;
            }

            // The total includes conjunctions; only the frequency report excludes them.
            result.TotalUniqueWordCount = uniqueWords.Count;
            return result;
        }
    }

    public class AnalysisResult
    {
        public int TotalUniqueWordCount { get; set; }
        public int PunctuationCount { get; set; }
        public Dictionary<string, int> WordFrequencies { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> PunctuationFrequencies { get; set; } = new Dictionary<string, int>();
    }
}
