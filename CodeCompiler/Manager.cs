﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCompiler
{
    class Manager
    {
        private List<Code> codes = new List<Code>();
        private List<BurstPair> dict = new List<BurstPair>();
        private List<BurstPair> finishedDict = new List<BurstPair>();

        public Manager()
        {
            /* panasonic
            codes.Add(new Code("POWER ON",     "0000 0071 0000 0032 0080 003F 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0030 0010 0030 0010 0030 0010 0030 0010 0010 0010 0010 0010 0010 0010 0030 0010 0030 0010 0030 0010 0030 0010 0030 0010 0010 0010 0030 0010 0A98"));
            codes.Add(new Code("POWER OFF",    "0000 0071 0000 0032 0080 003F 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0030 0010 0030 0010 0030 0010 0030 0010 0030 0010 0010 0010 0010 0010 0030 0010 0030 0010 0030 0010 0030 0010 0030 0010 0030 0010 0010 0010 0030 0010 0A98"));
            codes.Add(new Code("MUTE",         "0000 0071 0000 0032 0080 0040 0010 0010 0010 0031 0010 0011 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0031 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0031 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0031 0010 0010 0010 0010 0010 0031 0010 0031 0010 0010 0010 0010 0010 0010 0010 0031 0010 0010 0010 0010 0010 0031 0010 0031 0010 0010 0010 0031 0010 0A9E"));
            codes.Add(new Code("VOLUME UP",    "0000 0070 0000 0032 0080 0040 0010 0010 0010 0031 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0011 0010 0010 0010 0031 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0031 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0031 0010 0010 0010 0010 0010 0010 0010 0010 0010 0011 0010 0010 0010 0010 0010 0031 0010 0010 0010 0031 0010 0AA1"));
            codes.Add(new Code("VOLUME DOWN",  "0000 0071 0000 0032 0080 0040 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0030 0010 0010 0010 0010 0010 0010 0010 0010 0010 0030 0010 0010 0010 0030 0010 0A9D"));
            codes.Add(new Code("CHANNEL UP",   "0000 0070 0000 0032 0081 0041 0010 0011 0010 0031 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0031 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0031 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0031 0010 0011 0010 0031 0010 0031 0010 0011 0010 0011 0010 0011 0010 0011 0010 0031 0010 0011 0010 0031 0010 0031 0010 0011 0010 0031 0010 0AB6"));
            codes.Add(new Code("CHANNEL DOWN", "0000 0070 0000 0032 0081 0041 0010 0011 0010 0031 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0031 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0031 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0011 0010 0031 0010 0011 0010 0031 0010 0011 0010 0031 0010 0031 0010 0011 0010 0011 0010 0031 0010 0011 0010 0031 0010 0011 0010 0031 0010 0031 0010 0011 0010 0031 0010 0AB4"));
            */

            /* sony
            codes.Add(new Code("POWER ON",     "0000 0067 0000 000D 0060 0018 0018 0018 0030 0018 0030 0018 0030 0018 0018 0018 0030 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 03F6"));
            codes.Add(new Code("POWER OFF",    "0000 0067 0000 000D 0060 0018 0030 0018 0030 0018 0030 0018 0030 0018 0018 0018 0030 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 03DE"));
            codes.Add(new Code("MUTE",         "0000 0067 0000 000D 0060 0018 0018 0018 0018 0018 0030 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 0426"));
            codes.Add(new Code("VOLUME UP",    "0000 0067 0000 000D 0060 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 0426"));
            codes.Add(new Code("VOLUME DOWN",  "0000 0067 0000 000D 0060 0018 0030 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 040E"));
            codes.Add(new Code("CHANNEL UP",   "0000 0067 0000 000D 0060 0018 0018 0018 0018 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 043E"));
            codes.Add(new Code("CHANNEL DOWN", "0000 0067 0000 000D 0060 0018 0030 0018 0018 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 0426"));
            
            //LCD Monitor
            codes.Add(new Code("POWER TOGGLE", "0000 0067 0000 0015 0060 0018 0030 0018 0018 0018 0030 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 028E"));
            codes.Add(new Code("MUTE",         "0000 0067 0000 0015 0060 0018 0018 0018 0018 0018 0030 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 02A6"));
            codes.Add(new Code("VOLUME UP",    "0000 0067 0000 0015 0060 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 02A6"));
            codes.Add(new Code("VOLUME DOWN",  "0000 0067 0000 0015 0060 0018 0030 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 0018 028E"));
            */

            /*Zenith-LGE (DEBUG)
            codes.Add(new Code("POWER ON",     "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("POWER OFF",    "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("MUTE",         "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("VOLUME UP",    "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("VOLUME DOWN",  "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("CHANNEL UP",   "0000 006d 0022 0002 0154 00aa 0015 0015 0015 0015 0015 0040 0015 0015 0015 0015 0015 0015 0015 0015 0015 0015 0015 0040 0015 0040 0015 0015 0015 0040 0015 0040 0015 0040 0015 0040 0015 0040 0015 0040 0015 0015 0015 0015 0015 0015 0015 0040 0015 0040 0015 0040 0015 0015 0015 0015 0015 0041 0015 0040 0015 0041 0015 0015 0015 0015 0015 0015 0015 0040 0015 0611 0154 0056 0015 0e64"));
            codes.Add(new Code("CHANNEL DOWN", "0000 006d 0022 0002 0154 00aa 0015 0015 0015 0015 0015 0040 0015 0015 0015 0015 0015 0015 0015 0015 0015 0015 0015 0040 0015 0040 0015 0015 0015 0040 0015 0040 0015 0040 0015 0040 0015 0040 0015 0015 0015 0040 0015 0015 0015 0015 0015 0040 0015 0040 0015 0040 0015 0015 0015 0040 0015 0015 0015 0040 0015 0041 0015 0015 0015 0015 0015 0015 0015 0040 0015 0611 0154 0056 0015 0e64"));
            */

            /*
            codes.Add(new Code("POWER ON", "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("POWER OFF", "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("MUTE", "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("VOLUME UP", "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 05f3 0156 0055 0016 0e4d"));
            codes.Add(new Code("VOLUME DOWN", "0000 006d 0022 0002 0157 00ab 0016 0015 0016 0015 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 0015 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 003f 0016 05f3 0156 0055 0016 0e4d"));
            */
        }


        public void run()
        {
            buildCommonDict();
            enforceDict();
            handleEnd(codes[0].getEnd());

            for (int i = 0; i < codes.Count; i++)
            {
                codes[i].substitute(finishedDict);
            }
        }

        public void addCode(Code code)
        {
            codes.Add(code);
        }

        public void reset()
        {
            codes.Clear();
            dict.Clear();
            finishedDict.Clear();
        }

        private void buildCommonDict()
        {
            for (int i = 0; i < codes.Count; i++)
            {
                Code code = codes[i];
                for (int d = 0; d < code.dict.Count; d++)
                {
                    if (!inDict(code.dict[d]))
                    {
                        dict.Add(code.dict[d]);
                    }
                }
            }

            for (int i = 0; i < dict.Count; i++)
            {
                BurstPair b = dict[i];
                if (!betterValue(b))
                {
                    finishedDict.Add(b);
                }
            }
        }

        private void enforceDict()
        {
            for (int i = 0; i < codes.Count; i++)
            {
                codes[i].enforceDict(finishedDict);
            }
        }

        private void handleEnd(BurstPair current)
        {
            //search for an ending value that's doesn't require a second dict entry
            BurstPair better = null;
            for (int i = 0; i < finishedDict.Count; i++)
            {
                if (finishedDict[i].equals(current))
                {
                    //ensures that the reference to the current end is the object in the dict (for removing)
                    current = finishedDict[i];
                }
                else
                {
                    if (current.on == finishedDict[i].on)
                    {
                        if ((better == null) && (finishedDict[i].off < 50))
                        {
                            better = finishedDict[i];
                        }
                        else if ((better != null) && (finishedDict[i].off < better.off))
                        {
                            better = finishedDict[i];
                        }
                    }
                }
            }

            if (better != null)
            {
                finishedDict.Remove(current);
                for (int i = 0; i < codes.Count; i++)
                {
                    codes[i].setEnd(better);
                }
            }
        }

        private bool betterValue(BurstPair b)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                BurstPair test = dict[i];
                if (test != b)
                {
                    if (b.withinTol(test))
                    {
                        //choose best one
                        if (test.num > b.num)
                        {
                            return true;
                        }
                        else if (test.num < b.num)
                        {
                            //return null, no better value
                        }
                        else
                        {
                            int n = dict.IndexOf(b);
                            if (i < n) { return true; }
                        }
                    }
                }
            }
            return false;
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

        public override String ToString()
        {
            String result = "";
            for (int i = 0; i < codes.Count; i++)
            {
                result += codes[i].ToString() + Environment.NewLine;
            }
            result += Environment.NewLine;
            for (int i = 0; i < finishedDict.Count; i++)
            {
                result += finishedDict[i].ToString() + "   ";
            }
            return result;
        }

        public String ToCode()
        {
            String result = "";
            for (int i = 0; i < codes.Count; i++)
            {
                result += codes[i].ToCode() + ";" + Environment.NewLine;
            }
            return result;
        }

        public String GetDict()
        {
            String result = "{";
            for (int i = 0; i < finishedDict.Count; i++)
            {
                result += finishedDict[i].ToString();
                if (i != finishedDict.Count - 1)
                {
                    result += ", ";
                }
            }
            result += "}";
            return result;
        }

        public String GetEntries(String dictName)
        {
            String result = "";
            for (int i = 0; i < codes.Count; i++)
            {
                result += codes[i].GetEntry(dictName) + "," + Environment.NewLine;
            }
            return result;
        }
    }
}
