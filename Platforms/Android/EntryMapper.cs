using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcards_.Custom_Controls;
using Microsoft.Maui.Handlers;
using Android.Graphics.Drawables;
using Microsoft.Maui.Platform;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;

namespace Flashcards_.Platforms.Android
{
    public static class EntryMapper
    {
        public static void Map(IElementHandler handler, IElement view)
        {
            if (view is BasicEntry)
            {
                var casted = (EntryHandler)view;
                var viewData = (BasicEntry)casted.VirtualView;

                var gd = new GradientDrawable();

                gd.SetCornerRadius((int)handler.MauiContext?.Context.ToPixels(viewData.CornerRadius));
                gd.SetColor(viewData.BackgroundColor.ToAndroid());

                if (!viewData.HasBorder)
                {
                    gd.SetStroke((int)handler.MauiContext?.Context.ToPixels(viewData.BorderWidth), viewData.BorderColor.ToAndroid());
                }

                casted.PlatformView?.SetBackground(gd);

                casted.PlatformView.SetPadding(
                    (int)handler.MauiContext?.Context.ToPixels(viewData.Padding.Left),
                    (int)handler.MauiContext?.Context.ToPixels(viewData.Padding.Top),
                    (int)handler.MauiContext?.Context.ToPixels(viewData.Padding.Right),
                    (int)handler.MauiContext?.Context.ToPixels(viewData.Padding.Bottom)
                );
            }
        }
    }
}
