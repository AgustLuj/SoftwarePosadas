/*
 * Created by SharpDevelop.
 * User: Mateo Pidal
 * Date: 15/8/2018
 * Time: 1:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Program
{
  [TestFixture]
  public class Test1
  {
    [Test]
    public void TestMethod()
    {
      
      Assert.IsTrue(1 == 1);
      Console.WriteLine(string.Format("{0} Tests passed", Assert.Counter));
    }
    
    [Test]
    public void Test2() {
      //Assert.Fail();
      Assert.Pass();
    }
  }
}
