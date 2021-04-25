
using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class OrderManager : IOrderService
    {
        public void Sale(Order order)
        {
            Console.WriteLine("{0} satıldı", order.GameName,order.UserName);
        }
    }
}
