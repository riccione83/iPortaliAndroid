package md517e48b6440404dd485be69fbd07f088b;


public class ImageViewExt_ScaleListener
	extends android.view.ScaleGestureDetector.SimpleOnScaleGestureListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScale:(Landroid/view/ScaleGestureDetector;)Z:GetOnScale_Landroid_view_ScaleGestureDetector_Handler\n" +
			"";
		mono.android.Runtime.register ("iPortaliAndroid.ImageViewExt+ScaleListener, iPortaliAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ImageViewExt_ScaleListener.class, __md_methods);
	}


	public ImageViewExt_ScaleListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ImageViewExt_ScaleListener.class)
			mono.android.TypeManager.Activate ("iPortaliAndroid.ImageViewExt+ScaleListener, iPortaliAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onScale (android.view.ScaleGestureDetector p0)
	{
		return n_onScale (p0);
	}

	private native boolean n_onScale (android.view.ScaleGestureDetector p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
