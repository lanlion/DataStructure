using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
namespace LanWeb
{
    /// <summary>
    /// load1 的摘要说明
    /// </summary>
    public class load : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "json";
            try
            {

                var pageString = context.Request.QueryString["time"];
                var tmptime = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
               var path= System.AppDomain.CurrentDomain.BaseDirectory;
                var text = File.ReadLines(path+"data/data.txt").ToList();
                var dic = new Dictionary<DateTime, double>();
                var List = new List<TimeValue>();
                if (!string.IsNullOrEmpty(pageString))
                {
                    if (!DateTime.TryParse(pageString, out tmptime))
                    {
                        tmptime = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
                    }
                }

                var tmptimestr = tmptime.ToString("yyyy/MM/dd");
                foreach (var item in text)
                {
                    var strArr = item.Split('\t');
                    if (strArr.Length > 5)
                    {
                        var time =Convert.ToDateTime( strArr[1]);
                                                                            
                        if (time.ToString("yyyy/MM/dd") != tmptimestr) continue;
                        for (int i = strArr.Length-1; i >= 3; i--)
                        {
                            if (!string.IsNullOrEmpty(strArr[i])&& strArr[i]!="0")
                            {
                                dic[time] =double.Parse( strArr[i]); break;
                            }
                        }

                        List.Add(new LanWeb.TimeValue { name = time.ToLongTimeString(), value = dic[time] });


                    }

                }
                List.Sort((item1, item2) => Convert.ToDateTime(item1.name).CompareTo(Convert.ToDateTime(item2.name)));
                var json = JsonConvert.SerializeObject(List);
                context.Response.Write(json);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

    public class TimeValue
    {
        public string name { get; set; }
        public double value { get; set; }
    }
}