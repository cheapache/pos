using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Core.Domain.Orders
{
    public enum OrderStatus
    {
        Cancelled = 0,
        Pending = 1,
        PaymentReview = 2,
        Close = 3,
    }
}
