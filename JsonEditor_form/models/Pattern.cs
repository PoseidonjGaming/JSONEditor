using System.Runtime.Serialization;

namespace JsonEditor_form.models
{
    [Serializable]
    [DataContract]
    public class Pattern
    {
        [DataMember]
        public string Json { get; set; }

        [DataMember]
        public string Name { get; set; }

        public Pattern(string json, string names)
        {
            Json = json;
            Name = names;
        }

        public Pattern()
        {

        }
    }
}
