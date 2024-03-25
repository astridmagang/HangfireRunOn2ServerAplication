using System;
using System.Threading.Tasks;
using WebApplication2.Interface;

namespace WebApplication2.LogicInterface
{
    public class ContohWeb1 : InterfaceContohWeb1
    {
        public async Task SendAsync(string message)
        {
            Console.WriteLine($"Hello {message}");
        }
    }
}
