using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SolverBehavior))]
public class SolverBehaviorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SolverBehavior solverScript = (SolverBehavior)target;
        if (GUILayout.Button("Refill The Board Randomly"))
        {
            solverScript.RestartGame();
        }
    }
}
