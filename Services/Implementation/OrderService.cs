﻿using BusinessObjects;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
        }

        public List<Order> GetOrdersForCustomer(int customerId)
        {
            return _orderRepository.GetOrdersByCustomerID(customerId);
        }
        public List<Order> GetAllOrders() => _orderRepository.GetAll();

        public List<Order> SearchOrders(int? customerId, int? employeeId) =>
            _orderRepository.Search(customerId, employeeId);

        public void AddOrder(Order order) => _orderRepository.Add(order);

        public void DeleteOrder(int orderId)
        {
            _orderDetailRepository.DeleteDetailsByOrderId(orderId); //xoá order detail trước
            _orderRepository.Delete(orderId);
        }

        public List<OrderDetail> GetAllDetails() => _orderDetailRepository.GetAll();

        public List<OrderDetail> GetDetailsByOrderId(int orderId) =>
            _orderDetailRepository.GetByOrderId(orderId);

        public void AddOrderDetail(OrderDetail detail) =>
            _orderDetailRepository.Add(detail);

        public void DeleteOrderDetailsByOrderId(int orderId) =>
            _orderDetailRepository.DeleteDetailsByOrderId(orderId);
        public List<OrderReportModel> GetReportByMonth() => _orderRepository.GetReportByMonth();
    }
}