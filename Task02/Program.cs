//Создайте 2 интерфейса IPlayable и IRecodable.В каждом из интерфейсов создайте по 3 метода void Play() / 
//void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
//Написать программу, которая выполняет проигрывание и запись.

using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine(@"Menu
1 Play   (enter 1)
2 Pause  (enter 2)
3 Record (enter 3)
4 Stop   (enter 4)
  Exit   (enter 0)");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        player.Play();
                        break;
                    case "2":
                        player.Pause();
                        break;
                    case "3":
                        player.Record();
                        break;
                    case "4":
                        player.Stop();
                        break;
                    case "0":
                        return;
                }
            }
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Pause();
        void Stop();
        void Record();
    }
    public class Player : IPlayable, IRecodable
    {
        bool isPlaying = false;
        bool isRecording = false;
        public void Pause()
        {
            if (isPlaying || isRecording)
            {
                isPlaying = false;
                isRecording = false;
                Console.WriteLine("Pause");
            }
            else Console.WriteLine("Error!");
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Play");
            }
            else Console.WriteLine("Error!");
        }

        public void Record()
        {
            if (isPlaying && !isRecording)
            {
                isRecording = true;
                Console.WriteLine("Record");
            }
            else Console.WriteLine("Turn on the music!");
        }

        public void Stop()
        {
            if (isPlaying || isRecording)
            {
                isRecording = false;
                isPlaying = false;
                Console.WriteLine("Stop");
            }
            else Console.WriteLine("Error!");
        }
    }
}
