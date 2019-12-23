//. Создайте класс AbstractHandler.
//В теле класса создать методы void Open(), void Create(), void Change(), void Save(). 
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа. 


using System;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AbstractHandler> abstractHandler = new List<AbstractHandler>();
            abstractHandler.Add(new XMLHandler());
            abstractHandler.Add(new TXTHandler());
            abstractHandler.Add(new DOCHandler());
            foreach (var document in abstractHandler)
            {
                document.Create();
                document.Open();
                document.Change();
                document.Save();
            }
        }
    }
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
 
    }
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XMLHandler was changed");
        }

        public override void Create()
        {
            Console.WriteLine("XMLHandler was created");
        }

        public override void Open()
        {
            Console.WriteLine("XMLHandler was opened");
        }

        public override void Save()
        {
            Console.WriteLine("XMLHandler was saved");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXTHandler was changed");
        }

        public override void Create()
        {
            Console.WriteLine("TXTHandler was created");
        }

        public override void Open()
        {
            Console.WriteLine("TXTHandler was opened");
        }

        public override void Save()
        {
            Console.WriteLine("TXTHandler was saved");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOCHandler was changed");
        }

        public override void Create()
        {
            Console.WriteLine("DOCHandler was created");
        }

        public override void Open()
        {
            Console.WriteLine("DOCHandler was opened");
        }

        public override void Save()
        {
            Console.WriteLine("DOCHandler was saved");
        }
    }
}
