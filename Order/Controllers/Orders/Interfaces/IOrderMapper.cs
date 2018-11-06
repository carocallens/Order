using Order.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.Orders.Interfaces
{
    public interface IOrderMapper
    {
        OrderObject OrderRequestDTOtoOrder(OrderRequestDTO orderDTO);
        OrderResponseDTO OrderToOrderResponseDTOWithPrice(OrderObject order, decimal price);
        List<OrderDTO> ListOrdersToListOrderDTOs(List<OrderObject> orders);
    }
}
