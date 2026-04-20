using NUnit.Framework;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "MazeNode", menuName = "Scriptable Objects/MazeNode")]
public class MazeNode : ScriptableObject
{

    private string type;
    private int orientation;
    //[0] = x [1] = y
    private List<int> position = new List<int>();
   
    
    public string getType()
    {
        return this.type;
    }
    public int getOrientation()
    {
        return this.orientation;
    }
    public List<int> getPosition()
    {
        return this.position;
    }
    public void overridePart(string newType, int newOrienation)
    {
        this.type = newType;
        this.orientation = newOrienation;
    }

    public MazeNode(string type, int orientation, List<int> position)
    {
        this.type = type;
        this.orientation = orientation;
        this.position = position;
    }
}
