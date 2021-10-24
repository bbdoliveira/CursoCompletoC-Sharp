using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment)
        {
            Moment = moment;
        }
    }
}
