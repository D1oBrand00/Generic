using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person(546, "Tom");
            Person bob = new Person("abc123", "Bob");

            int tomId = (int)tom.Id;
            string bobId = (string)bob.Id;

            Console.WriteLine(tomId);   // 546
            Console.WriteLine(bobId);   // abc123
            //Все вроде замечательно работает, но такое решение является не очень оптимальным. Дело в том, что в данном случае мы сталкиваемся
            //с такими явлениями как упаковка (boxing) и распаковка (unboxing).

            //Так, при передаче в конструктор значения типа int, происходит упаковка этого значения в тип Object:
            Person tom2 = new Person(546, "Tom");    // упаковка значения int в тип Object

            //Чтобы обратно получить данные в переменную типов int, необходимо выполнить распаковку:
            int tomId2 = (int)tom.Id;      // Распаковка в тип int

            //Упаковка (boxing) предполагает преобразование объекта значимого типа (например, типа int) к типу object.
            //Распаковка (unboxing), наоборот, предполагает преобразование объекта типа object к значимому типу.
            //Упаковка и распаковка ведут к снижению производительности, так как системе надо осуществить необходимые преобразования.

            //Мы можем не знать, какой именно объект представляет Id, и при попытке получить число в данном случае мы столкнемся с исключением InvalidCastException.
            Person tom3 = new Person(546, "Tom");
            //string tomId3 = (string)tom3.Id;  // !Ошибка  - Исключение InvalidCastException
            //Console.WriteLine(tomId3);   // 546


            //Например, вместо параметра T можно использовать объект int, то есть число, представляющее номер пользователя.
            //Это также может быть объект string, либо или любой другой класс или структура:
            PPerson<int> tom4 = new PPerson<int>(546, "Tom");  // упаковка не нужна
            PPerson<string> bob4 = new PPerson<string>("abc123", "Bob");

            int tomId4 = tom4.Id;      // распаковка не нужна
            string bobId4 = bob4.Id;  // преобразование типов не нужно

            Console.WriteLine(tomId4);   // 546
            Console.WriteLine(bobId4);   // abc123

            //При попытке передать для параметра id значение другого типа мы получим ошибку компиляции:
            //PPerson<int> tom5 = new PPerson<int>("546", "Tom");  // ошибка компиляции


            //Здесь класс компании определяет свойство CEO, которое хранит президента компании.
            //И мы можем передать для этого свойства значение типа Person, типизированного каким-нибудь типом:
            PPerson<int> tom6 = new PPerson<int>(546, "Tom");
            Company<PPerson<int>> microsoft = new Company<PPerson<int>>(tom6);

            Console.WriteLine(microsoft.CEO.Id);  // 546
            Console.WriteLine(microsoft.CEO.Name);  // Tom


            PPPerson<int, string> tom7 = new PPPerson<int, string>(546, "qwerty", "Tom");
            Console.WriteLine(tom7.Id);  // 546
            Console.WriteLine(tom7.Password);// qwerty


            Console.ReadLine();
        }
    }

    //Использование нескольких универсальных параметров
    class PPPerson<T, K>
    {
        public T Id { get; }
        public K Password { get; set; }
        public string Name { get; }
        public PPPerson(T id, K password, string name)
        {
            Id = id;
            Name = name;
            Password = password;
        }

    }



    //При этом универсальный параметр также может представлять обобщенный тип:
    class Company<P>
    {
        public P CEO { get; set; }  // президент компании
        public Company(P ceo)
        {
            CEO = ceo;
        }
    }



    //Для решения этих проблем в язык C# была добавлена поддержка обобщенных типов (также часто называют универсальными типами).
    //Обобщенные типы позволяют указать конкретный тип, который будет использоваться. Поэтому определим класс Person как обощенный:
    class PPerson<T>
    {
        //Параметр T в угловых скобках еще называется универсальным параметром, так как вместо него можно подставить любой тип.
        public T Id { get; set; }
        public string Name { get; set; }
        public PPerson(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Person
    {
        //Нередко для идентификатора используются и строковые значения. И у числовых, и у строковых значений есть свои плюсы и минусы.
        //Чтобы выйти из подобной ситуации, мы можем определить свойство Id как свойство типа object. Так как тип object является универсальным типом, от которого наследуется все типы, соответственно в свойствах подобного типа мы можем сохранить и строки, и числа:
        public object Id { get; }
        public string Name { get; }
        public Person(object id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
