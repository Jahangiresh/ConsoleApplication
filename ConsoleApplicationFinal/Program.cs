using System;

namespace ConsoleAppFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            do
            {
                Console.WriteLine("1.Yeni qrup yarat\n2.Qrupların siyahısını goster\n3.Qrup uzerində duzliş etmək\n4.Qrupdakı telebelerin siyahısını göstər\n5.Butun telebelerin siyahısını goster\n6.Telebe yarat\n0.Cixis");
                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("qrup no daxil edin");
                            string no;
                            no = Console.ReadLine();
                            if (true)
                            {

                            }
                            break;
                        case 2:

                            break;
                        case 3:

                        case 4:

                            break;
                        case 5:


                            break;
                        case 6:


                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("xahish edirem mezelenmeyin");
                }

            } while (selection != 0);





        }
    }
}
