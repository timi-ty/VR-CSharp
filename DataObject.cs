using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DataObject
{
    public string question;
    public string option1;
    public string option2;

    public string successExplanation;

    public string failureExplanation;

    public DataObject(string question, string option1, string option2, string successExplanation, string failureExplanation)
    {
        this.question = question;
        this.option1 = option1;
        this.option2 = option2;
        this.successExplanation = successExplanation;
        this.failureExplanation = failureExplanation;
    }
    public DataObject()
    {

    }
}