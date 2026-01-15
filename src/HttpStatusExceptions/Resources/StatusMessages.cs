using System.Globalization;
using System.Resources;

namespace HttpStatusExceptions;

internal static class StatusMessages
{
    private static readonly ResourceManager _resourceManager = new(
        typeof(StatusMessages).FullName!,
        typeof(StatusMessages).Assembly);

    private static string GetString(string name)
    {
        return _resourceManager.GetString(name, CultureInfo.CurrentCulture) ?? name;
    }

    // 4xx Client Error Messages
    public static string Status400BadRequest => GetString(nameof(Status400BadRequest));
    public static string Status401Unauthorized => GetString(nameof(Status401Unauthorized));
    public static string Status402PaymentRequired => GetString(nameof(Status402PaymentRequired));
    public static string Status403Forbidden => GetString(nameof(Status403Forbidden));
    public static string Status404NotFound => GetString(nameof(Status404NotFound));
    public static string Status405MethodNotAllowed => GetString(nameof(Status405MethodNotAllowed));
    public static string Status405ConnectNotAllowed => GetString(nameof(Status405ConnectNotAllowed));
    public static string Status405DeleteNotAllowed => GetString(nameof(Status405DeleteNotAllowed));
    public static string Status405GetNotAllowed => GetString(nameof(Status405GetNotAllowed));
    public static string Status405HeadNotAllowed => GetString(nameof(Status405HeadNotAllowed));
    public static string Status405OptionsNotAllowed => GetString(nameof(Status405OptionsNotAllowed));
    public static string Status405PatchNotAllowed => GetString(nameof(Status405PatchNotAllowed));
    public static string Status405PostNotAllowed => GetString(nameof(Status405PostNotAllowed));
    public static string Status405PutNotAllowed => GetString(nameof(Status405PutNotAllowed));
    public static string Status405TraceNotAllowed => GetString(nameof(Status405TraceNotAllowed));
    public static string Status406NotAcceptable => GetString(nameof(Status406NotAcceptable));
    public static string Status407ProxyAuthenticationRequired => GetString(nameof(Status407ProxyAuthenticationRequired));
    public static string Status408RequestTimeout => GetString(nameof(Status408RequestTimeout));
    public static string Status409Conflict => GetString(nameof(Status409Conflict));
    public static string Status410Gone => GetString(nameof(Status410Gone));
    public static string Status411LengthRequired => GetString(nameof(Status411LengthRequired));
    public static string Status412PreconditionFailed => GetString(nameof(Status412PreconditionFailed));
    public static string Status413PayloadTooLarge => GetString(nameof(Status413PayloadTooLarge));
    public static string Status414UriTooLong => GetString(nameof(Status414UriTooLong));
    public static string Status415UnsupportedMediaType => GetString(nameof(Status415UnsupportedMediaType));
    public static string Status416RangeNotSatisfiable => GetString(nameof(Status416RangeNotSatisfiable));
    public static string Status417ExpectationFailed => GetString(nameof(Status417ExpectationFailed));
    public static string Status421MisdirectedRequest => GetString(nameof(Status421MisdirectedRequest));
    public static string Status422UnprocessableEntity => GetString(nameof(Status422UnprocessableEntity));
    public static string Status423Locked => GetString(nameof(Status423Locked));
    public static string Status424FailedDependency => GetString(nameof(Status424FailedDependency));
    public static string Status426UpgradeRequired => GetString(nameof(Status426UpgradeRequired));
    public static string Status428PreconditionRequired => GetString(nameof(Status428PreconditionRequired));
    public static string Status429TooManyRequests => GetString(nameof(Status429TooManyRequests));
    public static string Status431RequestHeaderFieldsTooLarge => GetString(nameof(Status431RequestHeaderFieldsTooLarge));
    public static string Status451UnavailableForLegalReasons => GetString(nameof(Status451UnavailableForLegalReasons));

    // 5xx Server Error Messages
    public static string Status500InternalServerError => GetString(nameof(Status500InternalServerError));
    public static string Status501NotImplemented => GetString(nameof(Status501NotImplemented));
    public static string Status502BadGateway => GetString(nameof(Status502BadGateway));
    public static string Status503ServiceUnavailable => GetString(nameof(Status503ServiceUnavailable));
    public static string Status504GatewayTimeout => GetString(nameof(Status504GatewayTimeout));
    public static string Status505HttpVersionNotSupported => GetString(nameof(Status505HttpVersionNotSupported));
    public static string Status506VariantAlsoNegotiates => GetString(nameof(Status506VariantAlsoNegotiates));
    public static string Status507InsufficientStorage => GetString(nameof(Status507InsufficientStorage));
    public static string Status508LoopDetected => GetString(nameof(Status508LoopDetected));
    public static string Status510NotExtended => GetString(nameof(Status510NotExtended));
    public static string Status511NetworkAuthenticationRequired => GetString(nameof(Status511NetworkAuthenticationRequired));
}
