/**
 * INewsSearchResultItem.cs
 *
 * Copyright (C) 2008,  iron9light
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;

namespace Google.API.Search
{
    /// <summary>
    /// A story of news search result.
    /// </summary>
    public interface INewsSearchResultItem
    {
        /// <summary>
        /// Get the url.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// Get the title.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Get the name of the publisher of the news story.
        /// </summary>
        string Publisher { get; }

        /// <summary>
        /// Get the location of the news story. This is a list of locations in most specific to least specific order where the components are seperated by ",". Note, there may only be one element in the list... A typical value for this property is "Edinburgh,Scotland,UK" or possibly "USA".
        /// </summary>
        string Location { get; }

        /// <summary>
        /// Get the published date of the news story referenced by this search result.
        /// </summary>
        DateTime PublishedDate { get; }
    }
}