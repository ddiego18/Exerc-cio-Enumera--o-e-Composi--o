using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Enumeração_e_Composição.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
