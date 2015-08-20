using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrell.Hand.Tests
{
    public static class Container
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new HandModule());

            // Bone have a default option, we will override with this setting.
            builder.RegisterInstance(new BoneOptions()
            {
                HasNerves = true,
                NumberOfBloodVessels = 10
            });

            builder.RegisterInstance(new FingerOptions()
            {
                Index = 0,
                Joints = 3,
                ConnectionString = "name:ReplicantLeftArm"
            });

            return builder.Build();
        }
    }
}
