using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CodeCompiler
{
    class BurstPair
    {
        public int on;
        public int off;
        public int num;

        public BurstPair(int a, int b)
        {
            on = a;
            off = b;
            num = 1;
        }

        public bool equals(BurstPair b)
        {
            return ((on == b.on) && (off == b.off));
        }

        public bool withinTol(BurstPair b)
        {
            return ((Math.Abs(on - b.on) <= 1) && (Math.Abs(off - b.off) <= 1));
        }

        public void set(BurstPair b)
        {
            on = b.on;
            off = b.off;
        }

        public override String ToString()
        {
            return "{" + on + ", " + off + "}";
        }
    }

    class Code
    {
        public String name;
        public int carrier;
        public int seq1;
        public int seq2;
        public List<BurstPair> pairs = new List<BurstPair>();
        public List<BurstPair> dict = new List<BurstPair>();

        public Code(String n, String code)
        {
            name = n;
            buildPairs(code);
            buildDict();
        }

        private void buildPairs(String code)
        {
            String[] split = code.Split(' ');
            int[] values = new int[split.Length];

            //take things out of hex
            for (int i = 0; i < split.Length; i++)
            {
                values[i] = Convert.ToInt32(split[i], 16);
                //init the pairs list
                if (i >= 4)
                {
                    if ((i % 2) == 0)
                    {
                        pairs.Add(new BurstPair(0, 0));
                    }
                }
            }

            //force ending OFF value to zero, handle dict entries later
            values[values.Length - 1] = 1;

            //collect header information
            carrier = values[1];
            seq1 = values[2];
            seq2 = values[3];

            //compute carrier
            carrier = (int)Math.Round((double)carrier * 0.120623);

            //pair up the values
            for (int i = 4; i < values.Length; i++)
            {
                int p = (int)Math.Floor((double)(i - 4) / 2);

                if ((i % 2) == 0)
                {
                    pairs[p].on = values[i];
                }
                else
                {
                    pairs[p].off = values[i];
                }
            }

            //if more than one sequences are present
            if ((seq1 > 0) && (seq2 > 0))
            {
                //truncate to use the first sequence
                pairs.RemoveRange(seq1, pairs.Count - seq1);
            }
        }

        private void buildDict()
        {
            for (int i = 0; i < pairs.Count; i++)
            {
                BurstPair b = pairs[i];
                if (!inDict(b))
                {
                    dict.Add(b);
                }
            }
        }

        private bool inDict(BurstPair b)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                if (dict[i].equals(b))
                {
                    dict[i].num += b.num;
                    return true;
                }
            }
            return false;
        }

        public void enforceDict(List<BurstPair> newDict)
        {
            for (int i = 0; i < newDict.Count; i++)
            {
                BurstPair newBurst = newDict[i];

                for (int p = 0; p < pairs.Count; p++)
                {
                    BurstPair burst = pairs[p];

                    if (newBurst.withinTol(burst))
                    {
                        burst.set(newBurst);
                    }
                }
            }
        }

        public BurstPair getEnd()
        {
            return pairs[pairs.Count - 1];
        }

        public void setEnd(BurstPair b)
        {
            getEnd().set(b);
        }

        public void substitute(List<BurstPair> dict)
        {
            for (int i = 0; i < pairs.Count; i++)
            {
                pairs[i].num = findInDict(dict, pairs[i]);
            }
        }

        private int findInDict(List<BurstPair> dict, BurstPair b)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                if (dict[i].equals(b))
                {
                    return i;
                }
            }
            return -1;
        }

        public override String ToString()
        {
            String result = "";
            for (int i = 0; i < pairs.Count; i++)
            {
                result += pairs[i].ToString() + ", ";
            }
            return result;
        }

        public String ToCode()
        {
            String result = "{{";
            for (int i = 0; i < pairs.Count; i++)
            {
                String s = ", ";
                if (i % 2 == 1)
                {
                    s = "}, {";
                }
                if (i == pairs.Count - 1)
                {
                    s = "}";
                    //handle odd numbered codes
                    if (pairs.Count % 2 == 1)
                    {
                        s = ", 0}";
                    }
                }
                result += pairs[i].num.ToString() + s;
            }
            result = "const Nibbles " + name + "[] PROGMEM = " + result + "}";
            return result;
        }

        public String GetEntry(String dictName)
        {
            return "{" + dictName + ", " + name + ", " + pairs.Count + ", " + carrier + "}";
        }
    }
}
