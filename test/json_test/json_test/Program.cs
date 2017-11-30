using System;
using System.Collections;

namespace json_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "{\"key\":\"value\"}";
            Hashtable o = (Hashtable)Json.Jsonparser.unpack(str);

            Hashtable t = new Hashtable();
            t.Add("key1", 0-1);
            t.Add("key2", "2");
            t.Add("key3", 3.1);
            t.Add("key4", true);
            string s = Json.Jsonparser.pack(t);
            o = (Hashtable)Json.Jsonparser.unpack(s);

            Hashtable t1 = new Hashtable();
            t1.Add("key1", 1);
            t1.Add("key2", "2");
            t1.Add("key3", 3.2);
            t1.Add("key4", true);
            t1.Add("key5", t);
            s = Json.Jsonparser.pack(t1);
            o = (Hashtable)Json.Jsonparser.unpack(s);

            ArrayList l = new ArrayList();
            l.Add("v1");
            l.Add(1);
            l.Add(2.2);
            l.Add(false);
            t1.Add("key6", l);
            s = Json.Jsonparser.pack(t1);
            o = (Hashtable)Json.Jsonparser.unpack(s);

            ArrayList l1 = new ArrayList();
            l1.Add("v1");
            l1.Add(1);
            l1.Add(2.254365675475E-05);
            l1.Add(false);
            l1.Add(l);
            l1.Add(t);
            t1.Add("key7", l1);
            s = Json.Jsonparser.pack(t1);
            o = (Hashtable)Json.Jsonparser.unpack(s);

            ArrayList a = new ArrayList();
            a.Add("123");
            a.Add("456");

            ArrayList a1 = new ArrayList();
            a1.Add("789");
            a1.Add(a);

            ArrayList a2 = new ArrayList();
            a2.Add("0");
            a2.Add(a1);

            var strjson = Json.Jsonparser.pack(a2);
            var o1 = Json.Jsonparser.unpack(strjson);

            var json = "[\"hub_call_gate\",\"forward_hub_call_client\",[\"0eb5d430-33b1-440c-b0f7-e3bd5eb701ed\",\"login\",\"login_sucess\",[\"onRisxOmFtBySUiNiXq0JK3jEB2o\",\"浅浅\",\"http://wx.qlogo.cn/mmopen/T121P1Nx7y8e9vDFCZ32ESZ2b6Ult4xdxJxZzsUOOZqyicsJJ0zWglC0ibl8r5h3qOCl1ZF2sar7Wt4hRR4sXpqq9S9esPWk2B/0\",1]]]";
            var o2 = Json.Jsonparser.unpack(json);

            o.Add("json", json);
            o.Add("null", null);
            var stro = Json.Jsonparser.pack(o);
            o = (Hashtable)Json.Jsonparser.unpack(stro);
            var o3 = (ArrayList)Json.Jsonparser.unpack((String)o["json"]);

        }
    }
}
