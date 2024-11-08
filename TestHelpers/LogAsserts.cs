using Microsoft.Extensions.Logging;
using NSubstitute.Core;
using Xunit;

namespace TestHelpers;

public static class LogAsserts
{
    public static void AssertLoggedLevelAndMessage(this ICall call, LogLevel level, string message)
    {
        // TODO I know this will always be right, but... Perhaps stabilize this :)
        var logLevel = (LogLevel)call.GetArguments()[0];
        var formattedLogMessage = call.GetArguments()[2]!.ToString();
        Assert.Equal(level, logLevel);
        Assert.Equal(message, formattedLogMessage);
    }
}