using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace App39
{
   public class MyCheckBox : CheckBox
    {
        public MyCheckBox(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            TypedArray ta = context.ObtainStyledAttributes(attrs, Resource.Styleable.custom);

            String text = ta.GetString(Resource.Styleable.custom_test);
            int number = ta.GetInteger(Resource.Styleable.custom_number, -1);

            Log.Error("IAttributeSet", "text = " + text + " , number = " + number);

            ta.Recycle();
        }
    }
}