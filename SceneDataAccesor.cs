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
        DataObject[] antiqueObjects = new DataObject[4];
        antiqueObjects[0] = new DataObject();
        antiqueObjects[0].question = "Hey, friend I heard about your parent’s anniversary";
        antiqueObjects[0].option1 = "Yes, I’m looking forward to it.";
        antiqueObjects[0].option2 = "Yes, I need some help planning.";
        antiqueObjects[0].failureExplanation = "";
        antiqueObjects[0].successExplanation = "!!!!";

        antiqueObjects[1] = new DataObject();
        antiqueObjects[1].question = "The party can be African themed. Want to get some elephant tusks or ancient Egyptian hieroglyphics for decoration?";
        antiqueObjects[1].option1 = "Yes, that’d be great ";
        antiqueObjects[1].option2 = "Nah, I’m not into that sort of thing.";
        antiqueObjects[1].failureExplanation = "According to the National Geographic Society, Nearly 100 elephants a day are slaughtered in the wild so their tusks can be removed and sold. Also,  cultural artifacts such as ‘ancient Egyptian hieroglyphics writings’ are usually stolen and the sites in which they are hidden are looted by criminals.link: https://www.unodc.org/unodc/en/organized-crime/intro/emerging-crimes/trafficking-in-cultural-property.html";
        antiqueObjects[1].successExplanation = "Good choice, you should avoid frivolous use of Cultural Antiquities and controlled goods. According to the National Geographic Society, Nearly 100 elephants a day are slaughtered in the wild so their tusks can be removed and sold. Also,  cultural artefacts such as ‘ancient egyptian hieroglyphics writings’ are usually stolen and the sites in which they are hidden are looted by criminals.link: https://www.unodc.org/unodc/en/organized-crime/intro/emerging-crimes/trafficking-in-cultural-property.html. Let's see what happens if you had made the wrong choice.";

        antiqueObjects[2] = new DataObject();
        antiqueObjects[2].question = "Do you want a link to a Facebook group that sells what you are looking for at very affordable rates?";
        antiqueObjects[2].option1 = "Sure, I’m in.";
        antiqueObjects[2].option2 = "Nah, I’m not into that sort of thing.";
        antiqueObjects[2].failureExplanation = "You should avoid the use of social media to purchase controlled goods.";
        antiqueObjects[2].successExplanation = "Good choice, you should avoid the use of social media to purchase controlled goods";

        antiqueObjects[3] = new DataObject();
        antiqueObjects[3].question = "You purchase the tusks online and go to pick them up at the post office. On your way back from the post office, you are flagged down by a police officer.";
        antiqueObjects[3].option1 = "Continue";


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