using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrell.Hand
{
    public class Finger : IFinger
    {
        private FingerOptions options;
        private Func<Bone> boneFactory;

        public List<Bone> Joints { get; } = new List<Bone>();

        public Finger(FingerOptions options, Func<Bone> boneFactory)
        {
            this.options = options;
            this.boneFactory = boneFactory;
            
            // Use the Joints from FingerOptions.
            for (int i = 0; i < options.Joints; i++)
            {
                var bone = boneFactory();
                Joints.Add(bone);
            }
        }

        public void Extend(int extends)
        {
            foreach (var bone in Joints)
            {
                bone.Move(extends);
            }

            // Retreive the connection string from options to connect with Arm.
            var connectionString = options.ConnectionString;

            Arm arm = new Arm();
            arm.ConnectionString = connectionString;
            arm.Connect(this);
        }
    }
}
