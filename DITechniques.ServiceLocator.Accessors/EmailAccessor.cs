﻿using System;
using DITechniques.ServiceLocator.Shared.DataContracts;
using DITechniques.ServiceLocator.Shared.Interfaces;

namespace DITechniques.ServiceLocator.Accessors
{
    class EmailAccessor : IEmailAccessor
    {
        public void SendPriceNotice(Product product, decimal newPrice)
        {
            // simulate sending an email with a price update
            Console.WriteLine("Email sent for product {0}. Threshold: {1}, Current: {2}", product.ProductCode, product.PriceThreshold, newPrice);
        }
    }
}
