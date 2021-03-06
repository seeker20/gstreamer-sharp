// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.LibraryErrorGType))]
	public enum LibraryError {

		Failed = 1,
		TooLazy = 2,
		Init = 3,
		Shutdown = 4,
		Settings = 5,
		Encode = 6,
		NumErrors = 7,
	}

	internal class LibraryErrorGType {
		[DllImport ("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_library_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_library_error_get_type ());
			}
		}
	}
#endregion
}
