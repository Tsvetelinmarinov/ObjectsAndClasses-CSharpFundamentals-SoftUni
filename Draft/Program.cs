/*
 * 
 * Draft
 */

using System.Runtime.Versioning;

namespace Draft
{
    class Program
    {
        [SupportedOSPlatform("windows")]
        static void Main()
        {
            Console.Beep(600, 6000);
        }
    }
}
