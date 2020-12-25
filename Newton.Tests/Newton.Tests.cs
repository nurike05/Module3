//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using Module_3._1;


namespace Newton.Tests
{

    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, 5, 0.000_001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        //[TestCase(0.041_006_25, 4, 0.0001, 0.45)]
        //[TestCase(0.027_9936, 7, 0.0001, 0.6)]
        //[TestCase(-0.008, 3, 0.1, -0.2)]
        //[TestCase(0.004_241_979, 9, 0.000_000_01, 0.545)]
        //[TestCase(0.0081, 4, 0.1, 0.3)]
        public void Sqrt_Num_Root_Result(double num, double n, double res)
        {
            NewtonSqrtN sqrt = new NewtonSqrtN();
            Assert.AreEqual(sqrt.SqrtN(num, n), res, 0.0000001);
        }

       
    }
}
