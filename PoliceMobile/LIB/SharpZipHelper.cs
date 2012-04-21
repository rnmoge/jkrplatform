using System;

using System.Linq;

using System.Collections.Generic;

using System.Text;



using ICSharpCode.SharpZipLib.Zip;//ZipOutputStream

using System.IO;//FileMode



public class SharpZipHelper
{

    /// <summary>   

    /// 压缩指定文件生成ZIP文件   

    /// </summary>   

    /// <param name="topDirName">顶层文件夹名称</param>   

    /// <param name="fileNamesToZip">待压缩文件列表</param>   

    /// <param name="ZipedFileName">ZIP文件</param>   

    /// <param name="CompressionLevel">压缩比</param>   

    /// <param name="password">密码</param>   

    /// <param name="comment">压缩文件注释文字</param>   

    public static void ZipFile

        (

        string topDirName,  //顶层文件夹名称 \Storage Card\PDADataExchange\send\xml\

        string[] fileNamesToZip,  //待压缩文件列表  version.xml

        string ZipedFileName,   //ZIP文件  \Storage Card\PDADataExchange\send\zip\version.zip

        int CompressionLevel,    //压缩比  7

        string password,    //密码   ""

        string comment   //压缩文件注释文字  ""

        )
    {

        ZipOutputStream s = new ZipOutputStream(System.IO.File.Open(ZipedFileName, FileMode.Create));



        if (password != null && password.Length > 0)

            s.Password = password;



        if (comment != null && comment.Length > 0)

            s.SetComment(comment);



        s.SetLevel(CompressionLevel); // 0 - means store only to 9 - means best compression   



        foreach (string file in fileNamesToZip)
        {

            FileStream fs = File.OpenRead(topDirName + file);    //打开待压缩文件   

            byte[] buffer = new byte[fs.Length];

            fs.Read(buffer, 0, buffer.Length);      //读取文件流   

            ZipEntry entry = new ZipEntry(file);    //新建实例   



            entry.DateTime = DateTime.Now;



            entry.Size = fs.Length;

            fs.Close();



            s.PutNextEntry(entry);

            s.Write(buffer, 0, buffer.Length);

        }

        s.Finish();

        s.Close();

    }



    /// <summary>   

    /// 解压缩ZIP文件到指定文件夹   

    /// </summary>   

    /// <param name="zipfileName">ZIP文件</param>   

    /// <param name="UnZipDir">解压文件夹</param>   

    /// <param name="password">压缩文件密码</param>   

    public static void UnZipFile(string zipfileName, string UnZipDir, string password)
    {



        //zipfileName=@"\Storage Card\PDADataExchange\receive\zip\test.zip";

        //UnZipDir= @"\Storage Card\PDADataExchange\receive\xml\";

        //password="";



        ZipInputStream s = new ZipInputStream(File.OpenRead(zipfileName));

        if (password != null && password.Length > 0)

            s.Password = password;

        try
        {

            ZipEntry theEntry;

            while ((theEntry = s.GetNextEntry()) != null)
            {

                string directoryName = Path.GetDirectoryName(UnZipDir);

                string pathname = Path.GetDirectoryName(theEntry.Name);

                string fileName = Path.GetFileName(theEntry.Name);



                //生成解压目录    

                pathname = pathname.Replace(":", "$");//处理压缩时带有盘符的问题   

                directoryName = directoryName + "\\" + pathname;

                Directory.CreateDirectory(directoryName);



                if (fileName != String.Empty)
                {

                    //解压文件到指定的目录   

                    FileStream streamWriter = File.Create(directoryName + "\\" + fileName);



                    int size = 2048;

                    byte[] data = new byte[2048];

                    while (true)
                    {

                        size = s.Read(data, 0, data.Length);

                        if (size > 0)
                        {

                            streamWriter.Write(data, 0, size);

                        }

                        else
                        {

                            break;

                        }

                    }

                    streamWriter.Close();

                }

            }

            s.Close();

        }

        catch (Exception eu)
        {

            throw eu;

        }

        finally
        {

            s.Close();

        }



    }

}



