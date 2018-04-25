using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }
        /// <summary>
        /// True if Id has been setted Identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
