﻿namespace PureFood.Core.Models.error
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message) : base(message) { }

    }
}
