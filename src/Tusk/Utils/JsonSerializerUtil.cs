using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tusk.Utils;

public static class JsonSerializerUtil
{
#if NET7_0
    public static readonly JsonSerializerOptions DefaultOptions = new()
    {
        PropertyNamingPolicy = new SeperatorNamingPolicy(),
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter(new SeperatorNamingPolicy()) }
    };
    #else
    public static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower) }
    };
#endif

    public static string Serialize<T>(T obj)
    {
        return JsonSerializer.Serialize(obj, DefaultOptions);
    }

    public static T Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, DefaultOptions);
    }
}

public class SeperatorNamingPolicy : JsonNamingPolicy
{
    public SeperatorNamingPolicy(char seperator = '_')
    {
        Seperator = seperator;
    }
    public char Seperator { get; }

    public override string ConvertName(string name)
    {
        IEnumerable<char> ToSeperated()
        {
            var e = name.GetEnumerator();
            if (!e.MoveNext()) yield break;
            yield return char.ToLower(e.Current);
            while (e.MoveNext())
            {
                if (char.IsUpper(e.Current))
                {
                    yield return Seperator;
                    yield return char.ToLower(e.Current);
                }
                else
                {
                    yield return e.Current;
                }
            }
        }

        return new string(ToSeperated().ToArray());
    }
}
