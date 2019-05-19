using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Game
    {
        public MadLibsGenerator Baskerville = new MadLibsGenerator(
            new List<string>()
            {
                "noun", "adjective", "adjective", "adjective",
                "occupation", "occupation", "occupation",
                "adjective", "noun", "noun"
            },
            "They all agreed that it was a huge {0}, {1}, {2}, and {3}."
            + " I have cross-examined these men, one of them a hard-headed "
            + "{4}, one a {5}, and one a moorland {6}"
            + ", who all tell the same story of this "
            + "{7} {8}, exactly corresponding to the {9} of the legend.");
    }
}
