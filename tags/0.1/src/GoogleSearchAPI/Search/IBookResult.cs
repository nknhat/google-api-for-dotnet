﻿/**
 * IBookResult.cs
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

namespace Google.API.Search
{
    /// <summary>
    /// Book search result.
    /// </summary>
    public interface IBookResult
    {
        /// <summary>
        /// Get the title of the book.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Get the URL of the result.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// Get the list of authors of the book.
        /// </summary>
        string Authors { get; }

        /// <summary>
        /// Get the identifier associated with the book. This is typically an ISBN.
        /// </summary>
        string BookId { get; }

        /// <summary>
        /// Get the year that the book was published.
        /// </summary>
        int PublishedYear { get; }

        /// <summary>
        /// Get the number of pages contained within the book.
        /// </summary>
        int PageCount { get; }

        /// <summary>
        /// Get a thumbnail image of the books cover.
        /// </summary>
        ITbImage TbImage { get; }
    }
}