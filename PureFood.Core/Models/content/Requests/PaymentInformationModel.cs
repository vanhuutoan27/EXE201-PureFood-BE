﻿namespace PureFood.Core.Models.content.Requests
{
    public class PaymentInformationModel
    {
        public string OrderType { get; set; }
        public double Amount { get; set; }
        public string OrderDescription { get; set; }
        public string Name { get; set; }
        //public int AccountId { get; set; }

    }
}
