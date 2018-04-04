using System;

using UIKit;

namespace XamIOSLesson2
{
    public partial class ViewController : UIViewController
    {
       public string Mensage = "";

        partial void BotonTraspasar_TouchUpInside(UIButton sender)
        {
            if(ValidField()){

                TextArea.Text = "RUT : " + TextIDE.Text + "  Nombre :" + TextNombre.Text + " Apellido : " + TextApellido.Text;

            }else{

                //Create Alert
                var okAlertController = UIAlertController.Create("Title", "The message "  + Mensage, UIAlertControllerStyle.Alert);

                //Add Action
                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                // Present Alert
                PresentViewController(okAlertController, true, null);

            }

          
        }


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            limpiarAreaCampo();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void limpiarAreaCampo()
        {
            TextArea.Text = "";


        }
        private void limpiarCampos()
        {
            TextIDE.Text = "";
            TextNombre.Text = "";
            TextApellido.Text = "";


        }

        private Boolean ValidField()
        {
            Boolean Valid = true;

            if(String.IsNullOrEmpty(TextIDE.Text))
            {
                Mensage = "Campo IDE Vacio";
                Valid = false;
                return Valid;
            }
            if (String.IsNullOrEmpty(TextNombre.Text))
            {
                Mensage = "Campo Nombre Vacio";
                Valid = false;
                return Valid;
            }
            if (String.IsNullOrEmpty(TextApellido.Text))
            {
                Mensage = "Campo Apellico Vacio";
                Valid = false;
                return Valid;
            }
            return Valid;
        }
    }
}
