using APIDemo.Models;
namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Ticket { get; }
        static int nextId = 3;
        static TicketService()
        {
            Ticket = new List<Ticket>
            {
                new Ticket{ID=1,BookedFor = "PlatinumPlus", Price = 5000 , Qty = 200 },
                new Ticket{ID=11,BookedFor = "Platinum", Price = 4000 , Qty = 30},
                new Ticket{ID=12,BookedFor = "Gold", Price = 3000 , Qty = 500},
                new Ticket{ID=13,BookedFor = "Silver", Price = 2000 , Qty = 50},
                new Ticket{ID=14,BookedFor = "General", Price = 800 , Qty = 10},


            };
        }
        public static List<Ticket> GetAll() => Ticket;

        public static Ticket Get(int id)
        {
            Ticket ticket = Ticket.FirstOrDefault(x => x.ID == id);
            return ticket;
        }
    }
}
