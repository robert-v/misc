using System;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Misc;

namespace Tests
{
	[TestClass]
	public class ListBoxExtensions
	{
		[TestMethod]
		public void TextArray()
		{
			var lb = new ListBox();
			lb.Items.Add("abc");
			lb.Items.Add("def");
			var arr = lb.GetTextsArray();

			Assert.AreEqual(arr.Length, 2);
		}
	}
}
