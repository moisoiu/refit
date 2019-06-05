using Newtonsoft.Json;
using Refit;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace RefitClient
{
    public class CustomUrlParameterFormatter : IUrlParameterFormatter
    {
        public string Format(object value, ParameterInfo parameterInfo)
        {
            if (value is IEnumerable enumerable)
            {
                var result = ToQueryString(enumerable, parameterInfo.Name);
                return result;
            }

            return string.Empty;
        }

        public static string ToQueryString(IEnumerable query, string parameterName)
        {
            var values = query.Cast<object>().Select(ToString).ToArray();
            var separator = parameterName + "=";

            return values.Any() ? separator + string.Join("&" + separator, values) : "";
        }

        public static string ToString(object value)
        {
            var json = JsonConvert.SerializeObject(value).Replace("\\\"", "\"").Trim('"');

            return Uri.EscapeUriString(json);
        }
    }
}