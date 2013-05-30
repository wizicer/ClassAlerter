using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ClassAlerter
{
    /// <summary>
    /// Summary description for TextOutline
    /// </summary>
    public class TextOutline
    {
        private Color _textColor;

        public Color TextColor
        {
            get { return _textColor; }
            set { _textColor = value; }
        }

        public TextOutline()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// 画文字阴影
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="text">文字串</param>
        /// <param name="font">字体</param>
        /// <param name="layoutRect">文字串的布局矩形</param>
        /// <param name="format">文字串输出格式</param>
        public void Draw(Graphics g, string text, Font font, RectangleF layoutRect, StringFormat format)
        {
            Rectangle sr = new Rectangle(0,0, layoutRect.Width, layoutRect.Height);
            // 根据文字布局矩形长宽扩大文字阴影半径4倍建立一个32位ARGB格式的位图
            Bitmap bmp = new Bitmap(sr.Width, sr.Height , PixelFormat.Format32bppArgb);
            // 按文字阴影不透明度建立阴影画刷
            Brush brush = new SolidBrush(Color.FromArgb(alpha, Color.Black));
            Graphics bg = Graphics.FromImage(bmp);
            try
            {
                // 在位图上画文字阴影
                bg.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                bg.DrawString(text, font, brush, sr, format);
                // 制造阴影模糊
                MaskShadow(bmp);
                // 按文字阴影角度、半径和距离输出文字阴影到给定的画布
                RectangleF dr = layoutRect;
                dr.Offset((float)(Math.Cos(Math.PI * angle / 180.0) * distance),
                          (float)(Math.Sin(Math.PI * angle / 180.0) * distance));
                sr.Inflate((float)radius, (float)radius);
                dr.Inflate((float)radius, (float)radius);
                g.DrawImage(bmp, dr, sr, GraphicsUnit.Pixel);
            }
            finally
            {
                bg.Dispose();
                brush.Dispose();
                bmp.Dispose();
            }
        }

        /// <summary>
        /// 画文字阴影
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="text">文字串</param>
        /// <param name="font">字体</param>
        /// <param name="layoutRect">文字串的布局矩形</param>
        public void Draw(Graphics g, string text, Font font, RectangleF layoutRect)
        {
            Draw(g, text, font, layoutRect, null);
        }

        /// <summary>
        /// 画文字阴影
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="text">文字串</param>
        /// <param name="font">字体</param>
        /// <param name="origin">文字串的输出原点</param>
        /// <param name="format">文字串输出格式</param>
        public void Draw(Graphics g, string text, Font font, PointF origin, StringFormat format)
        {
            RectangleF rect = new RectangleF(origin, g.MeasureString(text, font, origin, format));
            Draw(g, text, font, rect, format);
        }

        /// <summary>
        /// 画文字阴影
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="text">文字串</param>
        /// <param name="font">字体</param>
        /// <param name="origin">文字串的输出原点</param>
        public void Draw(Graphics g, string text, Font font, PointF origin)
        {
            Draw(g, text, font, origin, null);
        }
    }
}
