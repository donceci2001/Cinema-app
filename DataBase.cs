using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Kурсов_Проект
{

    public static class DataBase
    {
        private static string path = Directory.GetParent(Environment.CurrentDirectory)
           .Parent.Parent.FullName + "\\orders";

        public static void Save(List<Order> order)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(stream, order);
            }

        }
        public static void SaveOrder(Order CurrentOrder)
        {
            var Orders = LoadOrders();
            Orders.Add(CurrentOrder);
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(stream, Orders);
            }

        }
        public static List<Order> LoadOrders()
        {
            if (!File.Exists(path))
            {
                using var f = File.Create(path);
                return new List<Order>();
            }
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                if (stream.Length != 0)
                    return (List<Order>)formatter.Deserialize(stream);
                else
                    return new List<Order>();
            }
        }
    }
}
