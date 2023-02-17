using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customizer : MonoBehaviour
{
    public AssetSO Assets;

    public SkinnedMeshRenderer Belt;
    public SkinnedMeshRenderer Capes;
    public SkinnedMeshRenderer Eyebrows;
    public SkinnedMeshRenderer LeftElbows;
    public SkinnedMeshRenderer RightElbows;
    public SkinnedMeshRenderer LeftKnees;
    public SkinnedMeshRenderer RightKnees;
    public SkinnedMeshRenderer LeftPauldron;
    public SkinnedMeshRenderer RightPauldron;
    public SkinnedMeshRenderer Hair;
    public SkinnedMeshRenderer Torso;
    public SkinnedMeshRenderer FacialHair;
    public SkinnedMeshRenderer Head;
    


    public void Randomize()
    {
        Belt.sharedMesh = Assets.Belts[Random.Range(0, Assets.Belts.Length)];
        Capes.sharedMesh = Assets.Capes[Random.Range(0, Assets.Capes.Length)];
        Eyebrows.sharedMesh = Assets.Eyebrows[Random.Range(0, Assets.Eyebrows.Length)];
        LeftElbows.sharedMesh = Assets.LeftElbows[Random.Range(0, Assets.LeftElbows.Length)];
        RightElbows.sharedMesh = Assets.RightElbows[Random.Range(0, Assets.RightElbows.Length)];
        LeftKnees.sharedMesh = Assets.LeftKnees[Random.Range(0, Assets.LeftKnees.Length)];
        RightKnees.sharedMesh = Assets.RightKnees[Random.Range(0, Assets.RightKnees.Length)];
        LeftPauldron.sharedMesh = Assets.LeftPauldron[Random.Range(0, Assets.LeftPauldron.Length)];
        RightPauldron.sharedMesh = Assets.RightPauldron[Random.Range(0, Assets.RightPauldron.Length)];
        Hair.sharedMesh = Assets.Hair[Random.Range(0, Assets.Hair.Length)];
        Torso.sharedMesh = Assets.Torso[Random.Range(0, Assets.Torso.Length)];
        FacialHair.sharedMesh = Assets.FacialHair[Random.Range(0, Assets.FacialHair.Length)];
        Head.sharedMesh = Assets.Head[Random.Range(0, Assets.Head.Length)];
    }
}
