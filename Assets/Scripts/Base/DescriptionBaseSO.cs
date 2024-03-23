using UnityEngine;

/// <summary>
/// Все SO должны иметь описание себя
/// </summary>
namespace Portfolio
{
	public class DescriptionBaseSO : SerializableScriptableObject
	{
		[TextArea] public string description;
	}
}
