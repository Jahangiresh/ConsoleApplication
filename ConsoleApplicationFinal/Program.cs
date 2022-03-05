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
                           
                            if (no!="")
                            {
                                foreach (Category c in System.Enum.GetValues(typeof(Category)))
                                {
                                    Console.WriteLine($"{(int)c} {c}");
                                }
                                int category;
                                string catStr=Console.ReadLine();
                                bool resultCat=int.TryParse(catStr,out category);
                                if (resultCat)
                                {
                                    switch (category)
                                    {
                                        case (int)Category.Programming:
                                            ServiceCode serviceCode=new ServiceCode();
                                            string No = serviceCode.CreateGroup(online, offline, Category.Programming, no);
                                            Console.WriteLine($"{No} succesfully created");
                                        default:
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("please choose valid category");
                                }
                            }
                            else
                            {
                                Console.WriteLine("please type something not whitespace");
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
                    Console.WriteLine("xahish edirem 0-6 arasinda reqem secin");
                }

            } while (selection != 0);





        }
    }
}
