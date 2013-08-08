using System.IO;
using System.Collections.Generic;
using System;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

            Console.WriteLine(ConvertNumberToTextDollars(line));
        }
    }

    public static string ConvertNumberToTextDollars(string number)
    {
        int stringLength = number.Length;
        
        StringBuilder result = new StringBuilder("Dollars");

        //Split into chunks of 3
        var chunksOfThree = new List<string>();
        while (number.Length > 3)
        {
            int startingIndex = number.Length - 3;
            chunksOfThree.Add(number.Substring(startingIndex,3));
            number = number.Substring(0, startingIndex);
        }
        if (number != String.Empty) chunksOfThree.Add(number);

        for (int i = 0; i < chunksOfThree.Count; i++)
        {
            string chunkText = "";
            string denomText = "";
		    if (i == 0)
            {
                denomText = "";
            }
            else if (i == 1)
            {
                denomText = "Thousand";
            }
            else if (i == 2)
            {
                denomText = "Million";
            }

            chunkText = GetChunkText(chunksOfThree[i], denomText);

            result.Insert(0, chunkText);
		}

        return result.ToString();
    }

    private static string GetChunkText(string chunkText, string denomText)
    {
        string ret = "";
        int length = chunkText.Length;

        if (length == 1)
        {
            ret = GetTextRepresentation(chunkText[0].ToString());
        }
        else if (length >= 2)
        {
            ret = ConvertSingleAndTensPlace(chunkText[length - 2].ToString(), chunkText[length - 1].ToString());
            if (length == 3)
            {
                string tempRet = GetTextRepresentation(chunkText[0].ToString());
                if (tempRet != String.Empty) ret = tempRet + "Hundred" + ret;
            }
        }

        if (ret != String.Empty) ret = ret + denomText;
        return ret;
    }

    static string ConvertSingleAndTensPlace(string tens, string single)
    {
        switch (tens)
        {
            case "0":
                return GetTextRepresentation(single);
            case "1":
                switch (single)
	            {
                    case "0":
                        return "Ten";
                    case "1":
                        return "Eleven";
                    case "2":
                        return "Twelve";
                    case "3":
                        return "Thirteen";
                    case "5":
                        return "Fifteen";
                    case "4":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        return GetTextRepresentation(single)+"teen";
                    default:
                        throw new ArgumentOutOfRangeException("single", single, "Single must be in the range 0..9");
	            }
                break;
            case "2":
                return "Twenty" + GetTextRepresentation(single);
            case "3":
                return "Thirty" + GetTextRepresentation(single);
            case "4":
                return "Forty" + GetTextRepresentation(single);
            case "5":
                return "Fifty" + GetTextRepresentation(single);
            case "8":
                return "Eighty" + GetTextRepresentation(single);
            case "6":
            case "7":
            case "9":
                return GetTextRepresentation(tens) + "ty" + GetTextRepresentation(single);
        }
        throw new ArgumentOutOfRangeException("tens", tens, "Single must be in the range 1..9");
    }

    static string GetTextRepresentation(string number)
    {
        switch (number)
        {
            case "0":
                return "";
            case "1":
                return "One";
            case "2":
                return "Two";
            case "3":
                return "Three";
            case "4":
                return "Four";
            case "5":
                return "Five";
            case "6":
                return "Six";
            case "7":
                return "Seven";
            case "8":
                return "Eight";
            case "9":
                return "Nine";
        }
            
        throw new ArgumentOutOfRangeException("number", number, "Number must be in the range 0..9");
    }
}