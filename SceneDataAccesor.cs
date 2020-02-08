using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SceneDataAccesor
{
    private Dictionary<string, DataObject[]> dict = new Dictionary<string, DataObject[]>();
    public SceneDataAccesor()
    {
        DataObject[] antiqueObjects = new DataObject[1];
        antiqueObjects[0] = new DataObject("Hey, friend I heard about your parent’s anniversary.", "Ok", "Ok!!!", "halalalala", "failure !");
        dict.Add("C-Antique", antiqueObjects);
    }
    public DataObject GetSceneData(string sceneName, int progressIdx)
    {
        DataObject[] outData;
        dict.TryGetValue(sceneName, out outData);
        return outData[progressIdx];
    }

    static void Main(string[] args)
    {
        SceneDataAccesor accesor1 = new SceneDataAccesor();
        accesor1.GetSceneData("C-Antique", 0);
    }
}