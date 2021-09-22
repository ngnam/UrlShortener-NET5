using System;
using UrlShortener.Interfaces;
using UrlShortener.Models;

namespace UrlShortener.Implements
{
    public class ShortenerService : IShortenerService
    {
        public string HandleShortenUrl(string requestedUrl, string Scheme, string Host)
        {
            // Perform basic form validation
            if (string.IsNullOrEmpty(requestedUrl))
            {
                return "The url is required.";
            }

            // Test our URL
            if (!Uri.TryCreate(requestedUrl, UriKind.Absolute, out Uri result))
            {
                return "Could not understand URL.";
            }

            var url = result.ToString();

            // Temporary short link 
            var entry = new ShortLink
            {
                Id = 1,
                Url = url
            };

            var urlChunk = entry.GetUrlChunk();
            var responseUri = $"{Scheme}://{Host}/{urlChunk}";
            return responseUri;
        }
    }
}
