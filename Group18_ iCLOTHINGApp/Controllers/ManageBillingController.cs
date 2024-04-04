using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group18__iCLOTHINGApp.Models;
using System.Text.Json;
using System.Collections;

namespace Group18__iCLOTHINGApp.Controllers
{
    public interface ManageBillingState {
        void updateOrderStatus(String statusID);
        void getOrderStatuses();
        void setOrderStatuses(List<OrderStatus> newOrderStatuses);
    }
    public class ManageBillingController : Controller
    {
        private static OrderStatus orderStatus = new OrderStatus
        {
            statusID = System.Guid.NewGuid().ToString(),
            statusDate = DateOnly.FromDateTime(DateTime.Now),
            status = "Confirmed"
        };
        private static OrderStatus orderStatus2 = new OrderStatus
        {
            statusID = System.Guid.NewGuid().ToString(),
            statusDate = DateOnly.FromDateTime(DateTime.Now),
            status = "Confirmed"
        };

        public static List<OrderStatus> orderStatuses = new List<OrderStatus> { orderStatus, orderStatus2 };
        public static ManageBillingState myState;

        public static void setOrderStatuses(List<OrderStatus> newOrderStatuses)
        {
            orderStatuses = newOrderStatuses;
        }
        public static void updateOrderStatus(String statusID, String status)
        {
            for (int i = 0; i < orderStatuses.Count; i++)
            {
                if (orderStatuses[i].statusID.Equals(statusID))
                {
                    orderStatuses[i].status = status;
                    break;
                }
            }
        }
        public static List<OrderStatus> getOrderStatuses()
        {
            return orderStatuses;
        }

        public ActionResult ManageBilling()
        {
            return View();
        }

        public ActionResult EmailForm()
        {
            return View();
        }

        public ActionResult DeliverItem(String statusID)
        {
            ItemDelivery itemDelivery = new ItemDelivery
            {
                stickerID = System.Guid.NewGuid().ToString(),
                stickerDate = new DateOnly()
            };

            ManageBillingController.updateOrderStatus(statusID, "Shipped");
            Console.WriteLine(JsonSerializer.Serialize(itemDelivery));

            return View("ManageBilling");
        }

        public ActionResult SendEmail(String statusID)
        {
            Email email = new Email
            {
                emailSubject = "Order confirmation",
                emailBody = "Hello your order has been verified by an Administrator and is being prepared for delivery",
                emailDate = new DateOnly(),
                emailNo = System.Guid.NewGuid().ToString()
            };

            ManageBillingController.updateOrderStatus(statusID, "Verified");
            Console.WriteLine(JsonSerializer.Serialize(email));

            return View("ManageBilling");
        }
    }
}