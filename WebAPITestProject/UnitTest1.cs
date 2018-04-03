using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebAPI.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace WebAPITestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CoursesController controller = new CoursesController();
            List<int> testCourses = controller.GetCourses();

            List<int> testResults = new List<int>();
            testResults.Add(1);
            testResults.Add(2);
            testResults.Add(3);
            testResults.Add(4);

            Assert.IsTrue(testResults.SequenceEqual(testCourses));


        }


        [TestMethod]
        public void TestMethod2()
        {
            CoursesController controller = new CoursesController();
            List<int> testCourses = controller.GetCourses();

            List<int> testResults = new List<int>();
            testResults.Add(1);
            testResults.Add(2);
            testResults.Add(3);
            testResults.Add(4);

            Assert.IsTrue(testResults[0] == testCourses[0]);


        }

        [TestMethod]
        public void TestMethod3()
        {
            CoursesController controller = new CoursesController();
            List<int> testCourses = controller.GetCourses();

            List<int> testResults = new List<int>();
            testResults.Add(1);
            testResults.Add(2);
            testResults.Add(3);
            testResults.Add(4);

            Assert.IsTrue(testCourses[3] == 4);


        }


    }
}
