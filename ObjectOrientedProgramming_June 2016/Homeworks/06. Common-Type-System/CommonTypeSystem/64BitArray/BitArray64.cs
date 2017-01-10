namespace _64BitArray
{
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private int[] bits;

        public ulong DecimalValue
        {
            get
            {
                ulong decimalValue = 0;
                ulong powerOfTwo = 1;
                for (int i = 0; i < 64; i++, powerOfTwo *= 2)
                {
                    if (bits[64 - i - 1] == 1)
                    {
                        decimalValue += powerOfTwo;
                    }
                }

                return decimalValue;
            }
        }

        public BitArray64(ulong val)
        {
            bits = new int[64];
            for (int i = 0; i < 64; i++)
            {
                int mask = 1;
                int bit = (int)((val & ((ulong)mask << i)) >> i);
                bits[64 - i - 1] = bit;
            }
        }

        public int this[int index] => this.bits[index];

        public override bool Equals(object obj)
        {
            var objAsBitArray = obj as BitArray64;
            if (objAsBitArray == null)
            {
                return false;
            }

            return string.Join("", this.bits).Equals(string.Join("", objAsBitArray.bits));
        }

        public static bool operator ==(BitArray64 lhs, BitArray64 rhs)
        {
            bool eqRef = ReferenceEquals(lhs, rhs);

            if (eqRef)
            {
                return true;
            }

            return lhs.Equals(rhs);
        }

        public static bool operator != (BitArray64 lhs, BitArray64 rhs)
        {
            return !(lhs == rhs);
        }

        public override int GetHashCode()
        {
            int hashDat = 239;
            int hashMultiplier = 101;

            return (hashDat * hashMultiplier + this.bits.GetHashCode()) ^ this.DecimalValue.GetHashCode();
        }

        public override string ToString()
        {
            return string.Join(string.Empty, bits);
        }


        public IEnumerator<int> GetEnumerator()
        {
            foreach (int item in this.bits)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}