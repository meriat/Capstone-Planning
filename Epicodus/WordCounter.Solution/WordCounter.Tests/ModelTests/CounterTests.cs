using System;
using System.Collections.Generic;
using WordCounter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void IsWord_CheckIfInputIsValid_String()
        {
            //Arrange
            string input = "";
            List<string> inputList = new List<string> {};
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             bool result = newCount.IsWordEmpty();
            
            //Assert
            Assert.AreEqual(false, result);
        
        }
    }
}
