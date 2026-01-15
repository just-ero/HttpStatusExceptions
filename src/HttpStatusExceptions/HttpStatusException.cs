using System;

namespace HttpStatusExceptions;

/// <summary>
///     The base class for HTTP status exceptions.
/// </summary>
/// <param name="statusCode">
///     The HTTP status code associated with the exception.
/// </param>
/// <param name="message">
///     The message that describes the exception.
/// </param>
public class HttpStatusException(
    int statusCode,
    string message)
    : Exception(message)
{
    /// <summary>
    ///     The HTTP status code associated with the exception.
    /// </summary>
    public int StatusCode => statusCode;
}
