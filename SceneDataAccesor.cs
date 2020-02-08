using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApplication2;

namespace DemoApplication2
{
    public class SceneDataAccesor
    {
        public SceneDataAccesor()
        {
            Console.WriteLine("Initialized ob!!!j");
        }
        public void GetSceneData(string sceneName)
        {
            Console.WriteLine(sceneName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SceneDataAccesor accesor1 = new SceneDataAccesor();
            accesor1.GetSceneData("");
            Hashtable ht = new Hashtable();
            // ht.Add("001", ".Net");
            // ht.Add("002", "C#");
            // ht.Add("003", "ASP.Net");

            // ICollection keys = ht.Keys;

            // foreach (String k in keys)
            // {
            //     Console.WriteLine(ht[k]);
            // }
            // Console.ReadKey();
        }
    }
}
