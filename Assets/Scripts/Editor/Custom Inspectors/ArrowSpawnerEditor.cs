using UnityEditor;
using UnityEditor.XR.Interaction.Toolkit;

[CustomEditor(typeof(ArrowSpawner))]
public class ArrowSpawnerEditor : XRBaseInteractableEditor
{
    private SerializedProperty arrowPrefab = null;

    protected override void OnEnable()
    {
        base.OnEnable();
        arrowPrefab = serializedObject.FindProperty("arrowPrefab");
    }

    protected override void DrawCoreConfiguration()
    {
        base.DrawCoreConfiguration();

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("ArrowSpawner", EditorStyles.boldLabel);

        EditorGUILayout.PropertyField(arrowPrefab);
    }
}
