using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleEnglish
{
    class Dictionary
    {

        int total = 0;
        string[] english;
        string[] russian;
        string[] audioRus;
        string[] audioEng;
        string[] image;
        string[] video;

        public Dictionary()
        {
            Init();
        }

        private void Init()
        {
            total = 0;
            DirectoryInfo directoryInfo = new DirectoryInfo("data\\text\\");
            FileInfo[] info = directoryInfo.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
            total = info.Length;

            english = new string[total];
            russian = new string[total];
            audioRus = new string[total];
            audioEng = new string[total];
            image = new string[total];
            video = new string[total];

            foreach(FileInfo file in info)
            {
                string fileName = file.FullName;
                string name = file.Name.Replace(".txt", "");
            }

        }
    }
}
