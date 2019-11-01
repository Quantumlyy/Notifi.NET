#pragma warning disable CS1591

using System;
using System.Net.Http;

namespace Notifi.NET.Singletons
{
    public class Singletons
    {
        private static readonly Lazy<HttpClient> LazyHttpClient
            = new Lazy<HttpClient>(() => new HttpClient());

        private static readonly Lazy<Random> LazyRandom
            = new Lazy<Random>();

        public static HttpClient HttpClient
            => LazyHttpClient.Value;

        public static Random Random
            => LazyRandom.Value;
    }
}
