namespace Kindi.API.Shared.Exceptions;

public class KindiException : Exception
{
    public string StatusCode { get; }
    public object? AdditionalData { get; }

    public KindiException(string statusCode, string message, object? additionalData = null)
        : base(message)
    {
        StatusCode = statusCode;
        AdditionalData = additionalData;
    }
}