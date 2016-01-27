using System;
using System.Collections.Generic;
using System.Linq.Expressions;




namespace Exam
{
    class MyType<T> where T : new()
    {
        T value;

        public MyType() { value = new T(); }

        public MyType(T value_) { value = value_; }

        public static T Summarize(T a, T b)
        {
            try {
                dynamic aa = a;
                dynamic bb = b;
                dynamic cc = aa + bb;
                return cc;
            }
            catch
            {
                return new T();
            }
            //var a_exp = Expression.Constant(value, typeof(T));
            //var b_exp = Expression.Constant(value_to_add, typeof(T));
            
            //try
            //{
            //    var result = Expression.Add(a_exp, b_exp);
            //    return Expression.Convert(result, T.GetType());
            //}
        }

        public static T Divided(T a, int b)
        {
            try
            {
                dynamic aa = a;
                dynamic bb = b;
                dynamic cc = aa / bb;
                return cc;
            }
            catch
            {
                return new T();
            }
        }
    }


    class SetsMethods<T> where T : new()
    {
        
        public static T Summ(IEnumerable<T> set)
        {
            T res = new T();
            foreach(var s in set)
            {
                res = MyType<T>.Summarize(res, s);
            }
            return res;
        }


        public static T Mean(IEnumerable<T> set)
        {
            var res = Summ(set);
            int i = 0;
            foreach(var s in set)
            {
                i++;
            }
            return MyType<T>.Divided(res, i);
        }
    }
}
