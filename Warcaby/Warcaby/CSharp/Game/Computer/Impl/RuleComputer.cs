﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warcaby.CSharp.Dto;

namespace Warcaby.CSharp.Game.Computer.Impl
{
    public class RuleComputer
    {
        public int ThePawnStoodInTheArea(int index)
        {
            List<int> listOfArea1Fields = new List<int>(new int[] { 2, 4, 6, 8, 9, 24, 25, 40, 41, 56, 57, 59, 61, 63 });
            List<int> listOfArea2Fields = new List<int>(new int[] { 11, 13, 15, 18, 31, 34, 47, 50, 52, 54 });
            List<int> listOfArea3Fields = new List<int>(new int[] { 20, 22, 27, 29, 36, 38, 43, 45 });

            if (listOfArea1Fields.Contains(index))
                return 1;
            else if (listOfArea2Fields.Contains(index))
                return 2;
            else if (listOfArea3Fields.Contains(index))
                return 3;
            else
                return 0;
        }
    }
}
