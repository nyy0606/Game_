using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;

namespace CSharp_1
{  
    class Program
	{
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            bool found = name.Contains("Harry"); //문자열이 이 안에 있는지

            int index = name.IndexOf('P'); // 특정 문자가 이 안에 몇번째 인덱스에 있는지/ 없으면 -1


            name = name + " Junior";
            Console.WriteLine(name);

            string lowcasename = name.ToLower();
            string uppercasename = name.ToUpper();

            string newname = name.Replace('r', 'l'); //r을 l로 변경


            string[] names = name.Split(new char[] { ' ' }); //띄어쓰기를 기준으로 나눠서 저장

        }
    }
}
  