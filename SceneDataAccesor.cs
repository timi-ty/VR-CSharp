using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SceneDataAccesor
{
    public static string previousScene;
    private Dictionary<string, DataObject[]> dict = new Dictionary<string, DataObject[]>();
    public SceneDataAccesor()
    {
        DataObject[] antiqueObjects = new DataObject[3];
        antiqueObjects[0] = new DataObject();
        antiqueObjects[0].question = "Hey, I heard about your parent’s anniversary";
        antiqueObjects[0].option1 = "Yes, I’m looking forward to it";
        antiqueObjects[0].option2 = "Yes, I need some help planning";
        antiqueObjects[0].failureExplanation = "";
        antiqueObjects[0].successExplanation = "";

        antiqueObjects[1] = new DataObject();
        antiqueObjects[1].question = "I see the party is African themed. Want to get some elephant tusks or ancient Egyptian hieroglyphics for decoration?";
        antiqueObjects[1].option1 = "I don't think that's a good idea";
        antiqueObjects[1].option2 = "Yes, that’d be great";
        antiqueObjects[1].failureExplanation = "According to the National Geographic Society, Nearly 100 elephants a day are slaughtered in the wild so their tusks can be removed and sold. Also,  cultural artifacts such as ‘ancient Egyptian hieroglyphics writings’ are usually stolen and the sites in which they are hidden are looted by criminals.";
        antiqueObjects[1].successExplanation = "Good choice. According to the National Geographic Society, Nearly 100 elephants a day are slaughtered in the wild so their tusks can be removed and sold. Also,  cultural artefacts such as ‘ancient egyptian hieroglyphics writings’ are usually stolen and the sites in which they are hidden are looted by criminals. Let's see what happens if you had made the wrong choice.";

        antiqueObjects[2] = new DataObject();
        antiqueObjects[2].question = "Do you want a link to a Facebook group that sells what you are looking for at very affordable rates?";
        antiqueObjects[2].option1 = "Err... Do you think that's a good idea?";
        antiqueObjects[2].option2 = "Sure, I’m in";
        antiqueObjects[2].failureExplanation = "You should not buy controlled goods on social media. According to Antiquities Trafficking and Heritage Anthropology Research(ATHAR), groups on facebook that support the trade oxf illicit cultural antiquities usually consist of violent extremists affiliated with terrorists groups";
        antiqueObjects[2].successExplanation = "Good choice. You should not use social media to purchase cultural antiquities because according to United Nations Office on Drugs and Crime(UNODC), money generated from the illicit trade of cultural antiquities is a possible source of financing for terrorist groups. Let’s see what happens if you made the wrong choice";


        DataObject[] policeBrutalityObjects = new DataObject[4];
        policeBrutalityObjects[0] = new DataObject();
        policeBrutalityObjects[0].question = "A police car is behind, flagging you to stop.";
        policeBrutalityObjects[0].option1 = "Come to a slow stop.";
        policeBrutalityObjects[0].option2 = "Keep moving and try to escape";
        policeBrutalityObjects[0].failureExplanation = "Wrong choice: In Nigeria, The Police Act in Section 29, states that a police officer ‘…may detain and search any person whom he reasonably suspects of having in his possession or conveying in any manner anything which he has reason to believe to have been stolen or otherwise unlawfully obtained.";
        policeBrutalityObjects[0].successExplanation = "Good choice, In Nigeria, the Police Act in Section 29, states that a police officer ‘…may detain and search any person whom he reasonably suspects of having in his possession or conveying in any manner anything which he has reason to believe to have been stolen or otherwise unlawfully obtained.";


        policeBrutalityObjects[1] = new DataObject();
        policeBrutalityObjects[1].question = "You’ve parked the car. The officer comes down from the patrol car and is on his way to yours.";
        policeBrutalityObjects[1].option1 = "Wait patiently";
        policeBrutalityObjects[1].option2 = "Make a break for it";
        policeBrutalityObjects[1].failureExplanation = "Bad Choice. making a break for it could result in a police chase and a charge for disorderly conduct when caught. In extreme cases, shots may be fired at your car.";
        policeBrutalityObjects[1].successExplanation = "Good. Be cautious when dealing with security officials for your own safety. Note the officer’s name and comply. Let's see what could have happened.";

        policeBrutalityObjects[2] = new DataObject();
        policeBrutalityObjects[2].question = "Get down! I need to search your car!";
        policeBrutalityObjects[2].option1 = "Comply with the officer ";
        policeBrutalityObjects[2].option2 = "Refuse";
        policeBrutalityObjects[2].failureExplanation = "Bad Choice. making a break for it could result in a police chase and a charge for disorderly conduct when caught. In extreme cases, shots may be fired at your car.";
        policeBrutalityObjects[2].successExplanation = "Good choice. The police have the right to search your property, however this search can only be performed if a search warrant has been issued. If the police officer does not have a warrant to search your phone or laptop or other electronic device then any search carried out is an illegal one.";

        policeBrutalityObjects[3] = new DataObject();
        policeBrutalityObjects[3].question = "The officer then proceeds to check your car. He then finds the elephant tusks and ancient Egyptian writing in your trunk. You are mauled to the ground and handcuffed.";
        policeBrutalityObjects[3].option1 = "Comply with the officer ";
        policeBrutalityObjects[3].option2 = "Fightback";
        policeBrutalityObjects[3].failureExplanation = "Bad Choice, Fighting with an officer can get fatal. It is strongly discouraged";
        policeBrutalityObjects[3].successExplanation = "Good choice, Complying with the police is the safest way to avoid brutalization. Since the search was an illegal one, you can always hire a lawyer later to make a complaint and instigate a suit to claim compensation for unlawful search and harassment.";


        DataObject[] childAbuseObjects = new DataObject[1];

        childAbuseObjects[0].question = "If you think you had a rough day, think about what those kids might be going through? ";
        

        dict.Add("Cultural Antiques", antiqueObjects);
        dict.Add("Police Brutality", policeBrutalityObjects);
    }
    public DataObject GetSceneData(string sceneName, int progressIdx)
    {
        DataObject[] outData;
        dict.TryGetValue(sceneName, out outData);
        if (progressIdx == outData.Length - 1)
        {
            SceneDataAccesor.previousScene = sceneName;
        }
        return outData[progressIdx];
    }

    static void Main(string[] args)
    {
        // SceneDataAccesor accesor1 = new SceneDataAccesor();
        // Console.WriteLine(accesor1.GetSceneData("C-Antique", 0).successExplanation);
    }
}