using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tusk.Utils;

/// <summary>
/// JsonSerializerUtil for different versions of .NET. System.Text.Json is used for serialization.
/// </summary>
public static class JsonSerializerUtil
{
#if NET7_0
    /// <summary>
    /// Default JsonSerializerOptions for Net7.0
    /// </summary>
    public static readonly JsonSerializerOptions DefaultOptions = new()
    {
        PropertyNamingPolicy = new SeparatorNamingPolicy(),
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter(new SeparatorNamingPolicy()) }
    };
    #else
    /// <summary>
    /// Default JsonSerializerOptions
    /// </summary>
    public static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower) }
    };
#endif

    /// <summary>
    /// Serialize using current settings for .NET library
    /// </summary>
    /// <param name="obj">Object to serialize</param>
    /// <typeparam name="T">Type to serialize from</typeparam>
    /// <returns>Serialized string</returns>
    public static string Serialize<T>(T obj)
    {
        return JsonSerializer.Serialize(obj, DefaultOptions);
    }

    /// <summary>
    /// Deserialize type using current settings for .NET library
    /// </summary>
    /// <param name="json">Json formatted string</param>
    /// <typeparam name="T">Type to deserialize into</typeparam>
    /// <returns>Object T.</returns>
    public static T Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, DefaultOptions);
    }
}

/// <summary>
/// Naming policy used for non built in System.Text.Json property name support
/// </summary>
public class SeparatorNamingPolicy : JsonNamingPolicy
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SeparatorNamingPolicy" /> class.
    /// </summary>
    /// <param name="separator">Default separator "-"</param>
    public SeparatorNamingPolicy(char separator = '_')
    {
        Separator = separator;
    }
    /// <summary>
    /// Gets the separator.
    /// </summary>
    public char Separator { get; }

    /// <summary>
    /// Converts the specified name according to the policy.
    /// </summary>
    /// <param name="name">Name of field to parse</param>
    /// <returns>Name with separator</returns>
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
                    yield return Separator;
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
