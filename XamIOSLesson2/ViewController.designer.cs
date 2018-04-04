// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamIOSLesson2
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton botonTraspasar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextApellido { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TextArea { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextIDE { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextNombre { get; set; }

        [Action ("BotonTraspasar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BotonTraspasar_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (botonTraspasar != null) {
                botonTraspasar.Dispose ();
                botonTraspasar = null;
            }

            if (TextApellido != null) {
                TextApellido.Dispose ();
                TextApellido = null;
            }

            if (TextArea != null) {
                TextArea.Dispose ();
                TextArea = null;
            }

            if (TextIDE != null) {
                TextIDE.Dispose ();
                TextIDE = null;
            }

            if (TextNombre != null) {
                TextNombre.Dispose ();
                TextNombre = null;
            }
        }
    }
}