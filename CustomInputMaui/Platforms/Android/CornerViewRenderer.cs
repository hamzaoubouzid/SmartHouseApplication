#if ANDROID
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using CustomInputMaui.Controls;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

[assembly: ExportRenderer(typeof(CornerView), typeof(CornerViewRenderer))]
public class CornerViewRenderer : VisualElementRenderer<Frame>
{
    public CornerViewRenderer(Context context) : base(context) { }

    protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
    {
        base.OnLayout(changed, left, top, right, bottom);

        // Handle Circle or other rounded corner styles here
        var frame = (CornerView)this.Element;
        if (frame.StyleCorner == CornerView.ControlStyleCorner.Circle)
        {
            var radius = Math.Min(Width, Height) / 2;
            SetCornerRadius((float)radius);
        }
        else if (frame.StyleCorner == CornerView.ControlStyleCorner.RoundCorner)
        {
            SetCornerRadius(20); // Example for a fixed radius
        }
    }

    private void SetCornerRadius(float radius)
    {
        var shape = new GradientDrawable();
        shape.SetShape(ShapeType.Rectangle);
        shape.SetCornerRadius(radius);
        this.Background = shape;
    }
}
#endif
