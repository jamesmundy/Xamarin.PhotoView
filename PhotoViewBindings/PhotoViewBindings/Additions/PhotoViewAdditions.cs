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

namespace UK.CO.Senab.Photoview
{
  public partial class PhotoView
  {
    static IntPtr id_getScaleType;
    static IntPtr id_setScaleType;
    public ScaleType ScaleType
    {
      [Register("getScaleType", "()Landroid/widget/ImageView$ScaleType;", "GetGetScaleTypeHandler")]
      get
      {
        if (id_getScaleType == IntPtr.Zero)
          id_getScaleType = JNIEnv.GetMethodID(class_ref, "getScaleType", "()Landroid/widget/ImageView$ScaleType;");

        if (GetType() == ThresholdType)
          return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType>(JNIEnv.CallObjectMethod(Handle, id_getVisibleRectangleBitmap), JniHandleOwnership.TransferLocalRef);
        else
          return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;")), JniHandleOwnership.TransferLocalRef);
      }
      [Register("setScaleType", "()Landroid/widget/ImageView$ScaleType;", "setGetScaleTypeHandler")]
			set {
        if (id_setScaleType == IntPtr.Zero)
					id_setScaleType = JNIEnv.GetMethodID (class_ref, "setScaleType", "()Landroid/widget/ImageView$ScaleType;");
					JNIEnv.CallVoidMethod  (Handle, id_setScaleType, new JValue (value));
			}
    }
  }
}