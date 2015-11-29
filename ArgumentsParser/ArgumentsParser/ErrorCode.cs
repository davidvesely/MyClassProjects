﻿namespace ArgumentsParser
{
    public enum ErrorCode
    {
        OK,
        INVALID_ARGUMENT_NAME, INVALID_ARGUMENT_FORMAT, UNEXPECTED_ARGUMENT,
        MISSING_STRING,
        MISSING_INTEGER, INVALID_INTEGER,
        MISSING_DOUBLE, INVALID_DOUBLE
    }
}