using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Assignment_5_Simulating_a_Ticketing_System_with_Queue_T
{
    internal class TicketingSystem
    {

        /*Assignment 5: Simulating a Ticketing System with Queue<T>
              1.	Create a Queue<string> for customer service tickets.
              2.	Perform the following operations:
                  o	Add new tickets ("Ticket#1", "Ticket#2", etc.).
                  o	Process tickets FIFO style (use .Dequeue()).
                  o	Display remaining tickets in the queue.
              */

        public Queue<string> Que { get; set; } = new Queue<string>();


        public void AddTicket(string t) =>
            Que.Enqueue(t);

        public void ProcessTickets()
        {
            bool flag = Que.TryDequeue(out string s);
            if (flag)
                Console.WriteLine($"Processing {s}");
            else Console.WriteLine("No Tickets left");
        }

        public void DisplayRemainingTickets()
        {
            if (Que.Count > 0)
                foreach (var t in Que) Console.WriteLine(t);
            else Console.WriteLine("No Tickets left");
        }

    }
}
