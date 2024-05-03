// <copyright file="WorkingDirectory.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System;

namespace Endjin.Adr.Cli.Abstractions;

public static class WorkingDirectory
{
    private static Func<string> workingDirectoryProvider = () => Environment.CurrentDirectory;

    public static string Current => workingDirectoryProvider();

    public static void SetCurrentDirectory(Func<string> workingDirectoryProvider)
    {
        WorkingDirectory.workingDirectoryProvider = workingDirectoryProvider;
    }
}