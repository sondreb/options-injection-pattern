using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tyrell.Hand.Tests
{
    public class FingerTests
    {
        private IContainer container;

        public FingerTests()
        {
            container = Container.Register();
        }

        [Fact]
        public void Finger_Create_ShouldSucceed()
        {
            // Arrange
            var finger = container.Resolve<IFinger>();

            //  Act
            finger.Extend(50);

            // Assert
            Assert.Equal(3, finger.Joints.Count); // The container in the unit test project specifies 3 joints, verify this.
            
            Assert.Equal(50, finger.Joints[0].Extends); // Verify that each joint is extend to the specified extend on the finger.
        }
    }
}
