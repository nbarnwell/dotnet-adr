using Endjin.Adr.Cli.Abstractions;
using NUnit.Framework;

namespace Endjin.Adr.Cli.Tests;

[TestFixture]
public class FileSystemTests
{
    [Test]
    public void Get_current_working_directory()
    {
        Assert.That(WorkingDirectory.Current, Is.EqualTo(Environment.CurrentDirectory));

        WorkingDirectory.SetCurrentDirectory(() => @"C:\Temp");
        Assert.That(WorkingDirectory.Current, Is.EqualTo(@"C:\Temp"));
    }

    [Test]
    public void Find_repository_root()
    {
        //IRepositoryRootLocator locator = new ();
        
    }
}