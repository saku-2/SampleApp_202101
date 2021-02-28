using System.IO;
using System.Threading.Tasks;

namespace SampleApp_202101.Services.Impl
{
    public class FileCopyService
    {
        /// <summary>
        /// ファイルコピー
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="destPath"></param>
        public async Task FileCopyAsync(string srcPath, string destPath)
        {
            var chunk = new byte[0x1000];
            using (var readStream = ReadStream(srcPath))
            using (var writeStream = WriteStream(destPath))
            {
                while (true)
                {
                    var readBytes = await readStream.ReadAsync(chunk, 0, chunk.Length);
                    if (readBytes <= 0)
                    {
                        break;
                    }
                    writeStream.Write(chunk, 0, readBytes);
                }
            }
        }

        /// <summary>
        /// 読み取り用ストリームを取得
        /// </summary>
        /// <param name="srcPath">読み取り用ファイルパス</param>
        /// <returns>読み取り用ストリーム</returns>
        private Stream ReadStream(string srcPath)
        {
            return new FileStream(
                srcPath,
                FileMode.Open,
                FileAccess.Read
            );
        }

        /// <summary>
        /// 書き込み用ストリームを取得
        /// </summary>
        /// <param name="destPath">書き込み用ファイルパス</param>
        /// <returns>書き込み用ストリーム</returns>
        private Stream WriteStream(string destPath)
        {
            return new FileStream(
                destPath,
                FileMode.Append,
                FileAccess.Write,
                FileShare.ReadWrite
            );
        }
    }
}