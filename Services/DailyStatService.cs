﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoRepairShop.Data.Models.CarParts;
using AutoRepairShop.Data.Models.Humans;
using AutoRepairShop.Data.Repository;
using AutoRepairShop.Tools;
using AutoRepairShop.WorkFlow;

namespace AutoRepairShop.Services
{
    class DailyStatService
    {
        public List<string> DailyStats = new List<string>();
        private FileLoggerService _fls = new FileLoggerService();

        public void AddCustomer(Customer customer)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"New Customer: {customer.Name}, priority: {customer.MyDiscounts.Priority}");
            sb.AppendLine($"-- Car: {customer.MyCar.Name}, Accepted on: {TimeTool.GetGameTime()}");
            sb.AppendLine($"Broken parts:");
            foreach (CarPart carPart in customer.MyCar.CarContent)
            {
                if (!carPart.IsWorking)
                {
                    sb.Append($"{carPart.Name}, ");
                }
            }
            sb.AppendLine();
            DailyStats.Add(sb.ToString());
        }

        public void AddWorkOrder(RepairMan rm, string order, double workCost, double partCost)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{TimeTool.GetGameTime()} -- Work Order: {order}, work cost: {workCost}, part cost: {partCost}");
            _fls.StoreLog(sb.ToString());
            DailyStats.Add(sb.ToString());
        }

        public void FinalizeCustomer(Customer customer, double totalCost)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Finilized Customer: {customer.Name}, priority: {customer.MyDiscounts.Priority}");
            sb.AppendLine($"-- Car: {customer.MyCar.Name}, Released on: {TimeTool.GetGameTime()}");
            sb.AppendLine($"Car parts:");
            foreach (CarPart carPart in customer.MyCar.CarContent)
            {
                string works = carPart.IsWorking ? "is working" : "is not working";
                sb.AppendLine($"{carPart.Name} - {works}");
            }
            sb.AppendLine($"The total is {totalCost}");
            sb.AppendLine($"Discount applied: {customer.MyDiscounts.CardName}");
            sb.AppendLine();
            DailyStats.Add(sb.ToString());
        }

        public void Clear()
        {
            DailyStats.Clear();
        }

        public void Display()
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("***DAILY STATISTICS***");
            foreach (string line in DailyStats)
            {
                Console.WriteLine($"{line}");
            }
            Console.WriteLine($"-- Customers in Line --");
            CustomerQueue<Customer>.Display(ShopManager.Customers);
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"-- Customers on Hold --");
            CustomerQueue<Customer>.Display(ShopManager.CustomersOnHold);
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Kirills salary - {RmKirill.Kirill.Salary}");
            Console.WriteLine($"Vanos salary - {RmVano.Vano.Salary}");
            Console.WriteLine($"Petrovichs salary - {RmPetrovich.Petrovich.Salary}");
            Console.WriteLine($"SanSanuchs salary - {RmSanSanuch.SanSanuch.Salary}");
            Console.WriteLine("***END OF DAILY STATISTICS***");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
