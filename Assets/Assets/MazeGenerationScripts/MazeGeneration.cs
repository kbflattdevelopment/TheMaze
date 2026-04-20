using UnityEngine;
using System.Collections.Generic;
using static MazeNode;
using System;


public class MazeGeneration : MonoBehaviour
{
    //MazeIndex = { MazeRow = { MazePart}  }
    //
    //
    private List<List<MazeNode>> MazeIndex = new List<List<MazeNode>>();

    private List<MazeNode> QueuedList = new List<MazeNode>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MazeIndex[0] = new List<MazeNode>();

        List<int> position = new List<int> { 0, 0 };
        MazeNode orgin = new MazeNode("orgin", 0, position);

        MazeIndex[0][0] = orgin;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (MazeNode node in this.QueuedList)
        {
            List<int> position = node.getPosition();
            if (this.MazeIndex[position[0]] != null)
            {
                this.MazeIndex[position[0]] = new List<MazeNode>();
            }

            if (this.MazeIndex[position[0]][position[1]] == null)
            {
                this.MazeIndex[position[0]][position[1]] = node;
            }
            else
            { 
                //implement override here
            }
        }

        
    }
}
