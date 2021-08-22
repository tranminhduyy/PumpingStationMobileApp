using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinClient
{
    public class CustomEntry : Entry
    {
    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor),
                                                                                          typeof(Color),
                                                                                          typeof(CustomEntry),
                                                                                          Color.Black);
    
    //Gets or sets BorderColor value
    public Color BorderColor
    {
        get { return (Color)GetValue(BorderColorProperty); }
        set { SetValue(BorderColorProperty, value); }
    }

    public static readonly BindableProperty BorderWidthProperty = BindableProperty.Create(nameof(BorderWidth),
                                                                                          typeof(int),
                                                                                          typeof(CustomEntry),
                                                                                          Device.OnPlatform<int>(1, 2, 2));

    //Gets or Sets BorderWidth value
    public int BorderWidth
    {
        get { return (int)GetValue(BorderWidthProperty); }
        set { SetValue(BorderWidthProperty, value); }
    }

    public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius),
                                                                                          typeof(double),
                                                                                          typeof(CustomEntry),
                                                                                          Device.OnPlatform<double>(6, 7, 7));

    //Gets or Sets CornerRadius value
    public double CornerRadius
    {
        get { return (double)GetValue(CornerRadiusProperty); }
        set { SetValue(CornerRadiusProperty, value); }
    }

    public static readonly BindableProperty IsCurvedCornersEnabedProperty = BindableProperty.Create(nameof(IsCurvedCornersEnabed),
                                                                                          typeof(bool),
                                                                                          typeof(CustomEntry),
                                                                                          true);

    //Gets or Sets IsCurvedCornersEnabled value
    public bool IsCurvedCornersEnabed
    {
        get { return (bool)GetValue(IsCurvedCornersEnabedProperty); }
        set { SetValue(IsCurvedCornersEnabedProperty, value); }
    }

}
}
