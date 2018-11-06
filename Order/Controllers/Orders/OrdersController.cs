using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.Controllers.Orders.Interfaces;
using Order.Services.OrderServices.Interfaces;

namespace Order.API.Controllers.Orders
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;
        IOrderMapper _orderMapper;

        public OrdersController(IOrderService orderService, IOrderMapper orderMapper)
        {
            _orderService = orderService;
            _orderMapper = orderMapper;
        }
        
        [HttpGet]
        public ActionResult<List<OrderDTO>> GetAll()
        {
            return Ok(_orderMapper.ListOrdersToListOrderDTOs(_orderService.GetAll()));
        }


        [HttpPost]
        public ActionResult<OrderResponseDTO> OrderItems([FromBody] OrderRequestDTO orderDTO)
        {
            var order = _orderMapper.OrderRequestDTOtoOrder(orderDTO);
            var price = _orderService.Order(order);
            return Ok(_orderMapper.OrderToOrderResponseDTOWithPrice(order, price));
        }
    }
}