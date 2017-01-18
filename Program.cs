using System;
using System.Reflection;

namespace Crypto
{
    [Obfuscation]
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Success: {Test()}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected Error: {ex}");
                Environment.Exit(-1);
            }

        }

        [Obfuscation]
        static int Test()
        {
            var states = new [] { TestState.NothingToDo, TestState.Success, TestState.Dummy };
            return states.Length;
        }
    }
}
