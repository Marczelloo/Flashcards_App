using Flashcards_.Custom_Controls;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using System.Drawing;
using Microsoft.Maui.Platform;


namespace Flashcards_.Platforms.iOS
{
    public static class EntryMapper
    {
        public static void Map(IElementHandler handler, IElement view)
        {
            if (view is BasicEntry)
            {
                var casted = (EntryHandler)view;
                var viewData = (BasicEntry)casted.VirtualView;

                var control = new UITextField(RectangleF.Empty)
                {
                    BorderStyle = UITextBorderStyle.RoundedRect,
                    ClipsToBounds = true
                };

                // Set padding by adjusting the edge insets
                control.LeftView = new UIView(new RectangleF(0, 0, (float)viewData.Padding.Left, (float)viewData.Padding.Top));
                control.LeftViewMode = UITextFieldViewMode.Always;
                control.RightView = new UIView(new RectangleF(0, 0, (float)viewData.Padding.Right, (float)viewData.Padding.Bottom));
                control.RightViewMode = UITextFieldViewMode.Always;


                UpdateBackground(control, viewData);
            }
        }

        private static void UpdateBackground(UITextField control, BasicEntry entry) // Corrected method signature
        {
            if (control == null) return;

            var paddingControl = (UITextField)control;
            paddingControl.Layer.CornerRadius = entry.CornerRadius;
            paddingControl.Layer.BorderColor = entry.BorderColor.ToCGColor();
            paddingControl.Layer.BorderWidth = entry.BorderWidth;
        }
    }
}
