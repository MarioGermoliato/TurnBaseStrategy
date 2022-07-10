using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridDebugObject : MonoBehaviour
{
    private GridObject gridObject;
    [SerializeField] private TextMeshPro debugObjectText;
 public void SetGridObject(GridObject gridObject)
    {
        this.gridObject = gridObject;       
    }

    private void Update()
    {
        debugObjectText.text = gridObject.ToString();
            
    }
}
