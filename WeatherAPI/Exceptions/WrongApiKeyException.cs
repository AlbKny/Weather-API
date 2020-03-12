using System;
using System.Net.Http;
using System.Runtime.Serialization;

namespace WeatherAPI.Services
{
    [Serializable]
    internal class WrongApiKeyException : HttpRequestException
    {
        public WrongApiKeyException()
        {
        }

        public WrongApiKeyException(string message) : base(message)
        {
        }

        public WrongApiKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        //protected WrongApiKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}