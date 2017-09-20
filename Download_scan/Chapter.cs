using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_scan
{
    class Chapter
    {
        /// <summary>
        /// variable
        /// </summary>
        private string _uri;
        private string _path;
        private string[] _subpath;
        Download dl;
        Folder fl;

        /// <summary>
        /// constructor
        /// </summary>
        public Chapter()
        {
            dl = new Download();
            fl = new Folder();
        }

        /// <summary>
        /// instance variable
        /// </summary>
        public string Uri { get => _uri; set => _uri = value; }
        public string Path { get => _path; set => _path = value; }
        public string[] Subpath { get => _subpath; set => _subpath = value; }


        /// <summary>
        /// methode
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileName"></param>
        public void DownloadChapter(string url, string path, ListBox lst)
        {
            string page = GetThePageNumber(url);
            if (Convert.ToInt16(page) > 1)
            {
                url = SetNextPage(url, true);
            }
            string folder = path + @"\" + GetTheChapterName(url) + @"\" + GetTheChapterNum(url);


            if (!fl.existFolder(folder))
            {
                fl.createFolder(folder);
            }

            while (dl.VerifieThePath(url))
            {
                Path = folder + @"\" + GetThePageNumber(url) + GetExtention(url);
                dl.DownloadTheImage(url, Path);
                fl.RefreshFolder(lst, folder);
                url = SetNextPage(url, false);
            }
        }

        public string GetTheChapterName(string url)
        {
            string[] splitedEntry = url.Split('/');
            int j = 0;

            while (splitedEntry[j] != "manga")
            {
                j++;
            }

            url = splitedEntry[j + 1];
            return url;
        }

        public string GetTheChapterNum(string url)
        {
            string[] splitedEntry = url.Split('/');
            int j = 0;

            while (splitedEntry[j] != "chapters")
            {
                j++;
            }

            url = splitedEntry[j + 1];
            return url;
        }

        public string GetThePageNumber(string url)
        {
            string[] splitedEntry = url.Split('/');
            string[] splitedLastEntry = splitedEntry[splitedEntry.Length - 1].Split('.');

            foreach (var s in splitedLastEntry)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(s, "^\\d{2}$"))
                {
                    url = s;
                }
            }

            return url;
        }

        public string SetNextPage(string url, bool b)
        {
            string[] splitedEntry = url.Split('.');
            splitedEntry[1] = splitedEntry[1].Remove(splitedEntry[1].Length - 2, 2);

            string page = GetThePageNumber(url);
            int value = Convert.ToInt16(page);
            value++;
            page = Convert.ToString(value);

            url = "";

            if (b)
            {
                splitedEntry[1] += "01";
            }
            else
            {
                if (value < 10)
                {
                    splitedEntry[1] += page.PadLeft(2, '0');
                }
                else
                {
                    splitedEntry[1] += page;
                }
            }

            for (int i = 0; i < splitedEntry.Length; i++)
            {
                url += splitedEntry[i];
                if (i < 2)
                {
                    url += '.';
                }
            }

            return url;

        }

        public string GetExtention(string url)
        {
            string[] splitedEntry = url.Split('.');

            url = splitedEntry[splitedEntry.Length - 1];

            return '.' + url;
        }
    }
}
