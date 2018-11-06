using System;
using System.Collections.Generic;
using System.Text;
using Order.Domain.Orders;

namespace Order.Services.OrderServices.Interfaces
{
    public interface IOrderService
    {
        decimal Order(OrderObject orderObject);
        List<OrderObject> GetAll();

    }
}
