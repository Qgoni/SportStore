//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportStore.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int OrderNumber { get; set; }
        public string OrderComposition { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<int> PickupPoint { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> PickupCode { get; set; }
        public string OrderStatus { get; set; }
    }
}
