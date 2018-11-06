using System;
using CommomLib;
using UtilLib;
using Xunit;

namespace PersonalLib.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1.Say();
        }
         [Fact]
        public void Test2()
        {
            FirstUtil.Say();
        }
    }
}
