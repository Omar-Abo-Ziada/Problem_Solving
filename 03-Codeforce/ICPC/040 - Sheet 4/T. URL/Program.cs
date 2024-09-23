using System.Reflection.Metadata.Ecma335;

namespace T._URL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*T. URL
 time limit per test1 second
 memory limit per test256 megabytes
 Given a string S
  that represents a URL request. Print five lines contains the following format: "X
 : Y
 " where X
  is the parameter and Y
  is the parameter value.

 Note: The parameters of the URL: username, pwd, profile, role and key.

 Input
 Only one line contains a string S
  (100≤|S|≤104)
  where |S| is the length of the string and it consists of uppercase and lowercase English letters, digits, and special characters.

 The URL will be in the following format:

 http://www.{word}.{word}/{word}/{word}?username={word}&pwd={word}&profile={word}&role={word}&key={word}

 It's guaranteed that all parameters will have a value.

 Output
 Print 5 lines that contain the answer required above.

 Example
 InputCopy
 http://www.cleartrip.com/signin/service?username=test&pwd=test&profile=developer&role=ELITE&key=manager
 OutputCopy
 username: test
 pwd: test
 profile: developer
 role: ELITE
 key: manager*/


            //http://www.cleartrip.com/signin/service?username=test&pwd=test&profile=developer&role=ELITE&key=manager

            string? url = Console.ReadLine();

            string queryStringPart = url.Substring(url.IndexOf("?")+1);

            List<string> pairs = queryStringPart.Split('&').ToList();

            foreach (var pair in pairs)
            {
                string[] keyValue = pair.Split('=');

                Console.WriteLine($"{keyValue[0]}: {keyValue[1]}");
            }
        }
    }
}