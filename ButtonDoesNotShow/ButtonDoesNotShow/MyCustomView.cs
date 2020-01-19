using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace ButtonDoesNotShow
{
    public class MyCustomView : SKGLView
    {
        public MyCustomView()
        {
            PaintSurface += MyCustomView_PaintSurface;
        }

        private void MyCustomView_PaintSurface(object sender, SKPaintGLSurfaceEventArgs e)
        {
            e.Surface.Canvas.Clear(new SKColor(255, 128, 128));
        }
    }
}