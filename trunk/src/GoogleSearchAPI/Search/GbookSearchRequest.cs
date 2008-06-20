﻿/**
 * GbookSearchRequest.cs
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
    internal class GbookSearchRequest : GSearchRequestBase
    {
        private static readonly string s_BaseAddress = @"http://ajax.googleapis.com/ajax/services/search/books";

        public GbookSearchRequest(string keyword, int start, ResultSize resultSize, bool FullViewOnly, string library)
            : base(keyword, start, resultSize)
        {
            this.FullViewOnly = FullViewOnly;
            Library = library;
        }

        public bool FullViewOnly { get; private set; }

        /// <summary>
        /// This optional argument tells the book search system to restrict the search to "full view" books, or all books. A value of as_brr=1 restricts the search to only those books that are viewable in full. The default case is all books and that is indicated by not specifying this argument.
        /// </summary>
        [Argument("as_brr")]
        private string AsBrr
        {
            get
            {
                if (FullViewOnly)
                {
                    return "1";
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// This optional argument tells the book search system to restrict the search to the specified user-defined library.
        /// </summary>
        [Argument("as_list", NeedEncode = true)]
        public string Library { get; private set; }

        protected override string BaseAddress
        {
            get { return s_BaseAddress; }
        }
    }
}