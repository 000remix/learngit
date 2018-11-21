using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net;
using System.Collections;

namespace 网络爬虫_并行优化
{
    class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;

        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();

            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];

            myCrawler.urls.Add(startUrl, false);

            new Thread(myCrawler.Crawl).Start();
            //Action[] actions = { new Action(myCrawler.Crawl), myCrawler.Crawl };
            //Parallel.Invoke(actions);
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了......");
            /* while(true)
              {
                  string current = null;
                  foreach(string url in urls.Keys)                    //找到一个还没下载过的链接
                  {
                      if ((bool)urls[url]) continue;                  //已经下载过的不再下载
                      current = url;
                  }
                  if (current == null || count > 10) break;

                  Console.WriteLine("爬行" + current + "页面!");
                  string html = DownLoad(current);                   //下载

                  urls[current] = true;
                  count ++;

                  Parse(html);                                       //解析并加入新的链接
              }
              Console.WriteLine("爬行结束");*/

            while (true)
            {
                List<string> list1 = new List<string>();
                foreach (string url in urls.Keys)                    //找到一个还没下载过的链接
                {
                    list1.Add(url);
                }
                string current = null;
                ParallelLoopResult loopResult = Parallel.ForEach(
                    list1, (string url) =>
                {
                    if (!(bool)urls[url])
                    {              //已经下载过的不再下载
                        current = url;
                    }
                });
                if (current == null || count > 10) break;

                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current);                   //下载

                urls[current] = true;
                count++;

                Parse(html);

            }
        }
    

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();

                webClient.Encoding = Encoding.UTF8;
                
                string html = webClient.DownloadString(url);
                
                string fileName = count.ToString();
                File.WriteAllText(fileName,html,Encoding.UTF8);
                return html;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
  
            foreach(Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#' , ' ' , '>');
                    
                if (strRef.Length == 0) continue;

                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
