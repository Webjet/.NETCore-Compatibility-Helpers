using System;

using System.Reflection;
using System.Runtime.InteropServices;

namespace Handy.DotNETCoreCompatibility.StandardLibrary
{
    //Consider to add:
    //using ApplicationException = Handy.DotNETCoreCompatibility.StandardLibrary.ApplicationException;

#if NET_STANDARD
    [ComVisible(true)]
 //   [Serializable]
    public class ApplicationException : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.ApplicationException" /> class.</summary>
        public ApplicationException()
          : base()//Environment.GetResourceString("Arg_ApplicationException"))
        {
            //this.SetErrorCode(-2146232832);
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.ApplicationException" /> class with a specified error message.</summary>
        /// <param name="message">A message that describes the error. </param>
        public ApplicationException(string message)
          : base(message)
        {
            //this.SetErrorCode(-2146232832);
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.ApplicationException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception. </param>
        public ApplicationException(string message, Exception innerException)
          : base(message, innerException)
        {
            //this.SetErrorCode(-2146232832);
        }

        ///// <summary>Initializes a new instance of the <see cref="T:System.ApplicationException" /> class with serialized data.</summary>
        ///// <param name="info">The object that holds the serialized object data. </param>
        ///// <param name="context">The contextual information about the source or destination. </param>
        //protected ApplicationException(SerializationInfo info, StreamingContext context)
        //  : base(info, context)
        //{
        //}
    }

    public class HttpException : Exception //ExternalException
    {

        /// <summary>Initializes a new instance of the <see cref="T:System.Web.HttpException" /> class using a supplied error message.</summary>
        /// <param name="message">The error message displayed to the client when the exception is thrown. </param>
        public HttpException(string message)
          : base(message)
        {
        }
        /// <summary>Initializes a new instance of the <see cref="T:System.Web.HttpException" /> class using an error message and the <see cref="P:System.Exception.InnerException" /> property.</summary>
        /// <param name="message">The error message displayed to the client when the exception is thrown. </param>
        /// <param name="innerException">The <see cref="P:System.Exception.InnerException" />, if any, that threw the current exception. </param>
        public HttpException(string message, Exception innerException)
          : base(message, innerException)
        {
        }
    }
#else
    public class ApplicationException: System.ApplicationException
    {}
#endif
}
