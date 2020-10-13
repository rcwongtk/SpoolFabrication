using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInHandInfo : MonoBehaviour
{
    GameObject instructionObject;
    TextMeshPro instructionText;
    string thisObject;

    // Start is called before the first frame update
    void Start()
    {
        thisObject = gameObject.name;
        instructionObject = GameObject.FindWithTag("InstructionText");
        instructionText = instructionObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateText()
    {
        if(thisObject.Contains("PLUG NPT 3"))
        {
            instructionText.text = "1\" Solid Hex Head Threaded Plug - A-105N " +
                "\n\n Used here to block the drain valves in case valve leaks.";
        }
        else if (thisObject.Contains("BALL VALVE 3"))
        {
            instructionText.text = "1\" Ball Valve SW X THRD, Reduced Port - A-105N " +
                "\n\n SW on nipple side to prevent connection leaks (depends on service), THRD on drain side for ease of use.";
        }
        else if (thisObject.Contains("NIPPLE 9"))
        {
            instructionText.text = "1\" NIPPLE, Sch. XH, SMLS PBE - A-106-B " +
                "\n\n Nipple should match connected piping (Schedule and Type), PBE means \"Plain Both Ends\" so no Threads on either end.";
        }
    }

}
