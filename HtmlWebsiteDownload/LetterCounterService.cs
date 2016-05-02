// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LetterCounterService.cs" author="Pedro Magueija">
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
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    internal class LetterCounterService
    {
        private static readonly char[] Letters =
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b',
                'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

        public async Task<List<LetterCount>> CountAsync(string text)
        {
            return await Task.Run(() => Count(text));
        }

        public List<LetterCount> Count(string text)
        {
            var taskList = new List<Task<LetterCount>>();
            var taskFactory = new TaskFactory();

            foreach (char letter in Letters)
            {
                Task<LetterCount> newTask = taskFactory.StartNew(() => CountLetter(letter, text));
                taskList.Add(newTask);
            }

            Task.WaitAll(taskList.ToArray());

            var countMap = new List<LetterCount>();
            foreach (Task<LetterCount> task in taskList)
            {
                countMap.Add(task.Result);
            }

            Thread.Sleep(3000);
            return countMap;
        }

        private LetterCount CountLetter(char searchLetter, string text)
        {
            char[] letters = text.ToCharArray();
            int count = 0;

            foreach (char letter in letters)
            {
                if (letter.Equals(searchLetter))
                    count++;
            }

            return new LetterCount(searchLetter, count);
        }
    }
}