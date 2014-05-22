using System;

namespace DevStore.Domain
{
    public class Product
    {

        public Product()
        {
            this.AcquireDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public  decimal Price{ get; set; }
        public DateTime AcquireDate { get; set; }
        public bool IsActive{ get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int MyProperty { get; set; }

//        public ICollection<Product> Products { get; set; } - permite que o EF já adicione a classe associativa no banco

        public override string ToString()
        {
            return this.Title;
        }
    }
}
