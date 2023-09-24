using System.Collections.Generic;
using System;

namespace PierresTracker.Models
{
    public class Order
    {
        public string Description { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };
        public int Total { get; set; }

        public Order(string description)
        {
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
            // Total = total;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId-1];
        }


    }
}