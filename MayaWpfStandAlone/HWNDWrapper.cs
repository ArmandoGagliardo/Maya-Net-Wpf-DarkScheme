﻿// (C) Copyright 2014 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary
// to Autodesk, Inc., and considered a trade secret as defined
// in section 499C of the penal code of the State of California.
// Use of this information by anyone other than authorized
// employees of Autodesk, Inc. is granted only under a written
// non-disclosure agreement, expressly prescribing the scope
// and manner of such use.

//- Written by Cyrille Fauvel, Autodesk Developer Network (ADN)
//- http://www.autodesk.com/joinadn
//- January 20th, 2014
//
using System;
using System.Windows;

namespace Autodesk.Maya.Samples.MayaWpfStandAlone {

	// Wrapper for the IntPtr/IWin32Window
	public class HWNDWrapper : System.Windows.Forms.IWin32Window {
		private IntPtr hwnd ;

		public HWNDWrapper (IntPtr h) {
			hwnd =h ;
		}

		public IntPtr Handle {
			get {
				return (hwnd) ;
			}
		}
	}

}
