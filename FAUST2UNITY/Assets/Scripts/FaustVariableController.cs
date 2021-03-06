using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaustVariableController : MonoBehaviour
{
    public FaustPlugin_glassHarmonica scriptFaust;
    public int dummy_Toggle = 1;
    public GameObject CubeAudio;
    public float bowPressure;
    public float integrationConstant;

    // Start is called before the first frame update
    void Start()
    {
        print("FAUSTVARIABLECONTROLLER: inside Start");
        scriptFaust = CubeAudio.GetComponent<FaustPlugin_glassHarmonica>();
        bowPressure = scriptFaust.getParameter(7);
        print("scriptFaust.parameters damp = " + bowPressure);
        integrationConstant = scriptFaust.getParameter(9);
    }

    // Update is called once per frame
    void Update()
    {
        if (dummy_Toggle == 1)
        {
            // setParameter(int param, float x)
            scriptFaust.setParameter(7, 0.7f);
            scriptFaust.setParameter(9, 0.2f);
            print("VALUE CHANGED! scriptFaust.getParameter(7)= " + (scriptFaust.getParameter(7)));
            dummy_Toggle = 0;
        }
    }
}
