using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var src = new Mat(@"Images/1.jpg");
            var dst = new Mat();

            Cv2.CvtColor(src, dst, ColorConversionCodes.BGRA2GRAY);

            using (new Window("dst image", dst))
            {
                Cv2.WaitKey();
            }
        }
    }
}
