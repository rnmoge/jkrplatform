using System;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;

namespace JKR.Common.Zipper
{

    /// <summary>
    /// 压缩,解压缩
    /// </summary>
    public class Compression
    {
        //#region Compression DataSet

        ///// <summary>
        ///// 压缩数据集
        ///// </summary>
        ///// <param name="dsOriginal">源数据集</param>
        ///// <returns>字节数组</returns>
        //public static byte[] CompressionDataSet(DataSet dsOriginal)
        //{
        //    // 序列化为二进制
        //    BinaryFormatter bFormatter = new BinaryFormatter();
        //    MemoryStream mStream = new MemoryStream(1024);

        //    bFormatter.Serialize(mStream, dsOriginal);
        //    byte[] bytes = mStream.ToArray();

        //    // 压缩            
        //    MemoryStream oStream = new MemoryStream(1024);
        //    GZipOutputStream gzipStream = new GZipOutputStream(oStream);
        //    gzipStream.Write(bytes, 0, bytes.Length);
        //    gzipStream.Flush();
        //    gzipStream.Close();
        //    return oStream.ToArray();
        //}

        ///// <summary>
        ///// 解压数据集
        ///// </summary>
        ///// <param name="bytes">字节数组</param>
        ///// <returns>数据集</returns>
        //public static DataSet DecompressionDataSet(byte[] bytes)
        //{
        //    MemoryStream mStream = new MemoryStream(1024);
        //    mStream.Write(bytes, 0, bytes.Length);

        //    mStream.Seek(0, SeekOrigin.Begin);

        //    // 解压缩
        //    GZipInputStream gzipStream = new GZipInputStream(mStream);
        //    gzipStream.Flush();
        //    DataSet dsResult = null;

        //    MemoryStream ms = new MemoryStream(1024);
        //    int nSize = 2048;
        //    byte[] writeData = new byte[2048];

        //    while (true)
        //    {
        //        nSize = gzipStream.Read(writeData, 0, nSize);
        //        if (nSize > 0)
        //        {
        //            ms.Write(writeData, 0, nSize);
        //        }
        //        else
        //            break;
        //    }

        //    ms.Seek(0, SeekOrigin.Begin);

        //    BinaryFormatter bFormatter = new BinaryFormatter();
        //    dsResult = (DataSet)bFormatter.Deserialize(ms);
        //    return dsResult;
        //}
        //#endregion



        #region Compression File
        private const int compressionLeval = 6; // 0 - store only to 9 - means best compression

        #region Compression byte
        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="sourceFilePath">源文件参数数组</param>
        /// <returns>字节数组</returns>
        public static byte[] CompressionFile(params string[] sourceFilePath)
        {
            MemoryStream ms = new MemoryStream(1024);
            ZipOutputStream s = new ZipOutputStream(ms);

            s.SetLevel(compressionLeval);

            foreach (string filePath in sourceFilePath)
            {
                try
                {
                    FileStream fs = File.OpenRead(filePath);
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);

                    ZipEntry entry = new ZipEntry(filePath);
                    entry.DateTime = DateTime.Now;
                    entry.Size = fs.Length;
                    fs.Close();

                    Crc32 crc = new Crc32();
                    crc.Reset();
                    crc.Update(buffer);

                    entry.Crc = crc.Value;

                    s.PutNextEntry(entry);

                    s.Write(buffer, 0, buffer.Length);
                }
                catch (System.IO.FileNotFoundException noFoundEx)
                {
                    throw noFoundEx;
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
            s.Finish();

            ms.Seek(0, SeekOrigin.Begin);
            return ms.ToArray();
        }

        public static byte[] CompressionFile(bool isAbsolute, string relativityPath, params string[] sourceFilePath)
        {
            MemoryStream ms = new MemoryStream(1024);
            ZipOutputStream s = new ZipOutputStream(ms);

            s.SetLevel(compressionLeval);

            foreach (string filePath in sourceFilePath)
            {
                try
                {
                    FileStream fs = File.OpenRead(filePath);
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);

                    string entryName = string.Empty;
                    if (isAbsolute)
                    {
                        string path = relativityPath.EndsWith(@"\") ? relativityPath : relativityPath + @"\";
                        entryName = filePath.Replace(path, "");
                    }
                    else
                        entryName = filePath;

                    ZipEntry entry = new ZipEntry(entryName);
                    entry.DateTime = DateTime.Now;
                    entry.Size = fs.Length;
                    fs.Close();

                    Crc32 crc = new Crc32();
                    crc.Reset();
                    crc.Update(buffer);

                    entry.Crc = crc.Value;

                    s.PutNextEntry(entry);

                    s.Write(buffer, 0, buffer.Length);
                }
                catch (System.IO.FileNotFoundException noFoundEx)
                {
                    throw noFoundEx;
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
            s.Finish();

            ms.Seek(0, SeekOrigin.Begin);
            return ms.ToArray();
        }
        /// <summary>
        /// 从压缩的文件字节数组中解压成文件到当前目录,
        /// </summary>
        /// <param name="bytes">源文件字节数组</param>
        public static void DecompressionFile(byte[] bytes)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            DecompressionFile(path, bytes);
        }
        /// <summary>
        /// 从压缩的文件字节数组中还原成文件
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="bytes">源文件字节数组</param>
        public static void DecompressionFile(string path, byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);

            ZipInputStream s = new ZipInputStream(ms);
            ZipEntry theEntry;

            while ((theEntry = s.GetNextEntry()) != null)
            {
                string directoryName = Path.GetDirectoryName(theEntry.Name);
                string fileName = Path.GetFileName(theEntry.Name);

                // create directory
                Directory.CreateDirectory(Path.Combine(path, directoryName));

                if (fileName != String.Empty)
                {
                    FileStream streamWriter = File.Create(Path.Combine(path, theEntry.Name));

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
        #endregion

        #region Compression Dir
        /// <summary>
        /// 压缩多个文件到一个文件
        /// </summary>
        /// <param name="destictionFilePath">目标文件</param>
        /// <param name="sourceFilePaths">源文件</param>
        public static void CompressionDir(string destictionFile, params string[] sourceFiles)
        {
            Crc32 crc = new Crc32();
            ZipOutputStream s = new ZipOutputStream(File.Create(destictionFile));

            s.SetLevel(compressionLeval);

            foreach (string sourceFile in sourceFiles)
            {
                FileStream fs = File.OpenRead(sourceFile);

                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                ZipEntry entry = new ZipEntry(sourceFile);

                entry.DateTime = DateTime.Now;


                entry.Size = fs.Length;
                fs.Close();

                crc.Reset();
                crc.Update(buffer);

                entry.Crc = crc.Value;

                s.PutNextEntry(entry);

                s.Write(buffer, 0, buffer.Length);
            }

            s.Finish();
            s.Close();
        }
        /// <summary>
        /// 解压文件
        /// </summary>
        /// <param name="path">文件存放的路径</param>
        /// <param name="unzipFilePath">源压缩文件</param>
        public static void DecompressionDir(string path, string unzipFile)
        {
            ZipInputStream s = new ZipInputStream(File.OpenRead(unzipFile));

            ZipEntry theEntry;
            while ((theEntry = s.GetNextEntry()) != null)
            {

                string directoryName = Path.GetDirectoryName(theEntry.Name);
                string fileName = Path.GetFileName(theEntry.Name);

                // create directory
                Directory.CreateDirectory(Path.Combine(path, directoryName));

                if (fileName != String.Empty)
                {
                    FileStream streamWriter = File.Create(Path.Combine(path, theEntry.Name));

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

        #endregion
        #endregion

        #region Compression Object

        /// <summary>
        /// 压缩对象
        /// </summary>
        /// <param name="o">可序列化的对象</param>
        /// <returns>字节数组</returns>
        public static byte[] CompressionObject(object o)
        {
            // 序列化为二进制
            BinaryFormatter bFormatter = new BinaryFormatter();
            MemoryStream mStream = new MemoryStream(1024);

            bFormatter.Serialize(mStream, o);
            byte[] bytes = mStream.ToArray();

            // 压缩            
            MemoryStream oStream = new MemoryStream(1024);
            GZipOutputStream gzipStream = new GZipOutputStream(oStream);
            gzipStream.Write(bytes, 0, bytes.Length);
            gzipStream.Flush();
            gzipStream.Close();
            return oStream.ToArray();
        }
        /// <summary>
        /// 解压对象
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>对象</returns>
        public static object DecompressionObject(byte[] bytes)
        {
            MemoryStream mStream = new MemoryStream(1024);
            mStream.Write(bytes, 0, bytes.Length);

            mStream.Seek(0, SeekOrigin.Begin);

            // 解压缩
            GZipInputStream gzipStream = new GZipInputStream(mStream);
            gzipStream.Flush();

            MemoryStream ms = new MemoryStream(1024);
            int nSize = 2048;
            byte[] writeData = new byte[2048];

            while (true)
            {
                nSize = gzipStream.Read(writeData, 0, nSize);
                if (nSize > 0)
                {
                    ms.Write(writeData, 0, nSize);
                }
                else
                    break;
            }

            ms.Seek(0, SeekOrigin.Begin);

            BinaryFormatter bFormatter = new BinaryFormatter();
            object o = bFormatter.Deserialize(ms);
            return o;
        }
        #endregion


        #region Compression DataSet By DotNet 2.0 FrameWork

        public enum CompressionArithmetic
        {
            GZip = 0,
            Deflate = 1
        }

        /// <summary>
        /// 用GZip编码压缩DataSet为字节数组便于WebService远程传输对象
        /// </summary>
        /// <param name="target">要压缩成字节数组的DataSet</param>
        /// <returns>字节数组</returns>
        public static byte[] CompressionDataSet(DataSet dsTarget)
        {
            return Compression.CompressionDataSet(dsTarget, CompressionArithmetic.GZip); 
        }

        /// <summary>
        /// 选择一种编码压缩方法压缩DataSet为字节数组便于WebService远程传输对象
        /// </summary>
        /// <param name="dsTarget">要压缩成字节数组的DataSet</param>
        /// <param name="arithmetic">压缩算法</param>
        /// <returns>字节数组</returns>
        public static byte[] CompressionDataSet(DataSet dsTarget, CompressionArithmetic arithmetic)
        {

            MemoryStream inStream = null;
            MemoryStream outStream = null;
            global::System.IO.Stream compressionStream = null;

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                inStream = new MemoryStream(1024);
                outStream = new MemoryStream(1024);
                formatter.Serialize(inStream, dsTarget);

                if (arithmetic == CompressionArithmetic.GZip)
                {
                    compressionStream = new GZipStream(outStream, CompressionMode.Compress);
                }
                else
                {
                    compressionStream = new DeflateStream(outStream, CompressionMode.Compress);
                }
            
                byte[] bytes = inStream.ToArray();
                compressionStream.Write(bytes, 0, bytes.Length);
                compressionStream.Flush();
                compressionStream.Close();
                return outStream.ToArray();

            }
            catch (Exception)
            {
                return null;

            }
            finally
            {

                if (inStream != null) inStream.Close();
                if (outStream != null) outStream.Close();
            }


        }

        /// <summary>
        /// 用GZip编码将字节数组解压缩为DataSet给客户端使用
        /// </summary>
        /// <param name="byteTarget">要解压缩的字节数组</param>
        /// <returns>DataSet</returns>
        public static DataSet DecompressionDataSet(byte[] byteTarget)
        {
            return Compression.DecompressionDataSet(byteTarget, CompressionArithmetic.GZip); 
        }


        /// <summary>
        /// 选择一种解压缩编码将字节数组解压缩为DataSet给客户端使用
        /// </summary>
        /// <param name="byteTarget">要解压缩的字节数组</param>
        /// <param name="arithmetic">压缩算法</param>
        /// <returns>DataSet</returns>
        public static DataSet DecompressionDataSet(byte[] byteTarget, CompressionArithmetic arithmetic)
        {

            MemoryStream inStream = null;
            MemoryStream outStream = null;
            global::System.IO.Stream decompressionStream = null;

            try
            {
                inStream = new MemoryStream();
                inStream.Write(byteTarget, 0, byteTarget.Length);
                inStream.Seek(0, SeekOrigin.Begin);

                if (arithmetic == CompressionArithmetic.GZip)
                {
                    decompressionStream = new GZipStream(inStream, CompressionMode.Decompress, true);
                }
                else
                {
                    decompressionStream = new DeflateStream(inStream, CompressionMode.Decompress, true);
                }

                decompressionStream.Flush();
                outStream = new MemoryStream(1024);
                int nSize = 2048;
                byte[] writeData = new byte[nSize];
                int readData = decompressionStream.Read(writeData, 0, nSize);

                while (readData > 0)
                {
                    outStream.Write(writeData, 0, readData);
                    readData = decompressionStream.Read(writeData, 0, nSize);
                }

                outStream.Flush();
                outStream.Seek(0, SeekOrigin.Begin);

                BinaryFormatter formatter = new BinaryFormatter();
                DataSet dsTarget = formatter.Deserialize(outStream) as DataSet;

                return dsTarget;

            }
            catch (Exception)
            {
                return null;
            }

            finally
            {

                if (inStream != null) inStream.Close();
                if (outStream != null) outStream.Close();
           
            }
        
        
        }

        #endregion


    }
}
