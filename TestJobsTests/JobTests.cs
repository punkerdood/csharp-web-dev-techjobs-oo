using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TestJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            int testCase1 = new TechJobsOO.Job().Id;
            int testCase2 = new TechJobsOO.Job().Id;
            Assert.IsFalse(testCase1 == testCase2);
            Assert.IsTrue(testCase1 == testCase2 - 1);
            ; }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job wholeTest = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Assert.AreEqual("Product tester", wholeTest.Name);
            Assert.AreEqual("ACME", wholeTest.EmployerName.Value);
            Assert.AreEqual("Desert", wholeTest.EmployerLocation.Value);
            Assert.AreEqual("Quality control", wholeTest.JobType.Value);
            Assert.AreEqual("Persistance", wholeTest.JobCoreCompetency.Value);
        }
        [TestMethod]
        
        public void TestJobsForEquality()
        {
            Job testCase1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Job testCase2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistance"));
            Assert.IsFalse(testCase2.Equals(testCase1));


        }
    }
}
