namespace Elementary_Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Envelope class 
    /// </summary>
    public class Envelope : IComparable<Envelope>
    {
        /// <summary>
        /// Gets or sets Height of the Enveolope 
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets Width of the Envelope
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Gets or sets Width of the Envelope
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Compare 2 envelope
        /// </summary>
        /// <param name="secondenvelope">Second envelope to compare</param>
        /// <returns>Returns count of line entries</returns>
        public int CompareTo(Envelope secondenvelope)
        {
            if ((this.Width > secondenvelope.Width) && (this.Height >= secondenvelope.Height))
            {
                Console.WriteLine(this.Name);
                return 1;
            }
            if ((this.Width > secondenvelope.Height) && (this.Height >= secondenvelope.Width))
            {
                Console.WriteLine("the second envelope fits in the first");
                return 1;
            }
            else if ((this.Width < secondenvelope.Width) && (this.Height <= secondenvelope.Height))
            {
                Console.WriteLine(secondenvelope.Name);
                return 1;
            }
            else if ((this.Width < secondenvelope.Height) && (this.Height <= secondenvelope.Width))
            {
                Console.WriteLine("the first envelope fits in the second");
                return 1;
            }
            else
            {
                Console.WriteLine("Envelopes are not compatible");
                return -1;
            }
        }
    }
}
