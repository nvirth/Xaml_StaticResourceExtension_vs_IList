using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
	public partial class UserControl1 : UserControl
	{
		private static readonly Type ClassType = typeof(UserControl1);

		public UserControl1()
		{
			InitializeComponent();
			MyList = new List<string>(0);
		}

		#region MyList
		public static readonly DependencyProperty MyListProperty = DependencyProperty.Register(
			nameof(MyList), typeof(IList), ClassType, new PropertyMetadata(default(IList))
		);

		public IList MyList
		{
			get { return (IList)GetValue(MyListProperty); }
			set { SetValue(MyListProperty, value); }
		}
		#endregion
	}
}
