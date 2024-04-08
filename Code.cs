using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Load;

public class Read
{
  public static string File(string File , string Character_CODE)
  {
    using(var sr = new StreamReader(File, Encoding.GetEncoding(Character_CODE))){
     return sr.ReadToEnd(); 
    }
}
  public static IEnumerable<string> FileLine(string File , string Character_CODE)
  {
    using var sr = new StreamReader(File, Encoding.GetEncoding(Character_CODE));
      
      while(!sr.EndOfStream){
        yield return sr.ReadLine();
    }
        
  }
}  


