
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Cirrious.MvvmCross.Droid.Views;
; using TipCalc.Core;
using TipCalc.Core.ViewModels;

namespace TipCalc.Droid
{
	[Activity (Label = "Tip", MainLauncher=true)]			
	public class TipCalcView : MvxActivity
	{
		// protected override void OnCreate (Bundle bundle)
		// {
		// 	base.OnCreate (bundle);
		// }

        public new TipViewModel ViewModel
        {
            get { return (TipViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Tip);
        }
	}
}

