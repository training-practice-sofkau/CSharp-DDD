using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.ValueObjects
{
    //record quiere decir que es inmutable
    public record PersonName
    {
        public string Value { get; init; }
        internal PersonName(string value) 
        { 
            this.Value = value; 
        }

        public static PersonName Create(string value) 
        { 
            validate(value);
            return new PersonName(value); 
        }
        //validación de value object
        public static void validate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("El valor no puede ser nulo");
            }
        }
    }
}
