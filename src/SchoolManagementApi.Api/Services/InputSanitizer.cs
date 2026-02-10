using System.Net;
using System.Reflection;

namespace SchoolManagementApi.Api.Services;

public interface IInputSanitizer
{
    T Sanitize<T>(T input);
}

public sealed class InputSanitizer : IInputSanitizer
{
    public T Sanitize<T>(T input)
    {
        if (input == null)
        {
            return input!;
        }

        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(property => property.CanRead && property.CanWrite && property.PropertyType == typeof(string));

        foreach (var property in properties)
        {
            var value = property.GetValue(input) as string;
            if (value == null)
            {
                continue;
            }

            var sanitized = WebUtility.HtmlEncode(value.Trim());
            property.SetValue(input, sanitized);
        }

        return input;
    }
}
