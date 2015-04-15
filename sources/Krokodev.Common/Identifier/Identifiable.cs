// Crocodev (c) 2015 Crocodev
// Crocodev.Common
// Identifiable.cs
// romak_000, 2015-03-19 15:29

namespace Krokodev.Common.Identifier
{
    public class Identifiable<TC, TV>
    {
        public class Identifier : GenericIdentifier<TC, TV>
        {
            private Identifier(TV value)
                : base(value)
            {
            }

            public Identifier()
            {
            }

            public static explicit operator Identifier(TV value)
            {
                return new Identifier(value);
            }
        }
    }
}