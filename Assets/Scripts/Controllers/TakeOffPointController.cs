using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using PathCreation;

public class TakeOffPointController : MonoBehaviour
{
    public PathCreator path;
    private TextMeshPro identifier;
    public int pointId;
    
    private void Start()
    {
        identifier = GetComponentInChildren<TextMeshPro>();
        path = GetComponentInChildren<PathCreator>();
    }

    public void UpdateIdentifier(int newId)
    {
        pointId = newId;
        Debug.Log($"PointId: {pointId}");
        Debug.Log($"Identifier: {identifier}");
        if (!identifier) return;

        // Update the identifier text to match the pointId and add 1 to make it more palletable
        identifier.text = $"{pointId + 1}"; 
    }
}