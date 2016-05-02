// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LetterCount.cs" author="Pedro Magueija">
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HtmlWebsiteDownload
{
    internal class LetterCount
    {
        public char Letter { get; }
        public int Count { get; }

        public LetterCount(char letter, int count)
        {
            Letter = letter;
            Count = count;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return $"{Letter} appears {Count} times.";
        }
    }
}