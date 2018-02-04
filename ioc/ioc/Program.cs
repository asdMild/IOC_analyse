﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           //single ioc achive
           A a= IOC_factory.ioc_reflect(typeof(A))as A;
            Console.WriteLine( a.Get_s());

            Type[] typeparam = { typeof(C) };
            B b = IOC_factory.ioc_reflect(typeof(B),typeparam)as B;
            Console.WriteLine(b.Get_s());

            Type[] typeparam_= {};
            D d = IOC_factory.ioc_reflect(typeof(D), typeparam_) as D;
            Console.WriteLine(d.Get_s());

            Type[] typeparam__ = { typeof(C) , typeof(C) , typeof(C) };
            C c = IOC_factory.ioc_reflect(typeof(C), typeparam__) as C;
            Console.WriteLine(c.Get_s());
            */
            //single binding achive
            BindingValue<string> a = new BindingValue<string>();
            BindingValue<string> b = new BindingValue<string>();
            a.Bind(b.SetValueWithoutInvoke);
            b.Bind(a.SetValueWithoutInvoke);
            b.Value= "asd";
            Console.WriteLine(a.Value);
            a.Value = "ddd";
            Console.WriteLine(b.Value);
            while (true)
            { }
        }
    }
}
