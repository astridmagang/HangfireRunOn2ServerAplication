using System;
using System.Threading.Tasks;
using WebApplication1.Interface;

namespace WebApplication1.LogicInterface
{
    public class ContohWeb1 : InterfaceContohWeb1
    {
        public async Task SendAsync(string message)
        {
            Console.WriteLine($"Hello {message}");
        }
    }
}
