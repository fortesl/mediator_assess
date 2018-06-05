using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenMediator
{
    class Person
    {
        public string Name;
        public ChatRoom Room;
        private List<string> chatlog = new List<string>();

        public Person(string name)
        {
            Name = name;
        }

        public void Say(string message)
        {
            Room.Broadcast(Name, message);
        }

        public void PrivateMessage(string who, string message)
        {
            Room.Message(Name, who, message);
        }

        public void Receive(string sender, string message)
        {
            string s = $"{sender}: '{message}";
            chatlog.Add(s);
            Console.WriteLine($"[{Name}'s chat session] {s}");
        }
    }
}
