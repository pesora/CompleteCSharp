using System.Xml.Schema;

namespace QueueOrders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            //as long as the queue is not empty
            while (ordersQueue.Count > 0)
            {
                //remove the order At the front of the queue
                //and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //process the order
                currentOrder.ProcessOrder();
            }
        }

        //this method will create an array of orders an return it
        static Order[] ReceiveOrdersFromBranch1()
        {
            //createing new orders array
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            //createing new orders array
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }

    }

    //a class named order we will use it to store intance of it inside a queue beacude
    class Order
    {
        //order ID
        public int OrderId { get; set; }
        //quantity of the order
        public int OrderQuantity { get; set; }

        //simple constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        //print message on the screen that the order was processed
        public void ProcessOrder()
        {
            //print the message
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}