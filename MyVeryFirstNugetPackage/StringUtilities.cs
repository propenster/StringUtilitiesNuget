using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyVeryFirstNugetPackage
{
    public static class StringUtilities
    {

        ////public object Slugify { get; set; }

        //private object Slugify;
        ////{
        ////    get { return this.myvalue; }
        ////    set { this.myvalue = value; }
        ////}

        //public StringUtilsAttribute(object Slugify)
        //{
        //    this.Slugify = Slugify;
        //}

        //public override string ToString()
        //{
        //    return base.ToString() + ": " + GetType(Slugify).Equals();
        //}

        /// <summary>
        /// This utility generates slug from any string property passed to it.
        /// </summary>
        /// <param name="phrase">string field to be slugified</param>
        /// <returns>Slugified format of the input string</returns>
        public static string Slugify(this string phrase)
        {
            string str = phrase.RemoveAccent().ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }

        public static string RemoveAccent(this string txt)
        {
            byte[] bytes = Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return Encoding.ASCII.GetString(bytes);
        }

    }
}
