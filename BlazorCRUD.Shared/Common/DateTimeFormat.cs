using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Shared.Common
{
    public enum Dash
    {
        jum,
        Hyphen
    }

    public static class DateTimeFormat
    {
        public static string GetyyyyMMdd(DateTime dateTime, Dash dash)
        {
            string dashChar = (dash == Dash.jum ? "." : "-");
            return dateTime.ToString($"yyyy{dashChar}MM{dashChar}dd");
        }
    }
}
