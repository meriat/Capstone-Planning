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
        public void IsWordEmpty_CheckIfInputIsValid_String()
        {
            //Arrange
            string input = "";
            List<string> inputList = new List<string> {};
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             bool result = newCount.IsWordNotEmpty();
            
            //Assert
            Assert.AreEqual(true, result);
        
        }
        [TestMethod]
        public void IsWordNotEmpty_CheckIfInputIsValid_String()
        {
            //Arrange
            string input = "hello";
            List<string> inputList = new List<string> {"helo"};
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             bool result = newCount.IsWordNotEmpty();
            
            //Assert
            Assert.AreEqual(true, result);
        
        }
    }
}
