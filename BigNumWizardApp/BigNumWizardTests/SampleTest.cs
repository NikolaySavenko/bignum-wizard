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
			Assert.Equal("String from .NET Standart library", BigNumWizardShared.ExampleClass.exampleString);
		}

		[Fact]
		public void Test2()
		{
			string num = "12345";
			BigNum bigNum = new BigNum(num);

			Assert.Equal(num, ((int)bigNum).ToString());
		}
	}
}
