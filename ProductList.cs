using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_basic_operations
{
     public class ProductList
    {
        public ProductNode Head;
        public ProductNode obj_Product;

        public void Add(Product productToAdd, int insert, int after)
        {
            ProductNode newProductNode = new ProductNode(); // instancia de la clase productNode
            newProductNode.product = productToAdd; //insersiccion de lo que es el producto

            if (insert < after)
            {
                if (productToAdd.Code == insert || productToAdd.Code == after)
                {
                    if (productToAdd.Code == insert)
                    {
                        obj_Product = newProductNode;
                    }
                    else
                    {
                        if (Head == null)
                        {
                            Head = newProductNode;
                            ProductNode last = Head;
                            last = last.Next;
                            last.Next = newProductNode;
                        }
                        else
                        {
                            ProductNode last = Head;
                            while (last.Next != null)
                            {
                                last = last.Next;
                            }
                            last.Next = newProductNode;
                            last = last.Next;
                            last.Next = obj_Product;

                        }

                    }

                }
                else
                {
                    if (Head == null)
                    {
                        Head = newProductNode;
                    }
                    else
                    {
                        ProductNode last = Head;
                        while (last.Next != null)
                        {
                            last = last.Next;
                        }
                        last.Next = newProductNode;

                    }

                }

            }
            else
            {
                if (productToAdd.Code == insert)
                {
                    ProductNode last = Head;

                    for (int i = 101; i < after; i++)
                    {
                
                        last = last.Next;
                        
                    }
                    ProductNode Next = last.Next;
                    last.Next = newProductNode;
                    last.Next.Next = Next;
                }
                else
                {
                    if (Head == null)
                    {
                        Head = newProductNode;
                    }
                    else
                    {
                        ProductNode last = Head;
                        while (last.Next != null)
                        {
                            last = last.Next;
                        }
                        last.Next = newProductNode;

                    }

                }
            }
        }
            
        public void Print()
        {
            ProductNode tmp = Head;  //tmp= temporal
            while (tmp != null)
            {
                Console.WriteLine($"Name of the product: {tmp.product.Name} - price of the product: {tmp.product.price} - code of the product: {tmp.product.Code} - color of the product: {tmp.product.color}");
                tmp = tmp.Next;

            }
        }
     }
}
