using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_2
{
    class Program
    {
        class TV
        {
            public int currentСhannel = 0;
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Переключение канала стрелочками");

                TV Channel = new TV();
                bool tv = true;
            int currentChannel = 0; 

            while (tv)
                {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            currentChannel--;
                            Console.WriteLine("Текущий канал: " + currentChannel);
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            currentChannel++;
                            Console.WriteLine("Текущий канал: " + currentChannel);
                            break;
                        }

                }

                Console.WriteLine("Выбран канал " + currentChannel);

            }
                Console.ReadLine();
            
        }
    }
}
