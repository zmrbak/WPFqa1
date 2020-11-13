using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1
{
    public class CbConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return false;
            if (parameter == null) return false;

            //将value拆解成位的组合，判断第parameter位是否为1
            if (int.TryParse(value.ToString(), out int selectCBox) && int.TryParse(parameter.ToString(), out int index))
            {
                if ((selectCBox & (1 << index)) != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return false;
            if (parameter == null) return false;

            //解析参数
            if (bool.TryParse(value.ToString(), out bool selectCBox) && int.TryParse(parameter.ToString(), out int index))
            {
                if (selectCBox)
                {
                    SelectCBox = SelectCBox | (1 << index);
                }
                else
                {
                    SelectCBox = SelectCBox & ~(1 << index);
                }
            }
            return SelectCBox;
        }

        //添加一个额外的参数保存选中结果
        public static int SelectCBox;
    }
}
