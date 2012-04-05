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
    /// ѹ��,��ѹ��
    /// </summary>
    public class Compression
    {
        //#region Compression DataSet

        ///// <summary>
        ///// ѹ�����ݼ�
        ///// </summary>
        ///// <param name="dsOriginal">Դ���ݼ�</param>
        ///// <returns>�ֽ�����</returns>
        //public static byte[] CompressionDataSet(DataSet dsOriginal)
        //{
        //    // ���л�Ϊ������
        //    BinaryFormatter bFormatter = new BinaryFormatter();
        //    MemoryStream mStream = new MemoryStream(1024);

        //    bFormatter.Serialize(mStream, dsOriginal);
        //    byte[] bytes = mStream.ToArray();

        //    // ѹ��            
        //    MemoryStream oStream = new MemoryStream(1024);
        //    GZipOutputStream gzipStream = new GZipOutputStream(oStream);
        //    gzipStream.Write(bytes, 0, bytes.Length);
        //    gzipStream.Flush();
        //    gzipStream.Close();
        //    return oStream.ToArray();
        //}

        ///// <summary>
        ///// ��ѹ���ݼ�
        ///// </summary>
        ///// <param name="bytes">�ֽ�����</param>
        ///// <returns>���ݼ�</returns>
        //public static DataSet DecompressionDataSet(byte[] bytes)
        //{
        //    MemoryStream mStream = new MemoryStream(1024);
        //    mStream.Write(bytes, 0, bytes.Length);

        //    mStream.Seek(0, SeekOrigin.Begin);

        //    // ��ѹ��
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
        /// ѹ���ļ�
        /// </summary>
        /// <param name="sourceFilePath">Դ�ļ���������</param>
        /// <returns>�ֽ�����</returns>
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
        /// ��ѹ�����ļ��ֽ������н�ѹ���ļ�����ǰĿ¼,
        /// </summary>
        /// <param name="bytes">Դ�ļ��ֽ�����</param>
        public static void DecompressionFile(byte[] bytes)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            DecompressionFile(path, bytes);
        }
        /// <summary>
        /// ��ѹ�����ļ��ֽ������л�ԭ���ļ�
        /// </summary>
        /// <param name="path">ָ����·��</param>
        /// <param name="bytes">Դ�ļ��ֽ�����</param>
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
        /// ѹ������ļ���һ���ļ�
        /// </summary>
        /// <param name="destictionFilePath">Ŀ���ļ�</param>
        /// <param name="sourceFilePaths">Դ�ļ�</param>
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
        /// ��ѹ�ļ�
        /// </summary>
        /// <param name="path">�ļ���ŵ�·��</param>
        /// <param name="unzipFilePath">Դѹ���ļ�</param>
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
        /// ѹ������
        /// </summary>
        /// <param name="o">�����л��Ķ���</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] CompressionObject(object o)
        {
            // ���л�Ϊ������
            BinaryFormatter bFormatter = new BinaryFormatter();
            MemoryStream mStream = new MemoryStream(1024);

            bFormatter.Serialize(mStream, o);
            byte[] bytes = mStream.ToArray();

            // ѹ��            
            MemoryStream oStream = new MemoryStream(1024);
            GZipOutputStream gzipStream = new GZipOutputStream(oStream);
            gzipStream.Write(bytes, 0, bytes.Length);
            gzipStream.Flush();
            gzipStream.Close();
            return oStream.ToArray();
        }
        /// <summary>
        /// ��ѹ����
        /// </summary>
        /// <param name="bytes">�ֽ�����</param>
        /// <returns>����</returns>
        public static object DecompressionObject(byte[] bytes)
        {
            MemoryStream mStream = new MemoryStream(1024);
            mStream.Write(bytes, 0, bytes.Length);

            mStream.Seek(0, SeekOrigin.Begin);

            // ��ѹ��
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
        /// ��GZip����ѹ��DataSetΪ�ֽ��������WebServiceԶ�̴������
        /// </summary>
        /// <param name="target">Ҫѹ�����ֽ������DataSet</param>
        /// <returns>�ֽ�����</returns>
        public static byte[] CompressionDataSet(DataSet dsTarget)
        {
            return Compression.CompressionDataSet(dsTarget, CompressionArithmetic.GZip); 
        }

        /// <summary>
        /// ѡ��һ�ֱ���ѹ������ѹ��DataSetΪ�ֽ��������WebServiceԶ�̴������
        /// </summary>
        /// <param name="dsTarget">Ҫѹ�����ֽ������DataSet</param>
        /// <param name="arithmetic">ѹ���㷨</param>
        /// <returns>�ֽ�����</returns>
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
        /// ��GZip���뽫�ֽ������ѹ��ΪDataSet���ͻ���ʹ��
        /// </summary>
        /// <param name="byteTarget">Ҫ��ѹ�����ֽ�����</param>
        /// <returns>DataSet</returns>
        public static DataSet DecompressionDataSet(byte[] byteTarget)
        {
            return Compression.DecompressionDataSet(byteTarget, CompressionArithmetic.GZip); 
        }


        /// <summary>
        /// ѡ��һ�ֽ�ѹ�����뽫�ֽ������ѹ��ΪDataSet���ͻ���ʹ��
        /// </summary>
        /// <param name="byteTarget">Ҫ��ѹ�����ֽ�����</param>
        /// <param name="arithmetic">ѹ���㷨</param>
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
