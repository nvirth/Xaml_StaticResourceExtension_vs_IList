using System;
using System.Windows.Controls;

namespace WpfApplication1
{
	public partial class UserControl2 : UserControl
	{
		public UserControl2()
		{
			InitializeComponent();
			Console.WriteLine("Control1.MyList.Count: " + Control1.MyList.Count);
		}
	}
}
