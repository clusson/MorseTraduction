using NUnit.Framework;
using System;
namespace TestUnitaires
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			string t = Traducteur.Program.Translate("t");
			Assert.AreEqual(t, "- ");
		}


		[Test()]
		public void TestCase2()
		{
			string t = Traducteur.Program.Translate("m");
			Assert.AreEqual(t, "-- ");
		}

		[Test()]
		public void TestCase3()
		{
			string t = Traducteur.Program.Translate("5");
			Assert.AreEqual(t, "..... ");
		}
	}
}
