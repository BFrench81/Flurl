﻿using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Flurl.Http
{
	public static class GetExtensions
	{
		/// <summary>
		/// Sends an asynchronous GET request.
		/// </summary>
		/// <returns>A Task whose result is the received HttpResponseMessage.</returns>
		public static Task<HttpResponseMessage> GetAsync(this FlurlClient client) {
			return client.HttpClient.GetAsync(client.Url);
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request.
		/// </summary>
		/// <returns>A Task whose result is the received HttpResponseMessage.</returns>
		public static Task<HttpResponseMessage> GetAsync(this string url) {
			return new FlurlClient(url).GetAsync();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request.
		/// </summary>
		/// <returns>A Task whose result is the received HttpResponseMessage.</returns>
		public static Task<HttpResponseMessage> GetAsync(this Url url) {
			return new FlurlClient(url).GetAsync();
		}

		/// <summary>
		/// Sends an asynchronous GET request and deserializes the JSON-formatted response body to an object of type T.
		/// </summary>
		/// <typeparam name="T">A type whose structure matches the expected JSON response.</typeparam>
		/// <returns>A Task whose result is an object containing data in the response body.</returns>
		public static Task<T> GetJsonAsync<T>(this FlurlClient client) {
			return client.GetAsync().ReceiveJson<T>();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and deserializes the JSON-formatted response body to an object of type T.
		/// </summary>
		/// <typeparam name="T">A type whose structure matches the expected JSON response.</typeparam>
		/// <returns>A Task whose result is an object containing data in the response body.</returns>
		public static Task<T> GetJsonAsync<T>(this string url) {
			return new FlurlClient(url).GetJsonAsync<T>();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and deserializes the JSON-formatted response body to an object of type T.
		/// </summary>
		/// <typeparam name="T">A type whose structure matches the expected JSON response.</typeparam>
		/// <returns>A Task whose result is an object containing data in the response body.</returns>
		public static Task<T> GetJsonAsync<T>(this Url url) {
			return new FlurlClient(url).GetJsonAsync<T>();
		}

		/// <summary>
		/// Sends an asynchronous GET request and deserializes the JSON-formatted response body to a dynamic object.
		/// </summary>
		/// <returns>A Task whose result is a dynamic object containing data in the response body.</returns>
		public static Task<dynamic> GetJsonAsync(this FlurlClient client) {
			return client.GetAsync().ReceiveJson();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and deserializes the JSON-formatted response body to a dynamic object.
		/// </summary>
		/// <returns>A Task whose result is a dynamic object containing data in the response body.</returns>
		public static Task<dynamic> GetJsonAsync(this string url) {
			return new FlurlClient(url).GetJsonAsync();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and deserializes the JSON-formatted response body to a dynamic object.
		/// </summary>
		/// <returns>A Task whose result is a dynamic object containing data in the response body.</returns>
		public static Task<dynamic> GetJsonAsync(this Url url) {
			return new FlurlClient(url).GetJsonAsync();
		}

		/// <summary>
		/// Sends an asynchronous GET request and deserializes the JSON-formatted response body to a list of dynamic objects.
		/// </summary>
		/// <returns>A Task whose result is a list of dynamic objects containing data in the response body.</returns>
		public static Task<IList<dynamic>> GetJsonListAsync(this FlurlClient client) {
			return client.GetAsync().ReceiveJsonList();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and deserializes the JSON-formatted response body to a list of dynamic objects.
		/// </summary>
		/// <returns>A Task whose result is a list of dynamic objects containing data in the response body.</returns>
		public static Task<IList<dynamic>> GetJsonListAsync(this string url) {
			return new FlurlClient(url).GetJsonListAsync();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and deserializes the JSON-formatted response body to a list of dynamic objects.
		/// </summary>
		/// <returns>A Task whose result is a list of dynamic objects containing data in the response body.</returns>
		public static Task<IList<dynamic>> GetJsonListAsync(this Url url) {
			return new FlurlClient(url).GetJsonListAsync();
		}

		/// <summary>
		/// Sends an asynchronous GET request and returns the response body as a string.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<string> GetStringAsync(this FlurlClient client) {
			return client.GetAsync().ReceiveString();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and returns the response body as a string.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<string> GetStringAsync(this string url) {
			return new FlurlClient(url).GetStringAsync();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and returns the response body as a string.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<string> GetStringAsync(this Url url) {
			return new FlurlClient(url).GetStringAsync();
		}

		/// <summary>
		/// Sends an asynchronous GET request and returns the response body as a stream.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<Stream> GetStreamAsync(this FlurlClient client) {
			return client.GetAsync().ReceiveStream();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and returns the response body as a stream.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<Stream> GetStreamAsync(this string url) {
			return new FlurlClient(url).GetStreamAsync();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and returns the response body as a stream.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<Stream> GetStreamAsync(this Url url) {
			return new FlurlClient(url).GetStreamAsync();
		}

		/// <summary>
		/// Sends an asynchronous GET request and returns the response body as a byte array.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<byte[]> GetBytesAsync(this FlurlClient client) {
			return client.GetAsync().ReceiveBytes();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and returns the response body as a byte array.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<byte[]> GetBytesAsync(this string url) {
			return new FlurlClient(url).GetBytesAsync();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and returns the response body as a byte array.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<byte[]> GetBytesAsync(this Url url) {
			return new FlurlClient(url).GetBytesAsync();
		}

		/// <summary>
		/// Sends an asynchronous GET request and returns the response body as an XDocument.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<XDocument> GetXmlAsync(this FlurlClient client) {
			return client.GetAsync().ReceiveXml();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and returns the response body as an XDocument.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<XDocument> GetXmlAsync(this string url) {
			return new FlurlClient(url).GetXmlAsync();
		}

		/// <summary>
		/// Creates a FlurlClient from the URL and sends an asynchronous GET request and returns the response body as an XDocument.
		/// </summary>
		/// <returns>A Task whose result is the response body.</returns>
		public static Task<XDocument> GetXmlAsync(this Url url) {
			return new FlurlClient(url).GetXmlAsync();
		}
	}
}
