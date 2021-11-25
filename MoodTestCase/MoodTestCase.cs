using Microsoft.VisualStudio.TestTools.UnitTesting;

using MoodAnalyser;
using System;
using System.Runtime.Serialization;

namespace moodAnalysisTest
{
    [TestClass]
    public class MoodTestCase
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        ////TEST CASE-1

        ////Arrange
        //string message = null;
        //string expected = "Message Should Not Be Null";
        //string actual = null;

        //try
        //{
        //    //Act
        //    moodAnalysis analyser = new moodAnalysis(message);
        //    actual = analyser.AnalyseMood();
        //}
        //catch (MoodAnalyserCustomException ex)
        //{
        //    //Assert
        //    Assert.AreEqual(expected, ex.Message);
        //}


        //}

        [TestMethod]
        public void getCustomNullException()
        {
            //Arrange
            string expected = "Message Should Not Be Empty";
            moodAnalysis modeAnalyzer = new moodAnalysis(string.Empty);

            try
            {
                //Act
                string actual = modeAnalyzer.AnalyseMood();

            }
            catch (MoodAnalyserCustomException ex)
            {

                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}

