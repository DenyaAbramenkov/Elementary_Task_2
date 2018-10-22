namespace Elementary_Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class Envelope : IComparable<Envelope>
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        private Envelope(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public static Envelope EnvelopeInitialize(int height, int width)
        {
            if (width > 0 && height > 0)
            {
                
                    return new Envelope(height, width);
            }
            else
            {
                throw new ArgumentException("Incorrect width or height. Values should be natural numbers");
            }

        }
        public int CompareTo(Envelope secondEnvelope)
        {
            for (int alpha = 90; alpha >= 0; alpha--)
            {
                if ((Height * Math.Cos(alpha * Math.PI / 180)) + (Width * Math.Cos((90 - alpha) * Math.PI / 180)) < secondEnvelope.Height)
                {
                    if ((Height * Math.Cos((90 - alpha) * Math.PI / 180)) + (Width* Math.Sin((90 - alpha) * Math.PI / 180)) < secondEnvelope.Width)
                    {
                        return 1;
                    }
                }
            }
            
            return -1;
        }
    }
}
