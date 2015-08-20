namespace Tyrell.Hand
{
    public class Bone
    {
        private BoneOptions options;

        public int Extends { get; set; }

        public Bone(BoneOptions options)
        {
            this.options = options;
        }

        public void Move(int extends) {

            // Extend this join to the extend supplied.
            Extends = extends;

            if (options.HasNerves)
            {
                // Do something.
            }

            if (options.NumberOfBloodVessels > 5)
            {
                // Do another thing.
            }
            else
            {
                // Do something else.
            }
        }
    }
}