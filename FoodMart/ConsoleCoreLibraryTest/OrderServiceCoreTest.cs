using FoodMart.Services.Models;
using FoodMart.Services.Service;
using System;
using Xunit;

namespace ConsoleCoreLibraryTest
{
    public class OrderServiceCoreTest
    {
        OrderService service = new OrderService();
        FoodOrder foodOrder;


        [Fact]
        public void Should_CalculatePrice_ReturnCost_ForVegBiryani()
        {
            foodOrder = new FoodOrder()
            {
                CustomerName = "Megha",
                FoodItem = "VegBiryani",
                Price = 150,
                Quantity = 2
            };
            var expectedValue = 300;
            var cost = service.PriceCalculation(foodOrder.FoodItem, foodOrder.Quantity);
            Assert.Equal(expectedValue, cost);
        }

    }
}
