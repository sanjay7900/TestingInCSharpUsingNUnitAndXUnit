using Xunit;
using XHandsonPractice;
using Moq;
using System;
using NUnit.Framework;

namespace TestOperations
{
    public class UnitTest1
    {
        Operations operations=new Operations(); 
        [Fact]
        public void Class_add_test()
        {
            var a = 10;
            var b = 20;
            var result = 30;
            Xunit.Assert.Equal(result, operations.Additions(a, b));

        }
        [Fact]
        public void Class_sub_test()
        {
            var a = 20;
            var b = 10;
            var result = 10;
            Xunit.Assert.Equal(result, operations.Substraction(a, b));

        }
        [Fact]
        public void Class_mul_test()
        {
            var a = 20;
            var b = 10;
            var result = 200;
            Xunit.Assert.Equal(result, operations.Multiply(a, b));

        }
        [Fact]
        public void Class_div_test()
        {
            var a = 20;
            var b = 10;
            var result = 2;
            Xunit.Assert.Equal(result, operations.Division(a, b));

        }

        //interface Testing
        [Fact]
        public void add_interface_test()
        {
            var interfaceObject = new Mock<Ioperation>();
            interfaceObject.Setup(obj => obj.add(10, 20)).Returns(30);
           Xunit.Assert.Equal(30, interfaceObject.Object.add(10, 20));

        }
       [Fact]
       public void subs_Interface_test()
        {
            var subInterfaceObj=new Mock<Ioperation>();
            subInterfaceObj.Setup(obj=>obj.sub(20,10)).Returns(10);
            Xunit.Assert.Equal(10, subInterfaceObj.Object.sub(20, 10));
        }
        [Fact]
        public void div_Interface_test()
        {
            var subInterfaceObj = new Mock<Ioperation>();
            subInterfaceObj.Setup(obj => obj.sub(20, 10)).Returns(2);
            Xunit.Assert.Equal(2, subInterfaceObj.Object.sub(20, 10));
        }
        [Fact]
        public void mul_Interface_test()
        {
            var subInterfaceObj = new Mock<Ioperation>();
            subInterfaceObj.Setup(obj => obj.sub(20, 10)).Returns(200);
            Xunit.Assert.Equal(200, subInterfaceObj.Object.sub(20, 10));
        }




    }
}