
using System;
using System.Drawing;

using Foundation;
using UIKit;

using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TipCalc.Core.ViewModels;

namespace TipCalc.iOS
{
	public partial class TipView : MvxViewController
	{
		public TipView () : base ("TipView", null)
		{
		}

		public new TipViewModel ViewModel
		{
			get { return (TipViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.CreateBinding(TipLabel).To((TipViewModel vm) => vm.Tip).Apply();
			this.CreateBinding(SubtotalField).To((TipViewModel vm) => vm.SubTotal).Apply();
			this.CreateBinding(GenerositySlider).To((TipViewModel vm) => vm.Generosity).Apply();  
		}
	}
}

