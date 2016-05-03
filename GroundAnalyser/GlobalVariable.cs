using GroundAnalyser;
using System;
using System.Data;
using System.IO;
using System.Threading;

//全局变量
namespace GroundAnalyser
{
    public class GlobalVariable
    {
        public GlobalVariable()
        {
        }

        public struct OperaFile
        {
            public FileStream file;
            public String filePath;         //文件路径
            public String fileOnlyName;     //文件名+后缀
            public String fileAllName;      //文件路径+文件名+后缀
            public Byte[] fileBuf;          //文件缓存
            public long fileLength;         //文件总字节数
        }

        public struct ReportList
        {
            public UInt16[] minFrmID;
            public UInt16[] maxFrmID;
        }
        /*-------------------------------------------------窗体--------------------------------------------------------*/
        public static Form_MainCtrl global_FrmMain;                                     //控制器窗体的全局变量
        public static Form_Report global_FrmReport = new Form_Report();                 //状态报表窗体的全局变量
        public static Form_ImgOrigShow global_FrmImgOrigShow = new Form_ImgOrigShow();  //显示原始图像窗体的全局变量

        /*-----------------------------------------------图像常量------------------------------------------------------*/
        public const UInt16 IMG_FULL_WID = 2048;
        public const UInt16 IMG_FULL_HEI = 160;

        /*-----------------------------------------------文件常量------------------------------------------------------*/
        public const UInt16 LEN_ORIG = 1024;                            //原始文件每包包长1024B
        public const UInt16 LEN_COMP = 280;                             //压缩文件每包包长280B

        /*---------------------------------------------原始图像显示----------------------------------------------------*/
        public static String pathImgPathShow = "";
        public static Byte moveLeftHigh = 0;					        //高位向左移的位数
        public static Byte moveRightLow = 0;					        //低位向右移的位数

        /*-----------------------------------------------图像解压------------------------------------------------------*/
        public static OperaFile fileOrig = new OperaFile();             //原始文件，即从星务接收的第一手文件
        public static OperaFile fileComp = new OperaFile();             //压缩文件，即从原始文件解包后的压缩文件
        public static OperaFile[] fileCompSplit = new OperaFile[4];     //各通道压缩文件，即从压缩文件分包后的各通道压缩文件
        public static OperaFile fileDecomp = new OperaFile();           //解压后文件，即从压缩文件解压后的文件

        public static long curOrigPosiCnt = 0;                          //原始文件读到的位置
        public static long curCompPosiCnt = 0;                          //原始文件读到的位置

        public static Thread threadOrigResolve;                         //从原始文件解包成压缩文件的线程
        public static Thread threadCompSplit;                           //从压缩文件分包成帧文件的线程

        /*-------------------------------------------------数据库------------------------------------------------------*/
        public static DataSet dataReport = new DataSet("数据报表库");               //数据报表库
        public static DataTable dataErrSum = dataReport.Tables.Add("错误汇总");     //错误汇总表
        public static DataTable dataErrDetail = dataReport.Tables.Add("错误细则");  //错误细则表

        public static long cntErrHead = 0;  //帧头错误数
        public static long cntErrTail = 0;  //帧尾错误数
        public static long cntErrSum = 0;   //校验和错误数
        /*-------------------------------------------------数据库------------------------------------------------------*/
    }
}
