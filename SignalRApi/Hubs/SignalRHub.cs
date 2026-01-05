using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly ICustomerSeatService _customerSeatService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;

        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, ICustomerSeatService customerSeatService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _customerSeatService = customerSeatService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }

        public static int clientCount { get; set; } = 0;

        public async Task SendStatistic()
        {
            //Category
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var activeCategory = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", activeCategory);

            var passiveCategory = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", passiveCategory);

            //Product
            var products = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", products);

            var productHamburger = _productService.TProductCountByCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", productHamburger);

            var drinks = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", drinks);

            var productAvg = _productService.TProdutPriceAverage();
            await Clients.All.SendAsync("ReceiveProdutPriceAverage", productAvg.ToString("0.00") + "₺");

            var maxproduct = _productService.TProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", maxproduct);

            var minproduct = _productService.TProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", minproduct);

            var avghamburger = _productService.TProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", avghamburger.ToString("0.00") + "₺");

            //Order
            var totalorder = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", totalorder);

            var activeorders = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeorders);

            var lastorder = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", lastorder.ToString("0.00") + "₺");

            //MoneyCase
            var totalmoney = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", totalmoney.ToString("0.00") + "₺");

            //CustomerSeat
            var customerseat = _customerSeatService.TCustomerSeatCount();
            await Clients.All.SendAsync("ReceiveCustomerSeatCount", customerseat);
        }

        public async Task SendProgress()
        {
            var totalmoney = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", totalmoney.ToString("0.00") + "₺");

            var activeordercount = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeordercount);

            var totalcustomerseat = _customerSeatService.TCustomerSeatCount();
            await Clients.All.SendAsync("ReceiveCustomerSeatCount", totalcustomerseat);

            var value5 = _productService.TProdutPriceAverage();
            await Clients.All.SendAsync("ReceiveProdutPriceAvg", value5);

            var value6 = _productService.TProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveAvgPriceByHamburger", value6);

            var value7 = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", value7);

            var value8 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value8);

            var value9 = _productService.TProductPriceBySteakBurger();
            await Clients.All.SendAsync("ReceiveProductPriceBySteakBurger", value9);

            var value10 = _productService.TTotalPriceByDrinkCategory();
            await Clients.All.SendAsync("ReceiveTotalPriceByDrinkCategory", value10);

            var value11 = _productService.TTotalPriceBySaladCategory();
            await Clients.All.SendAsync("ReceiveTotalPriceBySaladCategory", value11);

        }

        public async Task GetBookingList()
        {
            var values = _bookingService.TGetListAll();
            await Clients.All.SendAsync("ReceiveBookingList", values);
        }

        public async Task SendNotification()
        {
            var values = _notificationService.TNotificationCountByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationCountByStatusFalse", values);

            var notificationListByFalse = _notificationService.TGetAllNotificationByFalse();
            await Clients.All.SendAsync("ReceiveGetAllNotificationByFalse", notificationListByFalse);
        }

        public async Task GetCustomerSeatStatus()
        {
            var values = _customerSeatService.TGetListAll();
            await Clients.All.SendAsync("ReceiveCustomerSeatStatus", values);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override async Task OnConnectedAsync()
        {
            clientCount++;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientCount--;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
