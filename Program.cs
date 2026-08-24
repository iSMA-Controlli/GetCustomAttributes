using System;
using System.Reflection;
using System.Threading;

namespace Attrs
{
    public class Program
    {
        public static void Main()
        {
            new Thread(ProcessAttributes).Start();

            void ProcessAttributes()
            {
                Console.WriteLine("Start");
                var loops = 0;
                while (true)
                {
                    Thread.Sleep(15);
                    int typesNo = 0;
                    int fieldsNo = 0;
                    int attrNo = 0;
                    Assembly assembly = Assembly.GetExecutingAssembly();

                    foreach (var type in assembly.GetTypes())
                    {
                        typesNo++;
                        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        foreach (var field in fields)
                        {
                            fieldsNo++;
                            try
                            {
                                var attributes = field.GetCustomAttributes(false);
                                foreach (var attr in attributes)
                                {
                                    attrNo++;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error during processing attributes" + e.ToString());
                            }
                        }
                    }
                    loops++;
                    Console.WriteLine($"types={typesNo}, fields={fieldsNo}, attr={attrNo}, {loops}");
                }
            }

            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}