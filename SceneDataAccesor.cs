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
        antiqueObjects[0] = new DataObject();
        antiqueObjects[0].question = "Hey, friend I heard about your parent’s anniversary";
        antiqueObjects[0].option1 = "Yes, I’m looking forward to it.";
        antiqueObjects[0].option2 = "Yes, I need some help planning.";
        antiqueObjects[0].failureExplanation = "";
        antiqueObjects[0].successExplanation = "!!!!";

        antiqueObjects[2] = new DataObject();
        antiqueObjects[2].question = "Do you want a link to a Facebook group that sells what you are looking for at very affordable rates?";
        antiqueObjects[2].option1 = "Sure, I’m in.";
        antiqueObjects[2].option2 = "Nah, I’m not into that sort of thing.";
        antiqueObjects[2].failureExplanation = "You should avoid the use of social media to purchase controlled goods.";
        antiqueObjects[2].successExplanation = "Good choice, you should avoid the use of social media to purchase controlled goods";



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
        Console.WriteLine(accesor1.GetSceneData("C-Antique", 0).successExplanation);
    }
}