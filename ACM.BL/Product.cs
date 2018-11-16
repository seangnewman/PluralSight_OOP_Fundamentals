using ACME.Common;
using System;


namespace ACM.BL
{
    public class Product:EntityBase, ILoggable
    {

        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }
        public Decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        //public string ProductName { get; set; }

        private string _ProductName ;

        public string  ProductName
        {
            get {

                return _ProductName.InsertSpaces();
                }
            set { _ProductName = value; }
        }




        public override bool Validate()
        {
            var isValid = true;
            if (String.IsNullOrWhiteSpace(ProductName) || (CurrentPrice == null))
                isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = $"{this.ProductId} : {this.ProductName} Detail: {this.ProductDescription} Status; {this.EntityState.ToString()}";
            return logString;
        }


    }
}
