using Endjin.Adr.Cli.Abstractions;
using NUnit.Framework;
using Spectre.IO;
using Spectre.IO.Testing;
using Environment = System.Environment;

namespace Endjin.Adr.Cli.Tests;

[TestFixture]
public class FileSystemTests
{
    private IEnvironment environment;

    [SetUp]
    public void SetUp()
    {
        this.environment = FakeEnvironment.CreateWindowsEnvironment();
    }

    [Test]
    public void Get_current_working_directory()
    {
        Assert.That(WorkingDirectory.Current, Is.EqualTo(Environment.CurrentDirectory));

        this.environment.SetWorkingDirectory(DirectoryPath.FromString(@"C:\Temp"));
        WorkingDirectory.SetCurrentDirectory(() => this.environment.WorkingDirectory.FullPath);
        Assert.That(WorkingDirectory.Current, Is.EqualTo(@"C:/Temp"));
    }

    [Test]
    public void Find_repository_root()
    {
        
    }
}