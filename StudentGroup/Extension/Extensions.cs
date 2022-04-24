using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGroup.Extension
{
    public static class Extensions
    {

        public static string GroupName(this string sbj)
        {
            return sbj.Substring(0, 2).ToUpper();



        }


    }
}
