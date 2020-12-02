using AutoMapper;
using MedicalExpress.API.Responses;
using MedicalExpress.CORE.DTOs;
using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.CORE.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderservice;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            ///inyeccion de dependencias
            _orderservice = orderService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _orderservice.GetOrders();
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);

            var response = new ApiResponse<IEnumerable<OrderDto>>(ordersDto);
            return Ok(response);
        }
        [HttpGet]
        [Route("bysession/{id}")]
        public async Task<IActionResult> GetSessionToken(string id)
        {
            var orders = await _orderservice.GetSessionToken(id);
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);

            var response = new ApiResponse<IEnumerable<OrderDto>>(ordersDto);
            return Ok(response);
        }
        [HttpGet]
        [Route("byuser/{id}")]
        public async Task<IActionResult> GetOrderByUser(int id)
        {
            var orders = await _orderservice.GetOrderByUser(id);
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);

            var response = new ApiResponse<IEnumerable<OrderDto>>(ordersDto);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var order = await _orderservice.GetOrder(id);
            var orderDto = _mapper.Map<OrderDto>(order);

            var response = new ApiResponse<OrderDto>(orderDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(OrderDto orderDto)
        {

            var order = _mapper.Map<Order>(orderDto);

            await _orderservice.InsertOrder(order);
            orderDto = _mapper.Map<OrderDto>(order);
            var response = new ApiResponse<OrderDto>(orderDto);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, OrderDto orderDto)
        {

            var order = _mapper.Map<Order>(orderDto);
            order.OrderId = id;

            var result = await _orderservice.UpdateOrder(order);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _orderservice.DeleteOrder(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
