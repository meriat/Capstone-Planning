using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models;

namespace WordCounter.Models
{
    public class WordChecker
    {
        private string _input;
        private List <string> _inputList;
        //add constructor
        public WordChecker(string input, List <string> inputList)
        {
            _input = input.ToLower();
            _inputList = inputList;

        }
        // public string GetInput()
        // {
        //     return _input;
        // }
        // public List<string> GetInputList()
        // {
        //     return _inputList;
        // }

        public bool IsWordEmpty()
        {
            //check if empty
             if (!_inputList.Any() || _input == "")
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        public int RepeatCounter()
        {
            //compare input to the list elements and output the counter
            int counter = 0;
            if(IsWordEmpty())
            {
                return -1;
            }
            for(int i = 0; i < _inputList.Count; i ++)
            {
                 if(_input == (_inputList[i].ToLower()))
                    {
                        counter++;
                    }
            }

            return counter;
        }
    }
}
// class Program
// {
//   public static void Main()
//   {
//     Console.WriteLine("Please enter a word");
//     string input = Console.ReadLine();
//     Console.WriteLine("Please enter a list of words");
//     List<string> inputList = new List<string>{};
//     inputList.Add(Console.ReadLine());
//     WordChecker checkWord = new WordChecker(input,inputList);
//     Console.WriteLine("Number of counts is " + checkWord.RepeatCounter());
//   }
// }