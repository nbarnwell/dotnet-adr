using NUnit.Framework;

namespace Endjin.Adr.Cli.Tests;

[TestFixture]
public class FileSystemTests
{
    [Test]
    public void Get_current_working_directory()
    {
        string cwd = Endjin.Adr.Cli.Abstractions.WorkingDirectory.Current;
        Assert.That(cwd, Is.EqualTo(System.Environment.CurrentDirectory));

        Abstractions.WorkingDirectory.SetCurrentDirectory(() => @"C:\Temp");
        cwd = Endjin.Adr.Cli.Abstractions.WorkingDirectory.Current;
        Assert.That(cwd, Is.EqualTo(@"C:\Temp"));
    }

    [Test]
    public void Find_repository_root()
    {
        //IRepositoryRootLocator locator = new ();
        
    }
}