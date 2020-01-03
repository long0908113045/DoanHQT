using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1
{
    class Globals
    {
        public static string GlobalUserId { get; private set; }
        public static void SetGlobalUserId(string userId)
        {
            GlobalUserId = userId;
        }
        public static string GlobalPass { get; private set; }
        public static void SetGlobalPass(string pass)
        {
            GlobalPass = pass;
        }


        public static string GlobalMaNV { get; private set; }
        public static void SetGlobalMaNV(string manv)
        {
            GlobalMaNV = manv;
        }
    }
}
