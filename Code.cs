using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
namespace Load;

public class Read
{
  public static string File(string File , string Character_CODE)
  {
    StreamReader sr = new StreamReader(File, Encoding.GetEncoding(Character_CODE));
    string str = sr.ReadToEnd();
    sr.Close();
    return str;
    }
  public static async void FileLine(string File , string Character_CODE)
  {
    StreamReader sr = new StreamReader(File, Encoding.GetEncoding(Character_CODE));
    while(sr.Peek() != -1){
    var das = await sr.ReadLineAsync();
      Console.WriteLine(das);
    }
    sr.Close();
  }
}
