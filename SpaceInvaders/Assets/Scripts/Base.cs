using UnityEngine;
using System.Collections.Generic;

public class Base : MonoBehaviour {

    //The list of the blocks belonging to this base
    [SerializeField] private List<Block> blocks;

    public List<Block> GetBlocks(){
        return blocks;
    }

    public void RemoveBlock(Block block){
        blocks.Remove(block);
    }
}
