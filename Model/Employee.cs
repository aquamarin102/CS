using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using System.Xml.Serialization;
//а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
//г)*Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).

namespace Model
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Describe { get; set; }

        private DateTime birthDay;

        public DateTime BirthDay
        {
            get { return birthDay; }
            set 
            {
                if (value > DateTime.Now) throw new ArgumentException("Дата дня рождения не может быть болше сегодняшней даты");
                birthDay = value;
            
            }
        }

        public Employee(string name, string position, string describe, DateTime birthDay)
        {
            Name = name;
            Position = position;
            Describe = describe;
            BirthDay = birthDay;
        }

        public Employee()//dla serealiz
        {

        }

    }

    public class Employees
    {
        List<Employee> list;

        int index;

        public int CurrentIndex
        {
            get { return index; }
        }
        public void Next()
        {
            if(list.Count>index+1)index++;
        }
        public void Prev() 
        {
           if(index>0) index--; 
        }
        public void Remove()
        {
            list.RemoveAt(index);
            Prev();
        }
        public Employees()
        {
            list = new List<Employee>();
            index = -1;
        }
        public Employee CurrentEmployee
        {
            get 
            {
                try { return list[index]; }
                catch { return null; }
            }
        }


        public void Save(string fileName)
        {
           XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));

            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fStream, list);
            fStream.Close();


        }

        public void Add(Employee employer) { list.Add(employer); }

       
        public void Load(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));

            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Employee>)xmlSerializer.Deserialize(fStream);
            fStream.Close();
        }

    }

}
