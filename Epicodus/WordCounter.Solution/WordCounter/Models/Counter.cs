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

        public WordChecker(string input, List <string> inputList)
        {
            _input = input;
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

        public bool IsWordNotEmpty()
        {
            //check if empty
             if (!_inputList.Any() || _input == "")
            {
               return true;
            }
            // else if(_input.Contains(_inputList[0]))
            // {
            //     return true;
            // }
            else
            {
                while(!_inputList.Any())
                {
                    for(int i = 0; i <= _inputList.Count; i ++)
                    {
                        if(_input == _inputList[i])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                 return true;
            }
        }

    }
}