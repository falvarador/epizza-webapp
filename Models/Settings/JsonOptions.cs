namespace ePizza.WebApp.Model
{
    using System.Text.Json;
    using ePizza.WebApi.Common.Utility;

    internal static class JsonSetting
    {
        public static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
        };
    }
}
