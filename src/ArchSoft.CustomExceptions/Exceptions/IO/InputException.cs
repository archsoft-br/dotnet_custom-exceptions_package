﻿using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.IO;

public class InputException : BadRequestException
{
    public InputException()
    {
    }

    public InputException(string message) : base(message)
    {
    }

    public InputException(string message, Exception inner) : base(message, inner)
    {
    }
}
