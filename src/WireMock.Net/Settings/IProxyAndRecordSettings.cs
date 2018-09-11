using WireMock.Matchers;

namespace WireMock.Settings
{
    /// <summary>
    /// IProxyAndRecordSettings
    /// </summary>
    public interface IProxyAndRecordSettings
    {
        /// <summary>
        /// The URL to proxy.
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// Save the mapping for each request/response to the internal Mappings structure.
        /// </summary>
        bool SaveMapping { get; set; }

        /// <summary>
        /// Save the mapping for each request/response also to a file. (Note that SaveMapping must also be set to true.)
        /// </summary>
        bool SaveMappingToFile { get; set; }

        /// <summary>
        /// The clientCertificate thumbprint or subject name fragment to use.
        /// Example thumbprint : "D2DBF135A8D06ACCD0E1FAD9BFB28678DF7A9818". Example subject name: "www.google.com".
        /// </summary>
        string ClientX509Certificate2ThumbprintOrSubjectName { get; set; }

        /// <summary>
        /// Defines a list from headers which will excluded from the saved mappings.
        /// </summary>
        string[] BlackListedHeaders { get; set; }

        /// <summary>
        /// Defines the default matcher and pattern to use when saving the matching details for a header.
        /// If the pattern is null (default), the value from the header is used. Also by default the <see cref="WildcardMatcher"/> will be used.
        /// </summary>
        (string Matcher, string Pattern)? MatcherAndPatternUsedForHeaders { get; set; }
    }
}
