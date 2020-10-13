using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInstructions : MonoBehaviour
{
    public TextMeshPro instructionText;
    public int counter;

    public GameObject fullPipingHint;
    public GameObject fullPipingModel;

    // Parts of Full Piping Spool
    public GameObject branch1;
    public GameObject branch2;
    public GameObject spoolSection1;
    public GameObject spoolSection2;
    public GameObject misc;

    // Parts of Hints / Assembly
    public GameObject branch1_Hint;

    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void upCounter()
    {
        counter++;
        instructions();
    }

    void instructions()
    {
        switch (counter)
        {
            case 0:
                break;
            case 1:
                fullPipingModel.SetActive(true);
                instructionText.text = "We will be assembling this fuel gas piping. We will show the stages that this would be built in the shop." +
                    "\n\n This piping consists of two spools and some connecting valves and instrumentation.";
                break;
            case 2:
                fullPipingHint.SetActive(true);
                spoolSection1.SetActive(false);
                spoolSection2.SetActive(false);
                misc.SetActive(false);
                instructionText.text = "We begin by assembling smaller components, such as the drain piping. this makes things easier to connect later." +
                    "\n\n On fuel gas service 1\" drains, we use a SWxTHRD valve with a THRD plug at the end (depending on service).";
                break;
            case 3:
                branch1.SetActive(false);
                branch1_Hint.SetActive(true);
                instructionText.text = "Lets have you assemble a piping drain. As you pick up a part this window will update with information." +
                    "\n\n These holograms represent the actual standard size of the piping components.";
                break;
            case 4:
                break;

        }
    }

}
