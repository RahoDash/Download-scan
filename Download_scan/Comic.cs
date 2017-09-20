using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_scan
{
    class Comic
    {
        Download dl;
        Chapter ch;
        Folder fl;


        public Comic()
        {
            dl = new Download();
            ch = new Chapter();
            fl = new Folder();
        }

        public void DownloadAll(string url, string fileName, ListBox lst)
        {
            string folder = fileName + @"\" + ch.GetTheChapterName(url);

            if (fl.existFolder(folder))
            {
                fl.createFolder(folder);
            }

            do
            {
                ch.DownloadChapter(url, fileName, lst);
                url = setNextChapter(url);

            } while (dl.VerifieThePath(url));
        }

        public string setNextChapter(string url)
        {
            string[] splitedEntry = url.Split('/');
            int j, i = 0;

            while (splitedEntry[i] != "chapters")
            {
                i++;
            }

            j = Convert.ToInt16(ch.GetTheChapterNum(url));
            j++;
            splitedEntry[i + 1] = j.ToString();

            url = "";
            for (int k = 0; k < splitedEntry.Length; k++)
            {
                url += splitedEntry[k]; 
                if (k < splitedEntry.Length-1)
                {
                    url += '/';
                }

            }

            return url;
        }
    }
}
