using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.Models;

namespace UrlShortener.Interfaces
{
    public interface IShortenerService
    {
        string HandleShortenUrl(string requestedUrl, string Scheme, string Host);
    }
}
