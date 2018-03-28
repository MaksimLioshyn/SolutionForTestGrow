using System;

namespace MockClassLibrary.CustonerForMoq
{
    public interface ICustomer
    {
        void Save(Customer customer);
        string LocalTimeZone { get; set; }
        event EventHandler<NotifyEventArgs> Notify;
    }
}