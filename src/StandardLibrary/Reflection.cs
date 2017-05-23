using System;

using System.Reflection;

namespace Handy.DotNETCoreCompatibility.StandardLibrary
{
    public class Reflection
    {
#if NET_STANDARD

            public static TypeInfo GetReflectionType(Object o)
            {
                return o.GetType().GetTypeInfo();
            }

            public static TypeInfo GetReflectionType(Type t)
            {
                return t.GetTypeInfo();
            }
        public static Assembly GetExecutingAssembly(Type currentType)
        {
            return currentType.GetTypeInfo().Assembly;
            //System.Reflection.Assembly.GetExecutingAssembly();
        }
#else


            public static Type GetReflectionType(Object o)
            {
                return o.GetType();
            }
            public static Type GetReflectionType(Type t)
            {
                return t;
            }
#endif
    }
}
