using System;

namespace MockClassLibrary.CustonerForMoq
{
    public class NotifyEventArgs : EventArgs
    {
        public NotifyEventArgs(string customerName)
        {
            CustomerName = customerName;
        }

        public string CustomerName { get; set; }
    }
}