using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class MadLibsGenerator
    {
        private List<string> _insertions { get; set; }
        private string _story { get; set; }

        public MadLibsGenerator (List<string> insertions, string story)
        {
            this._insertions = insertions;
            this._story = story;
        }

        private List<string> GetInput()
        {
            var input = new List<string>();
            foreach (var insertion in _insertions)
            {
                Console.WriteLine("Please enter a {0}", insertion);
                input.Add(Console.ReadLine());
            }

            return input;
        }

        public void PrintEditedStory()
        {
            Console.WriteLine(_story, GetInput().ToArray());
        }

    }
}
