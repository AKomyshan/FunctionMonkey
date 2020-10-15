﻿using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Tests.Integration.Common.Commands.Model;

namespace FunctionMonkey.Tests.Integration.Common.Commands.HttpResponseShaping
{
    public class HttpResponseHandlerCommandWithResultAndNoValidation : ICommand<SimpleResponse>
    {
        public int Value { get; set; }
    }
}
