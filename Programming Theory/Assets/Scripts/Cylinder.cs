using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public override void DisplayText()
    {
        displayText.text = "Cylinder\nColor Value:\n" + shapeColor.ToString();
    }
}
