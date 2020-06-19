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
            int j = 0;

            foreach(FileInfo file in info)
            {
                string fileName = file.FullName;
                string name = file.Name.Replace(".txt", "");
                
                string[] lines = File.ReadAllLines(fileName);
                english[j] = lines[0];
                russian[j] = lines[1];
                audioEng[j] = "data\\english\\" + name + ".mp3";
                audioRus[j] = "data\\russian\\" + name + ".mp3";
                if (!File.Exists(audioEng[j])) audioEng[j] = "";
                if (!File.Exists(audioRus[j])) audioRus[j] = "";

                image[j] = "data\\images\\" + name + ".jpg";
                video[j] = "data\\video\\" + name + ".mp4";
                if (!File.Exists(image[j])) image[j] = "";
                if (!File.Exists(video[j])) video[j] = "";
                j++;
            }
        }

        internal int Total()
        {
            return total;
        }

        public string English(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return english[nr];
        }
        public string Russian(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return russian[nr];
        }
        public string AudioEng(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return audioEng[nr];
        }
        public string AudioRus(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return audioRus[nr];
        }
        public string Image(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return image[nr];
        }
        public string Video(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return video[nr];
        }
    }
}
