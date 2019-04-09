using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONFileFromCodeGeneratorApp
{
    // Automatically generated in https://app.quicktype.io/
    public partial class ColorsJsonFile
    {
        [JsonProperty("colors")]
        public List<Color> Colors { get; set; }
    }

    public partial class Color
    {
        [JsonProperty("color")]
        public string ColorColor { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("code")]
        public Code Code { get; set; }
    }

    public partial class Code
    {
        [JsonProperty("rgba")]
        public List<long> Rgba { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }
    }

    public partial class ColorsJsonFile
    {
        public static ColorsJsonFile FromJson(string json) => JsonConvert.DeserializeObject<ColorsJsonFile>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ColorsJsonFile self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    public static class Colors
    {
        public static string SampleColors()
        {
            Code blackColorCode = new Code()
            {
                Rgba = new List<long> { 255, 255, 255, 1 },
                Hex = "#000"
            };

            Color black = new Color()
            {
                ColorColor = "black",
                Category = "hue",
                Type = "primary",
                Code = blackColorCode
            };

            Code whiteColorCode = new Code()
            {
                Rgba = new List<long> { 0, 0, 0, 1 },
                Hex = "#FFF"
            };

            Color white = new Color()
            {
                ColorColor = "white",
                Category = "value",
                Code = whiteColorCode
            };

            ColorsJsonFile colorsJsonFile = new ColorsJsonFile
            {
                Colors = new List<Color> { black, white }
            };

            return colorsJsonFile.ToJson();
        }
    }
}
