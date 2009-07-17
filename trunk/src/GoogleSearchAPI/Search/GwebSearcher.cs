﻿//-----------------------------------------------------------------------
// <copyright file="GwebSearcher.cs" company="iron9light">
// Copyright (c) 2009 iron9light
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// </copyright>
// <author>iron9light@gmail.com</author>
//-----------------------------------------------------------------------

namespace Google.API.Search
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Utility class for Google Web Search service.
    /// </summary>
    [Obsolete("Use GwebSearchClient instead.")]
    public static class GwebSearcher
    {
        /// <summary>
        /// Search.
        /// </summary>
        /// <param name="keyword">The keyword.</param>
        /// <param name="resultCount">The count of result itmes.</param>
        /// <returns>The result items.</returns>
        /// <remarks>Now, the max count of items Google given is <b>32</b>.</remarks>
        /// <example>
        /// This is the c# code example.
        /// <code>
        /// IList&lt;IWebResult&gt; results = GwebSearcher.Search("Google API for .NET", 8);
        /// foreach(IWebResult result in results)
        /// {
        ///     Console.WriteLine("{0} - {1}", result.Title, result.Content);
        /// }
        /// </code>
        /// </example>
        public static IList<IWebResult> Search(string keyword, int resultCount)
        {
            return Search(keyword, resultCount, new Language(), new SafeLevel());
        }

        /// <summary>
        /// Search.
        /// </summary>
        /// <param name="keyword">The keyword.</param>
        /// <param name="resultCount">The count of result itmes.</param>
        /// <param name="language">The language you want to search.</param>
        /// <returns>The result itmes.</returns>
        /// <remarks>Now, the max count of items Google given is <b>32</b>.</remarks>
        /// <example>
        /// This is the c# code example.
        /// <code>
        /// IList&lt;IWebResult&gt; results = GwebSearcher.Search("Google API for .NET", 32, Language.ChineseSimplified);
        /// foreach(IWebResult result in results)
        /// {
        ///     Console.WriteLine("{0} - {1}", result.Title, result.Content);
        /// }
        /// </code>
        /// </example>
        public static IList<IWebResult> Search(string keyword, int resultCount, Language language)
        {
            return Search(keyword, resultCount, language, new SafeLevel());
        }

        /// <summary>
        /// Search.
        /// </summary>
        /// <param name="keyword">The keyword.</param>
        /// <param name="resultCount">The count of result itmes.</param>
        /// <param name="language">The language you want to search.</param>
        /// <param name="safeLevel">The search safety level.</param>
        /// <returns>The result itmes.</returns>
        /// <remarks>Now, the max count of items Google given is <b>32</b>.</remarks>
        /// <example>
        /// This is the c# code example.
        /// <code>
        /// IList&lt;IWebResult&gt; results = GwebSearcher.Search("Google API for .NET", 20, Language.ChineseSimplified, SafeLevel.active);
        /// foreach(IWebResult result in results)
        /// {
        ///     Console.WriteLine("{0} - {1}", result.Title, result.Content);
        /// }
        /// </code>
        /// </example>
        public static IList<IWebResult> Search(string keyword, int resultCount, Language language, SafeLevel safeLevel)
        {
            var client = new GwebSearchClient();
            return client.Search(keyword, resultCount, language, safeLevel);
        }

        internal static SearchData<GwebResult> GSearch(
            string keyword, int start, ResultSize resultSize, Language language, SafeLevel safeLevel)
        {
            var client = new GwebSearchClient();
            return client.GSearch(keyword, start, resultSize, null, null, safeLevel, language, true);
        }
    }
}