using System;
using System.Collections.Generic;
using System.Linq;

public class Question1
{
    public static void ParseLocSegments()
    {
        string ediFactMessage = "UNA:+.? 'UNB+UNOC:3+2021000969+4441963198+180525:1225+3VAL2MJV6EH9IX+KMSV7HMD+CUSDECU-IE++1++1'UNH+EDIFACT+CUSDEC:D:96B:UN:145050'BGM+ZEM:::EX+09SEE7JPUV5HC06IC6+Z'LOC+17+IT044100'LOC+18+SOL'LOC+35+SE'LOC+36+TZ'LOC+116+SE003033'DTM+9:20090527:102'DTM+268:20090626:102'DTM+182:20090527:102";
        string[] edifFactMessageLines = ediFactMessage.Split('\'');
        List<List<string>> locSegments = new List<List<string>>();
        Console.WriteLine("Question 1");
        Console.WriteLine();

        foreach (var ediFactMessageLine in edifFactMessageLines)
        {
            string[] ediFactSegment = ediFactMessageLine.Split('+');
            if (ediFactSegment[0] == "LOC")
            {
                locSegments.Add(new List<string>() { ediFactSegment[1], ediFactSegment[2] });
                Console.WriteLine(ediFactMessageLine);
            }
        }
        Console.WriteLine();

        if (locSegments.Count() != 0)
        {
            string[][] arrayOfLocs = locSegments.Select(a => a.ToArray()).ToArray();
            Console.WriteLine("Array with the 2nd and 3rd element of each segment");
            int rowLength = arrayOfLocs.GetLength(0);
            int colLength = 2;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arrayOfLocs[i][j]));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}