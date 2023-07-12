using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTeamColourLookup", menuName = "Team Colour Lookup")]
public class TeamColourLookup : ScriptableObject
{
    [SerializeField] private Color[] teamColours;

    public Color[] TeamColours => teamColours;

    public Color GetTeamColour(int newTeamId)
    {
        if (newTeamId < 0 || newTeamId >= teamColours.Length)
        {
            return UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
        else
        {
            return teamColours[newTeamId];
        }
    }
}
