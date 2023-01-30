﻿namespace SteamApiClient.Exceptions;

public class CacheException : Exception
{
    public CacheException()
    {
    }

    public CacheException(string message)
        : base(message)
    {
    }

    public CacheException(string message, Exception inner)
        : base(message, inner)
    {
    }
}