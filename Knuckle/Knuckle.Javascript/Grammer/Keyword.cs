using System.Collections.Generic;
using System.ComponentModel;

namespace Knuckle.Javascript
{
    public static class JsGrammer
    {
        public static List<string> Keywords;
        static JsGrammer()
        {
            //Load the Keywords from a file
            Keywords = new List<string> {"var", "=", ";"};
        }
    }

    public class Grammer
    {
        public string Name { get; set; }
        public bool JavascriptKeyword { get; set; }
        public int StartLocation { get; set; }
        public int EndLocation { get; set; }
        public bool IsBlock { get; set; }
    }    
}