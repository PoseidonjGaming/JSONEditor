using JsonEditor_form.models;
using JsonEditor_form.Properties;

namespace JsonEditor_form
{
    public class Utils
    {
        public static List<Pattern> Patterns
        {
            get => Settings.Default.Patterns?? new List<Pattern>();
            set => Settings.Default.Patterns = value;
        }

        public static Pattern GetPatternByName(string name)
        {
            Pattern? pattern = Patterns.Find(e => e.Name.Equals(name));
            return pattern ?? new Pattern("Empty", "Empty");
        }

        public static Pattern GetPatternById(int id)
        {
            return Patterns[id];
        }

        public static void AddPattern(Pattern pattern)
        {
            Patterns.Add(pattern);
            Settings.Default.Save();

        }

        public static void RemovePattern(int index)
        {
            Patterns.RemoveAt(index);
            Settings.Default.Save();
        }
    }
}
