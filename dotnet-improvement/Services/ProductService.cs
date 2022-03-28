﻿using System;
using static dotnet_improvement.Configs.Events.GeneralEvents;

namespace dotnet_improvement.Services
{
    public interface IProductService
    {
        // Events
        event SuccessEvent AddProductEvent;
        
        // Methods
        void Add(string name);
    }

    public class ProductService : IProductService
    {
        // Events
        public event SuccessEvent AddProductEvent;

        // Methods
        public void Add(string name)
        {
            Console.WriteLine("Product Added!");
            OnAddProduct();
        }

        // Protected Event Invokers
        protected virtual void OnAddProduct()
        {
            AddProductEvent?.Invoke();
        }

    }
}
