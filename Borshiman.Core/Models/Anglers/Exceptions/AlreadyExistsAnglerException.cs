using System;
using Xeptions;

namespace Borshiman.Core.Models.Anglers.Exceptions
{
    public class AlreadyExistsAnglerException : Xeption                       
    {
        public AlreadyExistsAnglerException(Exception innerException)
            :base(message: "Angler with the same id already exists.", innerException)
        {}
    }
}
