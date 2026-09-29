using System.Diagnostics;

namespace System_Pro_Ev_Tapsirigi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? choice="";
            bool isytrue=true;
            Process? process1 = new Process();
            Process? process2 = new Process();
            bool isplay1=false;
            bool isplay2 = false;


            var thread1 = new Thread(() =>
            {
                while (true)
                {
                    switch (choice)
                    {
                        case "0":
                            goto case "3";
                        case "1":
                            if (!isplay1)
                            {
                                var tarkan = Process.Start("\"C:\\Program Files\\MPC-HC\\mpc-hc64.exe\"", "\"C:\\Users\\arzum\\Desktop\\C#\\System Pro Ev Tapsirigi2\\System Pro Ev Tapsirigi2\\TARKAN feat. OZAN ÇOLAKOĞLU - Aşk Gitti Bizden (Official Music Video)(MP3_160K).mp3\"");
                                process1 = tarkan;
                                isplay1 = true;
                            }
                            choice = "";
                            break;
                        case "3":
                            if (isplay1)
                            {
                                process1.Kill();
                                isplay1 = false;
                            }
                            choice = "";
                            break;
                        default:
                            break;
                    }
                }
            });


            var thread2 = new Thread(() =>
            {
                while (true)
                {
                    switch (choice)
                    {
                        case "0":
                            goto case "4";
                        case "2":
                            if (!isplay2)
                            {
                                var senorita = Process.Start("\"C:\\Program Files\\MPC-HC\\mpc-hc64.exe\"", "\"C:\\Users\\arzum\\Desktop\\C#\\System Pro Ev Tapsirigi2\\System Pro Ev Tapsirigi2\\Senorita.mp4\"");
                                process2 = senorita;
                                isplay2 = true;
                            }
                            choice = "";
                            break;
                        case "4":
                            if (isplay2)
                            {
                                process2.Kill();
                                isplay2=false;
                            }
                            choice = "";

                            break;
                        default:
                            break;
                    }
                }
            });


            var thread3 = new Thread(() =>
            {
                while (isytrue)
                {

                    switch (choice)
                    {

                        case "0":
                            isytrue = false;
                            break;
                        default:
                            break;
                    }
                }
            });


            thread1.IsBackground = true;
            thread2.IsBackground = true;

            thread1.Start();
            thread2.Start();
            thread3.Start();

            while (true)
            {
                Console.WriteLine("1.Tarkan-Ask gitdi bizden\n2.Shawn Mendes-Senorita\n3.Tarkan stop music\n4.Shawn stop music\n0.Stop all music and program");
                choice = Console.ReadLine();

                if (choice == "0") { Thread.Sleep(2000); break; }
                
                
            }







        }
    }
}
