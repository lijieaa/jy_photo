using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;    //添加相应的引用即可

namespace jy_photo
{
    class Program
    {

        /*public static void whiteFace(Mat matSelfPhoto, int alpha, int beta)
        {
            for (int y = 0; y < matSelfPhoto.Rows; y++)
            {
                for (int x = 0; x < matSelfPhoto.Cols; x++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        matSelfPhoto.At<Vec3b>(y, x)[c] = saturate_cast<uchar>(alpha * (matSelfPhoto.at<Vec3b>(y, x)[c]) + beta);
                    }
                }
            }
        }*/

        static void Main(string[] args)
        {
            //Mat matResult;
            // Mat src = imread("C:\\Users\\Administrator\\Desktop\\brightness\\test.jpg");
            //int bilateralFilterVal = 30;  // 双边模糊系数	
            //imshow("0000", src);
            //whiteFace(src, 1.1, 68);  // 调整对比度与亮度，参数2为对比度，参数3为亮度	
            //imshow("1111", src);
            //GaussianBlur(src, src, Size(9, 9), 0, 0); // 高斯模糊，消除椒盐噪声	
            //imshow("2222", src);
            //bilateralFilter(src, matResult, bilateralFilterVal, bilateralFilterVal * 2, bilateralFilterVal / 2); // 整体磨皮		

            //imshow("3333", matResult);
            //Mat matFinal;   // 图像增强，使用非锐化掩蔽（Unsharpening Mask）方案。	
           // cv::GaussianBlur(matResult, matFinal, cv::Size(0, 0), 9);
            //cv::addWeighted(matResult, 1.5, matFinal, -0.5, 0, matFinal);
            //imshow("4444", matFinal);
            //imwrite("E:\\test\\result.png", matFinal);


            Mat matResult=new Mat();
            Mat src = new Mat(@"E:\jy_photo\jy_photo\jy_photo\bin\Debug\微信图片_20190116163619.jpg");
            int bilateralFilterVal = 30;  // 双边模糊系数
            //Cv2.ImShow("0000", src);
            Cv2.GaussianBlur(src, src, new Size(9, 9), 0, 0); // 高斯模糊，消除椒盐噪声	
            Cv2.ImShow("1111", src);
            Cv2.ResizeWindow("1111", 640,480);
            Cv2.BilateralFilter(src, matResult, bilateralFilterVal, // 整体磨皮		
                bilateralFilterVal * 2, bilateralFilterVal / 2);
            //Cv2.ImShow("2222", matResult);
            Mat matFinal=new Mat();   // 图像增强，使用非锐化掩蔽（Unsharpening Mask）方案。
            Cv2.GaussianBlur(matResult, matFinal, new Size(0, 0), 9);
            Cv2.AddWeighted(matResult, 1.5, matFinal, -0.5, 0, matFinal);
            Cv2.ImShow("3333", matFinal);
            Cv2.ResizeWindow("3333", 640, 480);
            Cv2.WaitKey(0);
        }
    }
}
