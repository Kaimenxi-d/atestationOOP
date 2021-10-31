using System;
using System.IO;

namespace atestation
{
    class Vhod
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("|||||||| Добро пожаловать в Магазин Персональных Компьютеров 'ЭкТэк'\n");
            menuvhoda();

        }
        public static void menuvhoda()
        {
            Console.WriteLine("\n|||||||| 1.Посмотреть каталог");
            Console.WriteLine("|||||||| 2.Собрать самому\n");
            Console.Write("-------> Ответ цифрой:");
            int ans1 = int.Parse(Console.ReadLine());
            if (ans1 == 1)
            {
                katalog sp = new katalog();
                katalog.katalogpc();

            }
            else if (ans1 == 2)
            {
                sborkasam sp = new sborkasam();
                sborkasam.ssborka();
            }
            Console.ReadKey();
        }




    }
    class katalog
    {

        public static void katalogpc()
        {
            Console.WriteLine("\n-------> В данный момент каталог пуст\n\n|||||||| Вернутся в меню?\n\n|||||||| 1.Да\n|||||||| 2.Нет");
            Console.Write("\n-------> Ответ цифрой:");
            int ans1 = int.Parse(Console.ReadLine());
            if (ans1 == 1)
            {
                Vhod sp = new Vhod();
                Vhod.menuvhoda();

            }
            else if (ans1 == 2)
            {
                Console.WriteLine("|||||||| Тогда прощайте");
            }
            Console.ReadKey();

        }

    }
    class sborkasam
    {
        public static void ssborka()
        {
            Console.WriteLine("\n|||||||| Выберите тип товара\n\n|||||||| 1.Процессоры\n|||||||| 2.Видеокарты\n|||||||| 3.Корпуса\n|||||||| 4.Оперативная память\n|||||||| 5.Накопители\n|||||||| 6.Перейти в корзину");
            Console.Write("\n-------> Ответ цифрой:");
            int ans1 = int.Parse(Console.ReadLine());
            if (ans1 == 1)
            {
                CP();
            }
            else if (ans1 == 2)
            {
                VD();
            }
            else if (ans1 == 3)
            {
                CR();
            }
            else if (ans1 == 4)
            {
                OP();
            }
            else if (ans1 == 5)
            {
                PM();
            }
            else if (ans1 == 6)
            {
                spisoksborki();
            }
        }
        public static void CP()
        {
            Console.WriteLine("\n|||||||| Выберите производителя\n\n|||||||| 1.AMD\n|||||||| 2.Intel");
            Console.Write("\n-------> Ответ цифрой:");
            int ans1 = int.Parse(Console.ReadLine());
            if (ans1 == 1)
            {
                spisokKomplektov sp = new spisokKomplektov();
                spisokKomplektov.cpamd();

            }
            else if (ans1 == 2)
            {
                spisokKomplektov sp = new spisokKomplektov();
                spisokKomplektov.cpspintel();
            }



        }
        public static void VD()
        {
            Console.WriteLine("\n|||||||| Выберите производителя\n\n|||||||| 1.AMD\n|||||||| 2.Nvidia");
            Console.Write("\n-------> Ответ цифрой:");
            int ans1 = int.Parse(Console.ReadLine());
            if (ans1 == 1)
            {
                spisokKomplektov sp = new spisokKomplektov();
                spisokKomplektov.vdspamd();

            }
            else if (ans1 == 2)
            {
                spisokKomplektov sp = new spisokKomplektov();
                spisokKomplektov.vdnvi();


            }
        }
        public static void CR()
        {
            spisokKomplektov sp = new spisokKomplektov();
            spisokKomplektov.cprs();
        }
        public static void OP()
        {
            spisokKomplektov sp = new spisokKomplektov();
            spisokKomplektov.op();
        }
        public static void PM()
        {
            spisokKomplektov sp = new spisokKomplektov();
            spisokKomplektov.pm();
        }
        public static void oplatta()
        {
            Console.WriteLine("\n|||||||| Перейти к оплате?\n|||||||| 1.Да\n|||||||| 2.Нет");
            Console.Write("\n-------> Ответ цифрой:");
            int ans1 = int.Parse(Console.ReadLine());
            if (ans1 == 1)
            {
                Olata();
            }
            else if (ans1 == 2)
            {
                spisokKomplektov sp = new spisokKomplektov();
                spisokKomplektov.vdnvi();


            }


        }
        public static void Olata()
        {
            
                Console.WriteLine("\n|||||||| Выберите способ оплаты\n|||||||| 1.Наличные\n|||||||| 2.Картой");
                Console.Write("\n-------> Ответ цифрой:");
                int ans2 = int.Parse(Console.ReadLine());
                if(ans2 == 1)
                {
                Console.WriteLine("\n-------> С вас очень много деняг");
                Console.WriteLine("\n-------> Досвидания, приходите еще!");
            }
                else if(ans2 == 2)
                {
                    Console.WriteLine("\n|||||||| Оплата картой временно недоступна");
                    Olata();
                }
            



        }
        public static void spisoksborki()
        {
            Console.WriteLine("\n|||||||| Ваша сборка\n");
            using (FileStream fstream = File.OpenRead(@"C:\Users\Said-Emin\Documents\spisokcp.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("|||||||| Процессор:" + textFromFile);
                

            }
           
            using (FileStream fstream = File.OpenRead(@"C:\Users\Said-Emin\Documents\spisokvd.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("|||||||| Видеокарта:" + textFromFile);


            }
            using (FileStream fstream = File.OpenRead(@"C:\Users\Said-Emin\Documents\spisokcr.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("|||||||| Корпус:" + textFromFile);


            }
            using (FileStream fstream = File.OpenRead(@"C:\Users\Said-Emin\Documents\spisokop.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("|||||||| Оперативная память:" + textFromFile);


            }
            using (FileStream fstream = File.OpenRead(@"C:\Users\Said-Emin\Documents\spisokpm.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("|||||||| Накопители:" + textFromFile);


            }
            Olata();
           
        }
        class spisokKomplektov
        {
            public static void cpamd()
            {
                Console.WriteLine("\n|||||||| Товары в наличии\n");
                string[] spisokcp = { "1.Ryzen 5 3600", "2.Ryzen 7 3700", "3.Ryzen 5 5600" };

                Console.Write($"\n|||||||| {spisokcp[0]}");
                Console.Write($"\n|||||||| {spisokcp[1]}");
                Console.Write($"\n|||||||| {spisokcp[2]}");
                Console.Write("\n-------> Ответ цифрой:");
                int ans1 = int.Parse(Console.ReadLine());
                if (ans1 == 1)
                {
                    string kukuruza = "Ryzen 5 3600";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcp.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }
                else if (ans1 == 2)
                {

                    string kukuruza = "Ryzen 7 3700";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcp.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("\n//////// Товар добавлен\n");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();
                }
                else if (ans1 == 3)
                {
                    string kukuruza = "Ryzen 5 5600";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcp.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();
                }

            }
            public static void cpspintel()
            {
                Console.WriteLine("\n|||||||| Товары в наличии\n");
                string[] spisokcp = { "1.i3 10100f", "2.i5 10600k", "3.i7 7700" };

                Console.Write($"\n|||||||| {spisokcp[0]}");
                Console.Write($"\n|||||||| {spisokcp[1]}");
                Console.Write($"\n|||||||| {spisokcp[2]}");
                Console.Write("\n\n-------> Ответ цифрой:");
                int ans1 = int.Parse(Console.ReadLine());
                if (ans1 == 1)
                {
                    string kukuruza = "i3 10100f";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcp.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }
                else if (ans1 == 2)
                {

                    string kukuruza = "i5 10600k";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcp.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("\n//////// Товар добавлен\n");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();
                }
                else if (ans1 == 3)
                {
                    string kukuruza = "i7 7700";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcp.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();
                }

            }

            public static void vdspamd()
            {
                Console.WriteLine("\n|||||||| Товары в наличии\n");
                Console.WriteLine("\n|||||||| 1.Rx 6600");
                Console.Write("\n-------> Ответ цифрой:");
                int ans1 = int.Parse(Console.ReadLine());
                if (ans1 == 1)
                {
                    string kukuruza = "Rx 6600";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokvd.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }

            }
            public static void vdnvi()
            {
                Console.WriteLine("\n//////// Товара нет в наличии");
                Console.WriteLine("\n//////// Спасибо майнерам\n");
                sborkasam sp = new sborkasam();
                sborkasam.ssborka();


            }
            public static void cprs()
            {
                Console.WriteLine("\n|||||||| Товары в наличии\n");
                Console.WriteLine("\n|||||||| 1.Nzxt 510i\n|||||||| 2.Deepcool Matrexx55\n|||||||| 3.AeroCool CylonRGBPROMASTER");
                Console.Write("\n-------> Ответ цифрой:");
                int ans1 = int.Parse(Console.ReadLine());
                if (ans1 == 1)
                {
                    string kukuruza = "Nzxt 510i";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcr.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }
                else if (ans1 == 2)
                {
                    string kukuruza = "Deepcool Matrexx55";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcr.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }
                else if (ans1 == 3)
                {
                    string kukuruza = "AeroCool CylonRGBPROMASTER";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokcr.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }

            }

            public static void op()
            {
                Console.WriteLine("\n|||||||| Товары в наличии\n");
                Console.WriteLine("\n|||||||| 1.Patriot Viper 16gb 3200mhz\n|||||||| 2.HyperX Fury 32gb 3800 mhz\n|||||||| 3.Kingston 16gb 2666mhz");
                Console.Write("\n-------> Ответ цифрой:");
                int ans1 = int.Parse(Console.ReadLine());
                if (ans1 == 1)
                {
                    string kukuruza = "Patriot Viper 16gb 3200mhz";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokop.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }
                if (ans1 == 2)
                {
                    string kukuruza = "HyperX Fury 32gb 3800 mhz";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokop.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }
                if (ans1 == 3)
                {
                    string kukuruza = "Kingston 16gb 2666mhz";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokop.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }

            }
            public static void pm()
            {
                Console.WriteLine("\n|||||||| Товары в наличии\n");
                Console.WriteLine("\n|||||||| 1.Toshiba 1tb\n|||||||| 2.WD 500gb\n|||||||| 3.Seagate 1tb");
                Console.Write("\n-------> Ответ цифрой:");
                int ans1 = int.Parse(Console.ReadLine());
                if (ans1 == 1)
                {
                    string kukuruza = "Toshiba 1tb";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokpm.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }
                if (ans1 == 2)
                {
                    string kukuruza = "WD 500gb";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokpm.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }
                if (ans1 == 3)
                {
                    string kukuruza = "Seagate 1tb";

                    using (FileStream fstream = new FileStream(@"C:\Users\Said-Emin\Documents\spisokpm.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(kukuruza);
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("//////// Товар добавлен");
                    sborkasam sp = new sborkasam();
                    sborkasam.ssborka();


                }













            }





        }







    }

}








