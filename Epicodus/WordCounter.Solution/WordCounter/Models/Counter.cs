using namespace
{
    public class WordCounter
    {
        private string _input;
        private List <string> _inputList;

        public WordCounter(string input, List <string> inputList)
        {
            _input = input;
            _inputList = inputList;
        }
        public string GetInput()
        {
            return _input;
        }
        public List<string> GetInputList()
        {
            return _inputList;
        }

        public int RepeatCounter ()
        {
            if (!_inputList.Any() || _input == "")
            {
                return "Please provide both a word and a list of words.";
            }
            else
            {
                
            }
        }

    }
}