using System;

namespace Altkom.BPSC.CSharp.Models
{
    public class Service : Item
    {
        public Service(string name, decimal unitPrice, TimeSpan duration)
            : base(name, unitPrice)
        {
            this.Duration = duration;
        }

        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            return $"{Name} {Duration}";
        }
    }
}
