using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace HttpStatusExceptions;

/// <summary>
///     Provides a set of throw helpers for <see cref="HttpStatusException"/>.
/// </summary>
public static partial class HttpStatusExceptionExtensions
{
    extension(HttpStatusException ex)
    {
        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with the specified status code and message.
        /// </summary>
        /// <param name="statusCode">
        ///     The HTTP status code.
        /// </param>
        /// <param name="message">
        ///     The error message.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw(int statusCode, string message)
            => throw new HttpStatusException(statusCode, message);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 400 Bad Request.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Request could not be understood by the server'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw400BadRequest(string? message = default)
            => Throw(400, message ?? StatusMessages.Status400BadRequest);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 401 Unauthorized.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Requested resource requires authentication'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw401Unauthorized(string? message = default)
            => Throw(401, message ?? StatusMessages.Status401Unauthorized);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 402 Payment Required.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Payment is required to access the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw402PaymentRequired(string? message = default)
            => Throw(402, message ?? StatusMessages.Status402PaymentRequired);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 403 Forbidden.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server refuses to fulfill the request'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw403Forbidden(string? message = default)
            => Throw(403, message ?? StatusMessages.Status403Forbidden);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 404 Not Found.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'The requested resource does not exist on the server'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw404NotFound(string? message = default)
            => Throw(404, message ?? StatusMessages.Status404NotFound);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Method is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405MethodNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405MethodNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'CONNECT is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405ConnectNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405ConnectNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'DELETE is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405DeleteNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405DeleteNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'GET is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405GetNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405GetNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'HEAD is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405HeadNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405HeadNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'OPTIONS is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405OptionsNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405OptionsNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'PATCH is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405PatchNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405PatchNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'POST is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405PostNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405PostNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'PUT is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405PutNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405PutNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 405 Method Not Allowed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'TRACE is not allowed on the requested resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw405TraceNotAllowed(string? message = default)
            => Throw(405, message ?? StatusMessages.Status405TraceNotAllowed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 406 Not Acceptable.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Client has indicated that it will not accept any of the available representations of the resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw406NotAcceptable(string? message = default)
            => Throw(406, message ?? StatusMessages.Status406NotAcceptable);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 407 Proxy Authentication Required.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Requested proxy requires authentication'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw407ProxyAuthenticationRequired(string? message = default)
            => Throw(407, message ?? StatusMessages.Status407ProxyAuthenticationRequired);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 408 Request Timeout.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Client did not send a request within the time the server was expecting it'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw408RequestTimeout(string? message = default)
            => Throw(408, message ?? StatusMessages.Status408RequestTimeout);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 409 Conflict.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Request could not be completed due to a conflict with the current state of the resource'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw409Conflict(string? message = default)
            => Throw(409, message ?? StatusMessages.Status409Conflict);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 410 Gone.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'The requested resource is no longer available and has been permanently removed'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw410Gone(string? message = default)
            => Throw(410, message ?? StatusMessages.Status410Gone);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 411 Length Required.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Required Content-Length header is missing'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw411LengthRequired(string? message = default)
            => Throw(411, message ?? StatusMessages.Status411LengthRequired);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 412 Precondition Failed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'A condition set for this request failed'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw412PreconditionFailed(string? message = default)
            => Throw(412, message ?? StatusMessages.Status412PreconditionFailed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 413 Payload Too Large.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Request is too large for the server to process'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw413PayloadTooLarge(string? message = default)
            => Throw(413, message ?? StatusMessages.Status413PayloadTooLarge);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 414 URI Too Long.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Request URI is too long'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw414UriTooLong(string? message = default)
            => Throw(414, message ?? StatusMessages.Status414UriTooLong);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 415 Unsupported Media Type.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Request contains an unsupported media type'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw415UnsupportedMediaType(string? message = default)
            => Throw(415, message ?? StatusMessages.Status415UnsupportedMediaType);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 416 Range Not Satisfiable.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Range of data requested from the resource cannot be returned'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw416RangeNotSatisfiable(string? message = default)
            => Throw(416, message ?? StatusMessages.Status416RangeNotSatisfiable);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 417 Expectation Failed.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Expectation given in an Expect header could not be met by the server'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw417ExpectationFailed(string? message = default)
            => Throw(417, message ?? StatusMessages.Status417ExpectationFailed);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 421 Misdirected Request.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Request was directed at the server that is not able to produce a response'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw421MisdirectedRequest(string? message = default)
            => Throw(421, message ?? StatusMessages.Status421MisdirectedRequest);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 422 Unprocessable Entity.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Request was well-formed but was unable to be followed due to semantic errors'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw422UnprocessableEntity(string? message = default)
            => Throw(422, message ?? StatusMessages.Status422UnprocessableEntity);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 423 Locked.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Source or destination resource is locked'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw423Locked(string? message = default)
            => Throw(423, message ?? StatusMessages.Status423Locked);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 424 Failed Dependency.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Method couldn't be performed on the resource because a dependency on another action failed'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw424FailedDependency(string? message = default)
            => Throw(424, message ?? StatusMessages.Status424FailedDependency);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 426 Upgrade Required.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Client should upgrade to a different protocol'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw426UpgradeRequired(string? message = default)
            => Throw(426, message ?? StatusMessages.Status426UpgradeRequired);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 428 Precondition Required.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server requires the request to be conditional'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw428PreconditionRequired(string? message = default)
            => Throw(428, message ?? StatusMessages.Status428PreconditionRequired);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 429 Too Many Requests.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Client sent too many requests in a given amount of time'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw429TooManyRequests(string? message = default)
            => Throw(429, message ?? StatusMessages.Status429TooManyRequests);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 431 Request Header Fields Too Large.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server is unwilling to process the request because its header fields are too large'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw431RequestHeaderFieldsTooLarge(string? message = default)
            => Throw(431, message ?? StatusMessages.Status431RequestHeaderFieldsTooLarge);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 451 Unavailable For Legal Reasons.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server is denying access to the resource as a consequence of a legal demand'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw451UnavailableForLegalReasons(string? message = default)
            => Throw(451, message ?? StatusMessages.Status451UnavailableForLegalReasons);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 500 Internal Server Error.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Undefined error has occurred on the server'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw500InternalServerError(string? message = default)
            => Throw(500, message ?? StatusMessages.Status500InternalServerError);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 501 Not Implemented.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server does not support the requested function'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw501NotImplemented(string? message = default)
            => Throw(501, message ?? StatusMessages.Status501NotImplemented);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 502 Bad Gateway.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server received an invalid response from the upstream server'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw502BadGateway(string? message = default)
            => Throw(502, message ?? StatusMessages.Status502BadGateway);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 503 Service Unavailable.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server is temporarily unavailable'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw503ServiceUnavailable(string? message = default)
            => Throw(503, message ?? StatusMessages.Status503ServiceUnavailable);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 504 Gateway Timeout.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Intermediate proxy timed out while waiting for a response from another proxy or the origin server'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw504GatewayTimeout(string? message = default)
            => Throw(504, message ?? StatusMessages.Status504GatewayTimeout);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 505 HTTP Version Not Supported.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Requested HTTP version is not supported by the server'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw505HttpVersionNotSupported(string? message = default)
            => Throw(505, message ?? StatusMessages.Status505HttpVersionNotSupported);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 506 Variant Also Negotiates.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Chosen variant resource isn't a proper endpoint in the negotiation process'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw506VariantAlsoNegotiates(string? message = default)
            => Throw(506, message ?? StatusMessages.Status506VariantAlsoNegotiates);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 507 Insufficient Storage.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server is unable to store the representation needed to complete the request'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw507InsufficientStorage(string? message = default)
            => Throw(507, message ?? StatusMessages.Status507InsufficientStorage);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 508 Loop Detected.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Server detected an infinite loop while processing the request'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw508LoopDetected(string? message = default)
            => Throw(508, message ?? StatusMessages.Status508LoopDetected);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 510 Not Extended.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Further extensions to the request are required for the server to fulfill it'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw510NotExtended(string? message = default)
            => Throw(510, message ?? StatusMessages.Status510NotExtended);

        /// <summary>
        ///     Throws a new <see cref="HttpStatusException"/> with status code 511 Network Authentication Required.
        /// </summary>
        /// <param name="message">
        ///     An optional message describing the error.<br/>
        ///     Defaults to 'Client needs to authenticate to gain network access'.
        /// </param>
        [DoesNotReturn, StackTraceHidden]
        public static void Throw511NetworkAuthenticationRequired(string? message = default)
            => Throw(511, message ?? StatusMessages.Status511NetworkAuthenticationRequired);
    }
}
