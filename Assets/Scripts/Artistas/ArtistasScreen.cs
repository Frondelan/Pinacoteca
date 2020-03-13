//Deut 30:9
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtistasScreen : MonoBehaviour
{
    public GameObject opc1, opc2, opc3, opc4, opc5, opc6;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void panelInfo()
    {
        if (opc1 != null)
        {
            bool isActive = opc1.activeSelf;
            opc1.SetActive(!isActive);

        }else if (opc2 != null)
        {
            bool isActive = opc2.activeSelf;
            opc2.SetActive(!isActive);
        }
        else if (opc3 != null)
        {
            bool isActive = opc3.activeSelf;
            opc3.SetActive(!isActive);
        }
        else if (opc4 != null)
        {
            bool isActive = opc4.activeSelf;
            opc4.SetActive(!isActive);
        }
        else if (opc5 != null)
        {
            bool isActive = opc5.activeSelf;
            opc5.SetActive(!isActive);
        }
        else if (opc6 != null)
        {
            bool isActive = opc6.activeSelf;
            opc6.SetActive(!isActive);
        }
    }

}
