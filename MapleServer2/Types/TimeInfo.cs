﻿namespace MapleServer2.Types;

public static class TimeInfo
{
    public static long Now() => DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    public static DateTime CurrentDate() => DateTimeOffset.UtcNow.UtcDateTime;

    public static long AddDays(int days) => DateTimeOffset.UtcNow.AddDays(days).ToUnixTimeSeconds();
}