using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Category
    {
        #region Field-Property-LocalVariable

        //// Field: Eğer bir değer sınıf içerisinde tanımlanırsa o değer field olarak geçer.
        //int field;

        //// Property: Eğer bir değer sınıf içerisinde get ve set blokları ile tanımlanırsa o değer property olarak geçer.
        //public int Property { get; set; }

        //void Method()
        //{
        //    // Local Variable: Eğer bir değer sınıf içerisinde bir metot içerisinde tanımlanırsa o değer local variable olarak geçer.
        //    int localVariable;
        //}

        #endregion

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public List<Product> Product { get; set; }
    }
}
