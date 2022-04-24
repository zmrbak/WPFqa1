using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ImageButton
{
    public class ExImage
    {
        public static ImageSource GetImageFile(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(ImageFileProperty);
        }

        public static void SetImageFile(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(ImageFileProperty, value);
        }

        // Using a DependencyProperty as the backing store for ImageFile.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageFileProperty =
            DependencyProperty.RegisterAttached("ImageFile", typeof(ImageSource), typeof(ExImage), new PropertyMetadata());
    }
}
