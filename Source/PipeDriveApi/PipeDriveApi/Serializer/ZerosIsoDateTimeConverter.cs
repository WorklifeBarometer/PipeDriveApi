using System;
using Newtonsoft.Json;

namespace PipeDriveApi.Serializer
{
    // http://stackoverflow.com/q/27317239/860913

    /// <summary>
    /// Custom IsoDateTimeConverter for DateTime strings with zeros.
    /// 
    /// Usage Sample
    ///  [JsonConverter(typeof(ZerosIsoDateTimeConverter), "yyyy-MM-dd hh:mm:ss", "0000-00-00 00:00:00")]
    ///  public DateTime Zerodate { get; set; }

    /// </summary>
    public class ZerosIsoDateTimeConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        /// <summary>
        /// The string representing a datetime value with zeros. E.g. "0000-00-00 00:00:00"
        /// </summary>
        private readonly string _zeroDateString;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZerosIsoDateTimeConverter"/> class.
        /// </summary>
        /// <param name="dateTimeFormat">The date time format.</param>
        /// <param name="zeroDateString">The zero date string. 
        /// Please be aware that this string should match the date time format.</param>
        public ZerosIsoDateTimeConverter(string dateTimeFormat, string zeroDateString)
        {
            //DateTimeFormat = dateTimeFormat;
            _zeroDateString = zeroDateString;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// If a DateTime value is DateTime.MinValue than the zeroDateString will be set as output value.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime && (DateTime)value == DateTime.MinValue)
            {
                value = _zeroDateString;
                serializer.Serialize(writer, value);
            }
            else
            {
                base.WriteJson(writer, value, serializer);
            }
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// If  an input value is same a zeroDateString than DateTime.MinValue will be set as return value
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>
        /// The object value.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            return reader.Value.ToString() == _zeroDateString
                ? DateTime.MinValue
                : base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}