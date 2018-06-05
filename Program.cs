
namespace BrokenMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new ChatRoom();

            var john = new Person("John");
            room.Join(john);

            var jane = new Person("Jane");
            room.Join(jane);

            john.Say("Hi Jane");
            jane.Say("Hi John, how are you?");

            var simon = new Person("Simon");
            room.Join(simon);

            simon.Say("Hi everyone");
            jane.PrivateMessage("Simon", "Glad you could join us");
        }
    }
}
