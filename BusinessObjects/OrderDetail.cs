﻿namespace BusinessObjects
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        //Để để binding với ComboBox ở OrderDialog
        public Product Product { get; set; }
    }
}
