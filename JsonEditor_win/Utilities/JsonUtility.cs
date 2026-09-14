using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace JsonEditor_win.Utilities
{
    public partial class JsonUtility
    {
        public static string TreeToJson(Models.JsonProperty root)
        {
            if (root.Type == Models.JsonType.Object)
            {
                JsonObject jRoot = [];
                foreach (var child in root.Children)
                {
                    jRoot.Add(child.Name, CreateNode(child));
                }
                return jRoot.ToString();
            }
            else if (root.Type == Models.JsonType.Array)
            {
                JsonArray jRoot = new([.. root.Children.Select(CreateNode)]);
                return jRoot.ToString();
            }

            return string.Empty;
        }

        public static Models.JsonProperty JsonToTree(string json)
        {
            JsonNode? jNode = JsonNode.Parse(json);
            if (jNode is null)
                return new Models.JsonProperty("Root", string.Empty, Models.JsonType.Object);
            return CreateProperty("Root", jNode);
        }

        private static Models.JsonProperty CreateProperty(string key, JsonNode? jNode)
        {
            switch (jNode)
            {
                case JsonObject jObj:
                    Models.JsonProperty objProp = new(key, string.Empty, Models.JsonType.Object);
                    foreach (var node in jObj)
                    {
                        objProp.Children.Add(CreateProperty(node.Key, node.Value));
                    }
                    return objProp;
                case JsonArray jArr:
                    Models.JsonProperty arrProp = new(key, string.Join("  ", jArr), Models.JsonType.Array);
                    return arrProp;
                case JsonValue jVal:
                    return new Models.JsonProperty(key, GetValue(jVal), Models.JsonType.Value);
                case null:
                    return new Models.JsonProperty(key, "null", Models.JsonType.Value);
            }

            throw new ArgumentException("Unsupported JSON node type");
        }

        private static JsonNode CreateNode(Models.JsonProperty jProp)
        {
            switch (jProp.Type)
            {
                case Models.JsonType.Object:
                    JsonObject jObj = [];
                    foreach (var child in jProp.Children)
                    {
                        jObj.Add(child.Name, CreateNode(child));
                    }
                    return jObj;
                case Models.JsonType.Array:
                    return new JsonArray([.. jProp.Value.Split("  ")]);
                default:
                    return JsonValue.Create(jProp.Value);
            }
        }

        private static string GetValue(JsonNode node)
        {
            return node.GetValueKind() switch
            {
                JsonValueKind.String => node.GetValue<string>(),
                JsonValueKind.Number => node.ToString(),
                JsonValueKind.True => "true",
                JsonValueKind.False => "false",
                JsonValueKind.Null => "null",
                _ => node.ToString()
            };
        }
    }
}
