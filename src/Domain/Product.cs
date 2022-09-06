﻿namespace Domain
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }
        public int Stock { get; private set; }

		public Product()
		{

		}
    }
}