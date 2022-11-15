using System;
using Xeptions;

namespace Borshiman.Core.Models.Organizers.Exceptions
{
    public class FailedAnglerStorageException : Xeption
    {
        public FailedAnglerStorageException(Exception innerException)
            : base("Failed angler storage error occured, contact support!",innerException)
        {}
    }
}
