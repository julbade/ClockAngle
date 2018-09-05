using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle;
using System.Collections.Generic;

namespace ClockAngle.Tests
{
  [TestClass]
  public class ClockTest
  {

    [TestMethod]
    public void isClockAngle_face_True()
    {

      CollectionAssert.AreEqual(testList, ClockAngle.isClockAngle( ));
    }
  }
}
