using Autofac;

namespace Tyrell.Hand
{
    public class HandModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // It is possible to register default options in the module itself,
            // in this example, we create a default option for the Bone only.
            builder.RegisterInstance(new BoneOptions()
            {
                HasNerves = true,
                NumberOfBloodVessels = 5
            });

            builder.RegisterType<Finger>().As<IFinger>();
            builder.RegisterType<Bone>();
        }
    }
}
