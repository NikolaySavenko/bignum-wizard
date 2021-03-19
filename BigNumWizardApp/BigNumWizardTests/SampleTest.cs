using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
	public class SampleTest
	{
		[Fact]
		public void Test1()
		{
			Assert.Equal("SomeAnotherString", BigNumWizardShared.ExampleClass.exampleString);
		}

		[Fact]
		public void Test2()
		{
			Assert.Equal("String from .NET Standart library", BigNumWizardShared.ExampleClass.exampleString);
		}
	}
}
