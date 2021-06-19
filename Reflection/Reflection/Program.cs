using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
           // get the classes of a perticular namespacce 
            Type type = Type.GetType("Reflection.Customer");

            // get all the propertese 
            PropertyInfo[] propInfo = type.GetProperties();

            var privateProp = type.GetProperty("Name", BindingFlags.NonPublic | BindingFlags.Instance);

           
            // get all private propertese
            PropertyInfo[] protectedProp = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            // get the methods 
            MethodInfo[] methodInfo = type.GetMethods();

            List<MethodInfo> runtimeInfo = type.GetRuntimeMethods().ToList();

            // getting constructor with parameters 
            var customerCtor = type.GetConstructor(new Type[]{
                typeof(string) , typeof(string) 
            });

            // invoking a constructor with custom parameters 
            var cust = customerCtor.Invoke(new string[] { "123", "dinith" });



            // getting constructor without parameters 
            var noParamCtror = type.GetConstructor(Type.EmptyTypes);

            // invoking constructor without parameters 
            var cust2 = noParamCtror.Invoke(null);

            privateProp.SetValue(cust, "Dinith11");

            
            foreach (MethodInfo mi in runtimeInfo)
            {
                if(mi.Name == "set_Name")
                {
                    // invoking a method with the parameters 
                    mi.Invoke(cust, new object[] { "diinth 1234" });
                }
               if(mi.Name == "printCustomer")
                {
                    // invoking a methos 
                    mi.Invoke(cust , null);
                }

               if(mi.Name == "printAge")
                {
                    mi.Invoke(cust, new object[] { 23 });
                }
            }

            // reading propertese 
            foreach (PropertyInfo pi in propInfo)
            {
                Console.WriteLine($" property name : {pi.Name} . type : {pi.PropertyType}");
            }
        }
    }


    public class Customer
    {
        public string Id { private get; set; }

        protected string Name { get ; set; }

        public Customer(string id , string name)
        {
            Id = id;
            Name = name;
        }

        public Customer()
        {
            this.Id = "-1";
            Name = string.Empty;
        }

        public void printCustomer()
        {
            Console.WriteLine($" customer => name : {Name} \t Id : {Id} . ");
        }

        public void printAge(int age)
        {
            Console.WriteLine($"custemer {Name} age is {age}");
        }
    }
}
